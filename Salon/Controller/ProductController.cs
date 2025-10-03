using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ProductController
    {
        private readonly ProductRepository repo;
        public ProductController(ProductRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<ProductModel> getAllProduct()
        {
            return repo.GetAllProducts();
        }
        public ProductModel GetTotalProducts() 
        {
            return repo.GetTotalProducts();
        }
        public void addProduct(ProductModel product)
        {
            repo.AddProduct(product);
        }
        public void updateProduct(ProductModel product)
        {
            repo.UpdateProduct(product);
        }
        public void deleteProduct(int productId)
        {
            repo.DeleteProduct(productId);
        }
    }
}
