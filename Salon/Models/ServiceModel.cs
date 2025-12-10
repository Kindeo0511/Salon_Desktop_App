using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServiceModel
    {
        public int serviceName_id { get; set; }
        public int subCategory_id { get; set; }
        public string serviceName { get; set; }
        public string subCategoryName { get; set; }
        public int duration { get; set; }
        public  Status status { get; set; }
        public decimal servicePrice { get; set; }
        public int TotalService { get; set; }

}
    public enum Status
    {
        Active = 0,
        Inactive = 1
    }

}
