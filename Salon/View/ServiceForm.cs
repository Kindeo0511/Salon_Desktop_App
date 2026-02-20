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
        private int service_id = 0;
        private StylistModel _stylist;
        private bool _isSaving = false;
        private bool _isUpdating = false;
        private List<int> ss_id = new List<int>();


        private bool _isAddingProductUsage = false;
        private bool _isUpdatingProductUsage = false;
        public event EventHandler RefreshData;

        private bool serviceCreated = false;
        private int service_product_id = 0;

        private bool allowTabChange = false;
        public ServiceForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            this.mainform = mainform;
            _isSaving = true;
            LoadSubCategory();
            LoadStylist();




        }
        public ServiceForm(MainForm mainform, ServiceModel serviceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            _isUpdating = true;
            this.mainform = mainform;
            this.serviceModel = serviceModel;
            LoadSubCategory();
            LoadStylist();
            if (serviceModel != null) 
            {

                service_id = serviceModel.serviceName_id;
                txt_service_name.Text = serviceModel.serviceName;
                txt_duration.Value = serviceModel.duration;
                cmb_sub_category.SelectedValue = serviceModel.subCategory_id;
                cmb_status.SelectedItem = serviceModel.status == Status.Active ? "Active" : "Inactive";
                txt_price.Text = serviceModel.servicePrice.ToString("F2");
                btn_save.Visible= false;
                btn_update.Visible= true;


       
        
                allowTabChange = true;

                RefreshServiceProductUsage(serviceModel.serviceName_id);
            }

     
        }
        private void LoadStylist() 
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetStylistSpecialist();


            HashSet<int> assignedSpecialists = new HashSet<int>();



            if (serviceModel != null)
            {
                var assigned = controller.GetStylistsByServiceId(serviceModel.serviceName_id);
                assignedSpecialists = assigned.Select(ss => ss.stylist_id).ToHashSet();
            }

            stylist_list_box.Items.Clear();

            foreach (var item in stylist)
            {
                bool isChecked = assignedSpecialists.Contains(item.stylist_id);
                stylist_list_box.Items.Add(item, isChecked); // add the object itself


            }

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
        private bool AssignStylistToService(int serviceId)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);

            bool assigned = false;
      
            if (_isSaving)
            {
                foreach (var stylist in stylist_list_box.CheckedItems)
                {
                    var model = stylist as StylistModel;
                    if (model != null)
                    {


                        controller.AssignService(model.stylist_id, serviceId);
                        assigned = true;

                    }
                }


            }
            else if (_isUpdating)
            {
                // Get all existing assignments for this service
                var existingAssignments = controller.GetStylistsByServiceId(serviceId)
                                                    .Select(x => x.stylist_id)
                                                    .ToHashSet();

                foreach (var stylist in stylist_list_box.Items)
                {
                    var model = stylist as StylistModel;
                    if (model == null) continue;

                    bool isChecked = stylist_list_box.CheckedItems.Contains(stylist);

                    if (isChecked)
                    {
                        // Assign only if not already assigned
                        if (!existingAssignments.Contains(model.stylist_id))
                        {
                            controller.AssignService(model.stylist_id, serviceId);
                        }
                    }
                    else
                    {
                        // Unassign if it was previously assigned
                        if (existingAssignments.Contains(model.stylist_id))
                        {
                            controller.UnassignService(model.stylist_id, serviceId);
                        }
                    }
                }

                assigned = true;
            }

            return assigned;

        }
      
        
        private int AddService() 
        {

            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var service = new ServiceModel()
            {
                subCategory_id = (int)cmb_sub_category.SelectedValue,
                serviceName = txt_service_name.Text,
                servicePrice = Convert.ToDecimal(txt_price.Text),
                duration = (int)txt_duration.Value,
                status = cmb_status.Text == "Active" ? Status.Active : Status.Inactive,
            };
            int id = controller.addService(service);
            AssignStylistToService(id);
            service_id = id;

          

            return id;


        }

        private bool UpdateService() 
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            serviceModel.subCategory_id = (int)cmb_sub_category.SelectedValue;
            serviceModel.serviceName = txt_service_name.Text;
            serviceModel.servicePrice = Convert.ToDecimal(txt_price.Text);
            serviceModel.duration = (int)txt_duration.Value;
            serviceModel.status = cmb_status.Text == "Active" ? Status.Active : Status.Inactive;


            AssignStylistToService(serviceModel.serviceName_id);

            return controller.updateService(serviceModel);
          
     
        }
        private void IsServiceExists()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var existingService = controller.GetServiceAndCategory(txt_service_name.Text.Trim(), Convert.ToInt32(cmb_sub_category.SelectedValue));

            if (existingService != null)
            {

                if (existingService.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Service exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreServices(existingService.serviceName_id))
                        {
                            mainform.DeleteDeletedRecord(existingService.serviceName_id);
                            MessageBox.Show("Service restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {


                    if (AddService() > 0)
                    {
                      
                        MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_service_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services", $"Created service '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateService())
                    {
                        MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_service_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services", $"Updated service '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
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
            IsServiceExists();


            await mainform.RefreshServicesAsync(1,25);
            await mainform.RefreshTotalServices();

        }
        private bool HasServiceChange()
        {
            decimal currentPrice = 0;
            bool priceParsed = decimal.TryParse(txt_price.Text, out currentPrice);

            bool hasChanges =
                txt_service_name.Text.Trim() != (serviceModel?.serviceName?.Trim() ?? string.Empty)
                || (cmb_sub_category.SelectedValue == null
                    || (int)cmb_sub_category.SelectedValue != (serviceModel?.subCategory_id ?? -1))
                || (cmb_status.SelectedValue == null
                    || (Status)cmb_status.SelectedValue != (serviceModel?.status ?? Status.Active))
                || !priceParsed
                || currentPrice != (serviceModel?.servicePrice ?? 0);

            // Current checked stylists
            var currentServices = stylist_list_box.CheckedItems
                                                  .Cast<StylistModel>()
                                                  .Select(s => s.stylist_id)
                                                  .ToList();

            var stylistSpecialistRepo = new Stylist_Specialist_Repository();
            var stylistSpecialistController = new Stylist_specialist_Controller(stylistSpecialistRepo);

            var originalServices = new List<int>();

            if (_stylist != null)
            {
                var result = stylistSpecialistController.GetStylistById(_stylist.stylist_id);
                if (result != null)
                {
                    // ✅ compare stylist_id, not specialist_id
                    originalServices = result.Select(ss => ss.stylist_id).ToList();
                }
            }

            // Compare sets
            if (currentServices.Count != originalServices.Count ||
                !currentServices.All(originalServices.Contains) ||
                !originalServices.All(currentServices.Contains))
            {
                hasChanges = true;
            }

            return hasChanges;
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            //if (!HasServiceChange()) 
            //{
            //    MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            IsServiceExists();

            await mainform.RefreshServicesAsync(1, 25);

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



            if (string.IsNullOrWhiteSpace(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "Price is required.");
                validated = false;
            }
            else if (!decimal.TryParse(txt_price.Text, out decimal price) || price < 0)
            {
                errorProvider1.SetError(txt_price, "Price must be a valid non-negative number.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_price, string.Empty);
            }


            if (!Validator.IsComboBoxSelected(cmb_sub_category, errorProvider1, "Category Type is Required"))
            {
                validated = false;
            }

            if (!Validator.IsComboBoxSelected(cmb_status, errorProvider1, "Unit Type is Required"))
            {
                validated = false;
            }


            // Services (CheckedListBox must have at least one checked item)
            if (stylist_list_box.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(stylist_list_box, "Select at least one stylist.");
                validated = false;
            }
            else errorProvider1.SetError(stylist_list_box, "");



            return validated;


        }

        private void ServiceForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_service_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
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

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void RefreshServiceProductUsage(int id)
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var serviceProducts = controller.GetAllServiceProducts(id);

            dgv_Service_Product.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_product_id.DataPropertyName = "product_id";
            col_product__size_id.DataPropertyName = "product_size_id";
            col_product_size_label.DataPropertyName = "size_label";
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_total_usage.DataPropertyName = "qty_required";
            dgv_Service_Product.DataSource = serviceProducts;

        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            //await RefreshServiceProductUsage();
            LoadProducts();
        }

        // TAB PAGE 2

        private bool AddProductUsage()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var serviceProduct = new ServiceProductUsageModel()
            {
                service_id = service_id,
                product_id = (int)cmb_product.SelectedValue,
                product_size_id = Convert.ToInt32(lbl_size_id.Text),
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

                service_product_id = Convert.ToInt32(lbl_service_product_id.Text),
                service_id = service_id,
                product_id = (int)cmb_product.SelectedValue,
                product_size_id = Convert.ToInt32(lbl_size_id.Text),
                total_usage_amount = double.Parse(txt_total_usage.Text),

            };



            return controller.UpdateServiceProduct(model);





        }
        private void IsProductUsageExists()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var existingServiceUsage = controller.GetServiceProductUsage(service_id, Convert.ToInt32(cmb_product.SelectedValue), txt_brand.Text, Convert.ToInt32(txt_total_usage.Text));


                if (existingServiceUsage != null && existingServiceUsage.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Product Consumption exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreServiceProduct(existingServiceUsage.service_product_id))
                        {
                            MessageBox.Show("Service restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            

            else
            {
                if (_isAddingProductUsage)
                {
              

                    if (AddProductUsage())
                    {
                    
 
                        MessageBox.Show("Service product usage  added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = cmb_product.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Created product usage '{fullName}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

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
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Services, Product Usage", $"Updated product usage '{fullName}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

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

        }
        private void LoadProductSize(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);

            var productSize = controller.GetSingleProductSizeById(product_id);

            if (productSize != null)
            {
                lbl_size_id.Text = productSize.product_size_id.ToString();
                txt_size.Text = productSize.size_label;
            }
            else
            {
                lbl_size_id.Text = string.Empty;
                txt_size.Text = string.Empty;
            }


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
        private bool Validated()
        {

            bool validated = true;

            // REQUIRED FIELD







            if (!Validator.IsComboBoxSelected(cmb_product, errorProvider1, "Service is required."))
            {
                validated = false;
            }





            ////EXISTS VALIDATION
            //int excludeId = ServiceProductUsageModel?.service_product_id ?? 0;
            //int product_id = Convert.ToInt32(cmb_product.SelectedValue);
            //int sid = serviceModel?.serviceName_id ?? 0;
            //validated &= Validator.IsProductUsageExists(cmb_product, errorProvider1, "Product already exists.", product_id, sid, excludeId);


            return validated;


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            _isAddingProductUsage = true;
            if (!Validated()) return;
            IsProductUsageExists();


            RefreshServiceProductUsage(service_id);
        }

        private void btn_update_prodct_usage_Click(object sender, EventArgs e)
        {
            _isUpdatingProductUsage = true;
            if (!Validated()) return;
            IsProductUsageExists();

            RefreshServiceProductUsage(service_id);
        }

        private void materialButton1_Click(object sender, EventArgs e)
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
            txt_brand.Text = string.Empty;
            cmb_product.Hint = "Select Product";
        }

        private async void dgv_Service_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "col_usage_btn_update")
            {
                var productUsage = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (productUsage != null)
                {


                    cmb_product.Hint = string.Empty;
                    cmb_product.SelectedValue = productUsage.product_id;
                    lbl_service_product_id.Text = productUsage.service_product_id.ToString();
                    //lbl_size_id.Text = productUsage.product_size_id.ToString();
                    txt_total_usage.Text = productUsage.qty_required.ToString();



                    cmb_product.Hint = "Select Product";
                    btn_add.Visible = false;
                    btn_update_prodct_usage.Visible = true;
                    btn_cancel.Visible = true;

                }
            }
            else if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                var productUsage = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (MessageBox.Show($"Delete product {productUsage.product_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ServiceProductUsageRepository();
                    var controller = new ServiceProductUsageController(repo);
                    var product = cmb_product.Text;

                    if (controller.DeleteServiceProduct(productUsage.service_product_id))
                    {

                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Services Product Usage", $"Deleted product usage '{product}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        mainform.InsertDeletedRecord(productUsage.service_product_id, productUsage.product_id, "Manage Services Product Usage", productUsage.serviceName, UserSession.CurrentUser.first_Name, DateTime.Today);

                        await mainform.FilterdDeletedRecords(1, 25);
                        RefreshServiceProductUsage(service_id);
                        Clear();
                    }
                }
            }
        }

        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
          
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

           
        }

        private void cmb_product_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedProduct = cmb_product.SelectedItem as ProductModel;

            if (selectedProduct != null)
            {
                LoadProductSize(selectedProduct.product_id);

         
            }
            else
            {
                // Hide or clear when no product is selected
                lbl_size_id.Text = string.Empty;
                txt_size.Text = string.Empty;

             
            }

        }
    }
}
