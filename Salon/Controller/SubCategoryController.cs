using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class SubCategoryController
    {
        private readonly SubCategoryRepository repo;

        public SubCategoryController(SubCategoryRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<SubCategoryModel> getSubCategory()
        {
            return repo.GetAllSubCategories();
        }
        public async Task<IEnumerable<SubCategoryModel>> GetSubCategoryAsync() 
        {
            return await repo.GetAllSubCategoryAsync();
        }
        public bool addSubCategory(SubCategoryModel subCategory)
        {
            return repo.AddSubCategory(subCategory) > 0;
        }
        public bool updateSubCategory(SubCategoryModel subCategory)
        {
           return repo.UpdateSubCategory(subCategory) > 0;
        }
        public bool deleteSubCategory(int subCategoryId)
        {
           return repo.DeleteSubCategory(subCategoryId) > 0;
        }

        public bool RestoreSubCategory(int id) 
        {
           return repo.RestoreDeletedSubCategories(id) > 0;
        }
         
        public bool PermanentDeleteSubCategory(int id) 
        {
           return repo.PermanentDelete(id) > 0;
        }

        public bool IsSubCategoryUsed(int subCategoryId)
        {
            return repo.SubCategoryIsUsed(subCategoryId);
        }
        public bool CheckSubCategoryExists(string name, int category_id, int id) 
        {
            return repo.SubCategoriesExist(name, category_id, id);
        }

        public SubCategoryModel GetSubCategory(string name, int category_id) 
        {
            
            return repo.GetSubCategoryName(name, category_id);
            
        }
    }
}
