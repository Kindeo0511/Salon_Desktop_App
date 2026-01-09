using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class Stock_Out_Controller
    {
        private readonly Stock_Out_Repository repo;

        public Stock_Out_Controller(Stock_Out_Repository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<Stock_Out_Model> GetAllStockOutLists() 
        {
            return repo.Stock_Out_Lists();
        }
    }
}
