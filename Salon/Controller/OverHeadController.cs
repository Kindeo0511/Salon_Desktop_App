using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class OverHeadController
    {
        private readonly OverHeadRepository repo;
        public OverHeadController(OverHeadRepository repo)
        {
            this.repo = repo;
        }

        public OverHeadModel GetOverHeadTotal() 
        {
            return repo.GetOverHead(); ;
        }
        public void Add(OverHeadModel model) 
        {
            repo.AddOverHead(model);
        }
        public void Update(OverHeadModel model)
        {
            repo.UpdateOverHead(model);
        
        }
    }
}
