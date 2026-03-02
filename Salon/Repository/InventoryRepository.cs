using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.Repository
{
    public class InventoryRepository : I_Inventory
    {
        public IEnumerable<InventoryViewModel> GetAllInventory()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT  p.product_id, p.product_name,p.product_type, ps.size_label, p.brand,i.qty, i.total_remaining, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                        LEFT JOIN tbl_products p ON p.product_id = ps.product_id
  

                         
                        
                        ;";
                return con.Query<InventoryViewModel>(sql).ToList();
            }
      
        }
        public IEnumerable<InventoryViewModel> GetAllInventory(int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT  p.product_id, p.product_name,p.product_type, ps.size_label, p.brand,i.qty, i.total_remaining, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                        LEFT JOIN tbl_products p ON p.product_id = ps.product_id
  
                LIMIT @page_size OFFSET @off_set;";
                return con.Query<InventoryViewModel>(sql , new { page_size, off_set}).ToList();
            }

        }
        public double GetStockByProductSize(int productId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT SUM(i.total_remaining) 
                    FROM tbl_inventory i
                    JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                    JOIN tbl_products p ON p.product_id = ps.product_id
                    WHERE p.product_id = @productId

";

              var result = con.QueryFirstOrDefault<double?>(sql, new { productId });

                return result ?? 0;
            }
        }
        public int GetProductQtyStockkByProductSize(int productId, int productSizeId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT i.qty 
                    FROM tbl_inventory i
                    JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                    JOIN tbl_products p ON p.product_id = ps.product_id
                    WHERE ps.product_id = @productId 
                      AND i.product_size_id = @productSizeId;
";

                return con.QueryFirstOrDefault<int>(sql, new { productId = productId, productSizeId = productSizeId });
            }
        }
        public int TotalInventory() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_inventory";
                return con.ExecuteScalar<int>(sql);
            }
        }
        public async Task<IEnumerable<InventoryViewModel>> GetAllInventoryAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT  p.product_id, p.product_name,p.product_type, ps.size_label, p.brand,i.qty, i.total_remaining, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                        LEFT JOIN tbl_products p ON p.product_id = ps.product_id
  
                       
                        ;";
                var result = await  con.QueryAsync<InventoryViewModel>(sql);

                return result.ToList();
            }

        }
        public InventoryViewModel GetInventory(int inventory_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT inventory_id, product_size_id, qty, total_remaining
                    FROM tbl_inventory
                    WHERE inventory_id = @inventory_id";

                return con.QueryFirstOrDefault<InventoryViewModel>(sql, new { inventory_id });
            }
        }
        public IEnumerable<InventoryViewModel> GetAllInventory(string status)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT  p.product_id, p.product_name,p.product_type, ps.size_label, p.brand,i.qty, i.total_remaining, i.critical_level, i.status, i.expiry_date 
                        FROM tbl_inventory as i
                        LEFT JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                        LEFT JOIN tbl_products p ON p.product_id = ps.product_id
  ;

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


        public bool ProductExists(int size_id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(1) FROM tbl_inventory WHERE product_size_id = @product_size_id";

                return con.ExecuteScalar<int>(sql, new {product_size_id = size_id }) > 0;
            }
           
        }

        public int GetInventoryId(int size_id)
        {
            using (var con = Database.GetConnection())
            {
                const string sql = "SELECT inventory_id FROM tbl_inventory WHERE product_size_id = @product_size_id";
   
                return con.QueryFirstOrDefault<int>(sql, new { product_size_id = size_id });
            }
        }
        public int AddInventory(InventoryViewModel inventory)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_inventory (product_size_id, qty, total_remaining) VALUES (@product_size_id,@qty, @total_remaining);
                           SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, inventory);
            }
      
        }
        public void UpdateInventory(int product_size_id, int qty, int total_remaining)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_inventory SET qty  = qty + @qty, total_remaining = total_remaining + @total_remaining WHERE product_size_id = @product_size_id";
                con.Execute(sql, new {product_size_id, qty, total_remaining });
            }
               
        }
        public int UpdateCriticalLevel(int qty) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "UPDATE tbl_inventory SET critical_level = @qty";
                return con.Execute(sql, new { qty});
            }
        }
        public void VoidProductInventory(int id, int size_id, int qty) 
        {
        using (var con = Database.GetConnection()) 
            {

                var sql = @"
UPDATE tbl_inventory i
JOIN (
    SELECT ps.product_id,
           ps.product_size_id,
           (ps.content * @Qty) AS total_content,
           @Qty AS total_units
    FROM tbl_product_size ps
    WHERE ps.product_id = @Id
      AND ps.product_size_id = @SizeId
) x ON x.product_id = i.product_id
   AND x.product_size_id = i.product_size_id
SET i.total_remaining = GREATEST(i.total_remaining + x.total_content, 0),
    i.qty = GREATEST(i.qty + x.total_units, 0)
WHERE i.product_id = @Id
  AND i.product_size_id = @SizeId;
";

                con.Execute(sql, new { Id = id, SizeId = size_id, Qty = qty });
            }
              
        }
        public void DeductInventory(int id, int product_size_id, int qty, int total_remaining) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_inventory SET qty  = qty - @qty, total_remaining = total_remaining - @total_remaining WHERE product_id = @id AND product_size_id = @product_size_id";
                con.Execute(sql, new { id, product_size_id, qty, total_remaining });
            }
        }
        public void UpdateInventoryVolume(int id, double unit, double volume)
{
    unit = double.IsNaN(unit) ? 0 : unit;
    volume = double.IsNaN(volume) ? 0 : volume;

    using (var con = Database.GetConnection())
    {
        var sql = @"UPDATE tbl_inventory 
                    SET unit = @unit, 
                        volume = GREATEST(volume - @volume, 0) 
                    WHERE product_id = @id";
        con.Execute(sql, new { id, unit, volume });
    }
}
        public void RefundInventoryVolume(int id, double unit, double volume)
        {
            unit = double.IsNaN(unit) ? 0 : unit;
            volume = double.IsNaN(volume) ? 0 : volume;

            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_inventory 
                    SET unit = unit + @unit, 
                        volume = volume + @volume 
                    WHERE product_id = @id";
                con.Execute(sql, new { id, unit, volume });
            }
        }

        //public void UpdateInventoryVolume(int id, double unit, double volume)
        //{

        //    using (var con = Database.GetConnection()) 
        //    {
        //        var sql = "UPDATE tbl_inventory SET unit = @unit, volume = volume - @volume WHERE product_id = @id";
        //        con.Execute(sql, new { id, unit, volume });
        //    }

        //}
        public int LowOrOutOfStock()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM tbl_inventory
                    WHERE status IN ('Low Stock', 'Out of Stock');";
                return con.ExecuteScalar<int>(sql); // returns actual count
            }
        }
        //public void UpdateExpiredInventory() 
        //{
        //    using (var con = Database.GetConnection())
        //    {
        //        var sql = @"UPDATE tbl_inventory i
        //        JOIN (
        //         SELECT product_id, SUM(volume - used_volume) AS expired_volume
        //        FROM tbl_inventory_batch
        //        WHERE expiry_date < CURDATE()
        //          AND is_expired_processed = FALSE
        //          AND (volume - used_volume) > 0
        //        GROUP BY product_id

        //        ) expired ON i.product_id = expired.product_id
        //        SET 
        //          i.volume = GREATEST(i.volume - expired.expired_volume, 0),
        //          i.unit = GREATEST(FLOOR((i.volume - expired.expired_volume) / i.volume_per_unit), 0);";
        //                        con.Execute(sql);
        //    }
        //}

        public void UpdateExpiredInventory()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"
                    UPDATE tbl_inventory i
                    JOIN (
                        SELECT product_id, SUM(volume - used_volume) AS expired_volume
                        FROM tbl_inventory_batch
                        WHERE expiry_date < CURDATE()
                          AND is_expired_processed = FALSE
                          AND (volume - used_volume) > 0
                        GROUP BY product_id
                    ) expired ON i.product_id = expired.product_id
                    SET 
                      i.volume = GREATEST(i.volume - expired.expired_volume, 0),
                      i.unit = GREATEST(FLOOR((i.volume - expired.expired_volume) / i.volume_per_unit), 0);";

                con.Execute(sql);
            }
        }

        public void DeleteInventory(int inventoryId)
        {
            throw new NotImplementedException();
        }

        // INVENTORY REPORT
        public int TotalInventoryCount()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT COUNT(*) FROM inventory_report_view;";
                return con.ExecuteScalar<int>(sql); // returns actual count
            }
        }
        public IEnumerable<InventoryViewModel> InventoryReportView(int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM inventory_report_view LIMIT @page_size OFFSET @off_set;";
                return con.Query<InventoryViewModel>(sql,new { page_size, off_set }); // returns actual count
            }
        }
        public IEnumerable<InventoryViewModel> InventoryReportView(string status, int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM inventory_report_view WHERE status =@status LIMIT @page_size OFFSET @off_set;";
                return con.Query<InventoryViewModel>(sql, new { status, page_size, off_set}); // returns actual count
            }
        }
    }
}
