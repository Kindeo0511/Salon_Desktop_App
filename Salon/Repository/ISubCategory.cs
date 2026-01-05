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
        Task<IEnumerable<SubCategoryModel>> GetAllSubCategoryAsync(int page_size, int off_set);
        int AddSubCategory(SubCategoryModel subCategory);
        int UpdateSubCategory(SubCategoryModel subCategory);
        int DeleteSubCategory(int subCategoryId);
        int RestoreDeletedSubCategories(int id);
        int PermanentDelete(int id);
        bool SubCategoryIsUsed(int subCategoryId);
        bool SubCategoriesExist(string name, int category_id, int id = 0);
    }
}
