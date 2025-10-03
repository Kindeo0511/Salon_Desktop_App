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
    public class SupplierRepository : ISupplier
    {
        public IEnumerable<SupplierModel> GetAllSuppliers()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_supplier";
                return con.Query<SupplierModel>(sql).ToList();
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
                var sql = "DELETE FROM tbl_supplier WHERE supplier_id = @Id";
                con.Execute(sql, new { Id = id });
            }
        }
    }
}
