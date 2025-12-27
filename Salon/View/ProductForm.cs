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
using MaterialSkin.Controls;
using Salon.Repository;
using Salon.Controller;
using Salon.Models;
namespace Salon.View
{
    public partial class ProductForm : MaterialForm
    {
        private int _product_id;
        private MainForm mainForm;
        private ProductModel productModel;
        public ProductForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainform;
            LoadCategory();
        }
        public ProductForm(MainForm mainform, ProductModel productModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainform;
            this.productModel = productModel;
            LoadCategory();

            if (productModel != null) 
            {
                txt_product_name.Text = productModel.product_name;
                _product_id = productModel.product_id;
                txt_brand.Text = productModel.brand;
                cmb_category.SelectedValue = productModel.category_id;
                cmb_unit_type.Text = productModel.unit_type;

                btn_save.Visible = false;
                btn_update.Visible = true;

                // PRODUCT SIZE
                LoadProductSizeById(_product_id);

    

            }
        }
        private void LoadProductSizeById(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            var product_sizes = controller.GetProductSizeById(product_id);


            dgv_product_size.DataSource = null;
            dgv_product_size.AutoGenerateColumns = false;

            col_product_size_id.DataPropertyName = "product_size_id";
            col_product_id.DataPropertyName = "product_id";
            col_product_size_label.DataPropertyName = "size_label";
            col_product_content.DataPropertyName = "content";
            col_product_cost_price.DataPropertyName = "cost_price";
            dgv_product_size.DataSource = product_sizes;
        }
        private bool IsValid()
        {
            int excludeId = productModel?.product_id ?? 0;
            int cat_id = Convert.ToInt32(cmb_category.SelectedValue);
            bool validated = true;


          


            // REQUIRED FIELD
            string productName = txt_product_name.Text.Trim();
            string brandName = txt_brand.Text.Trim();
            string unitType = cmb_unit_type.Text.Trim();


            validated &= Validator.ValidateProductName(productName, txt_product_name, errorProvider1);
            validated &= Validator.ValidateBrandName(brandName, txt_brand, errorProvider1);
            validated &= Validator.ValidateProductCategory(cmb_category, errorProvider1);
            validated &= Validator.ValidateUnitType(cmb_unit_type, errorProvider1);


            
            if (!Validator.IsProductExists(txt_product_name, errorProvider1, "Product already exits.", cat_id, excludeId))
            {
                validated = false;
            }

           
        




            return validated;


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

        private int AddProduct() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var product = new ProductModel
            {
                product_name = txt_product_name.Text,
                product_type = "Ingredient",
                brand = txt_brand.Text,
                category_id = (int)cmb_category.SelectedValue,
                unit_type = cmb_unit_type.Text,
              
            };
            int product_id = controller.addProduct(product);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return product_id;
        }
        private void UpdateProduct() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            productModel.product_name = txt_product_name.Text;
            productModel.brand = txt_brand.Text;
            productModel.category_id = (int)cmb_category.SelectedValue;
            productModel.unit_type = cmb_unit_type.Text;
  
            controller.updateProduct(productModel);
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            _product_id = AddProduct();
            var productName = txt_product_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Products", $"Created product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            await mainForm.RefreshProductAsync();
            await mainForm.RefreshTotalProduct();
            ClearProductDetails();

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            UpdateProduct();
            var productName = txt_product_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Products", $"Updated product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await mainForm.RefreshProductAsync();
            ClearProductDetails();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_product_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, space, ampersand, hyphen, apostrophe, parentheses
            if (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '&' || c == '-' || c == '\'' || c == '(' || c == ')')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, space, ampersand, hyphen, apostrophe, parentheses
            if (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '&' || c == '-' || c == '\'' || c == '(' || c == ')')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_unit_volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, but not as the first character
            if (c == '.' && txt != null)
            {
                if (!txt.Text.Contains(".") && txt.SelectionStart > 0)
                    return;

                e.Handled = true;
                return;
            }

            // Block everything else
            e.Handled = true;
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClearProductDetails() 
        {
            cmb_category.SelectedIndex = -1;
            cmb_category.Hint = "";
            cmb_unit_type.SelectedIndex = -1;
            cmb_unit_type.Hint = "";
            txt_product_name.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_category.Hint = "Select Category";
            cmb_category.Hint = "Select Unit Type";



        }

        // PRODUCT SIZE
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddProductSize(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);


            controller.AddProductSize(ProductSizeModel(product_id));

            MessageBox.Show("Product size added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateProductSize(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);


            controller.UpdateProductSize(ProductSizeModel(product_id));

            MessageBox.Show("Product size updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private ProductSizeModel ProductSizeModel(int product_id) 
        {
            string size_label = txt_size_label.Text;
            int content = Convert.ToInt32(txt_content.Text);
            decimal cost = Convert.ToDecimal(txt_cost_price.Text);
            var model = new ProductSizeModel 
            {
                product_id = product_id,
                size_label = size_label,
                content = content,
                cost_price = cost,
            };

            return model;
        }
        private void btn_product_size_save_Click(object sender, EventArgs e)
        {
            AddProductSize(_product_id);
            ClearProductSize();
            LoadProductSizeById(_product_id);
        }

        private void dgv_product_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_update") 
            {
                var product_size_model = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;

                if (product_size_model != null) 
                {

                    txt_size_label.Text = product_size_model.size_label;
                    txt_content.Text = product_size_model.content.ToString();
                    txt_cost_price.Text = product_size_model.cost_price.ToString("C2");
                    btn_product_size_update.Enabled = true;

                }
                

            }
        }

        private void btn_product_size_update_Click(object sender, EventArgs e)
        {
            UpdateProductSize(_product_id);
            ClearProductSize();
            LoadProductSizeById(_product_id);
        }


        private void ClearProductSize() 
        {
            txt_size_label.Text = string.Empty;
            txt_content.Text = string.Empty;
            txt_cost_price.Text = string.Empty;
        }
        // END OF PRODUCTS


    }
}
