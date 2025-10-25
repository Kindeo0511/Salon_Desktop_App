using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Salon.Controller
{
    public class InventoryBatchController
    {
        private readonly InventoryBatchRepository _repository;

        public InventoryBatchController(InventoryBatchRepository _repository)
        {
            this._repository = _repository;
        }

        public IEnumerable<InventoryBatchModel> GetAllBatchInventory()
        {
            return _repository.GetAllInventoryBatch();

        }

        public async Task<IEnumerable<InventoryBatchModel>> GetAllInventoryBatchAsync() 
        {
            return await _repository.GetAllInventoryBatchAsync();
        }
        public int? GetAvailableBatchId(int productId, int requiredVolume) 
        {
            return _repository.GetAvailableBatchId(productId, requiredVolume);
        }
        public void RestoreBatchProductUsage(int id , double volume) 
        {
             _repository.RestoreBatchProductUsage(id, volume);
        }
        public List<InventoryBatchModel> GetAvailableBatchesByProductId(int id) 
        {
            return _repository.GetAvailableBatches(id);
        }
        public void RecordBatchProductUsage(int id, double volume) 
        {
            _repository.RecordBatchUsage(id, volume);
        }
        public InventoryBatchModel getByProductId(int product_id) 
        {
            return _repository.GetProductPriceByName(product_id);
        }

        public void AddBatchInventory(InventoryBatchModel inventoryBatchModel)
        {
            _repository.AddInventoryBatch(inventoryBatchModel);
        }
        public void UpdateInventoryStatus() 
        {
            _repository.UpdateInventoryBatch();
        }

        //public void UpdateStatusToExpiringSoon()
        //{
        //    connection.Open();

        //    string sql = "UPDATE tbl_inventory_batches SET status = 'Expiring Soon' WHERE expiry_date >= NOW() AND expiry_date <= NOW() + INTERVAL 7 DAY";
        //    MySqlCommand cmd = new MySqlCommand(sql, connection);
        //    cmd.ExecuteNonQuery();
        //    connection.Close();

        //}
        //public void UpdateStatusToExpired()
        //{
        //    connection.Open();

        //    string sql = "UPDATE tbl_inventory_batches SET status = 'Expired' WHERE expiry_date < NOW()";
        //    MySqlCommand cmd = new MySqlCommand(sql, connection);
        //    cmd.ExecuteNonQuery();

        //    connection.Close();

        //}

    }
}
