using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public IEnumerable<ProductModel> GetRetailProduct()
        {
            return repo.GetRetailProduct();
        }
        public RetailProduct GetRetailProductByName(string name) 
        {
            return repo.GetRetailProductByName(name);
        }
        public RetailProduct GetRetailProductByIdAndSize(int productId, int productSizeId) 
        {
            return repo.GetRetailProductByIdAndSize(productId, productSizeId);
        }
        public IEnumerable<ProductModel> getAllProduct()
        {
            return repo.GetAllProducts();
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductAsync() 
        {
            return await repo.GetAllProductAsync();
        }
        public ProductModel GetTotalProducts() 
        {
            return repo.GetTotalProducts();
        }

        public async Task<ProductModel> GetTotalProductAsync() 
        {
            return await repo.GetTotalProductAsync();
        }

        public IEnumerable<ProductModel> GetProductToOrder() 
        {
            return repo.GetAllProductToOrder();
        }
        public int addProduct(ProductModel product)
        {
           return repo.AddProduct(product);
        }
        public void updateProduct(ProductModel product)
        {
            repo.UpdateProduct(product);
        }
        public void deleteProduct(int productId)
        {
            repo.DeleteProduct(productId);
        }
        public void RestoreProduct(int productId)
        {
            repo.RestoreProduct(productId);
        }

        public void PermanentDeleteProduct(int id) 
        {
            repo.PermanentDelete(id);
        }
        public bool CheckProductExists(string name, int cat_id, int id = 0) 
        {
            return repo.ProductExists(name, cat_id, id);
        }
    }
}
