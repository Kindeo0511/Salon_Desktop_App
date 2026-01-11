using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class OwnerEmailController
    {
        private readonly OwnderEmailRepository repo;

        public OwnerEmailController(OwnderEmailRepository repo) 
        {
            this.repo=repo;
        }

        public OwnerEmaillModel GetOwnerEmail() 
        {
            return repo.OwnerEmail();
        }
        public bool Create(OwnerEmaillModel model)
        {
            return repo.Create(model) > 0;
        }
        public bool Update(OwnerEmaillModel model)
        {
            return repo.Update(model) > 0;
        }
    }
}
