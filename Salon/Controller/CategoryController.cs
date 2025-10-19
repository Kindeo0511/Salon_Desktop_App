using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class CategoryController
    {
        private readonly CategoryRepository repo;
        public CategoryController(CategoryRepository repo) 
        {
            this.repo = repo;
        }   

        public IEnumerable<CategoryModel> getAllCategory()
        {
            return repo.getAllCategory();
        }
        public IEnumerable<CategoryModel> getAllCategoryByService() 
        {
            return repo.getAllCategoryByService();
        }
        public IEnumerable<CategoryModel> getAllCategoryByProduct()
        {
            return repo.getAllCategoryByProduct();
        }

        public void addCategory(CategoryModel category)
        {
            repo.addCategory(category);
        }
        public void updateCategory(CategoryModel category)
        {
            repo.updateCategory(category);
        }
        public void deleteCategory(int id)
        {
            repo.deleteCategory(id);
        }

        public void restoreCategory(int id) 
        {
            repo.restoreDeleted(id);
        }
        public bool CheckCategoryExists(string category, string type, int id = 0) 
        {
           return repo.CategoriesExist(category,type, id);
        }
    }
}
