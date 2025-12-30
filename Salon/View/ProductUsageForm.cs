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
      
       
        }
        public ProductUsageForm(MainForm mainForm, ServiceModel serviceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            this.mainform = mainForm;
            this.serviceModel = serviceModel;
            txt_service.Text = serviceModel.serviceName;
       
           
        }

        private bool Validated()
        {

            bool validated = true;

            // REQUIRED FIELD
  
       





            if (!Validator.IsComboBoxSelected(cmb_product, errorProvider1, "Service is required.")) 
            {
                validated = false;
            }





            //EXISTS VALIDATION
            int excludeId = ServiceProductUsageModel?.service_product_id ?? 0;
            int product_id = Convert.ToInt32(cmb_product.SelectedValue);
            int sid = serviceModel?.serviceName_id ?? 0;
            validated &= Validator.IsProductUsageExists(cmb_product, errorProvider1, "Product already exists.", product_id, sid, excludeId);


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

        public async Task RefreshServiceProductUsage()
        {
            //var repo = new ServiceProductUsageRepository();
            //var controller = new ServiceProductUsageController(repo);
            //var serviceProducts = await controller.GetAllServiceProductsAsync(serviceModel.serviceName_id);

            //dgv_Service_Product.AutoGenerateColumns = false;
            //col_service_id.DataPropertyName = "service_id";
            //col_product_name.DataPropertyName = "product_name";
            //col_brand.DataPropertyName = "brand";
            //col_usage_type.DataPropertyName = "usage_type";
            //col_total_usage.DataPropertyName = "total_usage_amount";
            //dgv_Service_Product.DataSource = serviceProducts;

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
            col_total_usage.DataPropertyName = "total_usage_amount";
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
                   

                         
             
                }
            }
            else
            {
                txt_brand.Clear();
             
           
               

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
                total_usage_amount = double.Parse(txt_total_usage.Text),
           
            };
            controller.AddServiceProduct(serviceProduct);
            MessageBox.Show("Product usage added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
        }
        private void UpdateProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);

            ServiceProductUsageModel.product_id = (int)cmb_product.SelectedValue;
            ServiceProductUsageModel.total_usage_amount = double.Parse(txt_total_usage.Text);
       
            controller.UpdateServiceProduct(ServiceProductUsageModel);
            MessageBox.Show("Product usage updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            btn_add.Visible = true;
            btn_update_prodct_usage.Visible = false;
            btn_cancel.Visible = false;




        }

        private void txt_total_usage_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_usage_amount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_unit_volume_TextChanged(object sender, EventArgs e)
        {
          
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            AddProductUsage();
            var product = cmb_product.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Created product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();

            await RefreshServiceProductUsage();
        }

        private async void btn_update_prodct_usage_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateProductUsage();
            var product = cmb_product.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Updated product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();
            await RefreshServiceProductUsage();
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
            txt_total_usage.Text = string.Empty;
            txt_usage_type.Text = string.Empty;
            txt_brand.Text = string.Empty;
            cmb_product.Hint = "Select Product";
        }

        private async void dgv_Service_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "btn_update")
            {
                ServiceProductUsageModel = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (ServiceProductUsageModel != null)
                {
                    
                 
                    cmb_product.Hint = string.Empty;
                    cmb_product.SelectedValue = ServiceProductUsageModel.product_id;
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
                    mainform.InsertDeletedRecord(ServiceProductUsageModel.service_product_id, null, "Manage Services, Product Usage", ServiceProductUsageModel.serviceName, UserSession.CurrentUser.first_Name, DateTime.Today);
                    await mainform.FilterdDeletedRecords();
                    await RefreshServiceProductUsage();
                }
            }
        }

        private void tx_unit_volume_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_tota_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ProductUsageForm_Load(object sender, EventArgs e)
        {
            await RefreshServiceProductUsage();
            LoadProducts();
        }

        private void txt_usage_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, not at the start
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

            // Allow one decimal point, not at the start
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
    }
}
