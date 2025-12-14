using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class ItemRepository : I_Item
    {
        public int AddItem(ItemModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_item (item_id, name, price)
                VALUES (@item_id, @name, @price);
                SELECT LAST_INSERT_ID();";
                int newItemId = con.Query<int>(sql, model).Single();
                return newItemId;
            }
        }
    }
}
