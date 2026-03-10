using iText.StyledXmlParser.Jsoup.Safety;
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
        private bool _isDeleting = false;
        private List<int> ss_id = new List<int>();
        private string serviceName = null;


        private bool _isAddingProductUsage = false;
        private bool _isUpdatingProductUsage = false;
        public event EventHandler RefreshData;

        private bool serviceCreated = false;
        private int service_product_id = 0;

        private bool allowTabChange = false;

        private BindingList<ServiceProductUsageModel> product_consumption_list = new BindingList<ServiceProductUsageModel>();
        public ServiceForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Service_Product);
            this.mainform = mainform;
            _isSaving = true;
            LoadSubCategory();
   




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
 
            if (serviceModel != null) 
            {

                service_id = serviceModel.serviceName_id;
                txt_service_name.Text = serviceModel.serviceName;
                txt_duration.Value = serviceModel.duration;
                cmb_sub_category.SelectedValue = serviceModel.subCategory_id;
                txt_price.Text = serviceModel.servicePrice.ToString("F2");
                btn_save.Visible= false;
                btn_update.Visible= true;

                serviceName = serviceModel.serviceName;
       
        
                allowTabChange = true;

                RefreshServiceProductUsage(serviceModel.serviceName_id);
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
        //private bool AssignStylistToService(int serviceId)
        //{
        //    var repo = new StylistRepository();
        //    var controller = new StylistController(repo);

        //    bool assigned = false;
      
        //    if (_isSaving)
        //    {
        //        foreach (var stylist in stylist_list_box.CheckedItems)
        //        {
        //            var model = stylist as StylistModel;
        //            if (model != null)
        //            {


        //                controller.AssignService(model.stylist_id, serviceId);
        //                assigned = true;

        //            }
        //        }


        //    }
        //    else if (_isUpdating)
        //    {
        //        // Get all existing assignments for this service
        //        var existingAssignments = controller.GetStylistsByServiceId(serviceId)
        //                                            .Select(x => x.stylist_id)
        //                                            .ToHashSet();

        //        foreach (var stylist in stylist_list_box.Items)
        //        {
        //            var model = stylist as StylistModel;
        //            if (model == null) continue;

        //            bool isChecked = stylist_list_box.CheckedItems.Contains(stylist);

        //            if (isChecked)
        //            {
        //                // Assign only if not already assigned
        //                if (!existingAssignments.Contains(model.stylist_id))
        //                {
        //                    controller.AssignService(model.stylist_id, serviceId);
        //                }
        //            }
        //            else
        //            {
        //                // Unassign if it was previously assigned
        //                if (existingAssignments.Contains(model.stylist_id))
        //                {
        //                    controller.UnassignService(model.stylist_id, serviceId);
        //                }
        //            }
        //        }

        //        assigned = true;
        //    }

        //    return assigned;

        //}
      
        
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
            };
            int id = controller.addService(service);
            //AssignStylistToService(id);
            service_id = id;
            serviceName = txt_service_name.Text;
          

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


            //AssignStylistToService(serviceModel.serviceName_id);

            return controller.updateService(serviceModel);
          
     
        }
        private int ExistingServiceButDeleted() 
        {

            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            return controller.GetServiceAndCategory(txt_service_name.Text.Trim(), Convert.ToInt32(cmb_sub_category.SelectedValue));



        }
        private async void RestoreService(int service_id) 
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            if (controller.RestoreServices(service_id))
            {
                mainform.DeleteDeletedRecord(service_id);
                MessageBox.Show("Service restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await mainform.RefreshServicesAsync(1, 25);
                this.Close();
            }
        }
        private void IsServiceExists()
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
                || !priceParsed
                || currentPrice != (serviceModel?.servicePrice ?? 0);

            //// Current checked stylists
            //var currentServices = stylist_list_box.CheckedItems
            //                                      .Cast<StylistModel>()
            //                                      .Select(s => s.stylist_id)
            //                                      .ToList();

            //var stylistSpecialistRepo = new Stylist_Specialist_Repository();
            //var stylistSpecialistController = new Stylist_specialist_Controller(stylistSpecialistRepo);

            //var originalServices = new List<int>();

            //if (_stylist != null)
            //{
            //    var result = stylistSpecialistController.GetStylistById(_stylist.stylist_id);
            //    if (result != null)
            //    {
            //        // ✅ compare stylist_id, not specialist_id
            //        originalServices = result.Select(ss => ss.stylist_id).ToList();
            //    }
            //}

            //// Compare sets
            //if (currentServices.Count != originalServices.Count ||
            //    !currentServices.All(originalServices.Contains) ||
            //    !originalServices.All(currentServices.Contains))
            //{
            //    hasChanges = true;
            //}

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
            validated &= Validator.ValidateServiceCategory(cmb_sub_category, errorProvider1);
            validated &= Validator.ValidateDuration(txt_duration, errorProvider1);

            int deleted_service_id = 0;
            if (_isSaving) 
            {
                deleted_service_id = ExistingServiceButDeleted();
            }
            if (deleted_service_id > 0)
            {
                var result = MessageBox.Show("This Service exists but is deleted. Do you want to restore it?",
                                     "Restore Account",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RestoreService(deleted_service_id);
                    this.Close();
                }
                validated = false;
            }
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

        


            // Services (CheckedListBox must have at least one checked item)
            //if (stylist_list_box.CheckedItems.Count == 0)
            //{
            //    errorProvider1.SetError(stylist_list_box, "Select at least one stylist.");
            //    validated = false;
            //}
            //else errorProvider1.SetError(stylist_list_box, "");



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
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_total_usage.DataPropertyName = "qty_required";

            product_consumption_list = new BindingList<ServiceProductUsageModel>(serviceProducts.ToList());
            dgv_Service_Product.DataSource = product_consumption_list;

        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            //await RefreshServiceProductUsage();
            cmb_sub_category.MouseWheel += Helper.ComboBox_MouseWheel;
            cmb_product.MouseWheel += Helper.ComboBox_MouseWheel;
            LoadProducts();

            dgv_Service_Product.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_total_usage.DataPropertyName = "qty_required";
            dgv_Service_Product.DataSource = product_consumption_list;

        }




        private bool IsServiceListConsumptionValid(string name)
        {
            // ✅ Check if sizeList has at least one item
            if (product_consumption_list == null || product_consumption_list.Count == 0)
            {
                MessageBox.Show($"Please add at least one product consumption before {name}.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private async void btn_save_Click_1(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (!IsServiceListConsumptionValid("saving")) return;
            SaveServiceConsumption(Service_Model(),product_consumption_list);
            //IsServiceExists();


            await mainform.RefreshServicesAsync(1, 25);
            await mainform.RefreshTotalServices();
            this.Close();
        }

        private async void btn_update_Click_1(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (!IsServiceListConsumptionValid("updating")) return;

            if (_isUpdating)
            {
                UpdateServiceConsumption(Service_Model(), product_consumption_list);

            }
            else if (_isDeleting) 
            {
                DeleteServiceConsumption(Service_Model(), product_consumption_list);
            }

                //if (!HasServiceChange()) 
                //{
                //    MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                //IsServiceExists();

                await mainform.RefreshServicesAsync(1, 25);
            ClearConsumptionField();
        }
        private ServiceModel Service_Model() 
        {
            int _service_id = service_id;
            string service_name = txt_service_name.Text.Trim();
            int category_id = Convert.ToInt32(cmb_sub_category.SelectedValue);
            decimal price = Convert.ToDecimal(txt_price.Text);
            int duration = Convert.ToInt32(txt_duration.Value); 
   
            var model = new ServiceModel
            {
                serviceName_id = _service_id,
                serviceName = service_name,
                subCategory_id = category_id,
                servicePrice = price,
                duration = duration
   
            };


            return model;
        }
        private ServiceProductUsageModel ServiceConsumptionModel()
        {
            int _service_id = service_id;
            int.TryParse(lbl_usage_id.Text.Trim(), out int usage_id);
            int product_id = Convert.ToInt32(cmb_product.SelectedValue);
            string brand = txt_brand.Text.Trim();
            string product_name = cmb_product.Text.Trim();
            int.TryParse(txt_total_usage.Text.Trim(), out int qty);


            var size_model = new ServiceProductUsageModel
            {
                service_id = _service_id,
                product_name = product_name,
                brand = brand,
                product_id = product_id,
                service_product_id = usage_id,
                qty_required = qty,
          
            };


            return size_model;

        }
        private void SaveServiceConsumption(ServiceModel model, IEnumerable<ServiceProductUsageModel> consumption)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            bool success = controller.ServiceSaveWithConsumption(model, consumption);


            if (success)
            {
                MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add service please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateServiceConsumption(ServiceModel model, IEnumerable<ServiceProductUsageModel> consumption)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            bool success = controller.ServiceSaveWithConsumption(model, consumption);


            if (success)
            {
                MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update service please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteServiceConsumption(ServiceModel model, IEnumerable<ServiceProductUsageModel> consumptions)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            bool success = controller.ServiceSaveWithConsumption(model, consumptions);
            var consumption = consumptions.FirstOrDefault();
            if (consumptions == null) return;

            if (success)
            {
                MessageBox.Show("Service deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Services Product Usage", $"Deleted product usage '{consumption.product_name}' for ({serviceModel.serviceName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");


                mainform.InsertDeletedRecord(consumption.service_product_id, consumption.product_id, "Manage Services Product Usage", consumption.serviceName, UserSession.CurrentUser.first_Name, DateTime.Today);

             
                RefreshServiceProductUsage(service_id);

            }
            else
            {
                MessageBox.Show("Failed to delete service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsServiceConsumptionValidated()
        {

            bool validated = true;
            int excludeId = Convert.ToInt32(lbl_usage_id.Text);
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
        private bool IsDuplicateConsumption(ServiceProductUsageModel newItem, int excludeId = 0)
        {
            bool isDuplicate = product_consumption_list.Any(s =>
                s.product_id == newItem.product_id &&                    // ✅ same product
                s.service_product_id != excludeId);                      // ✅ exclude self when updating

            if (isDuplicate)
            {
                MessageBox.Show($"Product '{newItem.product_name}' already exists in the list.",
                                "Duplicate Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
        private int ExistingProductConsumptionButDeleted()
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            return controller.GetServiceProductUsage(service_id, Convert.ToInt32(cmb_product.SelectedValue), txt_brand.Text, Convert.ToInt32(txt_total_usage.Text));

        }
        private void RestoreProductConsumption(int id)
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);

            if (controller.RestoreServiceProduct(id))
            {
                MessageBox.Show("Service restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        private void btn_add_consumption_Click_1(object sender, EventArgs e)
        {
            if(!IsServiceConsumptionValidated()) return;
            product_consumption_list.Add(ServiceConsumptionModel());

            ClearConsumptionField();
            //if (service_id == 0)
            //{
            //    MessageBox.Show(
            //        "Please create a service first before adding a product consumption.",
            //        "Action Required",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );
            //    return;
            //}

            //using (var form = new ProductConsumptionForm(mainform, this, serviceName, service_id))
            //{
            //    form.ShowDialog();
            //}
        }

        private async void dgv_Service_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "col_usage_btn_update")
            {
                var productUsage = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                if (productUsage != null)
                {
                    lbl_usage_id.Text = productUsage.service_product_id.ToString();
                    cmb_product.SelectedValue = productUsage.product_id;
                    txt_brand.Text = productUsage.brand;
                    txt_total_usage.Text = productUsage.qty_required.ToString();

                    if (productUsage.service_product_id != 0)
                    {
                        btn_add_consumption.Visible = false;
                        btn_update_consumption.Visible = true;
                    }
                    else 
                    {
                        btn_add_consumption.Visible = true;
                        btn_update_consumption.Visible = false;
                    }
                 

                    //using (var form = new ProductConsumptionForm(mainform, this, productUsage, serviceName, service_id)) 
                    //{
                    //    form.ShowDialog();
                    //}


                }
            }
            else if (e.RowIndex >= 0 && dgv_Service_Product.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                var productUsage = dgv_Service_Product.Rows[e.RowIndex].DataBoundItem as ServiceProductUsageModel;

                var repo = new ServiceProductUsageRepository();
                var controller = new ServiceProductUsageController(repo);
                var product = productUsage.product_name;
                //if (controller.IsProductUsedInServices(productUsage.product_id))
                //{
                //    MessageBox.Show("This product cannot be deleted because it is still being used to inventory or delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                var result = MessageBox.Show($"Are you sure you want to delete {productUsage.product_name}?",
                                                 "Delete Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    product_consumption_list.Remove(productUsage);

                    _isDeleting = true; 
                  


                }

               
            }
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
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_update_consumption_Click(object sender, EventArgs e)
        {
            if (!IsServiceConsumptionValidated()) return;

            var updatedConsumption = ServiceConsumptionModel();

            var existing = product_consumption_list.FirstOrDefault(s => s.service_product_id == updatedConsumption.service_product_id);

            if (existing != null)
            {
                existing.product_name = updatedConsumption.product_name;
                existing.product_id = updatedConsumption.product_id;
                existing.brand = updatedConsumption.brand;
                existing.total_usage_amount = updatedConsumption.total_usage_amount;

            }
            ClearConsumptionField();

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

   
        private void ClearConsumptionField() 
        {
            cmb_product.Hint = string.Empty;
            cmb_product.SelectedIndex = -1;
            cmb_product.Hint = "Select product";
            txt_brand.Text = string.Empty;
            txt_total_usage.Text = string.Empty;

        }
    }
}
