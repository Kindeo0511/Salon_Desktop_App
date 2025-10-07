using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class UtilController
    {
        private readonly UtilityRepository repo;
        public UtilController(UtilityRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<UtilityModel> GetAllUtility() 
        {
            return repo.AllUtilities();
        }

        public UtilityModel GetUtility() 
        {
            return repo.AllUtilty();
        }
        public UtilityModel TotalUtility() 
        {
            return repo.TotalUtility(); 
        }
        public void AddUtility(UtilityModel model) 
        {
            repo.AddUtility(model);
        }
        public void UpdateUtility(UtilityModel model) 
        {
            repo.UpdateUtility(model);
        }
        public void RemoveUtility(int id) 
        {
            repo.RemoveUtility(id);
        }
    }
}
