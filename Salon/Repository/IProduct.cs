using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IProduct
    {
        IEnumerable<ProductModel> GetRetailProduct();
        RetailProduct GetRetailProductByName(string name);
        IEnumerable<ProductModel> GetAllProducts();
        Task<IEnumerable<ProductModel>> GetAllProductAsync();

        IEnumerable<ProductModel> GetAllProductToOrder();
  
        ProductModel GetTotalProducts();
        Task<ProductModel> GetTotalProductAsync();
        int AddProduct(ProductModel product);
        void UpdateProduct(ProductModel product);
        void DeleteProduct(int productId);
        void RestoreProduct(int productId);

        void PermanentDelete(int id);
        bool ProductExists(string name, int cat_id, int productId);
    }
}
