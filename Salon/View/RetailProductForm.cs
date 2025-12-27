using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
namespace Salon.View
{
    public partial class RetailProductForm : MaterialForm
    {
        private MainForm mainForm;
        private readonly ProductModel model;
        private int _product_id;
        public RetailProductForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public RetailProductForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            LoadCategory();
        }
        public RetailProductForm(MainForm main, ProductModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            this.model = model;
            LoadCategory();
            // PRODUCT DETAILS

            if (model != null) 
            {
                _product_id = this.model.product_id;
                txt_product_name.Text = this.model.product_name;
                txt_brand.Text = this.model.brand;
                cmb_category.SelectedValue = model.category_id;
                cmb_unit_type.Text = this.model.unit_type;

                btn_save.Visible = false;
                btn_update.Visible = true;
            }
           

            // PRODUCT SIZE

  

            LoadProductSizeById(_product_id);
        }
        private void LoadCategory()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var categories = controller.getAllCategoryByProduct();
            cmb_category.DisplayMember = "categoryName";
            cmb_category.ValueMember = "category_id";
            cmb_category.DataSource = categories;
            cmb_category.SelectedIndex = -1;
        }

        private int SaveProductDetail() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);


            int id = controller.addProduct(ProductModel());

            return id;
        }
        private ProductModel ProductModel() 
        {
            var product_Model = new ProductModel 
            {
                product_name = txt_product_name.Text,
                product_type = "Retail",
                brand = txt_brand.Text,
                category_id = Convert.ToInt32(cmb_category.SelectedValue),
                unit_type = cmb_unit_type.Text

            };

            return product_Model;
        }
       
        private void ClearProductDetail() 
        {
            cmb_category.SelectedValue = -1;
            cmb_category.Hint = "";
            txt_product_name.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_unit_type.Text = string.Empty;
            cmb_category.Hint = "Select Category";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
           _product_id =  SaveProductDetail();
            ClearProductDetail();

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // PRODUCT SIZE RETAIL
        private void LoadProductSizeById(int product_id)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            var product_sizes = controller.GetProductSizeById(product_id);

            if (product_sizes != null && product_sizes.Any())
            {
                dgv_product_size.DataSource = null;
                dgv_product_size.AutoGenerateColumns = false;

                col_product_size_id.DataPropertyName = "product_size_id";
                col_product_id.DataPropertyName = "product_id";
                col_product_size_label.DataPropertyName = "size_label";
                col_product_content.DataPropertyName = "content";
                col_product_sale_price.DataPropertyName = "selling_price";
                col_product_cost_price.DataPropertyName = "cost_price";
                dgv_product_size.DataSource = product_sizes;

                
            }
           
          
        }
        private ProductSizeModel ProductSizeModel()
        {
            var product_Model = new ProductSizeModel
            {
                product_id = _product_id,
                size_label = txt_size_label.Text,
                content = Convert.ToInt32(txt_content.Text),
                selling_price = Convert.ToDecimal(txt_selling_price.Text),
                cost_price = Convert.ToDecimal(txt_cost_price.Text)
            };

            return product_Model;
        }

        private void SaveProductSize()
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            controller.AddProductSize(ProductSizeModel());
        }
        private void ClearProductSize()
        {
            txt_size_label.Text = string.Empty;
            txt_content.Text = string.Empty;
            txt_selling_price.Text = string.Empty;
            txt_cost_price.Text = string.Empty;

        }

        private void UpdateProductSize() 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            controller.UpdateProductSize(ProductSizeModel());
        }
        private void btn_product_size_save_Click(object sender, EventArgs e)
        {
            SaveProductSize();
            ClearProductSize();
            LoadProductSizeById(_product_id);
            MessageBox.Show("Product size added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_product_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_update") 
            {
                var product_size = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;

                txt_size_label.Text = product_size.size_label;
                txt_content.Text = product_size.content.ToString();
                txt_selling_price.Text = product_size.selling_price.ToString();
                txt_cost_price.Text = product_size.cost_price.ToString();

                btn_product_size_update.Enabled = true;
            }
        }

        private void btn_product_size_update_Click(object sender, EventArgs e)
        {
           
            UpdateProductSize();
            LoadProductSizeById(_product_id);
            ClearProductSize();
            MessageBox.Show("Product size updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
