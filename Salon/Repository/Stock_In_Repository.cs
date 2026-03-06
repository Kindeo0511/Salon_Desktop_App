using Dapper;
using Laundry.Data;
using Salon.Models;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class Stock_In_Repository
    {
        public IEnumerable<Stock_In_Model> Stock_In_List() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM stock_in_details";
                return con.Query<Stock_In_Model>(sql);
            }
        }
        public int Add(Stock_In_Model model) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stock_in 
                            (delivery_id, product_size_id, qty,qty_remaining, total, total_remaining , created_at)
                            VALUES (@delivery_id, @product_size_id, @qty, @qty_remaining, @total, @total_remaining , CURRENT_TIMESTAMP())";
                return con.Execute(sql, model);
            }
            
        }
        public decimal GetTotalRemaining(int inventory_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT total_remaining
                    FROM tbl_inventory 
                    WHERE inventory_id = @inventory_id";

                return con.QuerySingleOrDefault<decimal>(sql, new { inventory_id });
            }
        }

        public void AddStockIn(Stock_In_Model model, decimal prevTotalRemaining, decimal newTotalRemaining, decimal prevQty, decimal newQty, bool is_update)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            if (model.product_id <= 0 || model.product_size_id <= 0 || model.qty <= 0)
                throw new ArgumentException("Invalid product, size or quantity.");

            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        // 1) Get product size and unit type
                        var ps = con.QueryFirstOrDefault<(int product_size_id, decimal content, string unit_type)>(
                            @"SELECT ps.product_size_id, ps.content, p.unit_type
                      FROM tbl_product_size ps
                      JOIN tbl_products p ON p.product_id = ps.product_id
                      WHERE ps.product_size_id = @psi AND ps.product_id = @pid",
                            new { psi = model.product_size_id, pid = model.product_id }, tx);

                        if (ps.product_size_id == 0)
                            throw new InvalidOperationException("Product size not found.");

                        // 2) Convert qty to total units — same logic for ml, g, and pcs
                        decimal qtyVolumeDecimal = model.qty * ps.content;
                        decimal qtyVolume = Math.Ceiling(qtyVolumeDecimal);
                        decimal bottlesForRow = Math.Round(qtyVolumeDecimal / ps.content, 4);

                        if (!new[] { "ml", "g", "pcs" }.Contains(ps.unit_type.ToLower()))
                            throw new InvalidOperationException($"Unknown unit type: {ps.unit_type}");

                        // 3) Compute new totals
                        if (model.inventory_id > 0)
                        {
                            var inv = con.QueryFirstOrDefault<(int inventory_id, decimal qty, decimal total_remaining)>(
                                @"SELECT i.inventory_id, i.qty, i.total_remaining
                          FROM tbl_inventory i
                          WHERE i.inventory_id = @id
                          FOR UPDATE",
                                new { id = model.inventory_id }, tx);

                            if (inv.inventory_id == 0)
                                throw new InvalidOperationException($"Inventory row {model.inventory_id} not found.");

                            //if (is_update)
                            //{
                            //    newTotalRemaining = prevTotalRemaining + qtyVolume;
                            //    newQty = newTotalRemaining / ps.content; // same for all units
                            //}
                            //else
                            //{
                            //    newTotalRemaining = prevTotalRemaining;
                            //    newQty = prevQty;
                            //}
                        }

                        // 4) Insert audit row
                        con.Execute(@"
                    INSERT INTO tbl_stock_in
                        (refund_id, stock_out_id, inventory_id, product_id, product_size_id,
                         qty, qty_volume, unit_price, line_total,
                         previous_total_remaining, new_total_remaining, previous_qty, new_qty,
                         movement_type, reason, created_by, created_at)
                    VALUES
                        (NULL, NULL, @inventoryId, @productId, @productSizeId,
                         @qty, @qtyVolume, @unitPrice, @lineTotal,
                         @prevTotal, @newTotal, @prevQty, @newQty,
                         'Delivery', @reason, @userId, NOW());",
                            new
                            {
                                inventoryId = model.inventory_id > 0 ? (int?)model.inventory_id : null,
                                productId = model.product_id,
                                productSizeId = model.product_size_id,
                                qty = bottlesForRow,
                                qtyVolume = qtyVolume,      // fixed — was ps.content before
                                unitPrice = model.unit_price,
                                lineTotal = model.unit_price * bottlesForRow,
                                prevTotal = prevTotalRemaining,
                                newTotal = newTotalRemaining,
                                prevQty = prevQty,
                                newQty = newQty,
                                reason = model.reason ?? "Delivery",
                                userId = model.created_by
                            }, tx);

                        tx.Commit();
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }
    }
}
