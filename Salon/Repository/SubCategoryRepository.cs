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
                            JOIN tbl_category c ON sc.category_id = c.category_id
                            WHERE sc.is_deleted = 0 AND c.is_deleted = 0;";
                return con.Query<SubCategoryModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<SubCategoryModel>> GetAllSubCategoryAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT sc.subCategory_id, sc.category_id, sc.subCategoryName, c.categoryName
                            FROM tbl_subcategory sc
                            JOIN tbl_category c ON sc.category_id = c.category_id
                            WHERE sc.is_deleted = 0 AND c.is_deleted = 0; ";
                var result =  await con.QueryAsync<SubCategoryModel>(sql);

                return result.ToList();
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
                var sql = "UPDATE tbl_subcategory SET is_deleted = 1 WHERE subCategory_id = @subCategory_id";
                con.Execute(sql, new { subCategory_id = subCategoryId });
            }
        }
        public void RestoreDeletedSubCategories(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_subcategory SET is_deleted = 0 WHERE subCategory_id = @id";
                con.Execute(sql, new { id = id });
            }
        }
        public void PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_subcategory WHERE subCategory_id = @id";
                con.Execute(sql, new { id = id });
            }
        }
        public bool SubCategoriesExist(string name, int category_id, int id = 0) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM tbl_subcategory WHERE subCategoryName = @name AND category_id = @category_id AND subCategory_id != @id";
                return con.ExecuteScalar<int>(sql, new { name, category_id, id }) > 0;
            }
        }
    }
}
