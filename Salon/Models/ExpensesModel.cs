using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ExpensesModel
    {
        public int id { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public string paid_by { get; set; }
        public string notes { get; set; }
        public DateTime timestamp { get; set; }
    }
}
