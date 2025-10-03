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
    public class SubCategoryRepository : ISubCategory
    {
        public IEnumerable<SubCategoryModel> GetAllSubCategories()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT sc.subCategory_id, sc.category_id, sc.subCategoryName, c.categoryName
                            FROM tbl_subcategory sc
                            JOIN tbl_category c ON sc.category_id = c.category_id";
                return con.Query<SubCategoryModel>(sql).ToList();
            }
        }
        public void AddSubCategory(SubCategoryModel subCategory)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_subcategory (category_id, subCategoryName) VALUES (@category_id, @subCategoryName)";
                con.Execute(sql, subCategory);
            }
        }
        public void UpdateSubCategory(SubCategoryModel subCategory)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_subcategory SET category_id = @category_id, subCategoryName = @subCategoryName WHERE subCategory_id = @subCategory_id";
                con.Execute(sql, subCategory);
            }
        }
        public void DeleteSubCategory(int subCategoryId)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_subcategory WHERE subCategory_id = @subCategory_id";
                con.Execute(sql, new { subCategory_id = subCategoryId });
            }
        }
    }
}
