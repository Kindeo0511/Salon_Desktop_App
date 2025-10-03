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
        public InventoryBatchModel getByProductId(int product_id) 
        {
            return _repository.GetProductPriceByName(product_id);
        }

        public void AddBatchInventory(InventoryBatchModel inventoryBatchModel)
        {
            _repository.AddInventoryBatch(inventoryBatchModel);
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
