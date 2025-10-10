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
                txt_brand.Text = productModel.brand;
                cmb_category.SelectedValue = productModel.category_id;
                cmb_unit_type.Text = productModel.unit_type;
                cmb_usage_type.Text = productModel.usage_type;
                txt_unit_volume.Text = productModel.unit_volume.ToString();

                btn_save.Visible = false;
                btn_update.Visible = true;

            }
        }
        private bool Validated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_product_name, errorProvider1, "Product is required.");
            validated &= Validator.IsRequired(txt_brand, errorProvider1, "Brand is required.");
            validated &= Validator.IsRequired(txt_unit_volume, errorProvider1, "Unit Volume is required.");
            validated &= Validator.IsRequired(cmb_category, errorProvider1, "Category is required.");
            validated &= Validator.IsRequired(cmb_unit_type, errorProvider1, "Unit type is required.");
            validated &= Validator.IsRequired(cmb_usage_type, errorProvider1, "Usage type is required.");



            // EXISTS VALIDATION
            int excludeId = productModel?.product_id ?? 0;
            int cat_id = Convert.ToInt32(cmb_category.SelectedValue);
            validated &= Validator.IsProductExists(txt_product_name, errorProvider1, "Product already exists.", cat_id, excludeId);


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

        private void AddProduct() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var product = new ProductModel
            {
                product_name = txt_product_name.Text,
                brand = txt_brand.Text,
                category_id = (int)cmb_category.SelectedValue,
                unit_type = cmb_unit_type.Text,
                usage_type = cmb_usage_type.Text,
                unit_volume = Convert.ToInt32(txt_unit_volume.Text)
            };
            controller.addProduct(product);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.LoadProducts();
            mainForm.LoadTotalProducts();
        }
        private void UpdateProduct() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            productModel.product_name = txt_product_name.Text;
            productModel.brand = txt_brand.Text;
            productModel.category_id = (int)cmb_category.SelectedValue;
            productModel.unit_type = cmb_unit_type.Text;
            productModel.usage_type = cmb_usage_type.Text;
            productModel.unit_volume = Convert.ToInt32(txt_unit_volume.Text);
            controller.updateProduct(productModel);
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.LoadProducts();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            AddProduct();
            var productName = txt_product_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Products", $"Created product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateProduct();
            var productName = txt_product_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Products", $"Updated product '{productName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // END OF PRODUCTS


    }
}
