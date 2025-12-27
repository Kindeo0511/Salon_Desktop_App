using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ProductSizeController
    {
        private readonly ProductSizeRepository repo;


        public ProductSizeController(ProductSizeRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<ProductSizeModel> GetProductSizeById(int product_id) 
        {
            return repo.GetAllProductSizeById(product_id);
        }
        public IEnumerable<ProductSizeModel> GetProductSize(int product_id) 
        {
            return repo.GetProductSize(product_id);
        }
        public void AddProductSize(ProductSizeModel model) 
        {
            repo.Add(model);
        }
        public void UpdateProductSize(ProductSizeModel model) 
        {
            repo.Update(model);
        }
        
    }
}
