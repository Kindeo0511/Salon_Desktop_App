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
        IEnumerable<CategoryModel> getAllCategoryByProduct();
        void addCategory(CategoryModel category);
        void updateCategory(CategoryModel category);
        void deleteCategory(int id);

        bool CategoriesExist(string category, string type ,int id);
    }
}
