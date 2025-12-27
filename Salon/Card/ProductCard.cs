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
    public partial class ProductCard : UserControl
    {
        public int SelectedProductID => (int)cmb_product.SelectedValue;
        public string ItemName => cmb_product.Text;
        public decimal _price;
        public decimal Price => _price;
        public int _qty;
        public int Quantity => _qty;

        public int Duration => 0;
 
  

        public event EventHandler OnRemove;
        public ProductCard()
        {
            InitializeComponent();
            btn_remove.Click += (s, e) => OnRemove?.Invoke(this, EventArgs.Empty);
        }

        public void SetProducts(List<ProductModel> services)
        {

            cmb_product.DataSource = services;
            cmb_product.DisplayMember = "product_name";
            cmb_product.ValueMember = "product_id";
            cmb_product.SelectedIndex = -1;
            cmb_product.SelectedIndexChanged += cmb_product_SelectedIndexChanged;

 
            lbl_price.Text = "0.00";
         

        }

        // ProductCard.cs
        public void LoadSelectedProduct(ServiceCart saved)
        {
            cmb_product.SelectedValue = saved.ProductId;
            _price = saved.Price;
            _qty = saved.Quantity;
            lbl_price.Text = _price.ToString("C");
            txt_qty.Text = _qty.ToString();
        }


        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_qty.Text))
            {
                txt_qty.Text = "1"; 
            }

            _qty = Convert.ToInt32(txt_qty.Text);

            var selected_product = cmb_product.SelectedItem as ProductModel;
            if (selected_product == null) return;


            lbl_price.Text = selected_product.selling_price.HasValue
            ? selected_product.selling_price.Value.ToString("C")
            : string.Empty; // or "N/A"
            _price = selected_product.selling_price ?? 0;
           
         
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            int qtn = txt_qty.Text != string.Empty ? int.Parse(txt_qty.Text) : 1;
            _qty = qtn;
        }
    }
}
