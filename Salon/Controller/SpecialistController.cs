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

        public int GetSpecialistIdByStylistId(int id) 
        {
            return repo.GetSpecialistIdByStylistId(id);
        }
        public bool CreateSpecialist(SpecialistModel model)
        {
            return repo.Create(model) > 0;
        }

        public bool UpdateSpecialist(SpecialistModel model)
        {
            return repo.Update(model) > 0;
        }

        public bool DeleteSpecialist(int specialist_id)
        {
            return repo.Delete(specialist_id);
        }
        public bool RestoreSpecilist(int specialist_id)
        {
            return repo.Restore(specialist_id);
        }
        public bool PermanentDeleteSpecialist(int specialist_id)
        {
            return repo.PermanentDelete(specialist_id);
        }

        public bool IsSpecialistUsed(int specialist_id)
        {
            return repo.IsSpecialistIsUsed(specialist_id);
        }
        public bool SpecialistExists(string name, int specialist_id)
        {
            return repo.SpecialistExists(name, specialist_id);
        }
        public int SpecialistExistsButDeleted(string name)
        {
            return repo.SpecialistExistsButDeleted(name);
        }
    }
}
