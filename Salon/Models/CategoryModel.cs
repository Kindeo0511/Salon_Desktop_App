using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CategoryModel
    {
        public int category_id { get; set; }
        public string categoryName { get; set; }
        public string type { get; set; }
        public bool is_deleted { get; set; }



    }
}
