using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class Walk_In_Controller
    {
        private readonly WalkInRepository repo;
        public Walk_In_Controller(WalkInRepository repo) 
        {
            this.repo = repo;
        }

        public int GetWalkInCode()
        {
            return repo.getWalkInCode();
        }
        public IEnumerable<WalkInModel> GetWalkIn()
        {
            return repo.GetWalkIn();
        }
        public void AddWalkIn(WalkInModel walkIn)
        {
            repo.AddWalkIn(walkIn);
        }
        public void UpdateWalkIn(WalkInModel walkIn)
        {
            repo.UpdateWalkIn(walkIn);
        }
    }
}
