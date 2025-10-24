using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class VatController
    {
        private readonly VatRepository _repo;

        public VatController(VatRepository repo)
        {
            this._repo = repo;
        }
        public VatModel LoadLatestTax()
        {
            return _repo.getTax().FirstOrDefault();
        }
        public async Task<VatModel> LoadLatestTaxAsync() 
        {
            var result = await _repo.GetTaxAsync();
            return result.FirstOrDefault();
        }
        public void CreateTax(VatModel taxModel)
        {
            _repo.addTax(taxModel);
        }
        public void UpdateTax(VatModel taxModel)
        {
            _repo.updateTax(taxModel);
        }
        public int checkTax()
        {
            return _repo.checkTax();
        }

    }
}
