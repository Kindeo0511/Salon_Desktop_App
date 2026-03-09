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
    public partial class ProductSizeForm : MaterialForm
    {
        private readonly int ProductId;
        private ProductModel productModel;
        private readonly ProductForm _productForm;
        private readonly ProductSizeModel SizeModel;
        private readonly MainForm mainForm;
        private bool _isProductSizeSaving = false;
        private bool _isProductSizeUpdating = false;
        private int is_retail;
        private int product_size_id = 0;
        public ProductSizeForm(MainForm main,ProductForm productForm, int product_id, string name)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            mainForm = main;
            _productForm = productForm;
            ProductId = product_id;
            this.Text = name;
            LoadProductInformation(product_id);



        }
        public ProductSizeForm(MainForm main, ProductForm productForm, ProductSizeModel productSizeModel, int product_id, string name)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            mainForm = main;
            _productForm = productForm;
            SizeModel = productSizeModel;
            ProductId = product_id;
            this.Text = name;
            LoadProductInformation(product_id);

            btn_product_size_save.Visible = false;
            btn_product_size_update.Visible = true;

        }

        //if (product_size_model != null) 
        //{
        //    txt_size_label.Tag = product_size_model.product_size_id;
        //    txt_size_label.Text = product_size_model.size_label;
        //    txt_content.Text = product_size_model.content.ToString();
        //    txt_cost_price.Text = product_size_model.cost_price.ToString();
        //    btn_product_size_update.Enabled = true;
        //    btn_product_size_save.Enabled = false;

        //}
        public void LoadProductSizeInformation() 
        {
            product_size_id = SizeModel.product_size_id;
            txt_size_label.Text = SizeModel.size_label;
            txt_content.Text = SizeModel.content.ToString();
            txt_cost_price.Text = SizeModel.cost_price.ToString();
            txt_selling_price.Text = SizeModel.selling_price.ToString();
        }
        private void LoadProductInformation(int product_id) 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            var product = controller.GetProductInformation(product_id);

            if (product != null) 
            {
                is_retail = product.is_retail;

                if (is_retail == 1)
                {
                    materialLabel1.Visible = true;
                    txt_selling_price.Visible = true;

                }
                else 
                {
                    materialLabel1.Visible = false;
                    txt_selling_price.Visible = false;
                }
            }

            if (SizeModel != null) 
            {
                LoadProductSizeInformation();
            }
          

        }
        private void btn_product_size_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsProductSizeValid()
        {
            int excludeId = SizeModel?.product_size_id ?? 0;
            bool validated = true;

            // Size label required
            if (string.IsNullOrWhiteSpace(txt_size_label.Text))
            {
                errorProvider1.SetError(txt_size_label, "Size label is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_size_label, "");
            }

            // Content must be numeric and > 0
            int contentValue = 0;
            if (string.IsNullOrWhiteSpace(txt_content.Text))
            {
                errorProvider1.SetError(txt_content, "Content is required.");
                validated = false;
            }
            else if (!int.TryParse(txt_content.Text, out contentValue) || contentValue <= 0)
            {
                errorProvider1.SetError(txt_content, "Content must be a positive number.");
                validated = false;
            }
            else errorProvider1.SetError(txt_content, "");


            // Cost must be decimal and > 0
            decimal cost = 0;
            if (string.IsNullOrWhiteSpace(txt_cost_price.Text))
            {
                errorProvider1.SetError(txt_cost_price, "Cost price is required.");
                validated = false;
            }
            else if (!decimal.TryParse(txt_cost_price.Text, out cost) || cost <= 0)
            {
                errorProvider1.SetError(txt_cost_price, "Cost price must be a positive amount.");
                validated = false;
            }
            else errorProvider1.SetError(txt_cost_price, "");

            int product_size_id = excludeId;
            int product_id = ProductId;

            int deleted_product_size_id = 0;

            if (_isProductSizeSaving) 
            {
                deleted_product_size_id = ExistingProductSizeButDeleted();
            }
            if (deleted_product_size_id > 0)
            {
                var result = MessageBox.Show("This Product Size exists but is deleted. Do you want to go to the Recovery module to restore it?",
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
                errorProvider1.SetError(txt_size_label, "Product size already exists.");
                validated = false;

            }



            return validated;

        }
        private bool ProductSizeExists(int product_size_id, int product_id, int content)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            bool exists = controller.Exists(product_size_id, product_id,content);
           // bool exists = controller.GetProductSize(product_id)
           //.Any(ps => ps.product_id == product_id
           //        && ps.size_label == txt_size_label.Text.Trim()
           //        && ps.content == content
           //        && ps.is_deleted == 0
           //        && ps.product_size_id != product_size_id);

            return exists;
        }
        
        private void btn_product_size_save_Click(object sender, EventArgs e)
        {
            _isProductSizeSaving = true;
            if (!IsProductSizeValid()) return;
         
            ProductSize();
            _productForm.LoadProductSizeById(ProductId);
            this.Close();
       

        }
        private int ExistingProductSizeButDeleted() 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            return controller.GetProductSize(ProductId, Convert.ToInt32(txt_content.Text));
        }
        private void RestoreProductSize(int product_size_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            if (controller.RestoreProductSize(product_size_id)) 
            {
                mainForm.DeleteDeletedRecord(product_size_id);
                MessageBox.Show("Product size restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _productForm.LoadProductSizeById(ProductId);
                this.Close();
            }
        }
        private void ProductSize()
        {
          
                if (_isProductSizeSaving)
                {


                    if (AddProductSize(ProductId))
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

                    if (UpdateProductSize(ProductId))
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
        private ProductSizeModel ProductSizeModel(int product_id)
        {
            string size_label = txt_size_label.Text;
            int content = Convert.ToInt32(txt_content.Text);

            decimal cost = Convert.ToDecimal(txt_cost_price.Text);
            decimal price = 0m;

            if (!string.IsNullOrWhiteSpace(txt_selling_price.Text))
            {
                decimal.TryParse(txt_selling_price.Text, out price);
            }
            var model = new ProductSizeModel
            {
                product_id = product_id,
                size_label = size_label,
                content = content,
                cost_price = cost,
                selling_price = price
            };

            return model;
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

            decimal cost = Convert.ToDecimal(txt_cost_price.Text);
            decimal price = 0m;

            if (!string.IsNullOrWhiteSpace(txt_selling_price.Text))
            {
                decimal.TryParse(txt_selling_price.Text, out price);
            }
            var model = new ProductSizeModel
            {
                product_size_id = product_size_id,
                product_id = product_id,
                size_label = txt_size_label.Text,
                content = Convert.ToInt32(txt_content.Text),
                cost_price = cost,
                selling_price = price
            };

            return controller.UpdateProductSize(model);


        }
        private bool HasProductSizeChanges()
        {
            return txt_size_label.Text != SizeModel.size_label
                || txt_content.Text != SizeModel.content.ToString()
                || txt_cost_price.Text != SizeModel.cost_price.ToString()
                || txt_selling_price.Text != SizeModel.selling_price.ToString()
                ;
        }
        private void btn_product_size_update_Click(object sender, EventArgs e)
        {
            if (!IsProductSizeValid()) return;

            if (!HasProductSizeChanges())
            {
                MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _isProductSizeUpdating = true;
            ProductSize();
            _productForm.LoadProductSizeById(ProductId);
            this.Close();
        }

        private void ProductSizeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void ProductSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
