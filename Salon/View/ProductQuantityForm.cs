using MaterialSkin.Controls;
using Salon.Models;
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

            if (!int.TryParse(txt_qtn.Text.Trim(), out var q) || q <= 0)
            {
                MessageBox.Show("Enter a valid positive quantity.", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedQuantity = q;
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
