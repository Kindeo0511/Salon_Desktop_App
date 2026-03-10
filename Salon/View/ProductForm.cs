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
using static ExCSS.RadialGradient;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
namespace Salon.View
{
    public partial class ProductForm : MaterialForm
    {
        private int _product_id = 0;
        private string ProductName;
        private MainForm mainForm;
        private ProductModel productModel;
        private bool _isSaving = false;
        private bool _isUpdating = false;
        private bool _isDelete = false;
        private bool _isProductSizeSaving = false;
        private bool _isProductSizeUpdating = false;
        public event EventHandler RefreshData;

        private bool productInfoCreated = false;
        private bool allowTabChange = false;

        private BindingList<ProductSizeModel> sizeList = new BindingList<ProductSizeModel>();

        public ProductForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_product_size);
            _isSaving = true;
            this.mainForm = mainform;


        }
        public ProductForm(MainForm mainform, ProductModel productModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_product_size);
            _isUpdating = true;
            this.mainForm = mainform;
            this.productModel = productModel;


            if (productModel != null)
            {
                txt_product_name.Text = productModel.product_name;
                _product_id = productModel.product_id;
                txt_brand.Text = productModel.brand;
                cmb_unit_type.Text = productModel.unit_type;
                ProductName = productModel.product_name;

                chk_ingredient.Checked = (productModel.is_ingredient == 1);
                chk_retail.Checked = (productModel.is_retail == 1);



                btn_save.Visible = false;
                btn_update.Visible = true;

                allowTabChange = true;


                // PRODUCT SIZE
                LoadProductSizeById(_product_id);



            }
        }
        public void LoadProductSizeById(int product_id)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            var product_sizes = controller.GetProductSizeById(product_id);

            if (product_sizes != null)
            {

                dgv_product_size.AutoGenerateColumns = false;

                col_product_size_id.DataPropertyName = "product_size_id";
                col_product_id.DataPropertyName = "product_id";
                coL_product_name.DataPropertyName = "product_name";
                col_product_size_label.DataPropertyName = "size_label";
                col_product_content.DataPropertyName = "content";
                col_product_cost_price.DataPropertyName = "cost_price";


                sizeList = new BindingList<ProductSizeModel>(product_sizes.ToList());
                dgv_product_size.DataSource = sizeList;



            }


        }
        private bool HasProductChanges()
        {
            return txt_product_name.Text != productModel.product_name
               || txt_brand.Text != productModel.brand
               || cmb_unit_type.Text != productModel.unit_type
               || chk_ingredient.Checked
               || chk_retail.Checked
               ;

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
            int deleted_product_id = ExistingProductButDeleted();

            if (deleted_product_id > 0)
            {
                var result = MessageBox.Show("This Product exists but is deleted. Do you want to restore it?",
                                  "Restore Product",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RestoreProduct(deleted_product_id);
                }
                validated = false;
            }
            else if (!Validator.IsProductExists(txt_product_name, errorProvider1, "Product already exits.", excludeId))
            {
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_product_name, "");
            }

            if (!chk_ingredient.Checked && !chk_retail.Checked)
            {
                errorProvider1.SetError(chk_retail, "Please select a product type.");
                errorProvider1.SetError(chk_ingredient, "Please select a product type");
            }
            else
            {
                errorProvider1.SetError(chk_retail, "");
                errorProvider1.SetError(chk_ingredient, "");
            }







            return validated;


        }
        private bool IsProductSizeListValid(string name)
        {
            // ✅ Check if sizeList has at least one item
            if (sizeList == null || sizeList.Count == 0)
            {
                MessageBox.Show($"Please add at least one product size before {name}.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private int AddProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var product = new ProductModel
            {
                product_name = txt_product_name.Text,
                is_ingredient = chk_ingredient.Checked ? 1 : 0,
                is_retail = chk_retail.Checked ? 1 : 0,
                brand = txt_brand.Text,
                unit_type = cmb_unit_type.Text

            };
            int product_id = controller.addProduct(product);
            _product_id = product_id;
            ProductName = txt_product_name.Text;

            return product_id;
        }
        private bool UpdateProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            productModel.product_name = txt_product_name.Text;
            productModel.brand = txt_brand.Text;
            productModel.unit_type = cmb_unit_type.Text;
            productModel.is_ingredient = chk_ingredient.Checked ? 1 : 0;
            productModel.is_retail = chk_retail.Checked ? 1 : 0;

            return controller.updateProduct(productModel);


        }

        private int ExistingProductButDeleted()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            return controller.GetProductIngredient(txt_product_name.Text.Trim(), txt_brand.Text.Trim(), cmb_unit_type.Text.Trim());


        }
        private void RestoreProduct(int product_id)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            if (controller.RestoreProduct(product_id))
            {
                mainForm.DeleteDeletedRecord(product_id);
                MessageBox.Show("Product restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void IsAccountExists()
        {

            if (_isSaving)
            {


                if (AddProduct() > 0)
                {
                    RefreshData?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var productName = txt_product_name.Text;
                    Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Products", $"Created product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");


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
                    RefreshData?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var productName = txt_product_name.Text;
                    Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Products", $"Updated product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                }
                else
                {
                    MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }



        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            IsAccountExists();

            //await mainForm.RefreshProductAsync(1,25);
            //await mainForm.RefreshTotalProduct();



        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            if (!HasProductChanges())
            {
                MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IsAccountExists();
            await mainForm.RefreshProductAsync(1, 25);
            await mainForm.RefreshTotalProduct();


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
        //private bool AddProductSize(int product_id) 
        //{
        //    var repo = new ProductSizeRepository();
        //    var controller = new ProductSizeController(repo);


        //   return controller.AddProductSize(ProductSizeModel(product_id));


        //}




        private bool IsProductSizeValid()
        {

            bool validated = true;
            int.TryParse(lbl_size_id.Text.Trim(), out int product_size_id);
            string size_label = txt_size.Text.Trim();
            int.TryParse(txt_size_content.Text.Trim(), out int content);
            decimal.TryParse(txt_size_price.Text.Trim(), out decimal cost_price);
            decimal.TryParse(txt_selling_price.Text.Trim(), out decimal selling_price);

            // Size label required
            if (string.IsNullOrWhiteSpace(txt_size.Text))
            {
                errorProvider1.SetError(txt_size, "Size label is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_size, "");
            }

            // Content must be numeric and > 0
            int contentValue = 0;
            if (string.IsNullOrWhiteSpace(txt_size_content.Text))
            {
                errorProvider1.SetError(txt_size_content, "Content is required.");
                validated = false;
            }
            else if (!int.TryParse(txt_size_content.Text, out contentValue) || contentValue <= 0)
            {
                errorProvider1.SetError(txt_size_content, "Content must be a positive number.");
                validated = false;
            }
            else errorProvider1.SetError(txt_size_content, "");


            // Cost must be decimal and > 0
            decimal cost = 0;
            decimal price = 0;
            if (string.IsNullOrWhiteSpace(txt_size_price.Text))
            {
                errorProvider1.SetError(txt_size_price, "Cost price is required.");
                validated = false;
            }
            else if (!decimal.TryParse(txt_size_price.Text, out cost) || cost <= 0)
            {
                errorProvider1.SetError(txt_size_price, "Cost price must be a positive amount.");
                validated = false;
            }
            else errorProvider1.SetError(txt_size_price, "");


            if (chk_retail.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_selling_price.Text))
                {
                    errorProvider1.SetError(txt_selling_price, "Selling price is required.");
                    validated = false;
                }
                else if (!decimal.TryParse(txt_selling_price.Text, out price) || price <= 0)
                {
                    errorProvider1.SetError(txt_selling_price, "Selling price must be a positive amount.");
                    validated = false;
                }
                else if (cost >= price) // ✅ Selling price must be greater than cost price
                {
                    errorProvider1.SetError(txt_selling_price, "Selling price must be greater than cost price.");
                    validated = false;
                }
                else
                {
                    errorProvider1.SetError(txt_selling_price, ""); // ✅ Clear error if valid
                }
            }
            else
            {
                errorProvider1.SetError(txt_selling_price, ""); // ✅ Clear error if retail is unchecked
                txt_selling_price.Text = "0";                   // ✅ Reset selling price if not retail
            }



            int product_id = _product_id;

            int deleted_product_size_id = 0;

            if (_isProductSizeSaving)
            {
                if (product_size_id == 0)
                {
                    deleted_product_size_id = ExistingProductSizeButDeleted();
                }
            }
            if (deleted_product_size_id > 0)
            {
                var result = MessageBox.Show("This Product Size exists but is deleted. Do you want to restore it?",
                                  "Deleted Product Size",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RestoreProductSize(deleted_product_size_id);
                }

                validated = false;
            }
            else if (ProductSizeExists(product_size_id, product_id, contentValue))
            {
                errorProvider1.SetError(txt_size, "Product size already exists.");
                validated = false;

            }



            return validated;

        }
        private bool IsDuplicateConsumption(ProductSizeModel newItem, int excludeId = 0)
        {
            bool isDuplicate = sizeList.Any(s =>
                s.product_id == newItem.product_id &&                    // ✅ same product
                s.product_size_id != excludeId &&
                s.is_deleted == 0);                      // ✅ exclude self when updating

            if (isDuplicate)
            {
                MessageBox.Show($"Size '{newItem.size_label}' already exists in the list.",
                                "Duplicate Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool ProductSizeExists(int product_size_id, int product_id, int content)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            bool exists = controller.Exists(product_size_id, product_id, content);
            // bool exists = controller.GetProductSize(product_id)
            //.Any(ps => ps.product_id == product_id
            //        && ps.size_label == txt_size_label.Text.Trim()
            //        && ps.content == content
            //        && ps.is_deleted == 0
            //        && ps.product_size_id != product_size_id);

            return exists;
        }
        private int ExistingProductSizeButDeleted()
        {
            // ✅ TryParse safely returns 0 if empty or invalid instead of throwing
            int.TryParse(txt_size_content.Text.Trim(), out int content);

            if (content <= 0) return 0; // ✅ No point querying if content is invalid

            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            return controller.GetProductSize(_product_id, content);
        }
        private void RestoreProductSize(int product_size_id)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            if (controller.RestoreProductSize(product_size_id))
            {
                mainForm.DeleteDeletedRecord(product_size_id);
                MessageBox.Show("Product size restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        private bool HasProductSizeChanges() 
        {
            return txt_size_label.Text != "" 
                || txt_content.Text != "" 
                || txt_cost_price.Text != "";
        }
        private async void btn_product_size_save_Click(object sender, EventArgs e)
        {
            //    if (!IsProductSizeValid()) return;



            //    _isProductSizeSaving = true;
            //    ProductSize();
            //    LoadProductSizeById(_product_id);
            //await mainForm.RefreshProductAsync();
        }

       

    


        private void ClearProductSize() 
        {
            txt_size.Text = string.Empty;
            txt_size_content.Text = string.Empty;
            txt_size_price.Text = string.Empty;
            txt_selling_price.Text = string.Empty;
        }

      

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ThemeManager.StyleDataGridView(dgv_product_size);
            cmb_unit_type.MouseWheel += Helper.ComboBox_MouseWheel;

            dgv_product_size.AutoGenerateColumns = false;
            col_product_size_id.DataPropertyName = "product_size_id";
            col_product_id.DataPropertyName = "product_id";
            coL_product_name.DataPropertyName = "product_name";
            col_product_size_label.DataPropertyName = "size_label";
            col_product_content.DataPropertyName = "content";
            col_product_cost_price.DataPropertyName = "cost_price";
            col_product_selling_price.DataPropertyName = "selling_price";
            dgv_product_size.DataSource = sizeList;
        }

       


        private async void btn_save_Click_1(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (!IsProductSizeListValid("saving")) return;

            SaveProductSize(Product_Model(), sizeList);
            this.Close();

            await mainForm.RefreshProductAsync(1, 25);
            await mainForm.RefreshTotalProduct();
        }
        private ProductModel Product_Model()
        {
            int product_id = _product_id;
            string product_name = txt_product_name.Text.Trim();
            string unit_type = cmb_unit_type.Text;
            string brand = txt_brand.Text.Trim();
            int is_ingredient = chk_ingredient.Checked ? 1 : 0; // ✅ bool to int
            int is_retail = chk_retail.Checked ? 1 : 0;
            var model = new ProductModel
            {
                product_id = product_id,
                product_name = product_name,
                unit_type = unit_type,
                brand = brand,
                is_ingredient = is_ingredient,
                is_retail = is_retail,
                
   
            };


            return model;

        }
        private ProductSizeModel SizeModel() 
        {
            int product_id = _product_id;
            int.TryParse(lbl_size_id.Text.Trim(), out int product_size_id);
            string size_label = txt_size.Text.Trim();
            int.TryParse(txt_size_content.Text.Trim(), out int content);
            decimal.TryParse(txt_size_price.Text.Trim(), out decimal cost_price);
            decimal.TryParse(txt_selling_price.Text.Trim(), out decimal selling_price);

            var size_model = new ProductSizeModel
            {
                product_id = product_id,
                product_size_id = product_size_id,
                size_label = size_label,
                content = content,
                cost_price = cost_price,
                selling_price = selling_price
            };


            return size_model;
     
        }
        private void SaveProductSize(ProductModel model, IEnumerable<ProductSizeModel> size) 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            bool success = controller.ProductSaveWithSize(model, size);


            if (success)
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProductSize(ProductModel model, IEnumerable<ProductSizeModel> size)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            bool success = controller.ProductSaveWithSize(model, size);


            if (success)
            {
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteProductSize(ProductModel model, IEnumerable<ProductSizeModel> sizes)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            var size = sizes.FirstOrDefault();
            if (size == null) return;

            bool success = controller.ProductSaveWithSize(model, sizes);


            if (success)
            {
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name,
                                  "Manage Products Size",
                                  $"Deleted product size '{size.size_label}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                mainForm.InsertDeletedRecord(size.product_size_id, null,
                                              "Manage Product Size",
                                              size.product_name + "( " + size.size_label + " )",
                                              UserSession.CurrentUser.first_Name, DateTime.Today);
            }
            else
            {
                MessageBox.Show("Failed to delete Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_size_Click_1(object sender, EventArgs e)
        {
            if (!IsProductSizeValid()) return;
            //if (_product_id == 0)
            //{
            //    MessageBox.Show(
            //        "Please create a product first before adding a product size.",
            //        "Action Required",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );
            //    return;
            //}

            //using (var form = new ProductSizeForm(mainForm, this, _product_id, ProductName))
            //{
            //    form.ShowDialog();
            //}
        }

        private async void btn_update_Click_1(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (!IsProductSizeListValid("updating")) return;

            if (_isUpdating)
            {
                UpdateProductSize(Product_Model(), sizeList);
            }
            else if (_isDelete)
            {


                DeleteProductSize(Product_Model(), sizeList);



                LoadProductSizeById(_product_id);
                await mainForm.FilterdDeletedRecords(1, 25);
            }


            this.Close();
            //if (!IsValid()) return;

            //if (!HasProductChanges())
            //{
            //    MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //IsAccountExists();
            //await mainForm.RefreshProductAsync(1, 25);
            //await mainForm.RefreshTotalProduct();

            //this.Close();
        }

        private void btn_add_size_Click(object sender, EventArgs e)
        {
            _isProductSizeSaving = true;
            if (!IsProductSizeValid()) return;
  
            sizeList.Add(SizeModel());
           

            ClearProductSize();
        }

        private void chk_retail_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_retail.Checked)
            {
                txt_selling_price.Enabled = true;
            }
            else 
            {
                txt_selling_price.Enabled = false;
            }
        }

        private async void dgv_product_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_update")
            {
                var product_size_model = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;

                if (product_size_model != null)
                {
                    lbl_size_id.Text = product_size_model.product_size_id.ToString();
                    txt_size.Text = product_size_model.size_label;
                    txt_size_content.Text = product_size_model.content.ToString();
                    txt_size_price.Text = product_size_model.cost_price.ToString();
                    txt_selling_price.Text = product_size_model.selling_price.ToString();
         


                    if (product_size_model.product_size_id != 0)
                    {
                        btn_add_size.Visible = false;
                        btn_update_size.Visible = true;
                    }
                    else
                    {
                        btn_add_size.Visible = true;
                        btn_update_size.Visible = false;
                    }

                }


            }
            else if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_delete")
            {


                var product_size_model = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;
                if (product_size_model != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this product size?",
                                                  "Delete Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // ✅ Remove from BindingList FIRST so it's excluded from the save
                        sizeList.Remove(product_size_model);
                        _isDelete = true;
                        _isUpdating = false;
                       
                    }
                }

                //var product_size_model = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;
                //if (product_size_model != null)
                //{
                //    var result = MessageBox.Show("Are you sure you want to delete this product size?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //    if (result == DialogResult.Yes)
                //    {
                //        var repo = new ProductSizeRepository();
                //        var controller = new ProductSizeController(repo);

                //        DeleteProductSize(Product_Model(), sizeList);
                //        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Products Size", $"Deleted product size '{product_size_model.size_label}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                //        mainForm.InsertDeletedRecord(product_size_model.product_size_id, null, "Manage Product Size", product_size_model.product_name + "( " + product_size_model.size_label + " )", UserSession.CurrentUser.first_Name, DateTime.Today);

                //        //MessageBox.Show("Product size deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        LoadProductSizeById(_product_id);
                //        //await mainForm.RefreshProductAsync();
                //        await mainForm.FilterdDeletedRecords(1, 25);
                //    }
                //}
            }
        }

        private void btn_update_size_Click(object sender, EventArgs e)
        {
            _isProductSizeUpdating = true;
            if (!IsProductSizeValid()) return;

            var updatedSize = SizeModel();


            var existing = sizeList.FirstOrDefault(s => s.product_size_id == updatedSize.product_size_id);

            if (existing != null)
            {
                
                existing.size_label = updatedSize.size_label;
                existing.content = updatedSize.content;
                existing.cost_price = updatedSize.cost_price;
                existing.selling_price = updatedSize.selling_price;

            
            }

            ClearProductSize();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // END OF PRODUCTS


    }
}
