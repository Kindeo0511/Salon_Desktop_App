using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class DeliveryAddStockForm : MaterialForm
    {
        private MainForm _mainForm;
        private int delivery_id;
        public DeliveryAddStockForm(MainForm mainForm , int id)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_items);
            _mainForm = mainForm;
            delivery_id = id;
            LoadDeliveryItems();
        }

        public void LoadDeliveryItems()
        {

            var _repo = new DeliveredItemRepository();
            var deliveryItemController = new DeliveryItemController(_repo);
            dgv_items.AutoGenerateColumns = false;
            dgv_items.DataSource = deliveryItemController.GetAllDeliveryItems(delivery_id);
            col_DeliveryItemId.DataPropertyName = "delivery_item_id";
            col_DeliveryId.DataPropertyName = "delivery_id";
            col_ProductId.DataPropertyName = "product_name";
            col_Quantity.DataPropertyName = "qty";
            col_UnitPrice.DataPropertyName = "unit_price";
            col_TotalPrice.DataPropertyName = "total_price";
            col_ExpiryDate.DataPropertyName = "expiry_date";
            col_notes.DataPropertyName = "notes";


        }
    }
}
