using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IProduct
    {
        IEnumerable<ProductModel> GetRetailProduct();
        IEnumerable<ProductModel> GetAllProducts();
        Task<IEnumerable<ProductModel>> GetAllProductAsync();
        ProductModel GetTotalProducts();
        Task<ProductModel> GetTotalProductAsync();
        void AddProduct(ProductModel product);
        void UpdateProduct(ProductModel product);
        void DeleteProduct(int productId);
        void RestoreProduct(int productId);

        void PermanentDelete(int id);
        bool ProductExists(string name, int cat_id, int productId);
    }
}
