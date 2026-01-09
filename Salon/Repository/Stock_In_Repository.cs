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
                            (delivery_id, product_id, product_size_id, qty,qty_remaining, total, total_remaining , created_at)
                            VALUES (@delivery_id, @product_id, @product_size_id, @qty, @qty_remaining, @total, @total_remaining , CURRENT_TIMESTAMP())";
                return con.Execute(sql, model);
            }
        }
    }
}
