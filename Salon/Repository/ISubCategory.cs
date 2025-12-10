using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface ISubCategory
    {
        IEnumerable<SubCategoryModel> GetAllSubCategories();
        Task<IEnumerable<SubCategoryModel>> GetAllSubCategoryAsync();
        void AddSubCategory(SubCategoryModel subCategory);
        void UpdateSubCategory(SubCategoryModel subCategory);
        void DeleteSubCategory(int subCategoryId);
        void RestoreDeletedSubCategories(int id);
        void PermanentDelete(int id);
        bool SubCategoryIsUsed(int subCategoryId);
        bool SubCategoriesExist(string name, int category_id, int id = 0);
    }
}
