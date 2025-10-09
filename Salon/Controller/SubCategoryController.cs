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
        public void addSubCategory(SubCategoryModel subCategory)
        {
            repo.AddSubCategory(subCategory);
        }
        public void updateSubCategory(SubCategoryModel subCategory)
        {
            repo.UpdateSubCategory(subCategory);
        }
        public void deleteSubCategory(int subCategoryId)
        {
            repo.DeleteSubCategory(subCategoryId);
        }

        public bool CheckSubCategoryExists(string name, int category_id, int id) 
        {
            return repo.SubCategoriesExist(name, category_id, id);
        }
    }
}
