using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class SpecialistController
    {
        private readonly SpecialistRepository repo;
        public SpecialistController(SpecialistRepository repo) 
        {
            this.repo = repo;
        }


        public IEnumerable<SpecialistModel> GetAllSpecialists() 
        {
            return repo.DisplayList();
        }

        public bool CreateSpecialist(SpecialistModel model) 
        {
            return repo.Create(model) > 0;
        }

        public bool UpdateSpecialist(SpecialistModel model)
        {
            return repo.Update(model) > 0;
        }
    }
}
