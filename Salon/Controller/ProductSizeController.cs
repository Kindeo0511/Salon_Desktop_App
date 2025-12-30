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
        public bool AddProductSize(ProductSizeModel model) 
        {
           return repo.Add(model) > 0;
        }
        public bool UpdateProductSize(ProductSizeModel model) 
        {
            return repo.Update(model) > 0;
        }
        public ProductSizeModel GetProductSize(int product_id, int content) 
        {
            return repo.GetProductSize(product_id, content);
        }

        public bool IsProductSizeIsUsed(int productSizeId) 
        {
            return repo.IsProductSizeUsed(productSizeId);
        }
        public bool IsProductRetailSizeUsed(int productSizeId) 
        {
            return repo.IsProductRetailSizeUsed(productSizeId);
        }
        public bool SoftDeleteProductSize(int productSizeId) 
        {
            return repo.SoftDelete(productSizeId) > 0;
        }
        public bool HardDeleteProductSize(int productSizeId) 
        {
            return repo.HardDelete(productSizeId) > 0;
        }
        public bool RestoreProductSize(int productSizeId) 
        {
            return repo.Restore(productSizeId) > 0;
        }

    }
}
