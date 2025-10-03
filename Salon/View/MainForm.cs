using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
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
using System.Management;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Salon.View
{
    public partial class MainForm : MaterialForm
    {
        private UserControl _userControl;
        private VatModel vatModel;
        private DiscountModel discountModel;
        private int currentOverheadId = 0;
        private UtilityModel utilityModel;

        public MainForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            DataGridViewTheme();
            _userControl = new UserControl();

            userTab.Controls.Add(_userControl);
            _userControl.Dock = DockStyle.Fill;
        }

        private void DataGridViewTheme() 
        {
            ThemeManager.StyleDataGridView(dgv_user);
            ThemeManager.StyleDataGridView(dgv_stylist);
            ThemeManager.StyleDataGridView(dgv_customer);
            ThemeManager.StyleDataGridView(dgv_category);
            ThemeManager.StyleDataGridView(dgv_sub_category);
            ThemeManager.StyleDataGridView(dgv_product);
            ThemeManager.StyleDataGridView(dgv_service);
            ThemeManager.StyleDataGridView(dgv_discount);
            ThemeManager.StyleDataGridView(dgv_supplier);
            ThemeManager.StyleDataGridView(dgv_delivery);
            ThemeManager.StyleDataGridView(dgv_inventory);
            ThemeManager.StyleDataGridView(dgv_BatchInventory);
            ThemeManager.StyleDataGridView(dgv_appointment);
            ThemeManager.StyleDataGridView(dgv_service_price);
            ThemeManager.StyleDataGridView(dgv_table_summary);
            ThemeManager.StyleDataGridView(dgv_report_table);
            ThemeManager.StyleDataGridView(dgv_inventory_report);
            ThemeManager.StyleDataGridView(dgv_expense_report);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUser();
            LoadStylist();
            LoadCustomers();
            LoadCategory();
            LoadSubCategory();
            LoadProducts();
            LoadServices();

            LoadVat();
            LoadDiscount();
            LoadSuppliers();
            LoadDelivery();
            LoadInventory();
            LoadBatchInventory();
            LoadAppointments();
            LoadServicePrices();


            // SUMMARY DASHBOARD
            LoadTotalSales();
            LoadTotalAppointments();
            LoadTotalProducts();
            LoadTotalServices();

            LoadPopularServices();

            // UTILITIES
            LoadUtility();
            LoadRent();

            // REPORTS
            FilterSalesReport();
            filterInventoryReport();
            FilterExpenseReport();
        }
        // DASHBOARD


        public void LoadTotalSales() 
        {
            var repo = new TransactionRepository();
            var controller = new TransactionController(repo);
            var total_sales = controller.GetTotalSales();

            if (total_sales != null)
            {
                lbl_total_sales.Text = total_sales.TotalSales.ToString("C2");
            }
            else 
            {
                lbl_total_sales.Text = "0.00";
            }

        }

        public void LoadTotalAppointments()
        {

            var controller = new AppointmentRepository();
            var total_appointment = controller.GetTotalAppointment();

            if (total_appointment != null)
            {
                lbl_total_appointment.Text = total_appointment.TotalAppointment.ToString();
            }
            else
            {
                lbl_total_appointment.Text = "0.00";
            }

        }
        public void LoadTotalProducts()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var total_products = controller.GetTotalProducts();

            if (total_products != null)
            {
                lbl_total_product.Text = total_products.TotalProduct.ToString();
            }
            else
            {
                lbl_total_product.Text = "0.00";
            }

        }
        public void LoadTotalServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var total_services = controller.TotalServices();

            if (total_services != null)
            {
                lbl_total_services.Text = total_services.TotalService.ToString();
            }
            else
            {
                lbl_total_services.Text = "0.00";
            }

        }

        private void dgv_table_summary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_table_summary.Columns[e.ColumnIndex].Name == "col_db_assign_staff")
            {
                var appointment = dgv_table_summary.Rows[e.RowIndex].DataBoundItem as AppointmentModel;
                using (var assignStylistForm = new AssignStylistForm(this, appointment))
                {
                    assignStylistForm.ShowDialog();
                }

            }

        }

        public void LoadPopularServices() 
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);

            foreach (var service in controller.GetPopularServices()) 
            {
                chart_popular_services.Series.Add(new PieSeries
                {
                    Title = service.ServiceName,
                    Values = new ChartValues<int> { service.bookings },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"

                });
               
            }
            chart_popular_services.LegendLocation = LegendLocation.Top;
        }
        // END OF DASHBOARD

        // USERS
        public void LoadUser()
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);
            var users = userController.GetAllUsers();

            dgv_user.AutoGenerateColumns = false;
            col_id.DataPropertyName = "user_id";
            col_first_name.DataPropertyName = "first_Name";
            col_middle_name.DataPropertyName = "middle_Name";
            col_last_name.DataPropertyName = "last_Name";
            col_birth_date.DataPropertyName = "birth_date";
            col_phone.DataPropertyName = "phone_Number";
            col_email.DataPropertyName = "email";
            col_address.DataPropertyName = "address";
            col_username.DataPropertyName = "userName";
            col_password.DataPropertyName = "password";
            col_role.DataPropertyName = "Position";

            dgv_user.DataSource = users;


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var userForm = new UserForm(this))
            {
                userForm.ShowDialog();
            }
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_user.Columns[e.ColumnIndex].Name == "btn_update")
            {

                var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;

                using (var userForm = new UserForm(this, user))
                {
                    userForm.ShowDialog();
                }



            }
            else if (dgv_user.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;


                // Ask for confirmation before delete
                if (MessageBox.Show($"Delete user {user.userName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var _repo = new UserRepository();
                    var userController = new UserController(_repo);
                    userController.DeleteUser(user.user_id);
                    LoadUser();

                }
            }
            else if (e.RowIndex >= 0 && dgv_user.Columns[e.ColumnIndex].Name == "col_view")
            {
                // Get the user object bound to this row
                var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;

                bool isViewed = true;
                using (var userForm = new UserForm(this, user, isViewed))
                {
                    userForm.ShowDialog();
                }

            }
        }
        // END OF USERS

        // STYLIST
        public void LoadStylist()
        {
            var _repo = new StylistRepository();
            var stylistController = new StylistController(_repo);
            var stylists = stylistController.GetAll();
            dgv_stylist.AutoGenerateColumns = false;
            col_stylist_id.DataPropertyName = "stylist_id";
            stylist_first_name.DataPropertyName = "firstName";
            stylist_middle_name.DataPropertyName = "middleName";
            stylist_last_name.DataPropertyName = "lastName";
            stylist_day_of_birth.DataPropertyName = "birth_date";
            stylist_contact.DataPropertyName = "contactNumber";
            stylist_email.DataPropertyName = "email";
            stylist_address.DataPropertyName = "address";
            dgv_stylist.DataSource = stylists;
        }

        private void btn_add_stylist_Click(object sender, EventArgs e)
        {
            using (var stylistForm = new StylistForm(this))
            {
                stylistForm.ShowDialog();
            }
        }

        private void dgv_stylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "stylist_btn_update")
            {

                var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;

                using (var stylistForm = new StylistForm(this, stylist))
                {
                    stylistForm.ShowDialog();
                }



            }
            else if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "stylist_btn_delete")
            {
                var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;


                // Ask for confirmation before delete
                if (MessageBox.Show($"Delete user {stylist.firstName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var _repo = new StylistRepository();
                    var stylistController = new StylistController(_repo);
                    stylistController.Delete(stylist.stylist_id);
                    LoadStylist();
                }
            }
            else if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "col_view_schedules")
            {



                var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;

                using (var stylistScheduleForm = new StylistScheduleForm(this, stylist))
                {
                    stylistScheduleForm.ShowDialog();
                }
            }
        }
        // END OF STYLIST

        // CUSTOMERS

        public void LoadCustomers()
        {
            var repo = new CustomerRepository();
            var customerController = new CustomerController(repo);
            var customers = customerController.GetAllCustomer();

            dgv_customer.AutoGenerateColumns = false;

            col_customer_id.DataPropertyName = "customer_id";
            col_customer_first_name.DataPropertyName = "firstName";
            col_customer_middle_name.DataPropertyName = "middleName";
            col_customer_last_name.DataPropertyName = "lastName";
            col_customer_contact.DataPropertyName = "phoneNumber";
            col_customer_email.DataPropertyName = "email";

            dgv_customer.DataSource = customers;


        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            using (var customerForm = new CustomerForm(this))
            {
                customerForm.ShowDialog();
            }
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_customer_btn_update")
            {
                var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;
                using (var customerForm = new CustomerForm(this, customer))
                {
                    customerForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_customer_btn_delete")
            {
                var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;

                if (MessageBox.Show($"Delete customer {customer.firstName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new CustomerRepository();
                    var customerController = new CustomerController(repo);
                    customerController.DeleteCustomer(customer.customer_id);
                    LoadCustomers();
                }
            }
        }

        // END OF CUSTOMERS

        // CATEGORY

        public void LoadCategory()
        {
            var repo = new CategoryRepository();
            var categoryController = new CategoryController(repo);
            var categories = categoryController.getAllCategory();

            dgv_category.AutoGenerateColumns = false;
            col_category_id.DataPropertyName = "category_id";
            col_category_name.DataPropertyName = "categoryName";
            col_category_type.DataPropertyName = "type";
            dgv_category.DataSource = categories;
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            using (var categoryForm = new CategoryForm(this))
            {
                categoryForm.ShowDialog();
            }
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_category.Columns[e.ColumnIndex].Name == "col_category_btn_update")
            {
                var category = dgv_category.Rows[e.RowIndex].DataBoundItem as CategoryModel;
                using (var categoryForm = new CategoryForm(this, category))
                {
                    categoryForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_category.Columns[e.ColumnIndex].Name == "col_category_btn_delete")
            {
                var category = dgv_category.Rows[e.RowIndex].DataBoundItem as CategoryModel;
                if (MessageBox.Show($"Delete category {category.categoryName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new CategoryRepository();
                    var categoryController = new CategoryController(repo);
                    categoryController.deleteCategory(category.category_id);
                    LoadCategory();
                }
            }
        }
        // END OF CATEGORY

        public void LoadSubCategory()
        {
            var repo = new SubCategoryRepository();
            var subCategoryController = new SubCategoryController(repo);
            var subCategories = subCategoryController.getSubCategory();

            dgv_sub_category.AutoGenerateColumns = false;
            col_subcategory_id.DataPropertyName = "subCategory_id";
            col_sub_cid.DataPropertyName = "category_id";
            col_sub_name.DataPropertyName = "subCategoryName";
            col_sub_category_name.DataPropertyName = "categoryName";
            dgv_sub_category.DataSource = subCategories;
        }
        private void btn_add_subcategory_Click(object sender, EventArgs e)
        {
            using (var subCategoryForm = new SubCategoryForm(this))
            {
                subCategoryForm.ShowDialog();
            }
        }

        private void dgv_sub_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_sub_category.Columns[e.ColumnIndex].Name == "col_sub_btn_update")
            {
                var subCategory = dgv_sub_category.Rows[e.RowIndex].DataBoundItem as SubCategoryModel;
                using (var subCategoryForm = new SubCategoryForm(this, subCategory))
                {
                    subCategoryForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_sub_category.Columns[e.ColumnIndex].Name == "coL_sub_btn_delete")
            {
                var subCategory = dgv_sub_category.Rows[e.RowIndex].DataBoundItem as SubCategoryModel;
                if (MessageBox.Show($"Delete sub-category {subCategory.subCategoryName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new SubCategoryRepository();
                    var subCategoryController = new SubCategoryController(repo);
                    subCategoryController.deleteSubCategory(subCategory.subCategory_id);
                    LoadSubCategory();
                }
            }
        }

        // END OF SUBCATEGORY

        // PRODUCTS

        public void LoadProducts()
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            var products = productController.getAllProduct();
            dgv_product.AutoGenerateColumns = false;
            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "productName";
            col_product_brand.DataPropertyName = "brand";
            col_product_category_id.DataPropertyName = "category_id";
            col_product_category_name.DataPropertyName = "categoryName";
            col_product_category_id.DataPropertyName = "category_id";
            col_product_category_name.DataPropertyName = "categoryName";
            col_product_unit_type.DataPropertyName = "unit_type";
            col_product_usage_type.DataPropertyName = "usage_type";
            col_product_unit_per_volume.DataPropertyName = "unit_volume";
            dgv_product.DataSource = products;
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_product.Columns[e.ColumnIndex].Name == "col_btn_product_update")
            {
                var product = dgv_product.Rows[e.RowIndex].DataBoundItem as ProductModel;
                using (var productForm = new ProductForm(this, product))
                {
                    productForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_product.Columns[e.ColumnIndex].Name == "col_btn_product_delete")
            {
                var product = dgv_product.Rows[e.RowIndex].DataBoundItem as ProductModel;
                if (MessageBox.Show($"Delete product {product.product_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ProductRepository();
                    var controller = new ProductController(repo);
                    controller.deleteProduct(product.product_id);
                    LoadProducts();
                    LoadTotalProducts();
                }
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            using (var productForm = new ProductForm(this))
            {
                productForm.ShowDialog();
            }
        }
        // END OF PRODUCTS

        // SERVICES

        public void LoadServices()
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            var services = serviceController.getServices();
            dgv_service.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_service_name.DataPropertyName = "serviceName";
            col_service_sid.DataPropertyName = "subCategory_id";
            col_service_subcategory.DataPropertyName = "subCategoryName";
            col_service_duration.DataPropertyName = "duration";
            col_service_status.DataPropertyName = "status";
            dgv_service.DataSource = services;
        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            using (var serviceForm = new ServiceForm(this))
            {
                serviceForm.ShowDialog();
            }
        }

        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_service.Columns[e.ColumnIndex].Name == "col_service_product_usage")
            {
                var service = dgv_service.Rows[e.RowIndex].DataBoundItem as ServiceModel;
                using (var serviceProductUsageForm = new ProductUsageForm(this, service))
                {
                    serviceProductUsageForm.ShowDialog();
                }

            }
            else if (e.RowIndex >= 0 && dgv_service.Columns[e.ColumnIndex].Name == "col_service_btn_update")
            {
                var service = dgv_service.Rows[e.RowIndex].DataBoundItem as ServiceModel;
                using (var serviceForm = new ServiceForm(this, service))
                {
                    serviceForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_service.Columns[e.ColumnIndex].Name == "col_service_btn_delete")
            {
                var service = dgv_service.Rows[e.RowIndex].DataBoundItem as ServiceModel;
                if (MessageBox.Show($"Delete product {service.serviceName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ServiceRepository();
                    var controller = new ServiceController(repo);
                    controller.deleteService(service.serviceName_id);
                    LoadServices();
                }
            }
        }

        // END OF SERVICES


        // VAT AND DISCOUNT
        private void LoadVat()
        {
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);
            var tax = tax_controller.LoadLatestTax();

            if (tax != null)
            {
                vatModel = tax;

                txt_vat.Text = tax.tax.ToString();
            }
            else
            {

                txt_vat.Text = "0.00";
            }

        }
        private void LoadDiscount()
        {
            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var discounts = discount_controller.getAllDiscount();
            dgv_discount.AutoGenerateColumns = false;
            col_discount_id.DataPropertyName = "discount_id";
            col_discount_type.DataPropertyName = "discount_type";
            col_promo_code.DataPropertyName = "promo_code";
            col_discount_rate.DataPropertyName = "discount_rate";
            dgv_discount.DataSource = discounts;



        }


        private void AddOrUpdateVat()
        {
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);
            var tax_exists = tax_controller.checkTax();

            int tax_rate = Convert.ToInt32(txt_vat.Text.Trim());
            if (tax_exists == 1)
            {

                int tax_id = vatModel.tax_id;

                vatModel.tax_id = tax_id;
                vatModel.tax = tax_rate;
                if (MessageBox.Show($"Are you sure you want to update {txt_vat.Text}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Tax updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tax_controller.UpdateTax(vatModel);
                    LoadVat();
                }


            }
            else
            {
                var tax_model = new VatModel
                {
                    tax = tax_rate
                };
                MessageBox.Show("Tax created succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tax_controller.CreateTax(tax_model);
                LoadVat();


            }
        }
        private void btn_apply_Click(object sender, EventArgs e)
        {
            AddOrUpdateVat();
        }
        private void clear_discount_fields()
        {
            cmb_discount_type.Hint = string.Empty;
            cmb_discount_type.SelectedIndex = -1;
            txt_promo_code.Text = string.Empty;
            txt_discount.Text = string.Empty;
            btn_add_discount.Visible = true;
            btn_update_discount.Visible = false;
            btn_cancel_discount.Visible = false;
            cmb_discount_type.Hint = "Select Discount Type";
        }
        private void AddDiscount()
        {
            string promo_code = "";

            if (!string.IsNullOrWhiteSpace(txt_promo_code.Text))
            {
                promo_code = txt_promo_code.Text.Trim();
            }
            else
            {
                promo_code = "N/A";
            }

            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var discount = new DiscountModel
            {
                discount_type = cmb_discount_type.Text,
                promo_code = promo_code,
                discount_rate = Convert.ToInt32(txt_discount.Text)
            };
            discount_controller.AddDiscount(discount);
            MessageBox.Show("Discount added succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDiscount();

        }

        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            AddDiscount();
            clear_discount_fields();
        }

        private void UpdateDiscount()
        {
            string promo_code = "";
            if (!string.IsNullOrWhiteSpace(txt_promo_code.Text))
            {
                promo_code = txt_promo_code.Text.Trim();
            }
            else
            {
                promo_code = "N/A";
            }
            discountModel.discount_type = cmb_discount_type.Text;
            discountModel.promo_code = promo_code;
            discountModel.discount_rate = Convert.ToInt32(txt_discount.Text);
            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            if (MessageBox.Show($"Are you sure you want to update {discountModel.discount_type}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                discount_controller.UpdateDiscount(discountModel);
                MessageBox.Show("Discount updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDiscount();
                clear_discount_fields();
            }
        }

        private void btn_update_discount_Click(object sender, EventArgs e)
        {
            UpdateDiscount();
        }

        private void btn_cancel_discount_Click(object sender, EventArgs e)
        {
            clear_discount_fields();
            btn_add_discount.Visible = true;
            btn_update_discount.Visible = false;
            btn_cancel_discount.Visible = false;

        }

        private void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_discount.Columns[e.ColumnIndex].Name == "col_discount_update")
            {
                discountModel = dgv_discount.Rows[e.RowIndex].DataBoundItem as DiscountModel;
                cmb_discount_type.Hint = string.Empty;
                cmb_discount_type.Text = discountModel.discount_type;
                if (discountModel.discount_type.ToLower() == "promo")
                {
                    txt_promo_code.Visible = true;
                    txt_promo_code.Text = discountModel.promo_code;
                }
                else
                {
                    txt_promo_code.Visible = false;
                    txt_promo_code.Text = "N/A";
                }
                txt_discount.Text = discountModel.discount_rate.ToString();
                cmb_discount_type.Hint = "Select Discount Type";
                btn_add_discount.Visible = false;
                btn_update_discount.Visible = true;
                btn_cancel_discount.Visible = true;


            }
            else if (e.RowIndex >= 0 && dgv_discount.Columns[e.ColumnIndex].Name == "coL_discount_delete")
            {
                discountModel = dgv_discount.Rows[e.RowIndex].DataBoundItem as DiscountModel;

                if (MessageBox.Show($"Delete discount {discountModel.discount_type}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new DiscountRepository();
                    var controller = new DiscountController(repo);
                    controller.DeleteDiscount(discountModel.discount_id);
                    LoadDiscount();
                }
            }
        }

        private void cmb_discount_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_discount_type.Text.ToLower() == "promo")
            {
                txt_promo_code.Visible = true;
            }
            else
            {
                txt_promo_code.Visible = false;
            }
        }

        // END OF VAT AND DISCOUNT


        public void LoadSuppliers()
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            var suppliers = controller.GetAllSuppliers();
            dgv_supplier.AutoGenerateColumns = false;
            col_supplier_id.DataPropertyName = "supplier_id";
            col_supplier_name.DataPropertyName = "supplier_name";
            col_supplier_contact.DataPropertyName = "contact";
            col_supplier_email.DataPropertyName = "email";
            col_supplier_address.DataPropertyName = "address";
            dgv_supplier.DataSource = suppliers;
        }
        private void btn_add_supplier_Click(object sender, EventArgs e)
        {
            using (var supplierForm = new SupplierForm(this))
            {
                supplierForm.ShowDialog();
            }
        }

        private void dgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_supplier.Columns[e.ColumnIndex].Name == "col_supplier_update")
            {
                var supplier = dgv_supplier.Rows[e.RowIndex].DataBoundItem as SupplierModel;
                using (var supplierForm = new SupplierForm(this, supplier))
                {
                    supplierForm.ShowDialog();
                }

            }
            else if (e.RowIndex >= 0 && dgv_supplier.Columns[e.ColumnIndex].Name == "col_supplier_delete")
            {
                var supplier = dgv_supplier.Rows[e.RowIndex].DataBoundItem as SupplierModel;
                if (MessageBox.Show($"Delete product {supplier.supplier_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new SupplierRepository();
                    var controller = new SupplierController(repo);
                    controller.DeleteSupplier(supplier.supplier_id);
                    LoadSuppliers();
                }
            }
        }

        // END OF SUPPLIERS

        // DELIVERY

        public void LoadDelivery()
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);
            var deliveries = controller.GetAllDelivery();
            dgv_delivery.AutoGenerateColumns = false;
            col_delivery_id.DataPropertyName = "delivery_id";
            col_delivery_supplier_id.DataPropertyName = "supplier_id";
            col_delivery_supplier.DataPropertyName = "supplier_name";
            col_delivery_date.DataPropertyName = "date";
            col_delivery_invoice.DataPropertyName = "invoice";
            col_delivery_received_by.DataPropertyName = "received_by";
            dgv_delivery.DataSource = deliveries;
        }

        private void btn_add_delivery_Click(object sender, EventArgs e)
        {
            using (var deliveryForm = new DeliveryForm(this))
            {
                deliveryForm.ShowDialog();
            }
        }

        private void dgv_delivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_delivery.Columns[e.ColumnIndex].Name == "col_delivery_view_items")
            {
                int delivery_id = Convert.ToInt32(dgv_delivery.Rows[e.RowIndex].Cells["col_delivery_id"].Value);
                using (var addStockForm = new DeliveryAddStockForm(this, delivery_id))
                {
                    addStockForm.ShowDialog();
                }

            }
        }
        // END OF DELIVERY

        // INVENTORY

        public void LoadInventory()
        {

            var repo = new InventoryRepository();
            var inventoryController = new InventoryController(repo);
            var inventory = inventoryController.GetAllInventory();
            dgv_inventory.AutoGenerateColumns = false;
            col_InventoryID.DataPropertyName = "inventory_id";
            col_ProductID.DataPropertyName = "product_id";
            col_ProductName.DataPropertyName = "product_name";
            col_Brand.DataPropertyName = "brand";
            col_Category.DataPropertyName = "category";
            col_Unit.DataPropertyName = "unit";
            col_volume_per_unit.DataPropertyName = "volume_per_unit";
            col_Volume.DataPropertyName = "volume";
            col_Critical_Level.DataPropertyName = "critical_level";
            col_Status.DataPropertyName = "status";


            dgv_inventory.DataSource = inventory;
        }

        public void LoadBatchInventory()
        {
            dgv_BatchInventory.AutoGenerateColumns = false;

            var _repo = new InventoryBatchRepository();
            var inventoryBatchController = new InventoryBatchController(_repo);

            col_BatchID.DataPropertyName = "batch_id";
            col_DeliveryItemID.DataPropertyName = "delivery_item_id";
            col_ProductID.DataPropertyName = "product_id";
            col_ProdName.DataPropertyName = "product_name";
            col_Quantity.DataPropertyName = "unit";
            col_volume_per_qtn.DataPropertyName = "volume_per_unit";
            col_vol.DataPropertyName = "volume";
            col_price.DataPropertyName = "price";
            col_notes.DataPropertyName = "notes";
            col_DateReceived.DataPropertyName = "delivered_date";
            col_ExpiryDate.DataPropertyName = "expiry_date";


            dgv_BatchInventory.DataSource = inventoryBatchController.GetAllBatchInventory();
        }

        // END OF INVENTORY

        // APPOINTMENT

        public void LoadAppointments()
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);
            var appointments = controller.LoadAppointments();
            dgv_appointment.AutoGenerateColumns = false;
            dgv_table_summary.AutoGenerateColumns = false;
          
            appointment_id.DataPropertyName = "AppointmentId";
            customer_id.DataPropertyName = "CustomerId";
            customerName.DataPropertyName = "CustomerName";
            stylist_id.DataPropertyName = "StylistId";
            stylistName.DataPropertyName = "StylistName";
            date.DataPropertyName = "AppointmentDate";
            startTime.DataPropertyName = "StartTime";
            endTime.DataPropertyName = "EndTime";
            status.DataPropertyName = "Status";
            paymentStatus.DataPropertyName = "PaymentStatus";
            col_book_type.DataPropertyName = "BookingType";
            dgv_appointment.DataSource = appointments;
        

            // DASHBOARD
            col_db_app_id.DataPropertyName = "AppointmentId";
            col_db_customer_id.DataPropertyName = "CustomerId";
            col_db_customer_name.DataPropertyName = "CustomerName";
            col_db_stylist_id.DataPropertyName = "StylistId";
            col_db_stylist_name.DataPropertyName = "StylistName";
            col_db_date.DataPropertyName = "AppointmentDate";
            col_db_start_time.DataPropertyName = "StartTime";
            col_db_end_time.DataPropertyName = "EndTime";
            col_db_status.DataPropertyName = "Status";
            col_db_payment_status.DataPropertyName = "PaymentStatus";
            col_db_booking_type.DataPropertyName = "BookingType";
            dgv_table_summary.DataSource = appointments;
        }

        private void btn_add_appointment_Click(object sender, EventArgs e)
        {
            using (var appointmentForm = new AppointmentForm(this))
            {
                appointmentForm.ShowDialog();
            }
        }

        private void dgv_appointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_appointment.Columns[e.ColumnIndex].Name == "col_assign_staff")
            {
                var appointment = dgv_appointment.Rows[e.RowIndex].DataBoundItem as AppointmentModel;
                using (var assignStylistForm = new AssignStylistForm(this, appointment))
                {
                    assignStylistForm.ShowDialog();
                }

            }
            else if (e.RowIndex >= 0 && dgv_appointment.Columns[e.ColumnIndex].Name == "col_pay")
            {
                var appointment = dgv_appointment.Rows[e.RowIndex].DataBoundItem as AppointmentModel;
                using (var paymentForm = new PaymentForm(this, appointment))
                {
                    paymentForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_appointment.Columns[e.ColumnIndex].Name == "col_appointment_status")
            {
                var appointment = dgv_appointment.Rows[e.RowIndex].DataBoundItem as AppointmentModel;
                using (var appointmentStatusForm = new AppointmentStatusForm(this, appointment))
                {
                    appointmentStatusForm.ShowDialog();
                }
            }



        }

        // END OF APPOINTMENT

        // PRICE MAINTENANCE

        private void btn_add_price_Click(object sender, EventArgs e)
        {
            using (var priceServiceForm = new PricingServiceForm(this)) 
            {
                priceServiceForm.ShowDialog();
            }
        }
        
        public void LoadServicePrices() 
        {
            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);
            var services = controller.ShowAllServices();

            dgv_service_price.AutoGenerateColumns = false;
            col_price_id.DataPropertyName = "pricing_id";
            col_service_price_name.DataPropertyName = "serviceName";
            col_service_product_id.DataPropertyName = "service_product_id";
            col_product_cost.DataPropertyName = "product_cost";
            col_stylist_cost.DataPropertyName = "stylist_cost";
            col_overhead_cost.DataPropertyName = "overhead_cost";
            col_total_cost.DataPropertyName = "total_cost";
            col_selling_price.DataPropertyName = "selling_price";
            col_vat_amount.DataPropertyName = "vat_amount";
            col_net_price.DataPropertyName = "net_price";
            col_net_profit.DataPropertyName = "net_profit";
            col_gross_profit.DataPropertyName = "gross_profit";
            col_profit_percent.DataPropertyName = "profit_percent";
            dgv_service_price.DataSource = services;
        }

        private void dgv_service_price_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_service_price.Columns[e.ColumnIndex].Name == "col_price_update")
            {
                var servicePrice = dgv_service_price.Rows[e.RowIndex].DataBoundItem as ServicePriceModel;
                using (var priceServiceForm = new PricingServiceForm(this, servicePrice))
                {
                    priceServiceForm.ShowDialog();
                }

            }
            else if (e.RowIndex >= 0 && dgv_service_price.Columns[e.ColumnIndex].Name == "col_price_delete")
            {
                var servicePrice = dgv_service_price.Rows[e.RowIndex].DataBoundItem as ServicePriceModel;

                if (MessageBox.Show($"Are you sure you want to delete {servicePrice.serviceName}?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    var repo = new ServicePriceRepository();
                    var controller = new ServicePriceController(repo);

                    controller.DeleteServicePrice(servicePrice.pricing_id);

                    MessageBox.Show("Delete success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServicePrices();

                }
            }
          
        }
        // END OF SERVICE PRICE


        // UTILITIES
        private void btn_add_utility_Click(object sender, EventArgs e)
        {
            using (var utilityForm = new UtilityForm(this)) 
            {
                utilityForm.ShowDialog();
            }
        }

        public void LoadUtility()
        {
            CheckTotalUtil();
           
            var repo = new UtilityRepository();
            var controller = new UtilController(repo);
            var utility = controller.GetAllUtility();

            decimal total = 0;

            foreach (var util in utility)
            {
                total += util.util_text;
                // Create a container panel
             

                // Create the textbox
                MaterialTextBox txtAmount = new MaterialTextBox
                {
                    Hint = util.util_name,
                    Text = util.util_text.ToString("N2"),
                    Width = 300,
                    Height = 50,
                    Location = new Point(0, 5)
                };

                // Create the update button
                MaterialButton btnUpdate = new MaterialButton
                {
                    Text = "Update",
                    Width = 50,
                    Height = 50,
                    Location = new Point(txtAmount.Right + 25, 10)
                };

                // Create the remove button
                MaterialButton btnRemove = new MaterialButton
                {
                    Text = "Remove",
                    Width = 50,
                    Height = 50,
                    Location = new Point(btnUpdate.Right + 50, 10)
                };

                // Wire up remove logic
                btnRemove.Click += (s, e) =>
                {
                    var confirm = MessageBox.Show("Remove this utility?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        controller.RemoveUtility(util.util_id);
                        LoadUtility();
                    }
                };

                // Wire up update logic
                btnUpdate.Click += (s, e) =>
                {
                    if (decimal.TryParse(txtAmount.Text, out decimal newAmount))
                    {
                        util.util_text = newAmount; // 🔥 Update the model with new value

                        using (var utilityForm = new UtilityForm(this, util))
                        {
                            utilityForm.ShowDialog();
                        }
                    }

                   
                };

               
                // Add panel to flow layout
               
            }// End of forloop

            txt_total_utility.Text = total.ToString("N2");


        }

       
        private void LoadRent() 
        {
            var repo = new OverHeadRepository();
            var controller = new OverHeadController(repo);
            var overhead = controller.GetOverHeadTotal();

         
            if (overhead != null && overhead.monthly_rent != 0)
            {
                currentOverheadId = overhead.over_head_id; // 🔥 Store ID
                txt_month_rent.Text = overhead.monthly_rent.ToString("N2");
                txt_working_hours.Text = overhead.total_working_hours.ToString();
                
            }
            else
            {
                currentOverheadId = 0;
                
                txt_month_rent.Text = "0.00";
            }



        }
        private void CheckTotalUtil() 
        {
            var repo = new UtilityRepository();
            var controller = new UtilController(repo);
            var total_utility = controller.TotalUtility();

            if (total_utility.total_util >= 7)
            {
               
            }
            else 
            {
           
            }
        }

        private void Calculate_Util_Total_Amount() 
        {
            decimal total_util = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;

            decimal.TryParse(txt_total_utility.Text, out total_util);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);

            total_util = electric_bill + water_bill + internet_bill + other_bill;
            txt_total_utility.Text = total_util.ToString("N2");
        }
        private void CalculateTotal()
        {
            decimal total_util = 0;
            decimal month_rent = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;

            decimal.TryParse(txt_total_utility.Text, out total_util);
            decimal.TryParse(txt_month_rent.Text, out month_rent);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);

            decimal total_cost = month_rent + total_util;
            lbl_total_cost.Text = total_cost.ToString("N2");
        }
        private void txt_electric_bill_TextChanged(object sender, EventArgs e)
        {
            Calculate_Util_Total_Amount();
        }

        private void txt_water_bill_TextChanged(object sender, EventArgs e)
        {
            Calculate_Util_Total_Amount();
        }

        private void txt_internet_bill_TextChanged(object sender, EventArgs e)
        {
            Calculate_Util_Total_Amount();
        }

        private void txt_other_bill_TextChanged(object sender, EventArgs e)
        {
            Calculate_Util_Total_Amount();
        }
        private void txt_month_rent_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_total_utility_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void btn_edit_bill_Click_1(object sender, EventArgs e)
        {
            btn_add_bill.Visible = false;
            btn_edit_bill.Visible = false;
            btn_save_changes.Visible = true;
            btn_cancel_bill.Visible = true;
        }
        private void btn_cancel_bill_Click_1(object sender, EventArgs e)
        {
            btn_add_bill.Visible = true;
            btn_edit_bill.Visible = true;
            btn_save_changes.Visible = false;
            btn_cancel_bill.Visible = false;
        }
 

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            decimal total_util = 0;
            decimal month_rent = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;
            string notes_bill = "";
            decimal total_cost = 0;
            int total_working_hrs = 0;

            decimal.TryParse(txt_total_utility.Text, out total_util);
            decimal.TryParse(txt_month_rent.Text, out month_rent);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);
            decimal.TryParse(lbl_total_cost.Text, out total_cost);
            int.TryParse(txt_working_hours.Text, out total_working_hrs);

            notes_bill = txt_bill_note.Text;

            var repo = new OverHeadRepository();
            var controller = new OverHeadController(repo);

            var model = new OverHeadModel
            {
                over_head_id = currentOverheadId,
                monthly_rent = month_rent,
                electricity_bill = electric_bill,
                water_bill = water_bill,
                internet_bill = internet_bill,
                other_bill = other_bill,
                notes = notes_bill,
                utilities_amount = total_util,
                total_over_head = total_cost,
                total_working_hours = total_working_hrs,

            };

            controller.Update(model);
            AddOrUpdateExpense("Utilities", "Updated Monthly Rent & Bills", total_cost, UserSession.CurrentUser.first_Name, "", DateTime.Now);
            LoadRent();
        }
        private void btn_add_bill_Click(object sender, EventArgs e)
        {
            decimal total_util = 0;
            decimal month_rent = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;
            string notes_bill = "";
            decimal total_cost = 0;
            int total_working_hrs = 0;

            decimal.TryParse(txt_total_utility.Text, out total_util);
            decimal.TryParse(txt_month_rent.Text, out month_rent);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);
            decimal.TryParse(lbl_total_cost.Text, out total_cost);
            int.TryParse(txt_working_hours.Text, out total_working_hrs);

            notes_bill = txt_bill_note.Text;

            var repo = new OverHeadRepository();
            var controller = new OverHeadController(repo);

            var model = new OverHeadModel
            {
                monthly_rent = month_rent,
                electricity_bill = electric_bill,
                water_bill = water_bill,
                internet_bill = internet_bill,
                other_bill = other_bill,
                notes = notes_bill,
                utilities_amount = total_util,
                total_over_head = total_cost,
                total_working_hours = total_working_hrs,

            };

            controller.Add(model);
            AddOrUpdateExpense("Utilities", "Created Monthly Rent & Bills", total_cost, UserSession.CurrentUser.first_Name, "", DateTime.Now);
            LoadRent();

        }
        private void AddOrUpdateExpense(string category, string description, decimal amount, string paid_by, string notes, DateTime timestamp)
        {
            var repo = new ExpensesRepository();
            var controller = new ExpensesController(repo);

            var model = new ExpensesModel
            {
                category = category,
                description = description,
                amount = amount,
                paid_by = paid_by,
                notes = notes,
                timestamp = timestamp
            };

            if (controller.Is_UtilityExists(category))
            {
                controller.UpdateExpense(model);
            }
            else 
            {
                controller.AddExpenses(model);
            }

        }

       

        // END OF UTILITIES

        // SALES REPORT
        private void FilterSalesReport()
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_sales_report_range.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {
                // No preset selected — use DateTimePicker values
                startDate = dtp_report_start_date.Value.Date;
                endDate = dtp_report_end_date.Value.Date;
            }
            else
            {
                switch (selectedRange)
                {
                    case "today":
                        startDate = DateTime.Today;
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;

                    case "weekly":
                        startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                        endDate = startDate.AddDays(6).AddDays(1).AddTicks(-1);
                        break;

                    case "monthly":
                        startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        endDate = startDate.AddMonths(1).AddTicks(-1);
                        break;

                    default:
                        MessageBox.Show("Invalid range selected.");
                        return;
                }

                // Optional: update DateTimePickers to reflect the selected range
                dtp_report_start_date.Value = startDate;
                dtp_report_end_date.Value = endDate;
            }

            LoadSalesReports(startDate, endDate);
        }

        private void LoadSalesReports(DateTime? startDate = null, DateTime? endDate = null) 
        {
            var repo = new TransactionRepository();
            var controller = new TransactionController(repo);

            var dgv_sales = (startDate.HasValue && endDate.HasValue)
               ? controller.ShowAllTransactions(startDate.Value, endDate.Value)
               : controller.ShowAllTransactions();

            var sales_summary = (startDate.HasValue && endDate.HasValue)
               ? controller.SalesReportSummary(startDate.Value, endDate.Value)
               : controller.SalesReportSummary();

            if (sales_summary != null && dgv_sales != null)
            {
                lbl_report_total_sales.Text = sales_summary.total_sales.ToString("C2");
                lbl_report_total_vat.Text = sales_summary.total_vat.ToString("C2");
                lbl_report_total_discount.Text = sales_summary.total_discount.ToString("C2");
                lbl_report_total_transaction.Text = sales_summary.total_transaction.ToString("N2");
                lbl_report_total_cash.Text = sales_summary.cash_total.ToString("C2");
                lbl_report_total_gcash.Text = sales_summary.gcash_total.ToString("C2");


                dgv_report_table.AutoGenerateColumns = false;
                col_transaction_id.DataPropertyName = "transaction_id";
                col_report_appointment_id.DataPropertyName = "appointment_id";
                col_report_amount_paid.DataPropertyName = "amount_paid";
                col_report_vat_amount.DataPropertyName = "vat_amount";
                col_report_discount_amount.DataPropertyName = "discount_amount";
                col_report_payment_method.DataPropertyName = "payment_method";
                col_report_date.DataPropertyName = "timestamp";
                dgv_report_table.DataSource = dgv_sales;
            }
            else 
            {
                lbl_report_total_sales.Text = "0.00";
                lbl_report_total_vat.Text = "0.00";
                lbl_report_total_discount.Text = "0.00";
                lbl_report_total_transaction.Text = "0.00";
                lbl_report_total_cash.Text = "0.00";
                lbl_report_total_gcash.Text = "0.00";
            }
        }

        private void btn_report_filter_Click(object sender, EventArgs e)
        {
            cmb_sales_report_range.Hint = string.Empty;
            cmb_sales_report_range.SelectedIndex = -1;
            FilterSalesReport();

            cmb_sales_report_range.Hint = "Select Range";
        }

        private void cmb_sales_report_range_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sales_report_range != null)
            {
                FilterSalesReport();
            }
        }

        private void btn_report_clear_Click(object sender, EventArgs e)
        {
            cmb_sales_report_range.Hint = string.Empty;
            dtp_report_start_date.Value = DateTime.Today;
            dtp_report_end_date.Value = DateTime.Today;
            cmb_sales_report_range.SelectedIndex = -1;
            FilterSalesReport();

            cmb_sales_report_range.Hint = "Select Range";
        }

        // END OF SALES REPORT

        // INVENTORY REPORT
        private void filterInventoryReport() 
        {
            string status = "";

            string selectedStockLevel = cmb_stock_status.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedStockLevel))
            {
                LoadInventoryReport(status);
            }
            else
            {
                switch (selectedStockLevel)
                {
                    case "in stock":
                        status = "In Stock";
                        break;

                    case "low stock":
                        status = "Low Stock";
                        break;

                    case "out of stock":
                        status = "Out of Stock";
                        break;

                    default:
                        MessageBox.Show("Invalid range selected.");
                        return;
                }

    
            }

            LoadInventoryReport(status);
        }

        private void LoadInventoryReport(string status = null) 
        {
            var repo = new InventoryRepository();
            var controller = new InventoryController(repo);


            var inventory_summary = (status.Length > 0) ? controller.GetInventorySummaryReport(status) : controller.GetInventorySummaryReport();
            var dgv_inventory = (status.Length > 0) ? controller.GetAllInventory(status) : controller.GetAllInventory();


            if (inventory_summary != null && dgv_inventory != null)
            {
                lbl_inventory_total_product.Text = inventory_summary.total_products.ToString();
                lbl_inventory_total_volume.Text = inventory_summary.total_volume.ToString();
                lbl_inventory_stock_item.Text = inventory_summary.in_stock_items.ToString();
                lbl_inventory_low_stock.Text = inventory_summary.low_stock_items.ToString();
                lbl_inventory_out_of_stock.Text = inventory_summary.out_of_stock_items.ToString();

                dgv_inventory_report.AutoGenerateColumns = false;

                col_inventory_id.DataPropertyName = "inventory_id";
                col_inventory_product_id.DataPropertyName = "product_id";
                col_inventory_product_name.DataPropertyName = "product_name";
                col_inventory_unit.DataPropertyName = "unit";
                col_inventory_volume.DataPropertyName = "volume_per_unit";
                col_inventory_total_volume.DataPropertyName = "volume";
                col_inventory_critical_level.DataPropertyName = "critical_level";
                col_inventory_status.DataPropertyName = "status";

                dgv_inventory_report.DataSource = dgv_inventory;


            }
            else 
            {
                lbl_inventory_total_product.Text = "0.00";
                lbl_inventory_total_volume.Text = "0.00";
                lbl_inventory_stock_item.Text = "0.00";
                lbl_inventory_low_stock.Text = "0.00";
                lbl_inventory_out_of_stock.Text = "0.00";
            }
        }

        private void cmb_stock_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
    
            filterInventoryReport();

          
        }

        private void btn_inventory_clear_Click(object sender, EventArgs e)
        {
            cmb_stock_status.Hint = string.Empty;
            cmb_stock_status.SelectedIndex = -1;
            filterInventoryReport();
            cmb_stock_status.Hint = "Select Stock Status";
        }

        // END OF INVENTORY REPORT

        private void FilterExpenseReport() 
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_expense_range.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {
          
                startDate = dtp_expense_start_date.Value.Date;
                endDate = dtp_expense_end_date.Value.Date;
            }
            else
            {
                switch (selectedRange)
                {
                    case "today":
                        startDate = DateTime.Today;
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;

                    case "weekly":
                        startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                        endDate = startDate.AddDays(6).AddDays(1).AddTicks(-1);
                        break;

                    case "monthly":
                        startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        endDate = startDate.AddMonths(1).AddTicks(-1);
                        break;

                    default:
                        MessageBox.Show("Invalid range selected.");
                        return;
                }

                // Optional: update DateTimePickers to reflect the selected range
                dtp_expense_start_date.Value = startDate;
                dtp_expense_end_date.Value = endDate;
            }

            LoadExpenseReport(startDate, endDate);
            LoadExpenseReportSummary(startDate, endDate);
        }
        private void LoadExpenseReport(DateTime? startDate = null, DateTime? endDate = null) 
        {
            var repo = new ExpensesRepository();
            var controller = new ExpensesController(repo);

            var dgv_expense = (startDate.HasValue && endDate.HasValue)
              ? controller.GetAllExpenses(startDate.Value, endDate.Value)
              : controller.GetAllExpenses();

            if (dgv_expense != null) 
            {
                dgv_expense_report.AutoGenerateColumns = false;
                col_expense_id.DataPropertyName = "id";
                col_expense_category.DataPropertyName = "category";
                col_expense_description.DataPropertyName = "description";
                col_expense_amount.DataPropertyName = "amount";
                col_expense_paid_by.DataPropertyName = "paid_by";
                col_expense_notes.DataPropertyName = "notes";
                col_expense_date.DataPropertyName = "timestamp";

                dgv_expense_report.DataSource = dgv_expense;
            }
        

        }

        private void LoadExpenseReportSummary(DateTime? startDate = null, DateTime? endDate = null)
        {
            var repo = new ExpensesRepository();
            var controller = new ExpensesController(repo);

            var expenseSummary = (startDate.HasValue && endDate.HasValue)
              ? controller.GetSummaryExpenses(startDate.Value, endDate.Value)
              : controller.GetSummaryExpenses();


            if (expenseSummary != null)
            {
                lbl_expense_total.Text = expenseSummary.TotalExpense.ToString("C2");
                lbl_expense_inventory_total.Text = expenseSummary.TotalPurchaseInventory.ToString("C2");
                lbl_expense_utility_total.Text = expenseSummary.TotalUtilities.ToString("C2");
                lbl_expense_supplies.Text = expenseSummary.TotalSupplies.ToString("C2");

            }
            else 
            {
                lbl_expense_total.Text = "0.00";
                lbl_expense_supplies.Text = "0.00";
                lbl_expense_inventory_total.Text = "0.00";
                lbl_expense_utility_total.Text = "0.00";
            }




        }

        private void cmb_expense_range_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_expense_range != null)
            {
                FilterExpenseReport();
            }
        }

        private void btn_expense_filter_Click(object sender, EventArgs e)
        {
            FilterExpenseReport();
        }

        private void btn_expense_clear_Click(object sender, EventArgs e)
        {
            cmb_expense_range.Hint = string.Empty;
            cmb_expense_range.SelectedIndex = -1;
            dtp_expense_start_date.Value = DateTime.Today;
            dtp_expense_end_date.Value = DateTime.Today;
            FilterExpenseReport();
            cmb_expense_range.Hint = "Select Range";
        }
    }
}

