using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
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
    public partial class ProductQuantityForm : MaterialForm
    {
        private readonly MainForm mainForm;
        private readonly SearchRetailProductForm searchRetailProductForm;
        public int SelectedQuantity { get; private set; }
        public RetailProduct Product { get; }

        public ProductQuantityForm(MainForm mainForm, RetailProduct retailProduct)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.Product = retailProduct;
        }

        private void txt_qtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;


            var inventoryRepo = new InventoryRepository();
            var inventoryController = new InventoryController(inventoryRepo);


            int stock = inventoryController.GetProductQtyStck(Product.product_id, Product.product_size_id);
            int qty_requested = Convert.ToInt32(txt_qtn.Text);
            if (stock < qty_requested)
            {
                MessageBox.Show($"Insufficient stock. Available: {stock}, Requested: {qty_requested}",
                                "Stock Check",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            if (!int.TryParse(txt_qtn.Text.Trim(), out var q) || q <= 0)
            {
                MessageBox.Show("Enter a valid positive quantity.", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(txt_qtn.Text) > 99)
            {
                MessageBox.Show("Quantity cannot exceed 99.", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            SelectedQuantity = q;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void ProductQuantityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txt_qtn_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_qtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
