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
                var sql = @"SELECT * FROM tbl_product_size WHERE product_id = @product_id";
                
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
        public void Add(ProductSizeModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_product_size
                            (product_id, size_label, content, selling_price, cost_price)
                            VALUES (@product_id, @size_label, @content, @selling_price, @cost_price)";
                con.Execute(sql, model);
            }
        }
        public void Update(ProductSizeModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_product_size 
                        SET
                            size_label = @size_label,
                            content = @content,
                            selling_price = @selling_price,
                            cost_price = @cost_price
                            WHERE product_id = @product_id";

                con.Execute(sql, model);
            }
            
        }
    }
}
