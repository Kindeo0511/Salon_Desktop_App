using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class StockTransactionModel
    {
        public int transaction_id { get; set; }
        public string transaction_type { get; set; }
        public string reference_no { get; set; }
        public DateTime date { get; set; }
        public int supplier_id { get; set; }
        public int user_id { get; set; }
        public string notes { get; set; }
        public string status { get; set; }
    }
}
