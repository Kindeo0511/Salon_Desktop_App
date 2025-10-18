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
    public class ProductRepository : IProduct
    {
        public IEnumerable<ProductModel> GetAllProducts()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT p.product_id, p.product_name, p.brand, p.category_id, c.categoryName AS categoryName, p.unit_type, p.usage_type, p.unit_volume
                            FROM tbl_products p
                            JOIN tbl_category c ON p.category_id = c.category_id
                            WHERE p.is_deleted = 0";
                return con.Query<ProductModel>(sql).ToList();
            }
        }
        public ProductModel GetTotalProducts() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) AS TotalProduct FROM tbl_products";

                return con.Query<ProductModel>(sql).FirstOrDefault();

            }
        }
        public void AddProduct(ProductModel product)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_products (product_name, brand, category_id, unit_type, usage_type, unit_volume)
                            VALUES (@product_name, @brand, @category_id, @unit_type, @usage_type, @unit_volume)";
                con.Execute(sql, product);
            }
        }
        public void UpdateProduct(ProductModel product)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_products
                            SET product_name = @product_name,
                                brand = @brand,
                                category_id = @category_id,
                                unit_type = @unit_type,
                                usage_type = @usage_type,
                                unit_volume = @unit_volume
                            WHERE product_id = @product_id";
                con.Execute(sql, product);
            }
        }
        public void DeleteProduct(int productId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_products SET is_deleted = 1 WHERE product_id = @productId";
                con.Execute(sql, new { productId });
            }
        }
       public void RestoreProduct(int productId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_products SET is_deleted = 0 WHERE product_id = @productId";
                con.Execute(sql, new { productId });
            }
        }

        public bool ProductExists(string name, int cat_id, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_products WHERE product_name = @name AND category_id =@cat_id AND product_id != @id";
                return con.ExecuteScalar<int>(sql, new { name, cat_id, id }) > 0;
            }
        }
    }
}
