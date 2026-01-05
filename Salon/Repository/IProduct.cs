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
        IEnumerable<ProductModel> GetRetailProduct(int page_size, int off_set);
        RetailProduct GetRetailProductByName(string name);
        IEnumerable<ProductModel> GetAllProducts();
        Task<IEnumerable<ProductModel>> GetAllProductAsync(int page_size, int off_set);

        IEnumerable<ProductModel> GetAllProductToOrder();
  
        ProductModel GetTotalProducts();
        Task<ProductModel> GetTotalProductAsync();
        int AddProduct(ProductModel product);
        int UpdateProduct(ProductModel product);
        int DeleteProduct(int productId);
        int RestoreProduct(int productId);

        int PermanentDelete(int id);
        bool ProductExists(string name, int productId);
    }
}
