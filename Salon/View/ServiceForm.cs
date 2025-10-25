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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.View
{
    public partial class ServiceForm : MaterialForm
    {
        private readonly MainForm mainform;
        private ServiceModel serviceModel;
        public ServiceForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            LoadSubCategory();
        }
        public ServiceForm(MainForm mainform, ServiceModel serviceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            this.serviceModel = serviceModel;
            LoadSubCategory();

            if (serviceModel != null) 
            {
                txt_service_name.Text = serviceModel.serviceName;
                txt_duration.Value = serviceModel.duration;
                cmb_sub_category.SelectedValue = serviceModel.subCategory_id;
                cmb_status.SelectedItem = serviceModel.status == Status.Active ? "Active" : "Inactive";

                btn_save.Visible= false;
                btn_update.Visible= true;
            }
        }

        private void LoadSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var subcategories = controller.getSubCategory();

            cmb_sub_category.DisplayMember = "subCategoryName";
            cmb_sub_category.ValueMember = "subcategory_id";
            cmb_sub_category.DataSource = subcategories;
            cmb_sub_category.SelectedIndex = -1;
        }

        private void AddService() 
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var service = new ServiceModel()
            {
                subCategory_id = (int)cmb_sub_category.SelectedValue,
                serviceName = txt_service_name.Text,
                duration = (int)txt_duration.Value,
                status = cmb_status.Text == "Active" ? Status.Active : Status.Inactive,
            };
            controller.addService(service);
            MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
    

        }

        private void UpdateService() 
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            serviceModel.subCategory_id = (int)cmb_sub_category.SelectedValue;
            serviceModel.serviceName = txt_service_name.Text;
            serviceModel.duration = (int)txt_duration.Value;
            serviceModel.status = cmb_status.Text == "Active" ? Status.Active : Status.Inactive;
            controller.updateService(serviceModel);
            MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            AddService();
            var service = txt_service_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services", $"Created service '{service}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            await mainform.RefreshServicesAsync();
            await mainform.RefreshTotalServices();
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            UpdateService();
            var service = txt_service_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services", $"Updated service '{service}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            await mainform.RefreshServicesAsync();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValid()
        {
            int excludeId = serviceModel?.serviceName_id ?? 0;
            int scid = Convert.ToInt32(cmb_sub_category.SelectedValue);
            bool validated = true;
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
        
            


                // REQUIRED FIELD
            string serviceName = txt_service_name.Text.Trim();
            validated &= Validator.ValidateServiceName(serviceName,txt_service_name,errorProvider1,name => controller.CheckServiceExists(name, scid, excludeId) );
            validated &= Validator.ValidateServiceStatus(cmb_status, errorProvider1);
            validated &= Validator.ValidateServiceCategory(cmb_sub_category, errorProvider1);
            validated &= Validator.ValidateDuration(txt_duration, errorProvider1);

          
            //if (!Validator.IsServicesExists(txt_service_name, errorProvider1, "Service already exits.", scid, excludeId))
            //{
            //    validated = false;
            //}

         




            if (!Validator.IsComboBoxSelected(cmb_sub_category, errorProvider1, "Category Type is Required"))
            {
                validated = false;
            }

            if (!Validator.IsComboBoxSelected(cmb_status, errorProvider1, "Unit Type is Required"))
            {
                validated = false;
            }

          




            return validated;


        }
      
    }
}
