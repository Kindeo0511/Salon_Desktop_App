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
    public class OverHeadRepository: IOverHead
    {
        public OverHeadModel GetOverHead() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM `tbl_overhead` WHERE 1";
                return con.Query<OverHeadModel>(sql).FirstOrDefault();
            }
        }
        public void AddOverHead(OverHeadModel overHead) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "INSERT INTO tbl_overhead (monthly_rent, electricity_bill, water_bill, internet_bill, other_bill, notes, total_over_head, total_working_hours) VALUES (@monthly_rent, @electricity_bill, @water_bill, @internet_bill, @other_bill, @notes, @total_over_head, @total_working_hours)";
                con.Execute(sql, overHead);
            }
        }
        public void UpdateOverHead(OverHeadModel overHead) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_overhead SET monthly_rent = @monthly_rent , electricity_bill = @electricity_bill, water_bill = @water_bill, internet_bill = @internet_bill, other_bill = @other_bill, notes = @notes, total_over_head = @total_over_head, total_working_hours = @total_working_hours WHERE over_head_id = @over_head_id";
                con.Execute(sql, overHead);
            }
        }
    }
}
