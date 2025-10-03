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
    public class InventoryRepository : I_Inventory
    {
        public IEnumerable<InventoryViewModel> GetAllInventory()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT i.inventory_id, p.product_id, p.product_name, p.brand, c.categoryName as category,i.unit,i.volume_per_unit, i.volume, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_products as p ON p.product_id = i.product_id
                        LEFT JOIN tbl_category as c ON c.category_id = p.category_id
                        ;";
                return con.Query<InventoryViewModel>(sql).ToList();
            }
      
        }
        public IEnumerable<InventoryViewModel> GetAllInventory(string status)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT i.inventory_id, p.product_id, p.product_name, p.brand, c.categoryName as category,i.unit,i.volume_per_unit, i.volume, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_products as p ON p.product_id = i.product_id
                        LEFT JOIN tbl_category as c ON c.category_id = p.category_id
                        WHERE i.status = @status
                        ;";
                return con.Query<InventoryViewModel>(sql, new { status = status}).ToList();
            }

        }
        public InventoryViewModel InventoryReportSummary() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                          COUNT(DISTINCT product_id) AS total_products,
                          SUM(volume) AS total_volume,
                          SUM(CASE WHEN status = 'In Stock' THEN 1 ELSE 0 END) AS in_stock_items,
                          SUM(CASE WHEN status = 'Out of Stock' THEN 1 ELSE 0 END) AS out_of_stock_items,
                          SUM(CASE WHEN volume < critical_level THEN 1 ELSE 0 END) AS low_stock_items
                        FROM tbl_inventory;";
                return con.Query<InventoryViewModel>(sql).FirstOrDefault();
            }
        }

        public InventoryViewModel InventoryReportSummary(string status)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                          COUNT(DISTINCT product_id) AS total_products,
                          SUM(volume) AS total_volume,
                          SUM(CASE WHEN status = 'In Stock' THEN 1 ELSE 0 END) AS in_stock_items,
                          SUM(CASE WHEN status = 'Out of Stock' THEN 1 ELSE 0 END) AS out_of_stock_items,
                          SUM(CASE WHEN volume < critical_level THEN 1 ELSE 0 END) AS low_stock_items
                        FROM tbl_inventory
                        WHERE status = @status;";
                return con.Query<InventoryViewModel>(sql, new { status = status}).FirstOrDefault();
            }
        }


        public bool ProductExists(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(1) FROM tbl_inventory WHERE product_id = @product_id";

                return con.ExecuteScalar<int>(sql, new { product_id = id }) > 0;
            }
           
        }
        public void AddInventory(InventoryViewModel inventory)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_inventory (product_id, unit,volume_per_unit, volume, expiry_date) VALUES (@product_id, @unit,@volume_per_unit, @volume, @expiry_date)";
                con.Execute(sql, inventory);
            }
      
        }
        public void UpdateInventory(int id, int unit, int volume)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_inventory SET unit  = unit + @unit, volume = volume + @volume WHERE product_id = @id";
                con.Execute(sql, new { id, unit, volume });
            }
               
        }

        public void UpdateInventoryVolume(int id, double unit, double volume)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_inventory SET unit = @unit, volume = volume - @volume WHERE product_id = @id";
                con.Execute(sql, new { id, unit, volume });
            }
              
        }

        public void DeleteInventory(int inventoryId)
        {
            throw new NotImplementedException();
        }
    }
}
