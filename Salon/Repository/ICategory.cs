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
        void addCategory(CategoryModel category);
        void updateCategory(CategoryModel category);
        void deleteCategory(int id);
        bool CategoryIsUsed(int id);
        void restoreDeleted(int id);
        void PermanentDelete(int id);
        bool CategoriesExist(string category, string type ,int id);
        Task<CategoryModel> GetExistingCategoryAsync(string category, string type, int id);

    }
}
