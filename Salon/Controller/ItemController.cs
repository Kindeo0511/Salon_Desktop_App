using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ItemController
    {
        private readonly ItemRepository repo;
        public ItemController(ItemRepository repo) 
        {
            this.repo = repo;
        }

        public int AddItem(ItemModel model) 
        {
            return repo.AddItem(model);
        }
    }
}
