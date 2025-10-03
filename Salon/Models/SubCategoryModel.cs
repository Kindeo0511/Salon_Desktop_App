using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SubCategoryModel
    {
        public int subCategory_id { get; set; }
        public int category_id { get; set; }
        public string subCategoryName { get; set; }
        public string categoryName { get; set; }

    }
}
