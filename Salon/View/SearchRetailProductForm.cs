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
    public partial class SearchRetailProductForm : MaterialForm
    {
        private readonly MainForm mainForm;
        public SearchRetailProductForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
        }
        private void LoadProducts()
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            var products = productController.GetAllRetailProducts();

            dgv_retails.DataSource = null;
            dgv_retails.AutoGenerateColumns = false;


            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_product_size_id.DataPropertyName = "product_size_id";
            col_size.DataPropertyName = "size_label";
            col_price.DataPropertyName = "selling_price";
            dgv_retails.DataSource = products;
        }

        private void SearchRetailProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgv_retails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgv_retails.Columns[e.ColumnIndex].Name == "btn_add_to_cart") 
            {
                var product = dgv_retails.Rows[e.RowIndex].DataBoundItem as RetailProduct;

                if (product != null) 
                {
                    using (var form = new ProductQuantityForm(mainForm, product)) 
                    {
                        form.ShowDialog();

                        int qty = form.SelectedQuantity;
                        mainForm.AddToCart(product, qty); // implement on main form

                    }
                }
            }
        }
    }
}
