using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface ICategory
    {
        IEnumerable<CategoryModel> getAllCategory();
        Task<IEnumerable<CategoryModel>> GetAllCategoryAsync();
        IEnumerable<CategoryModel> getAllCategoryByProduct();
        IEnumerable<CategoryModel> getAllCategoryByService();
        int addCategory(CategoryModel category);
        int updateCategory(CategoryModel category);
        int deleteCategory(int id);
        bool CategoryIsUsed(int id);
        int restoreDeleted(int id);
        int PermanentDelete(int id);
        bool CategoriesExist(string category, string type ,int id);
        Task<CategoryModel> GetExistingCategoryAsync(string category, string type, int id);

    }
}
