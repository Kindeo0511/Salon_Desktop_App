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
using System.Windows.Controls;
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
            LoadProducts();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            };
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
        private void LoadProducts(string key ="")
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            var products = productController.GetAllRetailProducts(key);

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
            ThemeManager.StyleDataGridView(dgv_retails);
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
                      
                      
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            int qty = form.SelectedQuantity;
                            mainForm.AddToCart(product, qty); // implement on main form
                        }

                    }
                }
            }
        }

        private void txt_search_box_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_box.Text.Length > 0)
            {
                LoadProducts(txt_search_box.Text.Trim());
            }
            else
            {
                LoadProducts();
            }
        }
    }
}
