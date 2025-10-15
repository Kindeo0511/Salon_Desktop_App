using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class InventoryBatchRepository : I_InventoryBatches
    {

        public IEnumerable<InventoryBatchModel> GetAllInventoryBatch()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT i_b.batch_id, d.delivery_item_id, p.product_id, p.product_name, i_b.unit,i_b.volume_per_unit, i_b.volume, i_b.price, (i_b.price * i_b.unit) AS total_price, 
                        i_b.notes, i_b.delivered_date, i_b.expiry_date
                        FROM tbl_inventory_batch as i_b
                        LEFT JOIN tbl_delivery_items as d ON d.delivery_item_id = i_b.delivery_item_id
                        LEFT JOIN tbl_products as p ON p.product_id = i_b.product_id";

                return con.Query<InventoryBatchModel>(sql).ToList();
            }
               
        }
        public InventoryBatchModel GetProductPriceByName(int product_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT i_b.batch_id, p.product_id,i_b.volume_per_unit, i_b.price
                        FROM tbl_inventory_batch as i_b
                        LEFT JOIN tbl_delivery_items as d ON d.delivery_item_id = i_b.delivery_item_id
                        LEFT JOIN tbl_products as p ON p.product_id = i_b.product_id
                        WHERE p.product_id = @product_id
                        ORDER BY i_b.delivered_date DESC
                        LIMIT 1";

                return con.Query<InventoryBatchModel>(sql, new { product_id }).FirstOrDefault();
            }

        }
        public void AddInventoryBatch(InventoryBatchModel inventoryBatch)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_inventory_batch (delivery_item_id, product_id, unit,volume_per_unit, volume, price, notes, delivered_date, expiry_date)
                        VALUES (@delivery_item_id, @product_id, @unit,@volume_per_unit, @volume, @price, @notes, @delivered_date, @expiry_date)";
                con.Execute(sql, inventoryBatch);
            }
               
        }
        public void UpdateInventoryBatch(InventoryBatchModel inventoryBatch)
        {

        }
        public void DeleteInventoryBatch(InventoryBatchModel inventoryBatch)
        {
        }
    }
}
