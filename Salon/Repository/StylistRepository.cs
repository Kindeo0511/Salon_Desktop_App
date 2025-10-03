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
    public class StylistRepository : IStylist
    {
        public IEnumerable<StylistModel> GetAllStylist()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_stylists";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public IEnumerable<StylistModel> GetStylistWithFullName()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT stylist_id, CONCAT(firstName,' ',middleName,' ',lastName) as fullName FROM tbl_stylists";
                return con.Query<StylistModel>(sql).ToList();
            }
        }
        public StylistModel GetStylistCost() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT ROUND(AVG(daily_wage), 0) AS stylist_cost
                            FROM tbl_stylists;
                            ";
                return con.Query<StylistModel>(sql).FirstOrDefault();
            }
        }
        public void AddStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"INSERT INTO tbl_stylists (firstName, middleName, lastName, birth_date, contactNumber, email, address) 
                            VALUES (@firstName, @middleName, @lastName, @birth_date, @contactNumber, @email, @address)";
                con.Execute(sql, stylist);
            }
        }
        public void UpdateStylist(StylistModel stylist)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_stylists SET firstName = @firstName, middleName = @middleName, lastName = @lastName, 
                            birth_date = @birth_date, contactNumber = @contactNumber, email = @email, address = @address
                            WHERE stylist_id = @stylist_id";
                con.Execute(sql, stylist);
            }
        }
        public void DeleteStylist(int stylist_id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_stylists WHERE stylist_id = @stylist_id";
                con.Execute(sql, new { stylist_id });
            }
        }
    }
}
