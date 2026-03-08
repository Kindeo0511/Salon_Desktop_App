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
    public partial class ProductConsumptionForm : MaterialForm
    {

        private bool _isAddingProductUsage = false;
        private bool _isUpdatingProductUsage = false;
        private readonly MainForm mainForm;
        private readonly ServiceForm serviceForm;
        private readonly ServiceProductUsageModel serviceUsageModel;
        private int service_id = 0;
        private int service_product_id = 0;
        private string ServiceName = null;
        public ProductConsumptionForm(MainForm main, ServiceForm service, string serviceName, int service_id)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            mainForm = main;
            serviceForm = service;
            ServiceName = serviceName;
            this.service_id = service_id;
            LoadProducts();
        }
        public ProductConsumptionForm(MainForm main, ServiceForm service, ServiceProductUsageModel serviceProductUsageModel, string serviceName, int service_id)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            mainForm = main;
            serviceForm = service;
            ServiceName = serviceName;
            this.service_id = service_id;
            serviceUsageModel = serviceProductUsageModel;


            LoadProducts();
            LoadServiceConsumptionInformation();
        }

        private void LoadProducts()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var products = controller.GetProductIngredients();
            cmb_product.DisplayMember = "product_name";
            cmb_product.ValueMember = "product_id";
            cmb_product.DataSource = products;
            cmb_product.SelectedIndex = -1;




        }
        private void LoadServiceConsumptionInformation() 
        {

            if (serviceUsageModel != null) 
            {
                service_product_id = serviceUsageModel.service_product_id;
                cmb_product.SelectedValue = serviceUsageModel.product_id;
                txt_brand.Text = serviceUsageModel.brand;
                txt_total_usage.Text = serviceUsageModel.qty_required.ToString();

                btn_add.Visible = false;
                btn_update_prodct_usage.Visible = true;
            }


     
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            _isAddingProductUsage = true;
            if (!Validated()) return;
            IsProductUsageExists();


            serviceForm.RefreshServiceProductUsage(service_id);
            this.Close();
        }
        private bool AddProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var serviceProduct = new ServiceProductUsageModel()
            {
                service_id = service_id,
                product_id = (int)cmb_product.SelectedValue,
                total_usage_amount = double.Parse(txt_total_usage.Text),

            };
            return controller.AddServiceProduct(serviceProduct);


        }
        private bool UpdateProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var model = new ServiceProductUsageModel
            {

                product_id = (int)cmb_product.SelectedValue,
                service_product_id = serviceUsageModel.service_product_id,
                total_usage_amount = double.Parse(txt_total_usage.Text),

            };



            return controller.UpdateServiceProduct(model);


        }
        private bool Validated()
        {

            bool validated = true;
            int excludeId = serviceUsageModel?.service_product_id ?? 0;
            int product_id = Convert.ToInt32(cmb_product.SelectedValue);
            int sid = service_id;
            // REQUIRED FIELD







            if (!Validator.IsComboBoxSelected(cmb_product, errorProvider1, "Service is required."))
            {
                validated = false;
            }





            //EXISTS VALIDATION
            int deleted_product_id = 0;
            if (_isAddingProductUsage) deleted_product_id = ExistingProductConsumptionButDeleted();

            if (deleted_product_id > 0) 
            {
                var result = MessageBox.Show("This Product Consumption exists but is deleted. Do you want to restore it?",
                              "Restore Account",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    RestoreProductConsumption(deleted_product_id);

                }
            }
    
            validated &= Validator.IsProductUsageExists(cmb_product, errorProvider1, "Product already exists.", product_id, sid, excludeId);


            return validated;


        }
        private int ExistingProductConsumptionButDeleted() 
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            return  controller.GetServiceProductUsage(service_id, Convert.ToInt32(cmb_product.SelectedValue), txt_brand.Text, Convert.ToInt32(txt_total_usage.Text));

        }
        private void RestoreProductConsumption(int id) 
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);

            if (controller.RestoreServiceProduct(id))
            {
                MessageBox.Show("Service restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serviceForm.RefreshServiceProductUsage(service_id);
                this.Close();
            }

        }
        private void IsProductUsageExists()
        {
           
                if (_isAddingProductUsage)
                {


                    if (AddProductUsage())
                    {


                        MessageBox.Show("Service product usage  added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = cmb_product.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Created product usage '{fullName}' for ({ServiceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdatingProductUsage)
                {
                    if (UpdateProductUsage())
                    {
                        MessageBox.Show("Service product usage updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = cmb_product.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Updated product usage '{fullName}' for ({ServiceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        btn_add.Visible = true;
                        btn_update_prodct_usage.Visible = false;
                        btn_cancel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            

        }
        private void Clear()
        {
            cmb_product.Hint = string.Empty;
            cmb_product.SelectedIndex = -1;
            txt_total_usage.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_product.Hint = "Select Product";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_product_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_product.SelectedIndex >= 0)
            {
                var selectedProduct = cmb_product.SelectedItem as ProductModel;
                if (selectedProduct != null)
                {
                    txt_brand.Text = selectedProduct.brand;




                }
            }
            else
            {
                txt_brand.Clear();




            }
        }

        private void btn_update_prodct_usage_Click(object sender, EventArgs e)
        {
            _isUpdatingProductUsage = true;
            if (!Validated()) return;
            IsProductUsageExists();

            serviceForm.RefreshServiceProductUsage(service_id);
            this.Close();
        }

        private void ProductConsumptionForm_Load(object sender, EventArgs e)
        {
            cmb_product.MouseWheel += Helper.ComboBox_MouseWheel;
        }
    }
}
