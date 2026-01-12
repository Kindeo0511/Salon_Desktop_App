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

        private bool _isSaving = false;
        private bool _isUpdating = false;

        private bool _isProductSizeSaving = false;
        private bool _isProductSizeUpdating = false;

        public event EventHandler RefreshData;
        public RetailProductForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_product_size);
        }
        public RetailProductForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_product_size);
            _isSaving = true;
            this.mainForm = main;
        
        }
        public RetailProductForm(MainForm main, ProductModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
            this.mainForm = main;
            this.model = model;
          
            // PRODUCT DETAILS

            if (model != null) 
            {
                _product_id = this.model.product_id;
                txt_product_name.Text = this.model.product_name;
                txt_brand.Text = this.model.brand;
            
                cmb_unit_type.Text = this.model.unit_type;

                btn_save.Visible = false;
                btn_update.Visible = true;
            }
           

            // PRODUCT SIZE

  

            LoadProductSizeById(_product_id);
        }
      
        private int SaveProductDetail() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);


            int id = controller.addProduct(ProductModel());
            _product_id = id;
            return id;
        }
        private bool UpdateProductDetail() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var updatedModel = new ProductModel
            {
                product_id = _product_id,
                product_name = txt_product_name.Text,
                product_type = "Retail",
                brand = txt_brand.Text,
                unit_type = cmb_unit_type.Text,
            };
            return controller.updateProduct(updatedModel);
        }
        private void ProductRetailInfo()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var existingProduct = controller.GetProductRetail(txt_product_name.Text.Trim(), txt_brand.Text.Trim(), cmb_unit_type.Text.Trim());

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
                            RefreshData?.Invoke(this, EventArgs.Empty);
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


                    if (SaveProductDetail() > 0)
                    {
                        RefreshData?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var productName = txt_product_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Product Retail", $"Created product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                       

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateProductDetail())
                    {
                        RefreshData?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var productName = txt_product_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Product Retail", $"Updated product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                   
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private ProductModel ProductModel() 
        {
            var product_Model = new ProductModel 
            {
                product_name = txt_product_name.Text,
                product_type = "Retail",
                brand = txt_brand.Text,
                unit_type = cmb_unit_type.Text

            };

            return product_Model;
        }
       
        private void ClearProductDetail() 
        {
        
            txt_product_name.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_unit_type.Text = string.Empty;
       
        }
        private void btn_save_Click(object sender, EventArgs e)
        {


            ProductRetailInfo();
            //mainForm.LoadRetailProducts();

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            ProductRetailInfo();
            //mainForm.LoadRetailProducts();
        }
        // PRODUCT SIZE RETAIL
        private void LoadProductSizeById(int product_id)
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

        private bool SaveProductSize()
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            return controller.AddProductSize(ProductSizeModel());
        }
        private void ClearProductSize()
        {
            txt_size_label.Text = string.Empty;
            txt_content.Text = string.Empty;
            txt_selling_price.Text = string.Empty;
            txt_cost_price.Text = string.Empty;

        }

        private bool UpdateProductSize() 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            var product_Model = new ProductSizeModel
            {
                product_size_id = Convert.ToInt32(txt_size_label.Tag),
                product_id = _product_id,
                size_label = txt_size_label.Text,
                content = Convert.ToInt32(txt_content.Text),
                selling_price = Convert.ToDecimal(txt_selling_price.Text),
                cost_price = Convert.ToDecimal(txt_cost_price.Text)
            };
            return controller.UpdateProductSize(product_Model);
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


                    if (SaveProductSize())
                    {
                        MessageBox.Show("Product Size added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_size_label.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Product Size", $"Created product size '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        ClearProductSize();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isProductSizeUpdating)
                {
        
                    if (UpdateProductSize())
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
        private void btn_product_size_save_Click(object sender, EventArgs e)
        {
            _isProductSizeUpdating = false;
            _isProductSizeSaving = true;
            ProductSize();
     
            LoadProductSizeById(_product_id);
            //mainForm.LoadRetailProducts();

        }
        
        private async void dgv_product_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_update") 
            {
                var product_size = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;

                txt_size_label.Tag = product_size.product_size_id;
                txt_size_label.Text = product_size.size_label;
                txt_content.Text = product_size.content.ToString();
                txt_selling_price.Text = product_size.selling_price.ToString();
                txt_cost_price.Text = product_size.cost_price.ToString();

                btn_product_size_update.Enabled = true;
                btn_product_size_save.Enabled = false;
                //mainForm.LoadRetailProducts();
            }
            else if (e.RowIndex >= 0 && dgv_product_size.Columns[e.ColumnIndex].Name == "col_product_size_delete")
            {
                var product_size = dgv_product_size.Rows[e.RowIndex].DataBoundItem as ProductSizeModel;
                if (product_size != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this product size?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var repo = new ProductSizeRepository();
                        var controller = new ProductSizeController(repo);


                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Product Retail Size", $"Deleted product size '{product_size.size_label}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        controller.SoftDeleteProductSize(product_size.product_size_id);
                        mainForm.InsertDeletedRecord(product_size.product_size_id, null, "Manage Product Retail Size", product_size.product_name + "( " + product_size.size_label + " )", UserSession.CurrentUser.first_Name, DateTime.Today);

                        MessageBox.Show("Product size deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductSizeById(_product_id);
                        await mainForm.FilterdDeletedRecords(1,25);
                    }
                }
            }
        }

        private void btn_product_size_update_Click(object sender, EventArgs e)
        {
            _isProductSizeSaving = false;
            _isProductSizeUpdating = true;

            ProductSize();
            LoadProductSizeById(_product_id);
           

        }

        private void RetailProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
