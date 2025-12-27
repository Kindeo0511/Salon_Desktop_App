using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Card
{
    public partial class CheckOutCard : UserControl
    {
       
        public string ItemName => lbl_service_name.Text;
        public decimal _price;
        public decimal Price => _price;
        public int _qty;
        public int Quantity => _qty;
        public int Duration => 0;
        public decimal TotalPrice => _price * _qty;
        public CheckOutCard()
        {
            InitializeComponent();
        }
        public void SetItemDetails(string itemName, int qty, decimal price)
        {

            lbl_service_name.Text = itemName;
            lbl_price.Text = price.ToString("C2");
            lbl_qty.Text = qty.ToString() + "x" ;


        }
        // ServiceCard
        public void LoadCheckout(ServiceCart cart)
        {
            lbl_service_name.Text = cart.ItemName;
            lbl_price.Text = cart.TotalPrice.ToString("C");
            _price = cart.TotalPrice;
            lbl_qty.Text = cart.Quantity.ToString();
            _qty = cart.Quantity;
        }

        private void lbl_qty_Click(object sender, EventArgs e)
        {

        }
    }
}
