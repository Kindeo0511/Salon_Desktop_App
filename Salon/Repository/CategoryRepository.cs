using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Salon.Repository
{
    public class CategoryRepository : ICategory
    {
        public IEnumerable<CategoryModel> getAllCategory()
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT * FROM tbl_category WHERE is_deleted = 0";
                return con.Query<CategoryModel>(sql).ToList();
            }
        }
        public async Task<IEnumerable<CategoryModel>> GetAllCategoryAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_category WHERE is_deleted = 0";
                var result = await con.QueryAsync<CategoryModel>(sql);

                return result.ToList();
            }
        }
        public IEnumerable<CategoryModel> getAllCategoryByService() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_category WHERE type = 'Service' AND is_deleted = 0";
                return con.Query<CategoryModel>(sql).ToList();
            }
        }
        public IEnumerable<CategoryModel> getAllCategoryByProduct()
        {
            using (var con = Database.GetConnection())
            {
                var sql = "SELECT * FROM tbl_category WHERE type = 'Product' AND is_deleted = 0";
                return con.Query<CategoryModel>(sql).ToList();
            }
        }
        public void addCategory(CategoryModel category)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "INSERT INTO tbl_category (categoryName, type) VALUES (@categoryName, @type)";
                con.Execute(sql, category);
            }
        }
        public void updateCategory(CategoryModel category)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_category SET categoryName = @categoryName, type = @type WHERE category_id = @category_id";
                con.Execute(sql, category);
            }
        }
        public void deleteCategory(int id)
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_category SET is_deleted = 1 WHERE category_id = @id";
                con.Execute(sql, new { id });
            }
        }
        public void restoreDeleted(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "UPDATE tbl_category SET is_deleted = 0 WHERE category_id = @id";
                con.Execute(sql, new { id });
            }
        }
        public void PermanentDelete(int id) 
        {
            using (var con = Database.GetConnection())
            {
                var sql = "DELETE FROM tbl_category WHERE category_id = @id";
                con.Execute(sql, new { id });
            }
        }
        public bool CategoriesExist(string category, string type, int id = 0) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "SELECT  COUNT(*) FROM tbl_category WHERE categoryName = @category AND type = @type AND category_id != @id";
               return  con.ExecuteScalar<int>(sql, new {category, type, id }) > 0;
            }
        }
        public async Task<CategoryModel> GetExistingCategoryAsync(string category, string type, int excludeId = 0)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT * FROM tbl_category WHERE categoryName = @category AND type = @type AND category_id != @excludeId";

                return await con.QueryFirstOrDefaultAsync<CategoryModel>(sql, new { category, type, excludeId });
            }
        }

    }
}
