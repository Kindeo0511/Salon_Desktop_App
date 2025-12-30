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

        public async Task<IEnumerable<CategoryModel>> GetAllCategoryAsync() 
        {
            return await repo.GetAllCategoryAsync();
        }
        public IEnumerable<CategoryModel> getAllCategoryByService() 
        {
            return repo.getAllCategoryByService();
        }
        public IEnumerable<CategoryModel> getAllCategoryByProduct()
        {
            return repo.getAllCategoryByProduct();
        }

        public bool addCategory(CategoryModel category)
        {
           return repo.addCategory(category) > 0;
        }
        public bool updateCategory(CategoryModel category)
        {
           return repo.updateCategory(category) > 0;
        }
        public bool deleteCategory(int id)
        {
            return repo.deleteCategory(id) > 0;
        }

        public bool restoreCategory(int id) 
        {
            return repo.restoreDeleted(id) > 0;
        }
        public bool PermanentDeleteCategory(int id) 
        {
           return repo.PermanentDelete(id) > 0;
        }
        public bool IsCategoryBeingUsed(int id) 
        {
            return repo.CategoryIsUsed(id);
        }
        public bool CheckCategoryExists(string category, string type, int id = 0) 
        {
           return repo.CategoriesExist(category,type, id);
        }

        public async Task<CategoryModel> CheckCategoryExistsAsync(string category, string type, int excludeId = 0)
        {
            return await repo.GetExistingCategoryAsync(category, type, excludeId);
        }

        public CategoryModel GetCategoryAndType(string category, string type)
        {
            return repo.GetCategoryNameAndType(category, type);
        }

    }
}
