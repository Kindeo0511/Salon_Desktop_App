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
        private bool _isSaving = false;
        private bool _isUpdating = false;

        private bool _isProductSizeSaving = false;
        private bool _isProductSizeUpdating = false;
        public ProductForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            this.mainForm = mainform;
  
        }
        public ProductForm(MainForm mainform, ProductModel productModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
            this.mainForm = mainform;
            this.productModel = productModel;
       

            if (productModel != null) 
            {
                txt_product_name.Text = productModel.product_name;
                _product_id = productModel.product_id;
                txt_brand.Text = productModel.brand;
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

            if (product_sizes != null && product_sizes.Any())
            {
                dgv_product_size.DataSource = null;
                dgv_product_size.AutoGenerateColumns = false;

                col_product_size_id.DataPropertyName = "product_size_id";
                col_product_id.DataPropertyName = "product_id";
                coL_product_name.DataPropertyName = "product_name";
                col_product_size_label.DataPropertyName = "size_label";
                col_product_content.DataPropertyName = "content";
                col_product_cost_price.DataPropertyName = "cost_price";
                dgv_product_size.DataSource = product_sizes;

           
        
            }
            else 
            {
         
        
            }
               
        }
        private bool IsValid()
        {
            int excludeId = productModel?.product_id ?? 0;
            bool validated = true;


          


            // REQUIRED FIELD
            string productName = txt_product_name.Text.Trim();
            string brandName = txt_brand.Text.Trim();
            string unitType = cmb_unit_type.Text.Trim();


            validated &= Validator.ValidateProductName(productName, txt_product_name, errorProvider1);
            validated &= Validator.ValidateBrandName(brandName, txt_brand, errorProvider1);
      
            validated &= Validator.ValidateUnitType(cmb_unit_type, errorProvider1);


            
            if (!Validator.IsProductExists(txt_product_name, errorProvider1, "Product already exits.", excludeId))
            {
                validated = false;
            }

           
        




            return validated;


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
                unit_type = cmb_unit_type.Text
              
            };
            int product_id = controller.addProduct(product);
            _product_id = product_id;

            return product_id;
        }
        private bool UpdateProduct() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            productModel.product_name = txt_product_name.Text;
            productModel.brand = txt_brand.Text;
            productModel.unit_type = cmb_unit_type.Text;
  
           return controller.updateProduct(productModel);

            
        }

        private void IsAccountExists()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var existingProduct = controller.GetProductIngredient(txt_product_name.Text.Trim(), txt_brand.Text.Trim(), cmb_unit_type.Text.Trim());

            if (existingProduct != null)
            {

                if (existingProduct.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Product exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreProduct(existingProduct.product_id))
                        {
                            mainForm.DeleteDeletedRecord(existingProduct.product_id);
                            MessageBox.Show("Product restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {


                    if (AddProduct() > 0)
                    {
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var productName = txt_product_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Products", $"Created product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateProduct())
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var productName = txt_product_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Products", $"Updated product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            IsAccountExists();

            await mainForm.RefreshProductAsync();
            await mainForm.RefreshTotalProduct();



        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            IsAccountExists();
            await mainForm.RefreshProductAsync();
  
            
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

            cmb_unit_type.SelectedIndex = -1;
            cmb_unit_type.Hint = "";
            txt_product_name.Text = string.Empty;
            txt_brand.Text = string.Empty;
      



        }

        // PRODUCT SIZE
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool AddProductSize(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);


           return controller.AddProductSize(ProductSizeModel(product_id));

        
        }
        private bool UpdateProductSize(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);


           return controller.UpdateProductSize(ProductSizeModel(product_id));

            
        }
        private void ProductSize()
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            var existingSize = controller.GetProductSize(_product_id, Convert.ToInt32(txt_content.Text));

            if (existingSize != null)
            {

                if (existingSize.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Product Size exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreProductSize(existingSize.product_size_id))
                        {
                            mainForm.DeleteDeletedRecord(existingSize.product_size_id);
                            MessageBox.Show("Product restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductSizeById(_product_id);
                        }



                    }
                }
            }

            else
            {
                if (_isProductSizeSaving)
                {


                    if (AddProductSize(_product_id))
                    {
                        MessageBox.Show("Product Size added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_size_label.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Product Size", $"Created product size '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                      

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isProductSizeUpdating)
                {
                    if (UpdateProductSize(_product_id))
                    {
                        MessageBox.Show("Product Size updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_size_label.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Product Size", $"Updated product size '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
               
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

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
        private async void btn_product_size_save_Click(object sender, EventArgs e)
        {
            _isProductSizeSaving = true;
            ProductSize();
            LoadProductSizeById(_product_id);
            await mainForm.RefreshProductAsync();
        }

        private async void dgv_product_size_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    btn_product_size_save.Enabled = false;

                }
                

            }
            else if(e.RowIndex >=0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_delete") 
            {
                var product_size_model = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;
                if (product_size_model != null) 
                {
                    var result = MessageBox.Show("Are you sure you want to delete this product size?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) 
                    {
                        var repo = new ProductSizeRepository();
                        var controller = new ProductSizeController(repo);
                  

                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Products Size", $"Deleted product size '{product_size_model.size_label}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        controller.SoftDeleteProductSize(product_size_model.product_size_id);
                        mainForm.InsertDeletedRecord(product_size_model.product_size_id, null, "Manage Product Size",product_size_model.product_name + "( "+ product_size_model.size_label +" )", UserSession.CurrentUser.first_Name, DateTime.Today);

                        MessageBox.Show("Product size deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductSizeById(_product_id);
                        await mainForm.RefreshProductAsync();
                        await mainForm.FilterdDeletedRecords();
                    }
                }
            }
        }

        private async void btn_product_size_update_Click(object sender, EventArgs e)
        {
            _isProductSizeUpdating = true;
            ProductSize();
            LoadProductSizeById(_product_id);
            await mainForm.RefreshProductAsync();
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
