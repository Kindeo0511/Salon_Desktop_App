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
    public class ProductSizeRepository
    {

        public IEnumerable<ProductSizeModel> GetAllProductSizeById(int product_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT ps.product_size_id,ps.product_id,p.product_name, ps.size_label, ps.content, ps.selling_price, ps.cost_price, ps.is_deleted
                        FROM tbl_product_size ps
                        JOIN tbl_products p 
                            ON p.product_id = ps.product_id
                        WHERE ps.product_id = @product_id 
                          AND ps.is_deleted = 0;
                        ";
                
                return con.Query<ProductSizeModel>(sql, new { product_id = product_id });
            }
        }
        public IEnumerable<ProductSizeModel> GetProductSize(int product_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_product_size WHERE product_id = @product_id";

                return con.Query<ProductSizeModel>(sql, new { product_id = product_id });
            }
        }
        public int Add(ProductSizeModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_product_size
                            (product_id, size_label, content, selling_price, cost_price)
                            VALUES (@product_id, @size_label, @content, @selling_price, @cost_price)";
               return con.Execute(sql, model);
            }
        }
        public int Update(ProductSizeModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_product_size 
                        SET
                            size_label = @size_label,
                            content = @content,
                            selling_price = @selling_price,
                            cost_price = @cost_price
                            WHERE product_size_id = @product_size_id";

               return con.Execute(sql, model);
            }
            
        }
        public ProductSizeModel GetProductSize(int product_id, int content) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT * FROM tbl_product_size 
                            WHERE product_id = @product_id AND content = @content";
                return con.QueryFirstOrDefault<ProductSizeModel>(sql, new { product_id, content });
            }
        }

        public bool IsProductSizeUsed(int product_size_id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_inventory WHERE product_size_id = @product_size_id)                        
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql, new { product_size_id }) == 1;
            }
        }
        public bool IsProductRetailSizeUsed(int product_size_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_inventory WHERE product_size_id = @product_size_id)   
                                    OR EXISTS (SELECT 1 FROM tbl_delivery_items WHERE product_size_id = @product_size_id)
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql, new { product_size_id }) == 1;
            }
        }
        public int SoftDelete(int productSizeId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_product_size 
                            SET is_deleted = 1 
                            WHERE product_size_id = @productSize_id";
                return con.Execute(sql, new { productSize_id = productSizeId });
            }
        }
        public int HardDelete(int productSize_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"DELETE FROM tbl_product_size 
                            WHERE product_size_id = @productSize_id";
                return con.Execute(sql, new { product_id = productSize_id });
            }
        }
        public int Restore(int productSizeId) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_product_size 
                            SET is_deleted = 0 
                            WHERE product_size_id = @productSize_id";
                return con.Execute(sql, new { productSize_id = productSizeId });
            }
        }
    }
}
