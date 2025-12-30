using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class DeletedRecord
    {
        public int deleted_id { get; set; }
        public int record_id { get; set; }
        public int sub_id { get; set; }
        public string module { get; set; }
        public string name { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_on { get; set; }
    }
}
