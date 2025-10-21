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
    public partial class ProductUsageForm : MaterialForm
    {
        private MainForm mainform;
        private ServiceModel serviceModel;
        private ServiceProductUsageModel ServiceProductUsageModel;

        public ProductUsageForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            LoadProducts();
            LoadServiceProductUsage();
        }
        public ProductUsageForm(MainForm mainForm, ServiceModel serviceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            this.mainform = mainForm;
            this.serviceModel = serviceModel;
            LoadProducts();
            LoadServiceProductUsage();
        }

        private bool Validated()
        {

            bool validated = true;

            // REQUIRED FIELD
            if (!Validator.IntOnly(txt_usage_amount, errorProvider1, "Usage amount is Required", "Spaces are not allowed", "Usage amount must be a whole number.", "Value must be greater than zero."))
            {
                validated = false;
            }

            if (!Validator.DecimalOnly(txt_unit_volume, errorProvider1,
               "Unit Volume is required.",
               "No spaces allowed.",
               "Unit Volume must be a valid number.",
               "PriUnit Volumece must be at least 1.00."))
            {
                validated = false;
            }

            if (!Validator.IsComboBoxSelected(cmb_product, errorProvider1, "Service is required.")) 
            {
                validated = false;
            }
            
     



            // EXISTS VALIDATION
            //int excludeId = ServiceProductUsageModel?.service_product_id ?? 0;
            //int product_id = Convert.ToInt32(cmb_product.SelectedValue);
            //validated &= Validator.IsProductUsageExists(cmb_product, errorProvider1, "Product already exists.", product_id, excludeId);


            return validated;


        }
        private void LoadProducts() 
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var products = controller.getAllProduct();
            cmb_product.DisplayMember = "product_name";
            cmb_product.ValueMember = "product_id";
            cmb_product.DataSource = products;
            cmb_product.SelectedIndex = -1;

         
         

        }
        public void LoadServiceProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var serviceProducts = controller.GetAllServiceProducts(serviceModel.serviceName_id);

            dgv_Service_Product.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_usage_type.DataPropertyName = "usage_type";
            col_usage_amount.DataPropertyName = "usage_amount";
            col_unit_volume.DataPropertyName = "unit_per_volume";
            col_total_usage.DataPropertyName = "total_usage_amount";
            col_total_cost.DataPropertyName = "total_cost";
            dgv_Service_Product.DataSource = serviceProducts;

        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_product.SelectedIndex >= 0)
            {
                var selectedProduct = cmb_product.SelectedItem as ProductModel;
                if (selectedProduct != null)
                {
                    txt_brand.Text = selectedProduct.brand;
                    txt_usage_type.Text = selectedProduct.usage_type;

                    var repo = new InventoryBatchRepository();
                    var controller = new InventoryBatchController(repo);
                    var products = controller.getByProductId(selectedProduct.product_id);
                    var batch = controller.getByProductId(selectedProduct.product_id);

                    if (batch != null)
                    {
                        txt_price_per_unit.Text = batch.price.ToString("N2");
                        tx_unit_volume.Text = batch.volume_per_unit.ToString("N2");
                    }
                    else
                    {
                        txt_price_per_unit.Text = "0.00";
                        tx_unit_volume.Text = "0.00";
                       
                    }

                   
             
                }
            }
            else
            {
                txt_brand.Clear();
                txt_usage_type.Clear();
                txt_price_per_unit.Text = "0.00";
                tx_unit_volume.Text = "0.00";
               

            }
        }
        private void Total_Product_Cost()
        {
            if (decimal.TryParse(txt_total_usage.Text, out decimal usage_amount) &&
                decimal.TryParse(tx_unit_volume.Text, out decimal unit_volume) &&
                decimal.TryParse(txt_price_per_unit.Text, out decimal price))
            {
                if (unit_volume == 0)
                {
                    txt_tota_cost.Text = "Invalid volume";
                    return;
                }

                var cost = (usage_amount / unit_volume) * price;
                txt_tota_cost.Text = cost.ToString("N2");
            }
            else
            {
                txt_tota_cost.Text = string.Empty;
            }
        }

        private void Total_Usage_Amount()
        {
            if (decimal.TryParse(txt_usage_amount.Text, out decimal usage_amount) &&
                decimal.TryParse(txt_unit_volume.Text, out decimal unit_volume))
            {
                var total = usage_amount * unit_volume;
                txt_total_usage.Text = total.ToString("N2");
            }
            else
            {
                txt_total_usage.Text = string.Empty;
            }
        }
         
        private void AddProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var serviceProduct = new ServiceProductUsageModel()
            {
                service_id = serviceModel.serviceName_id,
                product_id = (int)cmb_product.SelectedValue,
                usage_amount = double.Parse(txt_usage_amount.Text),
                unit_per_volume = double.Parse(txt_unit_volume.Text),
                total_usage_amount = double.Parse(txt_total_usage.Text),
                total_cost = decimal.Parse(txt_tota_cost.Text)
            };
            controller.AddServiceProduct(serviceProduct);
            MessageBox.Show("Product usage added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadServiceProductUsage();
        }
        private void UpdateProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);

            ServiceProductUsageModel.product_id = (int)cmb_product.SelectedValue;
            ServiceProductUsageModel.usage_amount = double.Parse(txt_usage_amount.Text);
            ServiceProductUsageModel.unit_per_volume = int.Parse(txt_unit_volume.Text);
            ServiceProductUsageModel.total_usage_amount = double.Parse(txt_total_usage.Text);
            ServiceProductUsageModel.total_cost = decimal.Parse (txt_tota_cost.Text);
            controller.UpdateServiceProduct(ServiceProductUsageModel);
            MessageBox.Show("Product usage updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadServiceProductUsage();
            btn_add.Visible = true;
            btn_update_prodct_usage.Visible = false;
            btn_cancel.Visible = false;




        }

        private void txt_total_usage_TextChanged(object sender, EventArgs e)
        {
            Total_Product_Cost();
        }

        private void txt_usage_amount_TextChanged(object sender, EventArgs e)
        {
            Total_Usage_Amount();
            Total_Product_Cost();
        }

        private void txt_unit_volume_TextChanged(object sender, EventArgs e)
        {
            Total_Usage_Amount();
            Total_Product_Cost();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            AddProductUsage();
            var product = cmb_product.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Created product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();
        }

        private void btn_update_prodct_usage_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateProductUsage();
            var product = cmb_product.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Updated product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_update_prodct_usage.Visible = false;
            btn_cancel.Visible = false;
            Clear();
        }

        private void Clear()
        {
            cmb_product.Hint = string.Empty;
            cmb_product.SelectedIndex = -1;
            txt_unit_volume.Text = string.Empty;
            txt_total_usage.Text = string.Empty;
            txt_usage_amount.Text = string.Empty;
            txt_usage_type.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_product.Hint = "Select Product";
        }

        private void dgv_Service_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "btn_update")
            {
                ServiceProductUsageModel = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (ServiceProductUsageModel != null)
                {
                    
                 
                    cmb_product.Hint = string.Empty;
                    cmb_product.SelectedValue = ServiceProductUsageModel.product_id;
                    txt_unit_volume.Text = ServiceProductUsageModel.unit_per_volume.ToString();
                    txt_usage_amount.Text = ServiceProductUsageModel.usage_amount.ToString();
                    txt_total_usage.Text = ServiceProductUsageModel.total_usage_amount.ToString();



                    cmb_product.Hint= "Select Product";
                    btn_add.Visible = false;
                    btn_update_prodct_usage.Visible = true;
                    btn_cancel.Visible = true;

                }
            } 
            else if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                ServiceProductUsageModel = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (MessageBox.Show($"Delete product {ServiceProductUsageModel.product_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ServiceProductUsageRepository();
                    var controller = new ServiceProductUsageController(repo);
                    var product = cmb_product.Text;
                    Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Deleted product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                    controller.DeleteServiceProduct(ServiceProductUsageModel.service_product_id);
                    mainform.InsertDeletedRecord(ServiceProductUsageModel.service_product_id, "Manage Services, Product Usage", ServiceProductUsageModel.serviceName, UserSession.CurrentUser.first_Name, DateTime.Today);
                    mainform.FilterdDeletedRecords();
                    LoadServiceProductUsage();
                }
            }
        }

        private void tx_unit_volume_TextChanged(object sender, EventArgs e)
        {
            Total_Product_Cost();
        }

        private void txt_tota_cost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
