using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class ProductRepository : IProduct
    {
        public IEnumerable<ProductModel> GetRetailProduct() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_products WHERE product_type = 'Retail' AND is_deleted = 0 LIMIT @page_size OFFSET @off_set";
                return con.Query<ProductModel>(sql).ToList();
            }
        }
        public IEnumerable<ProductModel> GetRetailProduct(int page_size, int off_set)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_products WHERE product_type = 'Retail' AND is_deleted = 0 LIMIT @page_size OFFSET @off_set";
                return con.Query<ProductModel>(sql, new { page_size, off_set }).ToList();
            }
        }
        public int TotalRetailProduct() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_products WHERE product_type = 'Retail' AND is_deleted = 0;";
                return con.ExecuteScalar<int>(sql);
            }
        }
        public IEnumerable<RetailProduct> GetAllRetailProducts()
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT p.product_id, ps.product_size_id, p.product_name, ps.size_label, 
                           ps.content, p.brand, ps.selling_price
                    FROM tbl_products p
                    JOIN tbl_product_size ps ON ps.product_id = p.product_id
                    WHERE p.is_deleted = 0  
                      AND p.product_type = 'Retail' ";
                return con.Query<RetailProduct>(sql).ToList();
            }
        }
        public RetailProduct GetRetailProductByIdAndSize(int productId, int productSizeId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT p.product_id, ps.product_size_id, p.product_name, p.unit_type, ps.size_label, 
                           ps.content, p.brand, ps.selling_price
                    FROM tbl_products p
                    JOIN tbl_product_size ps ON ps.product_id = p.product_id
                    WHERE p.is_deleted = 0  
                      AND p.product_type = 'Retail' 
                      AND p.product_id = @productId
                      AND ps.product_size_id = @productSizeId";

                return con.QuerySingleOrDefault<RetailProduct>(sql, new { productId, productSizeId });
            }
        }

        public RetailProduct GetRetailProductByName(string name)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT p.product_id, p.product_name, ps.size_label, ps.content, p.brand, ps.selling_price
                    FROM tbl_products p
                    LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                    WHERE p.is_deleted = 0  
                      AND p.product_type = 'Retail' 
                      AND p.product_name = @name"; // exact match

                return con.QuerySingleOrDefault<RetailProduct>(sql, new { name });
            }
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT p.product_id, p.product_name,p.product_type, p.brand, c.category_id, c.categoryName AS categoryName, p.unit_type,ps.size_label, ps.content, ps.selling_price, ps.cost_price
                            FROM tbl_products p
                            JOIN tbl_category c ON p.category_id = c.category_id
                            JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            WHERE p.is_deleted = 0 AND c.is_deleted = 0 AND p.product_type = 'Ingredient'";
                return con.Query<ProductModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<ProductModel>> GetAllProductAsync(int page_size, int off_set) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT p.product_id, p.product_name,p.product_type, p.brand, c.category_id, c.categoryName AS categoryName, p.unit_type,ps.size_label, ps.content, ps.selling_price, ps.cost_price
                            FROM tbl_products p
                            JOIN tbl_category c ON p.category_id = c.category_id
                            LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            WHERE p.is_deleted = 0 AND c.is_deleted = 0 AND p.product_type = 'Ingredient' 
                            LIMIT @page_size OFFSET @off_set";
                var result = await con.QueryAsync<ProductModel>(sql, new { page_size, off_set});

                return result.ToList();
            }
        }
        public IEnumerable<ProductModel> GetAllProductToOrder() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT p.product_id, p.product_name,p.product_type, p.brand, c.category_id, c.categoryName AS categoryName, p.unit_type,ps.size_label, ps.content, ps.selling_price, ps.cost_price
                            FROM tbl_products p
                            JOIN tbl_category c ON p.category_id = c.category_id
                            JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            WHERE p.is_deleted = 0 AND c.is_deleted = 0";
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

        public async Task<ProductModel> GetTotalProductAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) AS TotalProduct FROM tbl_products";

                var result = await con.QueryAsync<ProductModel>(sql);

                return result.FirstOrDefault();

            }
        }
        public ProductModel GetProductIngredient(string name, string brand, string unit_type) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT * FROM tbl_products 
                            WHERE product_type = 'Ingredient' AND product_name = @name AND brand = @brand AND unit_type = @unit_type AND is_deleted = 1";
                return con.Query<ProductModel>(sql, new { name, brand, unit_type }).FirstOrDefault();
            }
        }
        public ProductModel GetProductRetail(string name, string brand, string unit_type)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_products 
                            WHERE product_type = 'Retail' AND product_name = @name AND brand = @brand AND unit_type = @unit_type AND is_deleted = 1";
                return con.Query<ProductModel>(sql, new { name, brand, unit_type}).FirstOrDefault();
            }
        }
        public int AddProduct(ProductModel product)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_products (product_name, product_type, brand, unit_type, created_at)
                            VALUES (@product_name, @product_type, @brand, @unit_type, CURRENT_TIMESTAMP); SELECT LAST_INSERT_ID();";
                return con.QuerySingle<int>(sql, product);
            }
        }
        public int UpdateProduct(ProductModel product)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_products
                            SET product_name = @product_name,  
                                brand = @brand,
                                unit_type = @unit_type,
                                updated_at = CURRENT_TIMESTAMP
                            WHERE product_id = @product_id";
               return con.Execute(sql, product);
            }
        }
        public int DeleteProduct(int productId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_products SET is_deleted = 1 WHERE product_id = @productId";
               return con.Execute(sql, new { productId });
            }
        }
       public int RestoreProduct(int productId) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_products SET is_deleted = 0 WHERE product_id = @productId";
               return con.Execute(sql, new { productId });
            }
        }
        public int PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_products WHERE product_id = @id";
               return con.Execute(sql, new { id });
            }
        }
        
        public bool ProductExists(string name, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_products WHERE product_name = @name AND product_id != @id AND is_deleted = 0";
                return con.ExecuteScalar<int>(sql, new { name, id }) > 0;
            }
        }

        public bool ProductIsUsed(int productId) 
        {
            using (var con = Database.GetConnection())
            { 
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_inventory WHERE product_id = @productId)
                            OR EXISTS (SELECT 1 FROM tbl_service_product WHERE product_id = @productId)
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql, new { productId }) == 1; }
        }
        public bool ProductRetailIsUsed(int productId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @" SELECT CASE WHEN EXISTS (SELECT 1 FROM tbl_inventory WHERE product_id = @productId)
                            OR EXISTS (SELECT 1 FROM tbl_delivery_items WHERE product_id = @productId)   
                            THEN 1 ELSE 0 END";
                return con.ExecuteScalar<int>(sql, new { productId }) == 1;
            }
        }
    }
}
