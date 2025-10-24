using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Salon.Repository
{
    public class SupplierRepository : ISupplier
    {
        public IEnumerable<SupplierModel> GetAllSuppliers()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_supplier WHERE is_deleted = 0";
                return con.Query<SupplierModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<SupplierModel>> GetAllSuppliersAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_supplier WHERE is_deleted = 0";
                var result = await con.QueryAsync<SupplierModel>(sql);
                return result.ToList(); 
            }
        }
        public void AddSupplier(SupplierModel supplier)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_supplier (supplier_name, address, email, contact) VALUES (@supplier_name, @address, @email, @contact)";
                con.Execute(sql, supplier);
            }
        }
        public void UpdateSupplier(SupplierModel supplier)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_supplier SET supplier_name = @supplier_name, address = @address, email = @email, contact = @contact WHERE supplier_id = @supplier_id";
                con.Execute(sql, supplier);
            }
        }
        public void DeleteSupplier(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_supplier SET status = 'Inactive', is_deleted = 1 WHERE supplier_id = @Id";
                con.Execute(sql, new { Id = id });
            }
        }

        public void ActivateSupplier(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_supplier SET status = 'Active', is_deleted = 0 WHERE supplier_id = @Id";
                con.Execute(sql, new { Id = id });
            }
        }

        public bool SupplierExists(string name, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT COUNT(*) FROM tbl_supplier WHERE supplier_name = @name AND supplier_id != @id";
                return con.ExecuteScalar<int>(sql, new { name, id }) > 0;
            }
        }
        public bool EmailExists(string email, int id = 0) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_supplier WHERE email = @email AND supplier_id != @id";
                return con.ExecuteScalar<int>(sql, new { email, id }) > 0;
            }
        }
        public bool ContactExists(string contact, int id = 0) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_supplier WHERE contact = @contact AND supplier_id != @id";
                return con.ExecuteScalar<int>(sql, new { contact, id }) > 0;
            }
        }
    }
}
