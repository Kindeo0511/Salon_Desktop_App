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
    public class DiscountRepository
    {
        public IEnumerable<DiscountModel> getAllDiscounts()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount";
                return con.Query<DiscountModel>(sql);
            }
               
        }
        public DiscountModel GetDiscountById(int discountId)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_discount WHERE discount_id = @discount_id";
                return con.QueryFirstOrDefault<DiscountModel>(sql, new { discount_id = discountId });
            }
                
        }
        public void AddDiscount(DiscountModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_discount (discount_type,promo_code, discount_rate)
                        VALUES(@discount_type, @promo_code, @discount_rate)";
                con.Execute(sql, model);
            }
                
        }
        public void UpdateDiscount(DiscountModel model)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_discount SET discount_type =@discount_type, promo_code =@promo_code, discount_rate=@discount_rate WHERE discount_id = @discount_id";
                con.Execute(sql, model);
            }
                
        }
        public void DeleteDiscount(int id)
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"DELETE FROM tbl_discount  WHERE discount_id = @discount_id";
                con.Execute(sql, new { discount_id = id });
            }
                
        }
    }
}
