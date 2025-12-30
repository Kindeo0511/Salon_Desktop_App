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

        public ProductModel GetProductIngredient(string name, string brand, string unit_type) 
        {
            return repo.GetProductIngredient(name, brand, unit_type);
        }
        public ProductModel GetProductRetail(string name, string brand, string unit_type)
        {
            return repo.GetProductRetail(name, brand, unit_type);
        }

        public IEnumerable<ProductModel> GetProductToOrder() 
        {
            return repo.GetAllProductToOrder();
        }
        public int addProduct(ProductModel product)
        {
           return repo.AddProduct(product);
        }
        public bool updateProduct(ProductModel product)
        {
            return repo.UpdateProduct(product) > 0;
        }
        public bool deleteProduct(int productId)
        {
           return repo.DeleteProduct(productId) > 0;
        }
        public bool RestoreProduct(int productId)
        {
           return repo.RestoreProduct(productId) > 0;
        }

        public bool PermanentDeleteProduct(int id) 
        {
           return repo.PermanentDelete(id) > 0;
        }
        public bool CheckProductExists(string name, int id = 0) 
        {
            return repo.ProductExists(name, id);
        }

        public bool IsProductBeingUsed(int id) 
        {
            return repo.ProductIsUsed(id);
        }
        public bool IsProductRetailBeingUsed(int id) 
        {
            return repo.ProductRetailIsUsed(id);
        }
    }
}
