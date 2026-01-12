using Google.Protobuf.WellKnownTypes;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.XMP.Impl;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Laundry.Data;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Org.BouncyCastle.Asn1.Cmp;
using Salon.Card;
using Salon.Controller;
using Salon.Models;
using Salon.ReportForm;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;
using ZstdSharp.Unsafe;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace Salon.View
{
    public partial class MainForm : MaterialForm
    {
        public OwnderEmailRepository owner_repo = new OwnderEmailRepository();
        public OwnerEmailController owner_controller;

        private bool _isRefreshing = false;
        private UserControl _userControl;
        private VatModel vatModel;
        private DiscountModel discountModel;
        private int currentOverheadId = 0;
        private UtilityModel utilityModel;
        private readonly LoginForm loginForm;

        private int currentPage = 1;
        private int pageSize = 25;
        private int totalPages = 0;

        List<string> notificationTypes = new List<string>();
        private BindingList<RetailProduct> cart = new BindingList<RetailProduct>();


        public MainForm(LoginForm login)
        {
            InitializeComponent();
            loginForm = login;

            ThemeManager.ApplyTheme(this);


            DataGridViewTheme();





            //_userControl = new UserControl();

            //userTab.Controls.Add(_userControl);
            //_userControl.Dock = DockStyle.Fill;



        }
        public void ExpiredPromo() 
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            controller.MarkExpiredPromo();

            LoadDiscount();
        }
        private void DataGridViewTheme()
        {
            ThemeManager.StyleDataGridView(dgv_user);
            ThemeManager.StyleDataGridView(dgv_stylist);
            ThemeManager.StyleDataGridView(dgv_customer);
            ThemeManager.StyleDataGridView(dgv_category);
            ThemeManager.StyleDataGridView(dgv_sub_category);
            ThemeManager.StyleDataGridView(dgv_product);
            ThemeManager.StyleDataGridView(dgv_retail_product);
            ThemeManager.StyleDataGridView(dgv_service);
            ThemeManager.StyleDataGridView(dgv_discount);
            ThemeManager.StyleDataGridView(dgv_payment_method);
            ThemeManager.StyleDataGridView(dgv_supplier);
            ThemeManager.StyleDataGridView(dgv_delivery);
            ThemeManager.StyleDataGridView(dgv_inventory);
            ThemeManager.StyleDataGridView(dgv_walk_in);
            ThemeManager.StyleDataGridView(dgv_appointment);
            ThemeManager.StyleDataGridView(dgv_table_summary);
            ThemeManager.StyleDataGridView(dgv_report_table);
            ThemeManager.StyleDataGridView(dgv_inventory_report);

          

            ThemeManager.StyleDataGridView(dgv_transaction_list);
            ThemeManager.StyleDataGridView(dgv_audit_report);
            ThemeManager.StyleDataGridView(dgv_deleted_record);
            ThemeManager.StyleDataGridView(dgv_cart_product);
        }

        public void LowOrOutOfStock()
        {
            var inventoryRepo = new InventoryRepository();
            var inventoryController = new InventoryController(inventoryRepo);

            string message = "";

            // 🔍 Check for low/out-of-stock items
            int lowOrOutCount = inventoryController.GetLowOrOutOfStock();
            if (lowOrOutCount > 0)
            {
                notificationTypes.Add("inventory");


                message += $"⚠️ {lowOrOutCount} item(s) are low or out of stock.\n";

            }
            if (!string.IsNullOrEmpty(message))
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.ShowBalloonTip(3000);
            }
        }


        private void MinAndMaxDate()
        {
            var MinStartDate = DateTime.Today.AddYears(-2);
            var MaxStartDate = DateTime.Today;

            var MinEndDate = MinStartDate;
            var MaxEndDate = DateTime.Today.AddMonths(3);


            // SALES REPORT
            dtp_report_start_date.MinDate = MinStartDate;
            dtp_report_start_date.MaxDate = MaxStartDate;

            dtp_report_end_date.MinDate = MinEndDate;
            dtp_report_end_date.MaxDate = MaxEndDate;

         


          


         


            // ADUIT REPORT
            dtp_audit_start.MinDate = MinStartDate;
            dtp_audit_start.MaxDate = MaxStartDate;

            dtp_audit_end.MinDate = MinEndDate;
            dtp_audit_end.MaxDate = MaxEndDate;

            // TRANSACTION HISTORY
            dtp_transaction_start.MinDate = MinStartDate;
            dtp_transaction_start.MaxDate = MaxStartDate;

            dtp_transaction_end.MinDate = MinEndDate;
            dtp_transaction_end.MaxDate = MaxEndDate;



            // DELETED RECORD HISTORY
            dtp_delete_record_start.MinDate = MinStartDate;
            dtp_delete_record_start.MaxDate = MaxStartDate;

            dtp_delete_record_end.MinDate = MinEndDate;
            dtp_delete_record_end.MaxDate = MaxEndDate;


        }
        private async void MainForm_Load(object sender, EventArgs e)
        {

            paginationControl1.PageChanged += async (s, page) =>
            {
                await RefreshUsersAsync(page, pageSize);
            };
            await RefreshUsersAsync(currentPage, pageSize);
            //paginationControl2.PageChanged += async (s, page) =>
            //{
            //    await RefreshAuditLog(page,25);
            //};
            //await RefreshAuditLog();

            paginationControl3.PageChanged += async (s, page) =>
            {
                await RefreshStylistAsync(page, pageSize);
            };
            await RefreshStylistAsync(currentPage, pageSize);
            paginationControl4.PageChanged += async (s, page) =>
            {
                await RefreshCategoryAsync(page, pageSize);
            };
            await RefreshCategoryAsync(currentPage, pageSize);

            customerPagination.PageChanged += async (s, page) =>
            {
                await RefreshCustomers(page, pageSize);
            };
            await RefreshCustomers(currentPage, pageSize);

            supplierPagination.PageChanged += async (s, page) =>
            {
                await RefreshSupplierAsync(page, pageSize);
            };
            await RefreshSupplierAsync(currentPage, pageSize);

            subcatPagination.PageChanged += async (s, page) =>
            {
                await RefreshSubCategoryAsync(page, pageSize);
            };
            await RefreshSubCategoryAsync(currentPage, pageSize);

            product_pagination.PageChanged += async (s, page) =>
            {
                await RefreshProductAsync(page, pageSize);
            };
            await RefreshProductAsync(currentPage, pageSize);

            retailPagination.PageChanged += async (s, page) =>
            {
                LoadRetailProducts(page, pageSize);
            };
            LoadRetailProducts(currentPage, pageSize);

            delivery_pagination.PageChanged += async (s, page) =>
            {
                await RefreshDeliveryAsync(page, pageSize);
            };

            await RefreshDeliveryAsync(currentPage, pageSize);

            inventory_pagination.PageChanged += async (s, page) =>
            {
                LoadInventory(page, pageSize);
            };
            LoadInventory(currentPage, pageSize);

            service_pagination.PageChanged += async (s, page) =>
            {
                await RefreshServicesAsync(page, pageSize);
            };
            await RefreshServicesAsync(currentPage, pageSize);

            appointment_pagination.PageChanged += async (s, page) =>
            {
                await RefreshAppointmentAsync(page, pageSize);
            };
            await RefreshAppointmentAsync(currentPage, pageSize);


            data_recovery_pagination.PageChanged += async (s, page) =>
            {
                await FilterdDeletedRecords(page, pageSize);
            };

            await FilterdDeletedRecords(currentPage, pageSize);


            transaction_pagination.PageChanged += async (s, page) =>
            {
                 FilterTransactionReport(page, pageSize);
            };

             FilterTransactionReport(currentPage, pageSize);

            dgv_cart_product.AutoGenerateColumns = false;
            dgv_cart_product.DataSource = null;
            col_cart_product_name.DataPropertyName = "product_name";
            col_cart_product_category.DataPropertyName = "size_label";
            col_cart_product_brand.DataPropertyName = "brand";
            col_cart_product_price.DataPropertyName = "selling_price";
            col_cart_product_qty.DataPropertyName = "quantity";
            col_cart_discounted.DataPropertyName = "DiscountAmount";
            col_cart_final_price.DataPropertyName = "FinalPrice";
            col_cart_vat_exempt.DataPropertyName = "IsVatExempt";
            col_cart_status.DataPropertyName = "DisplayFinalPrice";
            dgv_cart_product.DataSource = cart;

            LoadDiscount();
            LoadPaymentMethodCombobox();
            MinAndMaxDate();
            expiry_timer.Start();
            LoadBusinessHours();
            LowOrOutOfStock();

            UserAccess();
            lbl_cashier_name.Text = $"{UserSession.CurrentUser.first_Name} {UserSession.CurrentUser.last_Name}";


            LoadPaymentMethod();
            ExpiredPromo();
            await RefreshUsersAsync(1, 20);


            //await RefreshCategoryAsync();





            await RefreshVat();


            //await RefreshInventoryAsync();

            await RefreshBatchInventory();
            LoadWalkIn();

           
            //await RefreshTransactionAsync();
     


            // SUMMARY DASHBOARD
            await RefreshTotalSales();
            await RefreshTotalAppointment();
            await RefreshTotalProduct();
            await RefreshTotalServices();

            await RefreshPopularServices();

            // POS
            SearchProduct();

            //// REPORTS
            sales_report_pagination.PageChanged +=  (s, page) =>
            {
                 FilterSalesReport(page, pageSize);
            };

            FilterSalesReport(currentPage,pageSize);

            //FilterSalesReport();

            inventory_report_pagination.PageChanged +=  (s, page) =>
            {
                filterInventoryReport(page, pageSize);
            };

            filterInventoryReport(currentPage, pageSize);

            audit_pagination.PageChanged +=  (s, page) =>
            {
                FilterAuditTrail(page, pageSize);
            };
             FilterAuditTrail(currentPage, pageSize);


            //FilterExpenseReport();
            //FilterProfitAndLostReport();
            //FilteredCustomerReport();
            //FilteredStaffReport();
            //FilteredDeliveryReport();
            //FilteredDiscountReport();


            // SETTINGS
            LoadOwnerEmailAndBusinessName();


        }


        private void UserAccess()
        {
            if (UserSession.CurrentUser.Position == "Staff")
            {
                HideTab(materialTabControl1, userTab);
                HideTab(materialTabControl1, stylistTab);
                HideTab(materialTabControl1, supplierTab);
                HideTab(materialTabControl1, categoriesTab);
                HideTab(materialTabControl1, subCategoryTab);
                HideTab(materialTabControl1, productsTab);
                HideTab(materialTabControl1, servicesTab);
                HideTab(materialTabControl1, reportsTab);
                HideTab(materialTabControl1, dataRecoveryTab);
                HideTab(materialTabControl1, settingsTab);


            }
            HideTab(materialTabControl1, walk_in_Tab);
        }
        private void HideTab(MaterialTabControl tabControl, TabPage tabPage)
        {
            if (tabControl.TabPages.Contains(tabPage))
            {
                tabControl.TabPages.Remove(tabPage);
            }

        }

        // DASHBOARD
        public async Task RefreshTotalSales()
        {
            var repo = new TransactionRepository();
            var controller = new TransactionController(repo);
            var total_sales = await controller.GetTotalSalesAsync();

            if (total_sales != null)
            {
                lbl_total_sales.Text = total_sales.TotalSales.ToString("C2");
            }
            else
            {
                lbl_total_sales.Text = "0.00";
            }

        }
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

        public async Task RefreshTotalAppointment()
        {


            var controller = new AppointmentRepository();
            var total_appointment = await controller.GetTotalAppointmentAsync();

            if (total_appointment != null)
            {
                lbl_total_appointment.Text = total_appointment.TotalAppointment.ToString();
            }
            else
            {
                lbl_total_appointment.Text = "0.00";
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
        public async Task RefreshTotalProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var total_products = await controller.GetTotalProductAsync();

            if (total_products != null)
            {
                lbl_total_product.Text = total_products.TotalProduct.ToString();
            }
            else
            {
                lbl_total_product.Text = "0.00";
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

        public async Task RefreshTotalServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var total_services = await controller.TotalServicesAsync();

            if (total_services != null)
            {
                lbl_total_services.Text = total_services.TotalService.ToString();
            }
            else
            {
                lbl_total_services.Text = "0.00";
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


        }
        public async Task RefreshPopularServices()
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);

            foreach (var service in await controller.GetPopulatServicesAsync())
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
        private async void LoadTotalUser()
        {
            var controller = new UserController(new UserRepository());
            var totalRecords = controller.GetTotalUsers();

            int pageSize = 20;
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            //paginationControl3.SetTotalPages(totalPages);

            await RefreshUsersAsync(1, pageSize);

        }
        public async Task RefreshUsersAsync(int pageNumber, int pageSize)
        {
            var controller = new UserController(new UserRepository());
            int offset = (pageNumber - 1) * pageSize;
            var users = await controller.RefreshUsers(pageSize, offset);

            var total = controller.GetTotalUsers();
            int total_pages = (int)Math.Ceiling((double)total / pageSize);
            paginationControl1.SetTotalPages(total_pages);

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
            col_user_status.DataPropertyName = "status";


            dgv_user.DataSource = users;
        }
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
            col_user_status.DataPropertyName = "status";

            dgv_user.DataSource = users;


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var userForm = new UserForm(this))
            {
                userForm.ShowDialog();

            }

        }

        private async void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
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
            //else if (dgv_user.Columns[e.ColumnIndex].Name == "btn_activate")
            //{
            //    var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;


            //    // Ask for confirmation before delete
            //    if (MessageBox.Show($"Activate user {user.userName}?", "Confirm Activation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        RestoreDeactivatedUserRecord(user.user_id);
            //        DeleteDeletedRecord(user.user_id);

            //        LoadDeletedRecords();
            //        LoadUser();
            //        var fullName = user.first_Name + " " + user.last_Name;
            //        Audit.AuditLog(DateTime.Now, "Activate", UserSession.CurrentUser.first_Name, "Manage User", $"Activated user {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            //    }
            //}

            else if (dgv_user.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;



                if (!string.IsNullOrEmpty(user.Position) && user.Position.Equals("admin", StringComparison.OrdinalIgnoreCase)) { return; }

                // Ask for confirmation before delete 
                if (MessageBox.Show($"Deactivate user {user.userName}?", "Confirm Deactivation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var _repo = new UserRepository();
                    var userController = new UserController(_repo);
                    if (userController.DeleteUser(user.user_id))
                    {
                        MessageBox.Show("User Deactivated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InsertDeletedRecord(user.user_id, null, "Manage User", user.first_Name, UserSession.CurrentUser.first_Name, DateTime.Today);
                        await FilterdDeletedRecords(currentPage,pageSize);
                        await RefreshUsersAsync(paginationControl1.CurrentPage, 20);
                        var fullName = user.first_Name + " " + user.last_Name;
                        Audit.AuditLog(DateTime.Now, "Deactivate", UserSession.CurrentUser.first_Name, "Manage User", $"Deactivated user {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Deactivate User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else if (e.RowIndex >= 0 && dgv_user.Columns[e.ColumnIndex].Name == "col_view")
            {
                // Get the user object bound to this row
                var user = dgv_user.Rows[e.RowIndex].DataBoundItem as UsersModel;

                bool isViewed = true;
                using (var userForm = new UserForm(this, user, isViewed))
                {
                    var fullName = user.first_Name + " " + user.last_Name;
                    Audit.AuditLog(DateTime.Now, "View", UserSession.CurrentUser.first_Name, "Manage User", $"Viewed user {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                    userForm.ShowDialog();
                }

            }
        }

        private void dgv_user_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if we're formatting the "Status" column
            if (dgv_user.Columns[e.ColumnIndex].Name == "col_user_status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Active")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                else if (status == "Inactive")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
            }

        }



        // END OF USERS

        public async Task RefreshStylistAsync(int pageNumber, int pageSize)
        {
            var _repo = new StylistRepository();
            var stylistController = new StylistController(_repo);
            int offset = (pageNumber - 1) * pageSize;
            var stylists = await stylistController.RefreshStlyistAsync(pageSize, offset);

            int totalRecords = stylists.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            paginationControl3.SetTotalPages(totalPages);
            dgv_stylist.AutoGenerateColumns = false;
            col_stylist_id.DataPropertyName = "stylist_id";
            stylist_first_name.DataPropertyName = "firstName";
            stylist_middle_name.DataPropertyName = "middleName";
            stylist_last_name.DataPropertyName = "lastName";
            stylist_day_of_birth.DataPropertyName = "birth_date";
            stylist_contact.DataPropertyName = "contactNumber";
            stylist_email.DataPropertyName = "email";
            stylist_address.DataPropertyName = "address";
            col_stylist_status.DataPropertyName = "status";

            dgv_stylist.DataSource = stylists;
        }
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
            col_stylist_status.DataPropertyName = "status";
            dgv_stylist.DataSource = stylists;
        }

        private void btn_add_stylist_Click(object sender, EventArgs e)
        {
            using (var stylistForm = new StylistForm(this))
            {


                stylistForm.Added += async (s, args) => { await RefreshCategoryAsync(paginationControl3.CurrentPage, 25); };

                stylistForm.ShowDialog();
            }
        }

        private async void dgv_stylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "stylist_btn_update")
            {

                var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;

                using (var stylistForm = new StylistForm(this, stylist))
                {


                    stylistForm.Updated += async (s, args) => { await RefreshCategoryAsync(paginationControl3.CurrentPage, pageSize); };

                    stylistForm.ShowDialog();
                }



            }
            //else if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "col_stylist_active")
            //{

            //    var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;

            //    if (MessageBox.Show($"Activate stylist {stylist.firstName}?", "Confirm Activation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        var _repo = new StylistRepository();
            //        var stylistController = new StylistController(_repo);
            //        var fullName = stylist.firstName + " " + stylist.lastName;
            //        Audit.AuditLog(DateTime.Now, "Activate", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Activated stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            //        RestoreDeletedStylistRecord(stylist.stylist_id);
            //        DeleteDeletedRecord(stylist.stylist_id);
            //        LoadStylist();
            //        LoadDeletedRecords();

            //    }



            //}
            else if (e.RowIndex >= 0 && dgv_stylist.Columns[e.ColumnIndex].Name == "stylist_btn_delete")
            {
                var _repo = new StylistRepository();
                var stylistController = new StylistController(_repo);

                var stylist = dgv_stylist.Rows[e.RowIndex].DataBoundItem as StylistModel;



                if (MessageBox.Show($"Delete user {stylist.firstName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    if (stylistController.Delete(stylist.stylist_id))
                    {
                        MessageBox.Show("Stylist Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        var fullName = stylist.firstName + " " + stylist.lastName;
                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Deleted stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        InsertDeletedRecord(stylist.stylist_id, null, "Manage Stylist", fullName, UserSession.CurrentUser.first_Name, DateTime.Today);
                        await RefreshStylistAsync(paginationControl3.CurrentPage, pageSize);
                        await FilterdDeletedRecords(currentPage,pageSize);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Stylist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }



        }

        private void dgv_stylist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_stylist.Columns[e.ColumnIndex].Name == "col_stylist_status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Active")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                else if (status == "Inactive")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
            }
        }

        // END OF STYLIST

        // CUSTOMERS
        public async Task RefreshCustomers(int PageNumber, int PageSize)
        {
            var controller = new CustomerController(new CustomerRepository());
            int offset = (PageNumber - 1) * pageSize;
            var customers = await controller.RefreshCustomerAsync(PageSize, offset);


            int totalRecords = controller.TotalCustomerCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            customerPagination.SetTotalPages(totalPages);

            dgv_customer.AutoGenerateColumns = false;

            col_customer_id.DataPropertyName = "customer_id";
            col_customer_first_name.DataPropertyName = "firstName";
            col_customer_middle_name.DataPropertyName = "middleName";
            col_customer_last_name.DataPropertyName = "lastName";
            col_customer_contact.DataPropertyName = "phoneNumber";
            col_customer_email.DataPropertyName = "email";
            col_customer_status.DataPropertyName = "customer_type";

            dgv_customer.DataSource = customers;
        }
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
            col_customer_status.DataPropertyName = "customer_type";

            dgv_customer.DataSource = customers;


        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            using (var customerForm = new CustomerForm(this))
            {
                customerForm.CustomerAdded += async (s, args) => { await RefreshCustomers(customerPagination.CurrentPage, 25); };
                customerForm.ShowDialog();
            }
        }

        private async void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_customer_btn_update")
            {
                var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;
                using (var customerForm = new CustomerForm(this, customer))
                {
                    customerForm.CustomerUpdated += async (s, args) => { await RefreshCustomers(customerPagination.CurrentPage, 25); };
                    customerForm.ShowDialog();
                }
            }
            //else if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_customer_activate")
            //{
            //    var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;

            //    if (MessageBox.Show($"Activate customer {customer.firstName}?", "Confirm Activation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        var repo = new CustomerRepository();
            //        var customerController = new CustomerController(repo);
            //        var fullName = customer.firstName + " " + customer.lastName;
            //        Audit.AuditLog(DateTime.Now, "Activate", UserSession.CurrentUser.first_Name, "Manage Customer", $"Activated customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            //        RestoreDeletedCustomerRecord(customer.customer_id);
            //        DeleteDeletedRecord(customer.customer_id);
            //        LoadDeletedRecords();
            //        LoadCustomers();
            //    }
            //}
            else if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_customer_btn_delete")
            {
                var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;

                if (MessageBox.Show($"Delete customer {customer.firstName}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new CustomerRepository();
                    var customerController = new CustomerController(repo);


                    if (customerController.DeleteCustomer(customer.customer_id))
                    {
                        MessageBox.Show("Customer Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var fullName = customer.firstName + " " + customer.lastName;
                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Customer", $"Deleted customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(customer.customer_id, null, "Manage Customer", fullName, UserSession.CurrentUser.first_Name, DateTime.Today);

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    await FilterdDeletedRecords(currentPage,pageSize);
                    await RefreshCustomers(customerPagination.CurrentPage, pageSize);
                }
            }
        }

        // END OF CUSTOMERS

        // CATEGORY
        public async Task RefreshCategoryAsync(int pageNumber, int pageSize)
        {
            var repo = new CategoryRepository();
            var categoryController = new CategoryController(repo);
            int offset = (pageNumber - 1) * pageSize;
            var categories = await categoryController.GetAllCategoryAsync(pageSize, offset);


            int totalRecords = categoryController.GetTotalCategory();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            paginationControl4.SetTotalPages(totalPages);
            dgv_category.AutoGenerateColumns = false;
            col_category_id.DataPropertyName = "category_id";
            col_category_name.DataPropertyName = "categoryName";
            col_category_type.DataPropertyName = "type";
            dgv_category.DataSource = categories;
        }
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
                categoryForm.CategoryAdded += async (s, args) => { await RefreshCategoryAsync(paginationControl4.CurrentPage, 25); };
                categoryForm.ShowDialog();
            }
        }

        private async void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_category.Columns[e.ColumnIndex].Name == "col_category_btn_update")
            {
                var category = dgv_category.Rows[e.RowIndex].DataBoundItem as CategoryModel;
                using (var categoryForm = new CategoryForm(this, category))
                {
                    categoryForm.CategoryUpdated += async (s, args) => { await RefreshCategoryAsync(paginationControl4.CurrentPage, 25); };
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

                    if (categoryController.IsCategoryBeingUsed(category.category_id))
                    {
                        MessageBox.Show(
                            "This category cannot be deleted because it is still linked to one or more subcategories.",
                            "Delete Blocked",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );


                        return;
                    }
                    else
                    {

                        if (categoryController.deleteCategory(category.category_id))
                        {
                            MessageBox.Show("Supplier Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Categories", $"Deleted category '{category.categoryName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                            InsertDeletedRecord(category.category_id, null, "Manage Categories", category.categoryName, UserSession.CurrentUser.first_Name, DateTime.Today);

                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete Supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        await RefreshCategoryAsync(paginationControl4.CurrentPage, pageSize);
                        await FilterdDeletedRecords(currentPage,pageSize);
                    }


                }
            }
        }
        // END OF CATEGORY
        public async Task RefreshSubCategoryAsync(int PageNumber, int PageSize)
        {
            var repo = new SubCategoryRepository();
            var subCategoryController = new SubCategoryController(repo);
            int offset = (PageNumber - 1) * pageSize;

            var subCategories = await subCategoryController.GetSubCategoryAsync(PageSize, offset);


            int totalRecords = subCategoryController.GetTotalSubCategoryCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            subcatPagination.SetTotalPages(totalPages);


            dgv_sub_category.AutoGenerateColumns = false;
            col_subcategory_id.DataPropertyName = "subCategory_id";
            col_sub_cid.DataPropertyName = "category_id";
            col_sub_name.DataPropertyName = "subCategoryName";
            col_sub_category_name.DataPropertyName = "categoryName";
            dgv_sub_category.DataSource = subCategories;
        }
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

                subCategoryForm.RefreshData += async (s, args) => { await RefreshSubCategoryAsync(subcatPagination.CurrentPage, pageSize); };
                subCategoryForm.ShowDialog();
            }
        }

        private async void dgv_sub_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_sub_category.Columns[e.ColumnIndex].Name == "col_sub_btn_update")
            {
                var subCategory = dgv_sub_category.Rows[e.RowIndex].DataBoundItem as SubCategoryModel;
                using (var subCategoryForm = new SubCategoryForm(this, subCategory))
                {
                    subCategoryForm.RefreshData += async (s, args) => { await RefreshSubCategoryAsync(subcatPagination.CurrentPage, pageSize); };
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

                    if (subCategoryController.IsSubCategoryUsed(subCategory.subCategory_id))
                    {
                        MessageBox.Show(
                            "This sub-category cannot be deleted because it is still linked to one or more services.",
                            "Delete Blocked",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                    else
                    {
                        if (subCategoryController.deleteSubCategory(subCategory.subCategory_id))
                        {

                            MessageBox.Show("Sub-Category Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Sub-Categories", $"Deleted sub-category '{subCategory.subCategoryName}' for ({subCategory.categoryName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                            subCategoryController.deleteSubCategory(subCategory.subCategory_id);
                            InsertDeletedRecord(subCategory.subCategory_id, null, "Manage Sub-Categories", subCategory.subCategoryName, UserSession.CurrentUser.first_Name, DateTime.Today);

                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete Supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                        await FilterdDeletedRecords(currentPage, pageSize);
                        await RefreshSubCategoryAsync(subcatPagination.CurrentPage, pageSize);
                    }

                }
            }
        }

        // END OF SUBCATEGORY

        // PRODUCTS
        public async Task RefreshProductAsync(int PageNumber, int PageSize)
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            int offset = (PageNumber - 1) * pageSize;

            var products = await productController.GetAllProductAsync(PageSize, offset);

            var total_products = await productController.GetTotalProductAsync();


            int total_records = total_products.TotalProduct;
            int totalPages = (int)Math.Ceiling((double)total_records / pageSize);
            product_pagination.SetTotalPages(totalPages);


            dgv_product.AutoGenerateColumns = false;
            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "product_name";
            col_product_type.DataPropertyName = "product_type";
            col_product_brand.DataPropertyName = "brand";
            col_product_unit_type.DataPropertyName = "unit_type";
            col_product_created_at.DataPropertyName = "created_at";
            col_product_updated_at.DataPropertyName = "updated_at";
            dgv_product.DataSource = products;
        }

        public void LoadProducts()
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            var products = productController.getAllProduct();
            dgv_product.AutoGenerateColumns = false;
            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "product_name";
            col_product_type.DataPropertyName = "product_type";
            col_product_brand.DataPropertyName = "brand";

            col_product_unit_type.DataPropertyName = "unit_type";

            dgv_product.DataSource = products;
        }
        private void dgv_product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if we're formatting the Price column
            if (dgv_product.Columns[e.ColumnIndex].Name == "col_product_cost_price" && e.Value != null)
            {
                // Get the product type from another column in the same row
                var productType = dgv_product.Rows[e.RowIndex].Cells["col_product_type"].Value?.ToString();

                if (productType == "Retail")
                {
                    // Format as currency
                    if (decimal.TryParse(e.Value.ToString(), out var price))
                    {
                        e.Value = price.ToString("C2");
                        e.FormattingApplied = true;
                    }
                }
                else if (productType == "Ingredient")
                {
                    // Blank out the price for consumables
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
        }

        private async void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_product.Columns[e.ColumnIndex].Name == "col_btn_product_update")
            {
                var product = dgv_product.Rows[e.RowIndex].DataBoundItem as ProductModel;
                using (var productForm = new ProductForm(this, product))
                {

                    productForm.RefreshData += async (s, args) => { await RefreshCategoryAsync(product_pagination.CurrentPage, pageSize); };
                    productForm.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_product.Columns[e.ColumnIndex].Name == "col_btn_product_delete")
            {
                var product = dgv_product.Rows[e.RowIndex].DataBoundItem as ProductModel;
                if (MessageBox.Show($"Delete Product {product.product_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ProductRepository();
                    var controller = new ProductController(repo);


                    if (controller.deleteProduct(product.product_id))
                    {
                        MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Products", $"Deleted product '{product.product_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(product.product_id, null, "Manage Products", product.product_name, UserSession.CurrentUser.first_Name, DateTime.Today);

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                    await FilterdDeletedRecords(currentPage, pageSize);
                    await RefreshProductAsync(currentPage, pageSize);
                    await RefreshTotalProduct();


                }

            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            using (var productForm = new ProductForm(this))
            {
                productForm.RefreshData += async (s, args) => { await RefreshProductAsync(product_pagination.CurrentPage, pageSize); };
                productForm.ShowDialog();
            }
        }
        // END OF PRODUCTS


        // RETAIL PRODUCTS



        public void LoadRetailProducts(int PageNumber, int PageSize)
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var products = productController.GetRetailProduct(PageSize, offset);

            dgv_retail_product.DataSource = null;
            dgv_retail_product.AutoGenerateColumns = false;

            int totalRecords = productController.GetTotalRetailProduct();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            retailPagination.SetTotalPages(totalPages);


            col_retail_product_id.DataPropertyName = "product_id";
            col_retail_product_name.DataPropertyName = "product_name";
            col_retail_product_type.DataPropertyName = "product_type";
            col_retail_product_brand.DataPropertyName = "brand";
            col_retail_product_category_id.DataPropertyName = "category_id";
            col_retail_product_unit_type.DataPropertyName = "unit_type";
            col_retail_product_created_at.DataPropertyName = "created_at";
            col_retail_product_updated_at.DataPropertyName = "updated_at";

            dgv_retail_product.DataSource = products;


        }
        private void btn_add_retail_product_Click(object sender, EventArgs e)
        {
            using (var retailForm = new RetailProductForm(this))
            {
                retailForm.RefreshData += async (s, args) => { LoadRetailProducts(retailPagination.CurrentPage, pageSize); };
                retailForm.ShowDialog();
            }
        }
        private async void dgv_retail_product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_retail_product.Columns[e.ColumnIndex].Name == "col_retail_product_update")
            {

                var product_retail = dgv_retail_product.Rows[e.RowIndex].DataBoundItem as ProductModel;

                using (var form = new RetailProductForm(this, product_retail))
                {
                    form.RefreshData += async (s, args) => { LoadRetailProducts(retailPagination.CurrentPage, pageSize); };
                    form.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_retail_product.Columns[e.ColumnIndex].Name == "col_retail_product_delete")
            {

                var product_retail = dgv_retail_product.Rows[e.RowIndex].DataBoundItem as ProductModel;

                if (MessageBox.Show($"Delete Product {product_retail.product_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new ProductRepository();
                    var controller = new ProductController(repo);


                    if (controller.deleteProduct(product_retail.product_id))
                    {
                        MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Product Retail", $"Deleted product '{product_retail.product_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(product_retail.product_id, null, "Manage Products Retail", product_retail.product_name, UserSession.CurrentUser.first_Name, DateTime.Today);

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    LoadRetailProducts(retailPagination.CurrentPage, pageSize);
                    await FilterdDeletedRecords(currentPage, pageSize);




                }
            }
        }



        // END OF RETAIL PRODUCTS

        // SERVICES
        public async Task RefreshServicesAsync(int PageNumber, int PageSize)
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var services = await serviceController.GetAllServicsAsync(PageSize, offset);


            var totalRecords = serviceController.TotalServices();
            int totalPages = (int)Math.Ceiling((double)totalRecords.TotalService / pageSize);
            service_pagination.SetTotalPages(totalPages);



            dgv_service.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_service_name.DataPropertyName = "serviceName";
            col_service_price.DataPropertyName = "servicePrice";
            col_service_sid.DataPropertyName = "subCategory_id";
            col_service_subcategory.DataPropertyName = "subCategoryName";
            col_service_duration.DataPropertyName = "duration";
            col_service_status.DataPropertyName = "status";

            dgv_service.DataSource = services;
        }
        public void LoadServices()
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            var services = serviceController.getServices();
            dgv_service.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "service_id";
            col_service_name.DataPropertyName = "serviceName";
            col_service_price.DataPropertyName = "servicePrice";
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
                serviceForm.RefreshData += async (s, args) => { await RefreshServicesAsync(service_pagination.CurrentPage, pageSize); };

                serviceForm.ShowDialog();
            }
        }
        private int GetServiceUsageCount(int service_id)
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var services = controller.GetProductUsageCount(service_id);

            return services;
        }
        private void dgv_service_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgv_service.Columns[e.ColumnIndex].Name == "col_service_product_usage")
            {
                var service = dgv_service.Rows[e.RowIndex].DataBoundItem as ServiceModel;
                if (service != null)
                {
                    int usageCount = GetServiceUsageCount(service.serviceName_id);
                    e.Value = usageCount == 0 ? "No products assigned yet" : "Manage Products";
                }
            }
        }
        private async void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    serviceForm.RefreshData += async (s, args) => { await RefreshServicesAsync(service_pagination.CurrentPage, pageSize); };
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
                    if (controller.deleteService(service.serviceName_id))
                    {
                        MessageBox.Show("Service Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Services", $"Deleted service '{service.serviceName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(service.serviceName_id, null, "Manage Services", service.serviceName, UserSession.CurrentUser.first_Name, DateTime.Today);

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    await FilterdDeletedRecords(currentPage, pageSize);
                    await RefreshServicesAsync(service_pagination.CurrentPage, pageSize);


                }
            }
        }

        // END OF SERVICES


        // VAT AND DISCOUNT
        public async Task RefreshVat()
        {
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);
            var tax = await tax_controller.LoadLatestTaxAsync();

            if (tax != null)
            {
                vatModel = tax;

                txt_vat.Text = tax.tax.ToString();
            }
            else
            {

                txt_vat.Text = string.Empty;
            }

        }


        private bool VatValidated()
        {

            bool validated = true;
            // REQUIRED FIELD
            //validated &= Validator.IsRequired(txt_vat, errorProvider1, "Vat is required.");
            validated &= Validator.ValidateVAT(txt_vat.Text, txt_vat, errorProvider1);

            return validated;


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
                if (MessageBox.Show($"Are you sure you want to update vat?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Vat updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tax_controller.UpdateTax(vatModel);
                    Audit.AuditLog(
                   DateTime.Now,
                   "Update",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                  $"Updated Vat with rate '{tax_rate}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );

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
                Audit.AuditLog(
                   DateTime.Now,
                   "Create",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Created Vat with rate '{tax_rate}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );



            }
        }
        private async void btn_apply_Click(object sender, EventArgs e)
        {
            if (!VatValidated()) return;

            AddOrUpdateVat();

            await RefreshVat();

        }











        // END OF VAT AND DISCOUNT


        public async Task RefreshSupplierAsync(int PageNumber, int PageSize)
        {
            var controller = new SupplierController(new SupplierRepository());
            int offset = (PageNumber - 1) * pageSize;
            var suppliers = await controller.RefreshSupplierAsync(PageSize, offset);

            int totalRecords = controller.GetTotalSupplier();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            supplierPagination.SetTotalPages(totalPages);


            dgv_supplier.AutoGenerateColumns = false;
            col_supplier_id.DataPropertyName = "supplier_id";
            col_supplier_name.DataPropertyName = "supplier_name";
            col_supplier_contact.DataPropertyName = "contact";
            col_supplier_email.DataPropertyName = "email";
            col_supplier_address.DataPropertyName = "address";

            dgv_supplier.DataSource = suppliers;
        }
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
                supplierForm.SupplierAdded += async (s, args) => { await RefreshSupplierAsync(supplierPagination.CurrentPage, 25); };
                supplierForm.ShowDialog();
            }
        }

        private async void dgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_supplier.Columns[e.ColumnIndex].Name == "col_supplier_update")
            {
                var supplier = dgv_supplier.Rows[e.RowIndex].DataBoundItem as SupplierModel;
                using (var supplierForm = new SupplierForm(this, supplier))
                {
                    supplierForm.SupplierUpdated += async (s, args) => { await RefreshSupplierAsync(supplierPagination.CurrentPage, 25); };
                    supplierForm.ShowDialog();
                }

            }

            else if (e.RowIndex >= 0 && dgv_supplier.Columns[e.ColumnIndex].Name == "col_supplier_delete")
            {
                var supplier = dgv_supplier.Rows[e.RowIndex].DataBoundItem as SupplierModel;
                if (MessageBox.Show($"Delete Supplier {supplier.supplier_name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var repo = new SupplierRepository();
                    var controller = new SupplierController(repo);

                    if (controller.DeleteSupplier(supplier.supplier_id))
                    {
                        MessageBox.Show("Supplier Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Supplier", $"Deleted supplier '{supplier.supplier_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(supplier.supplier_id, null, "Manage Supplier", supplier.supplier_name, UserSession.CurrentUser.first_Name, DateTime.Today);

                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    await FilterdDeletedRecords(currentPage, pageSize);
                    await RefreshSupplierAsync(supplierPagination.CurrentPage, pageSize);

                }
            }
        }

        // END OF SUPPLIERS

        // DELIVERY
        public async Task RefreshDeliveryAsync(int PageNumber, int PageSize)
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var deliveries = await controller.GetDeliveryAsync(PageSize, offset);


            int totalRecords = controller.GetTotalDeliveryCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            delivery_pagination.SetTotalPages(totalPages);

            dgv_delivery.AutoGenerateColumns = false;

            col_delivery_id.DataPropertyName = "delivery_id";
            col_delivery_supplier_id.DataPropertyName = "supplier_id";
            col_delivery_supplier.DataPropertyName = "supplier_name";
            col_delivery_date.DataPropertyName = "date";
            col_delivery_invoice.DataPropertyName = "invoice";
            col_delivery_received_by.DataPropertyName = "received_by";

            dgv_delivery.DataSource = deliveries;
        }
        public void LoadDelivery(int PageNumber, int PageSize)
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var deliveries = controller.GetAllDelivery(PageNumber, offset);

            int totalRecords = controller.GetTotalDeliveryCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            delivery_pagination.SetTotalPages(totalPages);

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


                deliveryForm.RefreshData += async (s, args) => { await RefreshDeliveryAsync(customerPagination.CurrentPage, pageSize); };
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

                    Audit.AuditLog(DateTime.Now, "View", UserSession.CurrentUser.first_Name, "Manage Delivery", $"Viewed delivery on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                    addStockForm.ShowDialog();
                }

            }
        }
        // END OF DELIVERY

        // INVENTORY
        public async Task RefreshInventoryAsync()
        {

            var repo = new InventoryRepository();
            var inventoryController = new InventoryController(repo);
            var inventory = await inventoryController.GetAllInventoryAsync();

            dgv_inventory.AutoGenerateColumns = false;
            col_ProductID.DataPropertyName = "product_id";
            col_ProductName.DataPropertyName = "product_name";
            col_size_label.DataPropertyName = "size_label";
            col_ProductType.DataPropertyName = "product_type";
            col_Brand.DataPropertyName = "brand";
            col_Category.DataPropertyName = "category";
            col_Unit.DataPropertyName = "qty";
            col_Volume.DataPropertyName = "total_remaining";
            col_Critical_Level.DataPropertyName = "critical_level";
            col_Status.DataPropertyName = "status";


            dgv_inventory.DataSource = inventory;
        }


        public void LoadInventory(int PageNumber, int PageSize)
        {

            var repo = new InventoryRepository();
            var inventoryController = new InventoryController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var inventory = inventoryController.GetAllInventory(PageSize, offset);


            int totalRecords = inventoryController.GetTotalInventory();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            inventory_pagination.SetTotalPages(totalPages);

            var filter_inventory = inventory.OrderBy(i => i.product_name).ToList();

            dgv_inventory.AutoGenerateColumns = false;
            col_InventoryID.DataPropertyName = "inventory_id";
            col_ProductID.DataPropertyName = "product_id";
            col_ProductName.DataPropertyName = "product_name";
            col_ProductType.DataPropertyName = "product_type";
            col_size_label.DataPropertyName = "size_label";
            col_Brand.DataPropertyName = "brand";
            col_Category.DataPropertyName = "category";
            col_Unit.DataPropertyName = "qty";
            col_Volume.DataPropertyName = "total_remaining";
            col_Critical_Level.DataPropertyName = "critical_level";
            col_Status.DataPropertyName = "status";


            dgv_inventory.DataSource = filter_inventory;

            txt_critical_level.Value = inventory.Select(i => i.critical_level).FirstOrDefault();
        }

        public async Task RefreshBatchInventory()
        {
            //dgv_BatchInventory.AutoGenerateColumns = false;

            //var _repo = new InventoryBatchRepository();
            //var inventoryBatchController = new InventoryBatchController(_repo);

            //col_BatchID.DataPropertyName = "batch_id";
            //col_DeliveryItemID.DataPropertyName = "delivery_item_id";
            //col_ProductID.DataPropertyName = "product_id";
            //col_ProdName.DataPropertyName = "product_name";
            //col_Quantity.DataPropertyName = "unit";
            //col_volume_per_qtn.DataPropertyName = "volume_per_unit";
            //col_used_volume.DataPropertyName = "used_volume";
            //col_vol.DataPropertyName = "volume";
            //col_price.DataPropertyName = "price";
            //col_total_price.DataPropertyName = "total_price";
            //col_notes.DataPropertyName = "notes";
            //col_DateReceived.DataPropertyName = "delivered_date";
            //col_ExpiryDate.DataPropertyName = "expiry_date";


            //dgv_BatchInventory.DataSource = await inventoryBatchController.GetAllInventoryBatchAsync();
        }

        public void LoadBatchInventory()
        {
            //dgv_BatchInventory.AutoGenerateColumns = false;

            //var _repo = new InventoryBatchRepository();
            //var inventoryBatchController = new InventoryBatchController(_repo);

            //col_BatchID.DataPropertyName = "batch_id";
            //col_DeliveryItemID.DataPropertyName = "delivery_item_id";
            //col_ProductID.DataPropertyName = "product_id";
            //col_ProdName.DataPropertyName = "product_name";
            //col_Quantity.DataPropertyName = "unit";
            //col_volume_per_qtn.DataPropertyName = "volume_per_unit";
            //col_used_volume.DataPropertyName = "used_volume";
            //col_vol.DataPropertyName = "volume";
            //col_price.DataPropertyName = "price";
            //col_total_price.DataPropertyName = "total_price";
            //col_notes.DataPropertyName = "notes";
            //col_DateReceived.DataPropertyName = "delivered_date";
            //col_ExpiryDate.DataPropertyName = "expiry_date";


            //dgv_BatchInventory.DataSource = inventoryBatchController.GetAllBatchInventory();
        }

        // END OF INVENTORY


        // WALK IN

        public void LoadWalkIn()
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            var walk_ins = controller.GetWalkIn();

            dgv_walk_in.AutoGenerateColumns = false;
            col_walk_in_id.DataPropertyName = "id";
            col_walk_in_code.DataPropertyName = "name";
            col_walk_in_stylist_id.DataPropertyName = "stylist_id";
            col_walk_in_stylist_name.DataPropertyName = "StylistName";
            col_walk_in_subcategory_id.DataPropertyName = "subCategory_id";
            col_walk_in_service_id.DataPropertyName = "serviceName_id";
            col_walk_in_service.DataPropertyName = "serviceName";
            col_walk_in_price.DataPropertyName = "selling_price";
            col_walk_in_date.DataPropertyName = "date";
            col_walk_in_start_time.DataPropertyName = "start_time";
            col_walk_in_end_time.DataPropertyName = "end_time";
            col_walk_in_status.DataPropertyName = "status";
            col_walk_in_payment_status.DataPropertyName = "payment_status";

            dgv_walk_in.DataSource = walk_ins;
        }


        private void btn_walk_in_Click(object sender, EventArgs e)
        {
            using (var form = new Walk_In_Form(this))
            {
                form.ShowDialog();
            }
        }

        // END OF WALK IN


        // APPOINTMENT
        public async Task RefreshAppointmentAsync(int PageNumber, int pageSize)
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var appointments = await controller.GetAllAppointmentAsync(cmb_appointment_status.Text, pageSize, offset);



            var totalRecords = await repo.GetTotalAppointmentAsync();
            int totalPages = (int)Math.Ceiling((double)totalRecords.TotalAppointment / pageSize);
            appointment_pagination.SetTotalPages(totalPages);


            dgv_appointment.AutoGenerateColumns = false;
            dgv_table_summary.AutoGenerateColumns = false;

            // APPOINTMENT
            appointment_id.DataPropertyName = "AppointmentId";
            customer_id.DataPropertyName = "CustomerId";
            customerName.DataPropertyName = "DisplayCustomerName";
            col_appointment_selling_price.DataPropertyName = "selling_price";
            col_appointment_vat_amount.DataPropertyName = "vat_amount";
            col_appointment_email.DataPropertyName = "Email";
            col_appointment_number.DataPropertyName = "PhoneNumber";
            stylist_id.DataPropertyName = "StylistId";
            stylistName.DataPropertyName = "StylistName";
            date.DataPropertyName = "AppointmentDate";
            startTime.DataPropertyName = "StartTime";
            endTime.DataPropertyName = "EndTime";
            status.DataPropertyName = "Status";
            paymentStatus.DataPropertyName = "PaymentStatus";
            col_book_type.DataPropertyName = "CustomerType";
            dgv_appointment.DataSource = appointments;







            // DASHBOARD
            col_db_app_id.DataPropertyName = "AppointmentId";
            col_db_customer_id.DataPropertyName = "CustomerId";
            customerName.DataPropertyName = "DisplayCustomerName";
            col_appointment_email.DataPropertyName = "Email";
            col_appointment_number.DataPropertyName = "PhoneNumber";
            col_db_stylist_id.DataPropertyName = "StylistId";
            col_db_stylist_name.DataPropertyName = "StylistName";
            col_db_date.DataPropertyName = "AppointmentDate";
            col_db_start_time.DataPropertyName = "StartTime";
            col_db_end_time.DataPropertyName = "EndTime";
            col_db_status.DataPropertyName = "Status";
            col_db_payment_status.DataPropertyName = "PaymentStatus";
            col_db_booking_type.DataPropertyName = "CustomerType";
            dgv_table_summary.DataSource = appointments;
        }

        public void LoadAppointments()
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);
            var appointments = controller.GetAllShowAppointments(cmb_appointment_status.Text);
            dgv_appointment.AutoGenerateColumns = false;
            dgv_table_summary.AutoGenerateColumns = false;

            appointment_id.DataPropertyName = "AppointmentId";
            customer_id.DataPropertyName = "CustomerId";
            customerName.DataPropertyName = "DisplayCustomerName";
            col_app_subcat_id.DataPropertyName = "SubCategoryId";
            col_appointment_selling_price.DataPropertyName = "selling_price";
            col_appointment_vat_amount.DataPropertyName = "vat_amount";
            col_appointment_email.DataPropertyName = "Email";
            col_appointment_number.DataPropertyName = "PhoneNumber";
            stylist_id.DataPropertyName = "StylistId";
            stylistName.DataPropertyName = "StylistName";
            date.DataPropertyName = "AppointmentDate";
            startTime.DataPropertyName = "StartTime";
            endTime.DataPropertyName = "EndTime";
            status.DataPropertyName = "Status";
            paymentStatus.DataPropertyName = "PaymentStatus";
            col_book_type.DataPropertyName = "CustomerType";

            dgv_appointment.DataSource = appointments;



            // DASHBOARD
            col_db_app_id.DataPropertyName = "AppointmentId";
            col_db_customer_id.DataPropertyName = "CustomerId";
            col_db_customer_name.DataPropertyName = "DisplayCustomerName";
            col_appointment_email.DataPropertyName = "Email";
            col_appointment_number.DataPropertyName = "PhoneNumber";
            col_db_stylist_id.DataPropertyName = "StylistId";
            col_db_stylist_name.DataPropertyName = "StylistName";
            col_db_date.DataPropertyName = "AppointmentDate";
            col_db_start_time.DataPropertyName = "StartTime";
            col_db_end_time.DataPropertyName = "EndTime";
            col_db_status.DataPropertyName = "Status";
            col_db_payment_status.DataPropertyName = "PaymentStatus";
            col_db_booking_type.DataPropertyName = "CustomerType";

            dgv_table_summary.DataSource = appointments;
        }

        private void btn_add_appointment_Click(object sender, EventArgs e)
        {
            using (var appointmentForm = new AppointmentForm(this))
            {
                appointmentForm.ShowDialog();
            }
        }

        private async void cmb_appointment_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_appointment_status.Text != null)
            {
                await RefreshAppointmentAsync(currentPage, pageSize);
            }
        }
        private void dgv_appointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (e.RowIndex >= 0 && dgv_appointment.Columns[e.ColumnIndex].Name == "col_pay")
            {
                var appointment = dgv_appointment.Rows[e.RowIndex].DataBoundItem as AppointmentModel;

                if (appointment.PaymentStatus.ToLower() == "paid")
                {
                    return;
                }

                using (var paymentForm = new PaymentForm(this, appointment))
                {
                    //paymentForm.RefreshData += async (s, args) => { await RefreshCategoryAsync(appointment_pagination.CurrentPage, pageSize); };

                    paymentForm.ShowDialog();
                }
            }

            if (e.RowIndex >= 0 && dgv_appointment.Columns[e.ColumnIndex].Name == "col_update_appointment")
            {
                var appointment = dgv_appointment.Rows[e.RowIndex].DataBoundItem as AppointmentModel;
                if (appointment.PaymentStatus.ToLower() == "paid" && (appointment.Status.ToLower() == "completed" || appointment.Status.ToLower() == "refunded"))
                {
                    return;
                }
                using (var appointmentForm = new AppointmentForm(this, appointment, true))
                {
                    appointmentForm.ShowDialog();
                }

            }



        }
        private async void cancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_appointment.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_appointment.SelectedRows[0];
                var appointmentId = Convert.ToInt32(selectedRow.Cells["appointment_id"].Value);
                var name = selectedRow.Cells["customerName"].Value;
                var confirm = MessageBox.Show(
                    "Are you sure you want to cancel this appointment?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    var controller = new AppointmentController();
                    controller.UpdateStatus("Cancelled", appointmentId);

                    MessageBox.Show(
                        "Appointment status updated to 'Cancelled' successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Audit.AuditLog(
                    DateTime.Now,
                    "Cancel Status",
                    UserSession.CurrentUser.first_Name,
                    "Appointment",
                    $"Cancelled Status for client '{name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );
                    await RefreshAppointmentAsync(currentPage, pageSize);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select an appointment first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private async void noShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_appointment.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_appointment.SelectedRows[0];
                var appointmentId = Convert.ToInt32(selectedRow.Cells["appointment_id"].Value);
                var name = selectedRow.Cells["customerName"].Value;
                var confirm = MessageBox.Show(
                    "Are you sure you want to mark this appointment as 'No Show'?",
                    "Confirm No Show",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    var controller = new AppointmentController();
                    controller.UpdateStatus("No Show", appointmentId); // ✅ Correct status

                    MessageBox.Show(
                        "Appointment status updated to 'No Show' successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Audit.AuditLog(
                        DateTime.Now,
                        "No Show Status",
                        UserSession.CurrentUser.first_Name,
                        "Appointment",
                        $"Marked client '{name}' as No Show on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );

                    await RefreshAppointmentAsync(currentPage, pageSize);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select an appointment first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void dgv_appointment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgv_appointment.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0)
                {
                    dgv_appointment.ClearSelection();
                    dgv_appointment.Rows[hit.RowIndex].Selected = true;

                    // Temporarily assign the menu and show it
                    dgv_appointment.ContextMenuStrip = contextMenuStrip1;
                    contextMenuStrip1.Show(dgv_appointment, e.Location);
                }
                else
                {
                    // Detach the menu so it doesn't show
                    dgv_appointment.ContextMenuStrip = null;
                }
            }




        }

        // END OF APPOINTMENT







        // SALES REPORT
        
        private  void FilterSalesReport(int pageNumber, int pageSize)
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_sales_report_range.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {
                // No preset selected — use DateTimePicker values
                if (dtp_report_start_date.Checked && dtp_report_end_date.Checked)
                {
                    startDate = dtp_report_start_date.Value.Date;
                    endDate = dtp_report_end_date.Value.Date.AddDays(1).AddTicks(-1); // Include full day

                    RefreshSalesReportAsync(startDate, endDate, pageNumber, pageSize);
                }
                else
                {
                    // No filter — show all records
                    RefreshSalesReportAsync(null, null, pageNumber, pageSize);
               
                }
          
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
                RefreshSalesReportAsync(startDate, endDate, pageNumber, pageSize);
            }

    
        }

        private void RefreshSalesReportAsync(DateTime? startDate = null, DateTime? endDate = null, int PageNumber = 0, int pageSize = 0)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var dgv_sales = (startDate.HasValue && endDate.HasValue)
                ? controller.GetSalesReportView(startDate.Value, endDate.Value,pageSize, offset)
                : controller.GetSalesReportView(pageSize, offset);


            int totalRecords = controller.GetCountTotalInvoice();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            sales_report_pagination.SetTotalPages(totalPages);


            var total_sales = dgv_sales.Sum(s => s.Total_Price);
            var total_vat = dgv_sales.Sum(s => s.VatAmount);
            var total_discount = dgv_sales.Sum(s => s.DiscountAmount);
            var total_refund = dgv_sales.Sum(s => s.RefundAmount);
            
            var net_sales = total_sales - total_discount;
            if (dgv_sales != null)
            {
                lbl_report_total_sales.Text = total_sales.ToString("C2");
                lbl_report_total_vat.Text = total_vat.ToString("C2");
                lbl_report_total_discount.Text = total_discount.ToString("C2");
                lbl_report_total_refund.Text = total_refund.ToString("C2");
                lbl_report_net_sales.Text = net_sales.ToString("C2");


                dgv_report_table.AutoGenerateColumns = false;
                col_report_service_name.DataPropertyName = "ServiceName";
                col_report_product_name.DataPropertyName = "ItemName";
                col_report_size_label.DataPropertyName = "SizeLabel";
                col_report_item_type.DataPropertyName = "ItemType";
                col_report_qty.DataPropertyName = "Quantity";
                col_report_vat_amount.DataPropertyName = "VatAmount";
                col_report_discount_amount.DataPropertyName = "DiscountAmount";
                col_report_amount_paid.DataPropertyName = "Total_Price";
                col_report_refund.DataPropertyName = "RefundAmount";
                col_report_date.DataPropertyName = "timestamp";
                dgv_report_table.DataSource = dgv_sales;
            }
            else
            {
                lbl_report_total_sales.Text = "0.00";
                lbl_report_total_vat.Text = "0.00";
                lbl_report_total_discount.Text = "0.00";
                lbl_report_total_refund.Text = "0.00";
                
            }
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
                lbl_report_total_refund.Text = sales_summary.total_transaction.ToString("N2");
               


                dgv_report_table.AutoGenerateColumns = false;
        
                //col_report_appointment_id.DataPropertyName = "appointment_id";
                col_report_amount_paid.DataPropertyName = "amount_paid";
                col_report_vat_amount.DataPropertyName = "vat_amount";
                col_report_discount_amount.DataPropertyName = "discount_amount";
 
                col_report_date.DataPropertyName = "timestamp";
                dgv_report_table.DataSource = dgv_sales;
            }
            else
            {
                lbl_report_total_sales.Text = "0.00";
                lbl_report_total_vat.Text = "0.00";
                lbl_report_total_discount.Text = "0.00";
                lbl_report_total_refund.Text = "0.00";
                
            }
        }

        private void btn_print_sales_report_Click(object sender, EventArgs e)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            var sales_report = controller.GetSalesReportView(25, 0);
            var filtered = sales_report.Where(s => s.timestamp >= dtp_report_start_date.Value && s.timestamp <= dtp_report_end_date.Value).ToList();
            var columns = new List<(string, Func<InvoiceServicesCart, string>, int)>
            { 
                ("Service", i => i.ServiceName,110),
                ("Item", i => i.ItemName, 280), 
                ("Qty", i => i.Quantity.ToString(), 350),
                ("VAT", i => i.VatAmount.ToString("F2"), 450), 
                ("Discount", i => i.DiscountAmount.ToString("F2"), 550), 
                ("Total", i => i.Total_Price.ToString("F2"), 
                680) 
            };
            var salesSummaries = new List<(string, Func<IEnumerable<InvoiceServicesCart>, string>)>
            {
                ("Total Sale", items => items.Sum(i => i.Total_Price).ToString("F2")),
                ("Total VAT", items => items.Sum(i => i.VatAmount).ToString("F2")),
                ("Total Discount",items => items.Sum(i => i.DiscountAmount).ToString("F2")),
                ("Total Refund",items => items.Sum(i => i.RefundAmount).ToString("F2")),
                ("Net Sales",items => items.Sum(i => i.Total_Price - i.DiscountAmount).ToString("F2")) };
            var printer = new ReportPrinter<InvoiceServicesCart>
                (filtered, "Sales Report", columns, salesSummaries);
            printer.Print();
        }

        private void btn_sales_report_export_pdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"SalesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var summary = new Dictionary<string, string>
            {
                { "Total Sales", lbl_report_total_sales.Text },
                { "Total VAT", lbl_report_total_vat.Text },
                { "Total Discount", lbl_report_total_discount.Text },
                { "Total Transactions", lbl_report_total_refund.Text }
              
            };
                    string logoPath = @"C:\Users\Alex\OneDrive\Pictures\hcsansor_logo.jpg";
                    var builder = new PdfReportBuilder(
                            sfd.FileName,
                            "Sales Report",
                            summary,
                            dgv_report_table,
                            UserSession.CurrentUser?.first_Name ?? "Unknown",
                            logoPath,
                            dtp_report_start_date.Value,
                            dtp_report_end_date.Value
                        );


                    builder.Export();

                    Audit.AuditLog(DateTime.Now, "Export PDF", UserSession.CurrentUser.first_Name, "User", $"Exported Sales Report to PDF at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    MessageBox.Show("Sales report exported successfully!", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void btn_report_filter_Click(object sender, EventArgs e)
        {
            cmb_sales_report_range.Hint = string.Empty;
            cmb_sales_report_range.SelectedIndex = -1;
            FilterSalesReport(sales_report_pagination.CurrentPage,25);

            cmb_sales_report_range.Hint = "Select Range";
        }

        private void cmb_sales_report_range_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sales_report_range != null)
            {
                FilterSalesReport(sales_report_pagination.CurrentPage, 25);
            }
        }

        private void btn_report_clear_Click(object sender, EventArgs e)
        {
            cmb_sales_report_range.Hint = string.Empty;
            dtp_report_start_date.Value = DateTime.Today;
            dtp_report_end_date.Value = DateTime.Today;
            cmb_sales_report_range.SelectedIndex = -1;
            FilterSalesReport(currentPage, 25);

            cmb_sales_report_range.Hint = "Select Range";
        }

        // END OF SALES REPORT

        // INVENTORY REPORT
        private void filterInventoryReport(int pageNumber, int pageSize)
        {
            string status = "";

            string selectedStockLevel = cmb_stock_status.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedStockLevel))
            {
                LoadInventoryReport(status,  pageNumber,  pageSize);
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

            LoadInventoryReport(status,  pageNumber,  pageSize);
        }
        private void btn_inventory_print_Click(object sender, EventArgs e)
        {
            var repo = new InventoryRepository();
            var controller = new InventoryController(repo);
            int offset = (1 - 1) * 25;
            var dgv_inventory = (cmb_stock_status.Text.Length > 0) ? controller.GetInventoryReportView(cmb_stock_status.Text, pageSize, offset) : controller.GetInventoryReportView(pageSize, offset);
            var inventory_report = dgv_inventory.ToList();
            var columns = new List<(string, Func<InventoryViewModel, string>, int)>
            {
                ("Product", i => i.product_name,110),
                ("Product Type", i => i.product_type, 280),
                ("Brand", i => i.brand.ToString(), 400),
                ("Size label", i => i.size_label.ToString(), 500),
                ("Qty", i => i.qty.ToString(), 600),
                ("Status", i => i.status.ToString(),
                680)
            };

            var total_products = dgv_inventory.Count();
            var consumable_products = dgv_inventory.Count(i => i.product_type == "Ingredient");
            var retail_products = dgv_inventory.Count(i => i.product_type == "Retail");
            var in_stock = dgv_inventory.Count(i => i.status == "In Stock");
            var low_stock = dgv_inventory.Count(i => i.status == "Low Stock");
            var out_of_stock = dgv_inventory.Count(i => i.status == "Out of Stock");

            var salesSummaries = new List<(string, Func<IEnumerable<InventoryViewModel>, string>)>
            {
                ("Total Products", items => total_products.ToString()),
                ("Consumable Products", items => consumable_products.ToString()),
                ("Retail Products",items => retail_products.ToString()),
                ("In Stock",items => in_stock.ToString()),
                ("Low Stock",items => low_stock.ToString()),
                ("Out of Stock",items => out_of_stock.ToString()),

            };
            var printer = new ReportPrinter<InventoryViewModel>
                (inventory_report, "Inventory Report", columns, salesSummaries);
            printer.Print();
        }
        private void btn_inventory_export_pdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"InventoryReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var summary = new Dictionary<string, string>
            {
                { "Total Products", lbl_inventory_total_product.Text },
                { "In Stock Items", lbl_inventory_stock_item.Text },
                { "Low Stock Items", lbl_inventory_low_stock.Text },
                { "Out of Stock Items", lbl_inventory_out_of_stock.Text }
            };

                    string logoPath = @"C:\Users\Alex\OneDrive\Pictures\hcsansor_logo.jpg";

                    var builder = new PdfReportBuilder(
                        sfd.FileName,
                        "Inventory Report",
                        summary,
                        dgv_inventory_report,
                        UserSession.CurrentUser?.first_Name ?? "Unknown",
                        logoPath
                    );

                    builder.Export();

                    Audit.AuditLog(DateTime.Now, "Export PDF", UserSession.CurrentUser.first_Name, "User", $"Exported Inventory Report to PDF at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    MessageBox.Show("Inventory report exported successfully!", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void LoadInventoryReport(string status = null, int pageNumber = 0, int pageSize = 0)
        {
            var repo = new InventoryRepository();
            var controller = new InventoryController(repo);
            int offset = (pageNumber - 1) * pageSize;

            //var inventory_summary = (status.Length > 0) ? controller.GetInventorySummaryReport(status) : controller.GetInventorySummaryReport();
            var dgv_inventory = (status.Length > 0) ? controller.GetInventoryReportView(status, pageSize, offset) : controller.GetInventoryReportView(pageSize, offset);

            int totalRecords = controller.GetTotalInventoryCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            inventory_report_pagination.SetTotalPages(totalPages);

            var total_products = dgv_inventory.Count();
            var consumable_products = dgv_inventory.Count(i => i.product_type == "Ingredient");
            var retail_products = dgv_inventory.Count(i => i.product_type == "Retail");
            var in_stock = dgv_inventory.Count(i => i.status == "In Stock");
            var low_stock = dgv_inventory.Count(i => i.status == "Low Stock");
            var out_of_stock = dgv_inventory.Count(i => i.status == "Out of Stock");

            if (dgv_inventory != null)
            {
                lbl_inventory_total_product.Text = total_products.ToString();
                lbl_inventory_consum_product.Text = consumable_products.ToString();
                lbl_inventory_retail_product.Text = retail_products.ToString();
                lbl_inventory_stock_item.Text = in_stock.ToString();
                lbl_inventory_low_stock.Text = low_stock.ToString();
                lbl_inventory_out_of_stock.Text = out_of_stock.ToString();

                dgv_inventory_report.AutoGenerateColumns = false;

                col_inventory_product_name.DataPropertyName = "product_name";
                col_inventory_product_type.DataPropertyName = "product_type";
                col_inventory_brand.DataPropertyName = "brand";
                col_inventory_size_label.DataPropertyName = "size_label";
                col_inventory_qty.DataPropertyName = "qty";
                col_inventory_status.DataPropertyName = "status";

                dgv_inventory_report.DataSource = dgv_inventory;


            }
            else
            {
                lbl_inventory_total_product.Text = "0.00";
                lbl_inventory_consum_product.Text = "0.00";
                lbl_inventory_retail_product.Text = "0.00";
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

            filterInventoryReport(inventory_report_pagination.CurrentPage,pageSize);


        }

        private void btn_inventory_clear_Click(object sender, EventArgs e)
        {
            cmb_stock_status.Hint = string.Empty;
            cmb_stock_status.SelectedIndex = -1;
            filterInventoryReport(currentPage, pageSize);
            cmb_stock_status.Hint = "Select Stock Status";
        }

        // END OF INVENTORY REPORT








        // AUDIT TRAIL


      
        private  void btn_audit_filter_Click(object sender, EventArgs e)
        {
            cmb_audit.Hint = string.Empty;
            cmb_audit.SelectedIndex = -1;
            DateTime start = dtp_audit_start.Value;
            DateTime end = dtp_audit_end.Value;
            cmb_audit.Hint = "Select Range";
            FilterAuditTrail(currentPage, pageSize);
    
        }
        private  void btn_audit_clear_Click(object sender, EventArgs e)
        {
            cmb_audit.Hint = string.Empty;
            cmb_audit.SelectedIndex = -1;
            dtp_audit_start.Value = DateTime.Today;
            dtp_audit_end.Value = DateTime.Today;
            cmb_audit.Hint = "Select Range";
            FilterAuditTrail(currentPage, pageSize);
           
        }

        private async void FilterAuditTrail(int pageNumber, int pageSize)
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_audit.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {
                // No preset selected — use DateTimePicker values
                if (dtp_audit_start.Checked && dtp_audit_end.Checked)
                {
                    startDate = dtp_audit_start.Value.Date;
                    endDate = dtp_audit_end.Value.Date.AddDays(1).AddTicks(-1); // Include full day

                    await RefreshAuditLog(startDate, endDate, pageNumber, pageSize);
                }
                else
                {
                    // No filter — show all records
                    await RefreshAuditLog(null, null, pageNumber, pageSize);
                }
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
                        endDate = startDate.AddDays(7).AddTicks(-1);
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
                dtp_audit_start.Value = startDate;
                dtp_audit_end.Value = endDate;

                await RefreshAuditLog(startDate, endDate, pageNumber, pageSize);
            }
        }


        public async Task RefreshAuditLog(DateTime? start = null, DateTime? end = null, int pageNumber = 0, int pageSize = 0)
        {


            var repo = new AuditRepository();
            var controller = new AuditController(repo);
            int offset = (pageNumber - 1) * pageSize;
            var logs = (start.HasValue && end.HasValue) 
                ? await controller.GetAllAuditAsync(start.Value, end.Value, pageSize, offset) 
                : await controller.GetAllAuditAsync(pageSize, offset);

            int totalRecords = controller.GetTotalRecordCount();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            audit_pagination.SetTotalPages(totalPages);
            var result = logs.Count();
       

            dgv_audit_report.AutoGenerateColumns = false;

            col_audit_id.DataPropertyName = "id";
            col_audit_date.DataPropertyName = "timestamp";
            col_audit_user.DataPropertyName = "user";
            col_audit_action.DataPropertyName = "action";
            col_audit_module.DataPropertyName = "module";
            col_audit_notes.DataPropertyName = "note";

           
           dgv_audit_report.DataSource = logs;
          


            //totalPages = controller.GetTotalPages(pageSize);
         

          
            //lbl_total_result.Text = $"Showing {logs.Count()} of {totalRecords} records";

        }
       
        private void btn_export_audit_pdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"AuditTrailReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var summary = new Dictionary<string, string>
            {
            
                { "Records Shown", lbl_total_result.Text.Replace("Showing ", "").Replace(" records", "") }
            };

                    string logoPath = @"C:\Users\Alex\OneDrive\Pictures\hcsansor_logo.jpg";

                    var builder = new PdfReportBuilder(
                          sfd.FileName,
                          "Audit Trail Report",
                          new Dictionary<string, string>(),
                          dgv_audit_report,
                          UserSession.CurrentUser?.first_Name ?? "Unknown",
                          logoPath,
                          dtp_audit_start.Value,
                          dtp_audit_end.Value
                      );

                    builder.Export();

                    Audit.AuditLog(DateTime.Now, "Export PDF", UserSession.CurrentUser.first_Name, "User", $"Exported Audit Trail Report to PDF at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    MessageBox.Show("Audit trail report exported successfully!", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        // END OF AUDIT TRAIL


        // LOGOUT
        private async void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = materialTabControl1.SelectedTab;
            if (selectedTab == categoriesTab)
            {
                //await RefreshCategoryAsync();
            }
            if (selectedTab == logoutTab)
            {
                LogOut();
            }
            if (selectedTab == reportsTab)
            {

                Audit.AuditLog(
                DateTime.Now,
                "View",
                UserSession.CurrentUser.first_Name,
                "Sales Report",
                $"Sales Report on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
            );
            }

            if (selectedTab == inventoryTab)
            {

                Audit.AuditLog(
                DateTime.Now,
                "View",
                UserSession.CurrentUser.first_Name,
                "Inventory",
                $"Viewed inventory on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
            );
            }

            if (selectedTab == transactionTab)
            {

                Audit.AuditLog(
                    DateTime.Now,
                    "View",
                    UserSession.CurrentUser.first_Name,
                    "Transaction History",
                    $"Viewed Transaction History on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                );

            }

        }
        private void LogOut()
        {

            var confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Audit.AuditLog(
                       DateTime.Now,
                       "Log Out",
                       UserSession.CurrentUser.first_Name,
                       "User",
                       $"Log Out '{UserSession.CurrentUser.first_Name}'on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                   );

                UserSession.Clear();
                var form = new LoginForm();
                form.Show();
                this.Close();




            }

        }
        // END OF LOG OUT

        // TRANSACTION HISTORY
        public void FilterTransactionReport(int pageNumber, int pageSize)
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_transaction_range.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {
                // No preset selected — use DateTimePicker values
                if (dtp_transaction_start.Checked && dtp_transaction_end.Checked)
                {
                    startDate = dtp_transaction_start.Value.Date;
                    endDate = dtp_transaction_end.Value.Date.AddDays(1).AddTicks(-1); // Include full day

                    LoadInvoiceTransaction(startDate, endDate, pageNumber, pageSize);
                }
                else
                {
                    // No filter — show all records
                    LoadInvoiceTransaction(null, null, pageNumber, pageSize);

                }

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
                dtp_transaction_start.Value = startDate;
                dtp_transaction_end.Value = endDate;
                LoadInvoiceTransaction(startDate, endDate, pageNumber, pageSize);
            }


        }

       
        public void LoadInvoiceTransaction(DateTime? start = null, DateTime? end = null, int PageNumber = 0, int PageSize = 0)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var transactions = (start.HasValue && end.HasValue)
                             ?  controller.GetAllInvoice(start.Value, end.Value, pageSize, offset)
                             :  controller.GetAllInvoice(pageSize, offset);

            int totalRecords = controller.GetTotalTransactionList();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            transaction_pagination.SetTotalPages(totalPages);

            dgv_transaction_list.DataSource = null;
            dgv_transaction_list.AutoGenerateColumns = false;

            col_invoice_id.DataPropertyName = "InvoiceID";
            col_invoice_number.DataPropertyName = "InvoiceNumber";
            col_amount.DataPropertyName = "TotalAmount";
            col_payment_method.DataPropertyName = "PaymentMethod";
            col_invoice_ref_num.DataPropertyName = "reference_number";
            col_tran_status.DataPropertyName = "status";
            col_date.DataPropertyName = "TimeStamp";

            dgv_transaction_list.DataSource = transactions;
            ;
        }

        //public async Task RefreshTransactionAsync(DateTime? start = null, DateTime? end = null)
        //{
        //    var repo = new TransactionRepository();
        //    var controller = new TransactionController(repo);
        //    var transactions = (start.HasValue && end.HasValue)
        //                     ? await controller.GetAllTransactionsAsync(start.Value, end.Value)
        //                     : await controller.GetAllTransactionsAsync();
        //    dgv_transaction_history.AutoGenerateColumns = false;

        //    col_transaction_id.DataPropertyName = "transaction_id";
        //    col_transaction_appointment_id.DataPropertyName = "appointment_id";
        //    dgv_col_transaction_customer_name.DataPropertyName = "ClientName";
        //    dgv_col_transaction_services.DataPropertyName = "Services";
        //    dgv_col_transaction_staff_name.DataPropertyName = "StaffName";
        //    dgv_col_transaction_payment_method.DataPropertyName = "payment_method";
        //    dgv_col_transaction_sub_total.DataPropertyName = "sub_total";
        //    dgv_col_transaction_discount_amount.DataPropertyName = "discount_amount";
        //    dgv_col_transaction_vat.DataPropertyName = "vat_amount";
        //    dgv_col_transaction__total_amount.DataPropertyName = "amount_paid";
        //    dgv_col_transaction__status.DataPropertyName = "AppointmentStatus";
        //    dgv_col_transaction_date.DataPropertyName = "timestamp";

        //    dgv_transaction_history.DataSource = transactions;
        //}

        //public void LoadAllTransactions(DateTime? start = null, DateTime? end = null)
        //{
        //    var repo = new TransactionRepository();
        //    var controller = new TransactionController(repo);
        //    var transactions = (start.HasValue && end.HasValue)
        //                     ? controller.GetAllTransactions(start.Value, end.Value)
        //                     : controller.GetAllTransactions();
        //    dgv_transaction_history.AutoGenerateColumns = false;

        //    col_transaction_id.DataPropertyName = "transaction_id";
        //    col_transaction_appointment_id.DataPropertyName = "appointment_id";
        //    dgv_col_transaction_customer_name.DataPropertyName = "ClientName";
        //    dgv_col_transaction_services.DataPropertyName = "Services";
        //    dgv_col_transaction_staff_name.DataPropertyName = "StaffName";
        //    dgv_col_transaction_payment_method.DataPropertyName = "payment_method";
        //    dgv_col_transaction_sub_total.DataPropertyName = "sub_total";
        //    dgv_col_transaction_discount_amount.DataPropertyName = "discount_amount";
        //    dgv_col_transaction_vat.DataPropertyName = "vat_amount";
        //    dgv_col_transaction__total_amount.DataPropertyName = "amount_paid";
        //    dgv_col_transaction__status.DataPropertyName = "AppointmentStatus";
        //    dgv_col_transaction_date.DataPropertyName = "timestamp";

        //    dgv_transaction_history.DataSource = transactions;
        //}
        private InvoiceModel invoice_model;
        private void btn_void_product_Click(object sender, EventArgs e)
        {
            using (var form = new VoirdForm(this, invoice_model))
            {
                form.ShowDialog();
            }
        }
        private void btn_tran_refund_Click(object sender, EventArgs e)
        {
            using (var form = new RefundForm(this, invoice_model))
            {
                form.ShowDialog();
            }
        }

        private void dgv_transaction_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0)
            {
                var row = dgv_transaction_list.Rows[e.RowIndex];
                var status = row.Cells["col_tran_status"].Value?.ToString();

                if (status != "Voided" && status != "Refunded")
                {
                    btn_void_product.Enabled = true;
                    btn_tran_refund.Enabled = true;

                    var model = dgv_transaction_list.Rows[e.RowIndex].DataBoundItem as InvoiceModel;

                    invoice_model = model;

                }
                else
                {
                    btn_void_product.Enabled = false;
                    btn_tran_refund.Enabled = false;
                }
            }
        }

        private  void btn_transaction_filter_Click(object sender, EventArgs e)
        {
            DateTime start = dtp_transaction_start.Value;
            DateTime end = dtp_transaction_end.Value;

            FilterTransactionReport(transaction_pagination.CurrentPage, pageSize);
        }

        private  void btn_transaction_clear_Click(object sender, EventArgs e)
        {
            dtp_transaction_start.Value = DateTime.Today;
            dtp_transaction_end.Value = DateTime.Today;

            cmb_transaction_range.Hint = string.Empty;
            dtp_transaction_start.Value = DateTime.Today;
            dtp_transaction_end.Value = DateTime.Today;
            cmb_transaction_range.SelectedIndex = -1;
            FilterTransactionReport(currentPage, pageSize);

            cmb_transaction_range.Hint = "Select Range";
            //await RefreshTransactionAsync();
        }

        private void inventoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

          

           


        }

        private async void reportsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedTab = reportsTabControl.SelectedTab;

            switch (selectedTab)
            {
                case var tab when tab == SalesTabPage:
                    Audit.AuditLog(
                        DateTime.Now,
                        "View",
                        UserSession.CurrentUser.first_Name,
                        "Sales Report",
                        $"Viewed Sales Report on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );
                    break;

                case var tab when tab == categoriesTab:

                    //await RefreshCategoryAsync();
                    break;

                case var tab when tab == inventoryTabPage:
                    Audit.AuditLog(
                        DateTime.Now,
                        "View",
                        UserSession.CurrentUser.first_Name,
                        "Inventory Report",
                        $"Viewed Inventory Report on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );
                    break;


                case var tab when tab == auditTabPage:
                    Audit.AuditLog(
                        DateTime.Now,
                        "View",
                        UserSession.CurrentUser.first_Name,
                        "AuditReport",
                        $"Viewed Aduit Report on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );

                    //await RefreshAuditLog();
                    break;
            }
        }
        private void dgv_transaction_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     


        // DELETED RECORDS

        public void InsertDeletedRecord(int record_id, int? sub_id, string module, string name, string deleted_by, DateTime deleted_on)
        {
            var repo = new DeletedRecordRepository();
            var controller = new DeletedRecordController(repo);

            var model = new DeletedRecord
            {
                record_id = record_id,
                sub_id = sub_id ?? 0,
                module = module,
                name = name,
                deleted_by = deleted_by,
                deleted_on = deleted_on
            };

            controller.Add(model);

        }

        public bool PermanentDelete(int record_id)
        {
            var repo = new DeletedRecordRepository();
            var controller = new DeletedRecordController(repo);

            return controller.Delete(record_id);
        }
        public bool DeleteDeletedRecord(int record_id)
        {
            var repo = new DeletedRecordRepository();
            var controller = new DeletedRecordController(repo);

            return controller.Delete(record_id);


        }
        public async Task FilterdDeletedRecords(int page_number, int _page_size)
        {
            DateTime startDate;
            DateTime endDate;

            string selectedRange = cmb_deleted_record_filter.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(selectedRange))
            {

                startDate = dtp_delete_record_start.Value.Date;
                endDate = dtp_delete_record_end.Value.Date;
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
                dtp_delete_record_start.Value = startDate;
                dtp_delete_record_end.Value = endDate;
            }

            await RefreshDeletedRecords(startDate, endDate, page_number, _page_size);

        }
        public async Task RefreshDeletedRecords(DateTime? start = null, DateTime? end = null,int PageNumber = 0, int PageSize = 0)
        {
            var repo = new DeletedRecordRepository();
            var controller = new DeletedRecordController(repo);
            int offset = (PageNumber - 1) * pageSize;
            var records = (start.HasValue && end.HasValue) ? await controller.GetAllDeletedRecordAsync(start.Value, end.Value, PageSize, offset) : await controller.GetAllDeletedRecordAsync(PageSize, offset);

            int totalRecords = controller.GetTotalDeletedRecords();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            data_recovery_pagination.SetTotalPages(totalPages);


            if (records != null)
            {
                dgv_deleted_record.AutoGenerateColumns = false;

                col_deleted_id.DataPropertyName = "deleted_id";
                col_deleted_record_id.DataPropertyName = "record_id";
                col_deleted_sub_id.DataPropertyName = "sub_id";
                col_deleted_module.DataPropertyName = "module";
                col_deleted_name.DataPropertyName = "name";
                col_deleted_by.DataPropertyName = "deleted_by";
                col_deleted_date.DataPropertyName = "deleted_on";

                dgv_deleted_record.DataSource = records;
            }


        }
        public void LoadDeletedRecords(DateTime? start = null, DateTime? end = null)
        {
            var repo = new DeletedRecordRepository();
            var controller = new DeletedRecordController(repo);
            var records = (start.HasValue && end.HasValue) ? controller.GetAllDeleteRecords(start.Value, end.Value) : controller.GetAllDeleteRecords();

            if (records != null)
            {
                dgv_deleted_record.AutoGenerateColumns = false;

                col_deleted_id.DataPropertyName = "deleted_id";
                col_deleted_record_id.DataPropertyName = "record_id";
                col_deleted_module.DataPropertyName = "module";
                col_deleted_name.DataPropertyName = "name";
                col_deleted_by.DataPropertyName = "deleted_by";
                col_deleted_date.DataPropertyName = "deleted_on";

                dgv_deleted_record.DataSource = records;
            }


        }

        // USER RECORD
        public void RestoreDeactivatedUserRecord(int id)
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);
            controller.RestoreUser(id);
        }
        public void DeleteUserRecord(int id)
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);
          

            if (controller.DeletePermanent(id))
            {
                DeleteDeletedRecord(id);

                MessageBox.Show("User Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("Failed to Delete User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // CATEGORY RECORD
        public void RestoreDeletedCategoryRecord(int id)
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            controller.restoreCategory(id);
        }

        public void DeleteCategoryRecord(int id, string name)
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
  

            if (controller.IsCategoryBeingUsed(id))
            {
                MessageBox.Show("Cannot delete category because they are associated with existing sub-categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Delete category {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteCategory(id))
                {
                    DeleteDeletedRecord(id);

                    MessageBox.Show("Category Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Failed to Delete Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        // STYLIST RECORD
        public void RestoreDeletedStylistRecord(int id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            controller.restoreStylist(id);
        }

        public void DeleteStylistRecord(int id, string name)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);

            if (controller.CheckIsStylistIsUsed(id))
            {
                MessageBox.Show("Cannot delete stylist because they are associated with existing appointments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Delete stylist {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    if (controller.PermanentDeleteStylist(id))
                    {
                    DeleteDeletedRecord(id);

                    MessageBox.Show("Stylist Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     

                }
                    else
                    {
                        MessageBox.Show("Failed to Delete Stylist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
         
        }

        // CUSTOMER RECORD
        public void RestoreDeletedCustomerRecord(int id)
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            controller.RestoreCustomer(id);

          

        }

        public void DeleteCustomerRecord(int id, string name)
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
          


            if (controller.CheckIsCustomerUsed(id))
            {
                MessageBox.Show("Cannot delete customer because they are associated with existing appointments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Delete Customer {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteCustomer(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Customer Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        // SUPPLIER RECORD
        public void RestoreDeletedSupplierRecord(int id)
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            controller.RestoreSupplier(id);

        }
        public void DeleteSupplierRecord(int id, string name)
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
   


            if (controller.CheckIsSupplierIsUsed(id))
            {
                MessageBox.Show("Cannot delete supplier because they are associated with existing delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Supplier {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteSupplier(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Supplier Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        // SUBCATEGORY RECORD
        public void RestoreDeletedSubCategoryRecord(int id)
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            controller.RestoreSubCategory(id);

        }
        public void DeleteSubCategoryRecord(int id, string name)
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);



            if (controller.IsSubCategoryUsed(id))
            {
                MessageBox.Show("Cannot delete sub-category because they are associated with existing delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Sub-Category {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteSubCategory(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Sub-Category Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete sub-category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        // PRODUCT RECORD
        public void RestoreDeletedProductRecord(int id)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            controller.RestoreProduct(id);
        }

        public void DeleteProductRecord(int id, string name)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);


            if (controller.IsProductBeingUsed(id))
            {
                MessageBox.Show("This product cannot be deleted because it is still being used to product size or services.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Product {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteProduct(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        // PRODUCT SIZE INGREDIENT

        public void RestoreProductSizeRecord(int id)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            controller.RestoreProductSize(id);
        }
        public void DeleteProductSizeRecord(int id, string name)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
         

            if (controller.IsProductSizeIsUsed(id))
            {
                MessageBox.Show("This product size cannot be deleted because it is still being used to inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Product size {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.HardDeleteProductSize(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Product size Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        // PRODUCT RECORD

        // PRODUCT RETAIL RECORD
        public void RestoreDeletedProductRetailRecord(int id)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            controller.RestoreProduct(id);
        }

        public void DeleteProductRetailRecord(int id, string name)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
    

            if (controller.IsProductRetailBeingUsed(id))
            {
                MessageBox.Show("This product cannot be deleted because it is still being used to inventory or delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Product {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteProduct(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void RestoreProductRetailSizeRecord(int id)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            controller.RestoreProductSize(id);
        }


        public void DeleteProductRetailSizeRecord(int id, string name)
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);


            if (controller.IsProductRetailSizeUsed(id))
            {
                MessageBox.Show("This product size cannot be deleted because it is still being used to inventory or delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Product size {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.HardDeleteProductSize(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Product size Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        // END OF PRODUCT RETAIL RECORD

        // SERVICE RECORD
        public void RestoreDeletedServiceRecord(int id)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            controller.RestoreServices(id);
        }
        public void DeleteServiceRecord(int id, string name)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
      
            if (controller.IsServiceUsed(id))
            {
                MessageBox.Show("This service cannot be deleted because it is still being used to appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Service {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteService(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Service Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        // SERVICE PRICE RECORD
        public void RestoreDeletedServicePriceRecord(int id)
        {
            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);
            controller.RestoreServicePrice(id);
        }
        public void DeleteServicePriceRecord(int id)
        {
            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);
            controller.PermanentDeleteServicePrice(id);
        }
        // DISCOUNT RECORD

        public void RestoreDeletedDiscountRecord(int id)
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            controller.RestoreDiscount(id);
        }

        public void DeleteDiscountRecord(int id, int sub_id, string name)
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
       

            if (MessageBox.Show($"Delete Discount {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteDiscount(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Discount Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        // SERVICE PRODUCT USAGE
        public void RestoreDeletedServiceProductRecord(int id)
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            controller.RestoreServiceProduct(id);
        }

        public void DeleteServiceProductUsage(int id, int sub_id, string name)
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
         

            if (controller.IsProductUsedInServices(sub_id))
            {
                MessageBox.Show("This product cannot be deleted because it is still being used to inventory or delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete Product {name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (controller.PermanentDeleteServiceProductUsage(id))
                {
                    DeleteDeletedRecord(id);
                    MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



        private async void dgv_deleted_record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgv_deleted_record.Columns[e.ColumnIndex].Name == "col_restore")
            {
                var record = dgv_deleted_record.Rows[e.RowIndex].DataBoundItem as DeletedRecord;

                if (record != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to restore this {record.name} record?",
                        "Information",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        bool success = DeleteDeletedRecord(record.deleted_id);

                        if (success)
                        {
                            switch (record.module)
                            {
                                case "Manage User":
                                    RestoreDeactivatedUserRecord(record.record_id);
                                    await RefreshUsersAsync(currentPage,pageSize);
                                    break;
                                case "Manage Categories":
                                    RestoreDeletedCategoryRecord(record.record_id);
                                    await RefreshCategoryAsync(currentPage,pageSize);
                                    break;
                                case "Manage Stylist":
                                    RestoreDeletedStylistRecord(record.record_id);
                                    await RefreshStylistAsync(currentPage,pageSize);
                                    break;
                                case "Manage Customer":
                                    RestoreDeletedCustomerRecord(record.record_id);
                                    await RefreshCustomers(currentPage,pageSize);
                                    break;
                                case "Manage Supplier":
                                    RestoreDeletedSupplierRecord(record.record_id);
                                    await RefreshSupplierAsync(currentPage,pageSize);
                                    break;
                                case "Manage Sub-Categories":
                                    RestoreDeletedSubCategoryRecord(record.record_id);
                                    await RefreshSubCategoryAsync(currentPage, pageSize);
                                    break;
                                case "Manage Products":
                                    RestoreDeletedProductRecord(record.record_id);
                                    await RefreshProductAsync(currentPage, pageSize);
                                    break;
                                case "Manage Product Size":
                                    RestoreProductSizeRecord(record.record_id);
                                    break;
                                case "Manage Products Retail":
                                    RestoreDeletedProductRetailRecord(record.record_id);
                                    LoadRetailProducts(currentPage, pageSize);
                                    break;
                                case "Manage Product Retail Size":
                                    RestoreProductSizeRecord(record.record_id);
                                    break;
                                case "Manage Services":
                                    RestoreDeletedServiceRecord(record.record_id);
                                    await RefreshServicesAsync(currentPage, pageSize);
                                    break;                           
                                case "Manage Services Product Usage":
                                    RestoreDeletedServiceProductRecord(record.record_id);
                                    break;
                                case "Manage Discount":
                                    RestoreDeletedDiscountRecord(record.record_id);
                                    LoadDiscount();
                                    break;



                            }

                            MessageBox.Show("Record restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            await FilterdDeletedRecords(data_recovery_pagination.CurrentPage, pageSize);
                        }
                        else
                        {
                            MessageBox.Show("Restore failed. Please check logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (dgv_deleted_record.Columns[e.ColumnIndex].Name == "col_btn_deleted_record")
            {
                var record = dgv_deleted_record.Rows[e.RowIndex].DataBoundItem as DeletedRecord;
                if (record != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to permanently delete this {record.name} record?",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {

               

                            switch (record.module)
                            {
                                case "Manage User":
                                    DeleteUserRecord(record.record_id);
                                    await RefreshUsersAsync(currentPage, pageSize);
                                    break;
                                case "Manage Categories":
                                    DeleteCategoryRecord(record.record_id, record.name);
                                await RefreshCategoryAsync(currentPage, pageSize);
                                break;
                                case "Manage Stylist":

                                    DeleteStylistRecord(record.record_id, record.name);
                                    
                                await RefreshStylistAsync(currentPage, pageSize);
                                    break;
                                case "Manage Customer":
                                    DeleteCustomerRecord(record.record_id, record.name);
                                    await RefreshCustomers(currentPage, pageSize);
                                    break;
                                case "Manage Supplier":
                                    DeleteSupplierRecord(record.record_id, record.name);
                                    await RefreshSupplierAsync(currentPage, pageSize);
                                    break;
                                case "Manage Sub-Categories":
                                    DeleteSubCategoryRecord(record.record_id, record.name);
                                    await RefreshSubCategoryAsync(currentPage, pageSize);
                                    break;
                                case "Manage Products":
                                    DeleteProductRecord(record.record_id, record.name);
                                    await RefreshProductAsync(currentPage, pageSize);
                                    break;
                                case "Manage Products Retail":
                                    DeleteProductRetailRecord(record.record_id, record.name);
                                    LoadRetailProducts(currentPage, pageSize);
                                    break;
                                case "Manage Product Size":
                                    DeleteProductSizeRecord(record.record_id, record.name);
                                break;
                                    case "Manage Product Retail Size":
                                    DeleteProductRetailSizeRecord(record.record_id, record.name);
                                    await RefreshProductAsync(currentPage, pageSize);                      
                                    break;
                                case "Manage Services":
                                    DeleteServiceRecord(record.record_id, record.name);
                                    await RefreshServicesAsync(currentPage, pageSize);
                                    break;                              
                                case "Manage Product Consumption":
                                    DeleteServiceProductUsage(record.record_id, record.sub_id, record.name);
                                    break;
                                case "Manage Discount":
                                    DeleteDiscountRecord(record.record_id, record.sub_id, record.name);
                                    LoadDiscount();
                                    break;



                        }



                        await FilterdDeletedRecords(data_recovery_pagination.CurrentPage, pageSize);
                    }
                }
            }

        }

        private async void cmb_deleted_record_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_deleted_record_filter.Text.Length > 0)
            {
                await FilterdDeletedRecords(data_recovery_pagination.CurrentPage, pageSize);
            }
        }

        private async void btn_deleted_record_filter_Click(object sender, EventArgs e)
        {
            cmb_deleted_record_filter.Hint = string.Empty;
            cmb_deleted_record_filter.SelectedIndex = -1;
            await FilterdDeletedRecords(data_recovery_pagination.CurrentPage, pageSize);

            cmb_deleted_record_filter.Hint = "Select Filter";
        }

        private async void btn_deleted_record_clear_Click(object sender, EventArgs e)
        {
            cmb_deleted_record_filter.Hint = string.Empty;
            cmb_deleted_record_filter.SelectedIndex = -1;
            dtp_delete_record_start.Value = DateTime.Today;
            dtp_delete_record_end.Value = DateTime.Today;
            await FilterdDeletedRecords(data_recovery_pagination.CurrentPage, pageSize);

            cmb_deleted_record_filter.Hint = "Select Filter";
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                this.Activate();

                if (notificationTypes.Contains("inventory"))
                    materialTabControl1.SelectedTab = inventoryTab;
                else if (notificationTypes.Contains("discount"))
                    materialTabControl1.SelectedTab = settingsTab;


                notifyIcon1.Visible = false;

            }

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Activate();

            if (notificationTypes.Contains("inventory"))
                materialTabControl1.SelectedTab = inventoryTab;
            else if (notificationTypes.Contains("discount"))
                materialTabControl1.SelectedTab = settingsTab;


            notifyIcon1.Visible = false;



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var repo = new InventoryRepository();
            var controller = new InventoryController(repo);

            controller.UpdateExpiredProducts();
            InventoryBatchProcessed();

            ;
        }


        private void InventoryBatchProcessed()
        {
            var repo = new InventoryBatchRepository();
            var controller = new InventoryBatchController(repo);
            controller.UpdateInventoryStatus();
        }

        private async void expiry_timer_Tick(object sender, EventArgs e)
        {
            //if (!bgExpiryWorker.IsBusy)
            //    bgExpiryWorker.RunWorkerAsync();
            //await RefreshInventoryAsync();

        }

        private void dgv_customer_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }


        private async void RefreshDataTimer_Tick(object sender, EventArgs e)
        {
            //    if (_isRefreshing) return;
            //    _isRefreshing = true;

            //    try
            //    {
            //        // Group 1: Core Data
            //        var coreTasks = new[]
            //        {
            //    RefreshCategoryAsync(),
            //    RefreshUsersAsync(),
            //    RefreshStylistAsync(),
            //    RefreshCustomers(),
            //    RefreshSubCategoryAsync(),
            //    RefreshProductAsync(),
            //    RefreshServicesAsync()
            //};

            //        // Group 2: Business Logic
            //        var businessTasks = new[]
            //        {
            //    RefreshVat(),
            //    RefreshDiscountAsync(),
            //    RefreshSupplierAsync(),
            //    RefreshDeliveryAsync(),
            //    RefreshInventoryAsync(),
            //    RefreshBatchInventory(),
            //    RefreshAppointmentAsync(),
            //    RefreshServicePriceAsync(),
            //    RefreshTransactionAsync(),
            //    RefreshRefundAsync(),
            //    RefreshAuditLog()
            //};

            //        // Group 3: Summary Dashboard
            //        var summaryTasks = new[]
            //        {
            //    RefreshTotalSales(),
            //    RefreshTotalAppointment(),
            //    RefreshTotalProduct(),
            //    RefreshTotalServices(),
            //    RefreshPopularServices()
            //};

            //        // Group 4: Utilities
            //        var utilityTasks = new[]
            //        {
            //    RefreshRentAsync(),
            //    RefreshUtilAsync()
            //};

            //        // Run all groups in parallel
            //        await Task.WhenAll(coreTasks);
            //        await Task.WhenAll(businessTasks);
            //        await Task.WhenAll(summaryTasks);
            //        await Task.WhenAll(utilityTasks);

            //        // Sync calls after async data is ready
            //        LoadUtility();
            //        await FilterdDeletedRecords();

            //        // Reports
            //        RefreshAllReports();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Refresh error: " + ex.Message);
            //    }
            //    finally
            //    {
            //        _isRefreshing = false;
            //    }
        }

        private void RefreshAllReports()
        {
            //FilterSalesReport();
            //filterInventoryReport();
            //FilterExpenseReport();
            //FilterProfitAndLostReport();
            //FilteredCustomerReport();
            //FilteredStaffReport();
            //FilteredDeliveryReport();
            //FilteredDiscountReport();
        }

        private void dtp_report_start_date_ValueChanged(object sender, EventArgs e)
        {
            dtp_report_end_date.MinDate = dtp_report_start_date.Value.Date;
        }

     

       
      
        private void dtp_audit_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_audit_end.MinDate = dtp_audit_start.Value.Date;
        }

        private void dtp_transaction_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_transaction_end.MinDate = dtp_audit_start.Value.Date;
        }



        private void dtp_delete_record_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_delete_record_end.MinDate = dtp_delete_record_start.Value.Date;
        }

        private void dgv_appointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "StartTime" ||
                dgv.Columns[e.ColumnIndex].DataPropertyName == "EndTime")
            {
                if (e.Value is TimeSpan timeSpan)
                {
                    // Convert TimeSpan to DateTime for formatting
                    DateTime time = DateTime.Today.Add(timeSpan);
                    e.Value = time.ToString("hh:mm tt"); // e.g., 02:30 PM
                    e.FormattingApplied = true;
                }
            }
        }

        private async void btn_refresh_data_Click(object sender, EventArgs e)
        {
            await RefreshCategoryAsync(currentPage, pageSize);
        }

        private async void btn_refresh_user_Click(object sender, EventArgs e)
        {
            await RefreshUsersAsync(currentPage, pageSize);
        }

        private async void btn_refresh_stylist_Click(object sender, EventArgs e)
        {
            await RefreshStylistAsync(currentPage, pageSize);
        }

        private async void btn_refresh_customer_Click(object sender, EventArgs e)
        {
            await RefreshCustomers(currentPage, pageSize);
        }

        private async void btn_refresh_supplier_Click(object sender, EventArgs e)
        {
            await RefreshSupplierAsync(currentPage, pageSize);
        }

        private async void btn_refresh_subcategory_Click(object sender, EventArgs e)
        {
            await RefreshSubCategoryAsync(currentPage, pageSize);
        }

        private async void btn_refresh_product_Click(object sender, EventArgs e)
        {
            await RefreshProductAsync(currentPage, pageSize);
        }

        private async void btn_refresh_services_Click(object sender, EventArgs e)
        {
            await RefreshServicesAsync(currentPage, pageSize);
        }


        private async void btn_refresh_appointment_Click(object sender, EventArgs e)
        {
            await RefreshAppointmentAsync(currentPage, pageSize);
        }

        private async void btn_refresh_transaction_Click(object sender, EventArgs e)
        {
            //await RefreshTransactionAsync();
        }

        private async void btn_refresh_data_recovery_Click(object sender, EventArgs e)
        {
            await RefreshDeletedRecords();
        }

        private async void btn_refresh_discount_Click(object sender, EventArgs e)
        {
         
        }

        private void dgv_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_vat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_month_rent_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_electric_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_water_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_internet_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_other_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_bill_note_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
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

        private void txt_working_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits only
            if (char.IsDigit(c))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_walk_in_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_walk_in.Columns[e.ColumnIndex].Name == "btn_walk_in_update")
            {
                var walk_in_data = dgv_walk_in.Rows[e.RowIndex].DataBoundItem as WalkInModel;

                using (var form = new Walk_In_Form(this, walk_in_data))
                {
                    form.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_walk_in.Columns[e.ColumnIndex].Name == "btn_walk_in_payment")
            {
                var walk_in_data = dgv_walk_in.Rows[e.RowIndex].DataBoundItem as WalkInModel;

                using (var form = new Process_Walk_In_Payment_Form(this, walk_in_data))
                {
                    form.ShowDialog();
                }
            }
        }


        // END OF DELETED RECORD


        // POS SYSTEM


        private void LoadPaymentMethodCombobox()
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);
            var paymentMethod = controller.GetAllPaymentMethod();


            cmb_payment_method.DisplayMember = "name";
            cmb_payment_method.ValueMember = "id";
            cmb_payment_method.DataSource = paymentMethod;

            cmb_payment_method.SelectedIndex = -1;
        }


        private string GenerateInvoiceNumber() 
        {
            string prefix = "INV";
            string datePart = DateTime.Now.ToString("yyyyMMdd-HHmm");
            return $"{prefix}-{datePart}";
        }
       
        private int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        private void PrintReceipt(int invoice_id)
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            var services = controller.GetInvoiceServiceCartByInvoiceId(invoice_id);

            decimal sub_total = SubTotal();
            decimal amount_paid = Convert.ToDecimal(lbl_total.Text);
            decimal vat_amount = Convert.ToDecimal(lbl_vat.Text);
            decimal discount_amount = Convert.ToDecimal(lbl_discount_name.Text);
            decimal change_amount = Convert.ToDecimal(lbl_change.Text);
            string payment_method = cmb_payment_method.Text.ToString();

            int vat_rate = Convert.ToInt32(LoadVat());

            ReceiptPrinter receiptPrinter = new ReceiptPrinter(services, sub_total, amount_paid, vat_amount, discount_amount, change_amount, payment_method, vat_rate);
            receiptPrinter.ShowPreview();
            //receiptPrinter.Print();
        }

        private decimal SubTotal()
        {
            decimal subtotal = 0m;

            foreach (DataGridViewRow row in dgv_cart_product.Rows)
            {
                if (row.Cells["col_cart_product_price"].Value != null &&
                    row.Cells["col_cart_product_qty"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["col_cart_product_price"].Value);
                    int qty = Convert.ToInt32(row.Cells["col_cart_product_qty"].Value);

                    subtotal += price * qty;
                }
            }

            return subtotal;
        }



        private decimal LoadVat()
        {
            var repo = new VatRepository();
            var controller = new VatController(repo);
            var vat = controller.LoadLatestTax();

            if (vat != null)
            {
                return vat.tax;

            }
            else
            {
                return 0m;
            }
        }
        private void calculate()
        {

           

            decimal vat = LoadVat();
            decimal original_price = SubTotal();
            decimal discount_rate = currentPercentDiscount;
            decimal discount_amount = 0m;
            decimal points_discount_amount = 0m;
            decimal vat_amount = 0m;
            decimal final_price = 0m;
            decimal base_price = 0m;


            if (discount_rate > 0 && isVatExempt)
            {
                base_price = original_price / (1 + (vat / 100)); // remove VAT
                vat_amount = 0m; // VAT is not charged
                discount_amount = base_price * discount_rate / 100;


            }
            else if (discount_rate > 0)
            {
                base_price = original_price;
                vat_amount = (base_price * vat) / 100;
                discount_amount = (base_price * discount_rate) / 100;

            }
            else if (currentFixedDiscount > 0)
            {
                discount_amount = currentFixedDiscount;
                base_price = original_price;
                vat_amount = (base_price * vat) / 100;
            }
            else
            {
                base_price = original_price;
                vat_amount = (base_price * vat) / 100;
            }

            lbl_vat.Text = vat_amount.ToString("N2");
            //_vatAmount = vat_amount;



            // Step 3: Final payable
            final_price = base_price - discount_amount;

            // Update UI
            //_discountAmount = discount_amount;
            lbl_discount_name.Text = discount_amount.ToString("N2");
            lbl_total.Text = final_price.ToString("N2");
            AmountPaid();

        }
        private void AmountPaid()
        {
            decimal received_amount = Convert.ToDecimal(txt_received.Text == "" ? "0" : txt_received.Text);
            decimal total_amount = Convert.ToDecimal(lbl_total.Text);
            decimal change_amount = 0m;

            if (txt_received.Text.Length > 0)
            {
                change_amount = received_amount - total_amount;

                lbl_change.Text = change_amount.ToString("N2");
            }

            if (change_amount < 0)
            {
                lbl_change.Text = "0.00";
            }
        }
        //private void calculate()
        //{
        //    decimal vat = LoadVat();
        //    decimal original_price = SubTotal();
        //    decimal discount_rate = Convert.ToDecimal(lbl_discount_name.Tag);
        //    decimal discount_amount = 0m;
        //    decimal vat_amount = 0m;
        //    decimal final_price = 0m;
        //    decimal inclusive_price = original_price;
        //    decimal base_price = 0m;

        //    if (discount_rate != 0)
        //    {
        //        discount_amount = (original_price * discount_rate) / 100;



        //        // Step 1: Remove VAT
        //        base_price = inclusive_price / (1 + (LoadVat() / 100));

        //        // Step 2: Compute VAT amount
        //        vat_amount = inclusive_price - base_price;

        //        // Step 3: Compute final payable amount
        //        final_price = base_price - discount_amount;

        //        lbl_vat.Text = vat_amount.ToString("N2");
        //        lbl_discount_name.Text = discount_amount.ToString("N2");
        //        lbl_total.Text = final_price.ToString("N2");

        //    }
        //    else
        //    {
        //        // Step 1: Remove VAT
        //        base_price = inclusive_price / (1 + (LoadVat() / 100));

        //        // Step 2: Compute VAT amount
        //        vat_amount = inclusive_price - base_price;
        //        lbl_vat.Text = vat_amount.ToString("N2");
        //        lbl_total.Text = original_price.ToString("N2");
        //    }





        //}


        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_TextChanged(object sender, EventArgs e)
        {

            decimal received_amount = Convert.ToDecimal(txt_received.Text == "" ? "0" : txt_received.Text);
            decimal total_amount = Convert.ToDecimal(lbl_total.Text);
            decimal change_amount = 0m;

            if (lbl_total.Text.Length > 0)
            {
                change_amount = received_amount - total_amount;

                lbl_change.Text = change_amount.ToString("N2");
            }
        }

        private void Clear()
        {
            lbl_discount_name.Text = "0.00";
            lbl_discount_name.Tag = 0m;
            txt_received.Text = "";
            lbl_sub_total.Text = "0.00";
            lbl_vat.Text = "0.00";
            lbl_total.Text = "0.00";
            lbl_change.Text = "0.00";
            cmb_payment_method.SelectedIndex = -1;
            cart.Clear();
   

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void btn_confirm_payment_Click(object sender, EventArgs e)
        {
  

            decimal amount_paid = Convert.ToDecimal(lbl_total.Text);
            decimal vat_amount = Convert.ToDecimal(lbl_vat.Text);
            decimal discount_amount = Convert.ToDecimal(lbl_discount_name.Text);
            int payment_method_id = Convert.ToInt32(cmb_payment_method.SelectedValue);
            string invoice_number = GenerateInvoiceNumber();
            var invoice = new InvoiceModel
            {
                InvoiceNumber = invoice_number,
                TotalAmount = amount_paid,
                VATAmount = vat_amount,
                DiscountAmount = discount_amount,
                payment_method_id = payment_method_id,
                Timestamp = DateTime.Now
            };


            // Finalize payment
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);

            controller.AddProductInvoice(invoice);
            //AddTransactions(model.AppointmentId, _vatAmount, _discountAmount, _subtotal, totalAmount, cb_PaymentMethod.SelectedItem.ToString(), "Paid", DateTime.Now);


            MessageBox.Show("✅ Payment has been recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Audit.AuditLog(
              DateTime.Now,
              "Process Payment",
              UserSession.CurrentUser.first_Name,
              "Invoice",
              $"Processed payment for invoice '{invoice_number}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
          );



         
            await RefreshBatchInventory();
            await RefreshAppointmentAsync(currentPage, pageSize);
            await RefreshTotalSales();
            //await RefreshTransactionAsync();


            Clear();
        }

        private void btn_create_appointment_Click(object sender, EventArgs e)
        {
            using (var appointmentForm = new AppointmentForm(this))
            {
                appointmentForm.ShowDialog();
            }
        }

       

      

       

        private void txt_search_product_TextChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<string, (int productId, int productSizeId)> productLookup;
        private void SearchProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var products = controller.GetAllRetailProducts(); // or however you fetch all

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            productLookup = new Dictionary<string, (int, int)>();
            foreach (var p in products)
            {
                string display = p.DisplaySearchProduct;
                source.Add(display); // or p.Name depending on your model

                productLookup[display] = (p.product_id, p.product_size_id);
            }

            txt_search_product.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search_product.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_search_product.AutoCompleteCustomSource = source;

        }


        private void txt_search_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selected = txt_search_product.Text;
                if (productLookup.TryGetValue(selected, out var ids))
                {

                    int productId = ids.productId; 
                    int productSizeId = ids.productSizeId; 
                    InsertProductToCart(productId, productSizeId);
                }
                
                txt_search_product.Clear(); // reset for next search
                lbl_sub_total.Text = SubTotal().ToString("N2");
                calculate();
            }

        }


        private void InsertProductToCart(int productId, int productSizeId)
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var product = controller.GetRetailProductByIdAndSize(productId, productSizeId);

            if (product != null)
            {
                var existing = cart.FirstOrDefault(p =>
                    p.product_id == product.product_id &&
                    p.product_size_id == product.product_size_id);

                if (existing != null)
                {
                    MessageBox.Show("This product is already in the cart.");
                }
                else
                {
                    product.quantity = 1;
                    cart.Add(product);
                }

            }

        }

        private void dgv_cart_product_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            var qtyCol = dgv_cart_product.Columns["col_cart_product_qty"];

            if (qtyCol != null && e.ColumnIndex == qtyCol.Index)
            {
                lbl_sub_total.Text = SubTotal().ToString("C");
                calculate();
            }

        }

        private void dgv_cart_product_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_cart_product.IsCurrentCellDirty) { dgv_cart_product.CommitEdit(DataGridViewDataErrorContexts.Commit); }
        }

        private void dgv_cart_product_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_cart_product.Columns[e.ColumnIndex].Name == "col_cart_product_qty")
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
                {
                    e.Cancel = true;
                    dgv_cart_product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            //using (var discountForm = new DiscountModelForm())
            //{
            //    if (discountForm.ShowDialog() == DialogResult.OK)
            //    {
            //        // Get the selected discount rate from the discount form
            //        lbl_discount_name.Text = $"DISCOUNT ({discountForm.discountName}%)";
            //        lbl_discount_name.Tag = discountForm.discountRate.ToString("N2");
            //        calculate();
            //    }
            //}
        }

        private void txt_received_TextChanged(object sender, EventArgs e)
        {
            decimal received_amount = Convert.ToDecimal(txt_received.Text == "" ? "0" : txt_received.Text);
            decimal total_amount = Convert.ToDecimal(lbl_total.Text);
            decimal change_amount = 0m;

            if (txt_received.Text.Length > 0)
            {
                change_amount = received_amount - total_amount;

                lbl_change.Text = change_amount.ToString("N2");
            }
        }
        private int SaveInvoice(InvoiceModel model)
        {
            var repo = new InvoiceRepository();
            var invoiceController = new InvoiceController(repo);
            var invoice_id = invoiceController.AddProductInvoice(model);

            return invoice_id;
        }
        private void SaveInvoiceServices(ServiceCart cart)
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

        }

        private void btn_confirm_payment_Click_1(object sender, EventArgs e)
        {
            decimal amount_paid = Convert.ToDecimal(lbl_total.Text);
            decimal vat_amount = Convert.ToDecimal(lbl_vat.Text);
            decimal discount_amount = Convert.ToDecimal(lbl_discount_name.Text);
            int payment_method_id = Convert.ToInt32(cmb_payment_method.SelectedValue);
            string invoice_number = GenerateInvoiceNumber();

            var invoice = new InvoiceModel
            {
                InvoiceNumber = invoice_number,
                TotalAmount = amount_paid,
                VATAmount = vat_amount,
                DiscountAmount = discount_amount,
                payment_method_id = payment_method_id,
                reference_number = txt_reference.Text.Trim(),
                status = "Paid",
                Notes = txt_reason.Text.Trim(),
                Timestamp = DateTime.Now
            };
         
            int invoice_id = SaveInvoice(invoice);

            var inventory_repo = new InventoryRepository();
            var inventory_controller = new InventoryController(inventory_repo);

            foreach (var product in cart)
            {



                var invoiceServiceCart = new ServiceCart
                {
                    InvoiceId = invoice_id,
                    ProductId = product.product_id,
                    ItemType = "Product",
                    Quantity = product.quantity,
                    Price = product.selling_price,
                    Duration = 0
                };
                SaveInvoiceServices(invoiceServiceCart);

                var repo = new StockOutRepository();
                var controller = new StockOutController(repo);

               
                    controller.DeductProductStockOut(product.product_id, product.product_size_id, product.quantity, "Sale", "used "+ product.quantity +"x " +product.size_label + " of " + product.product_name);



                


               
            }



            MessageBox.Show("Payment has been recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




            Audit.AuditLog(
              DateTime.Now,
              "Process Payment",
              UserSession.CurrentUser.first_Name,
              "Invoice",
              $"Processed payment for invoice '{invoice_number}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
          );


            FilterTransactionReport(currentPage, pageSize);
            Clear();
        }

        private void btn_stock_in_Click(object sender, EventArgs e)
        {
            using (var stock_in_form = new StockInTransactionForm(this)) 
            {


                stock_in_form.RefreshData += async (s, args) => {  LoadInventory(inventory_pagination.CurrentPage, pageSize); };
                stock_in_form.ShowDialog();
            }
        }

        private void btn_stock_out_Click(object sender, EventArgs e)
        {
            using (var stock_out_form = new StockOutForm())
            {
                stock_out_form.ShowDialog();
            }
        }


        private void btn_void_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_transaction_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private decimal currentAmount = 0m;
        private decimal currentPercentDiscount = 0m;
        private decimal currentFixedDiscount = 0m;
        private bool isVatExempt = false;
        private bool pointsRedeemedAlready = false;
        private bool discountAppliedAlready = false;
        private bool OverallDiscountApplied = false;

        public void PremadeButtons(string input)
        {

            decimal amount = Convert.ToDecimal(input);

            currentAmount += amount;
            txt_received.Text = currentAmount.ToString("N2");
            calculate();

        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            PremadeButtons("20");
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            PremadeButtons("50");
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            PremadeButtons("100");
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            PremadeButtons("200");
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            PremadeButtons("500");
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            PremadeButtons("1000");
        }
        private void PremadeDiscountButtons(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return;

            if (discountAppliedAlready)
            {

                return;
            }

            if (decimal.TryParse(input, out decimal discountValue))
            {
                currentPercentDiscount = discountValue;

                calculate();
            }
            else
            {
                calculate();
            }


        }

        private void btn_custom_Click(object sender, EventArgs e)
        {
            using (var form = new CustomAmountForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    txt_received.Text = form.CustomAmount.ToString();
                    calculate();
                }

            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {




            foreach (var item in cart)
            {
                item.DiscountedQty = 0;
                item.DiscountPercent = 0;
                item.DiscountAmount = 0;
                item.IsVatExempt = false;
                item.IsFreeReward = false;
                item.HasDiscountApplied = false;
               
            }
            currentPercentDiscount = 0m;
            currentFixedDiscount = 0m;
            discountAppliedAlready = false;
            OverallDiscountApplied = false;
            txt_received.Text = "0.00";
         
            dgv_cart_product.Refresh();
            lbl_sub_total.Text = SubTotal().ToString("N2");
            calculate();


        }

        private void btn_5_percent_Click(object sender, EventArgs e)
        {
            PremadeDiscountButtons("5");
        }

        private void btn_10_percent_Click(object sender, EventArgs e)
        {
            PremadeDiscountButtons("10");
        }

        private void btn_20_percent_Click(object sender, EventArgs e)
        {
            PremadeDiscountButtons("20");
        }

        private void btn_100_percent_Click(object sender, EventArgs e)
        {
            PremadeDiscountButtons("100");
        }
        public DiscountModel LoadDiscountType(string type)
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var discount = controller.GetDiscountType(type);
            return discount;
        }
        private void btn_senior_Click(object sender, EventArgs e)
        {
            var discount = LoadDiscountType("Senior");

            if (discount == null)
            { 
                MessageBox.Show("Senior discount type not found.");
                return;
            }
            if (discount.mode == "Percentage")
            {
                currentPercentDiscount = discount.discount_rate;

            }
            else if (discount.mode == "Fixed Amount")
            {
                currentFixedDiscount = discount.discount_rate;
            }
            isVatExempt = discount.vat_exempt > 0;
            OverallDiscountApplied = true;
            calculate();
        }

        private void btn_pwd_Click(object sender, EventArgs e)
        {
            var discount = LoadDiscountType("PWD");
   
            if (discount.mode == "Percentage")
            {
                currentPercentDiscount = discount.discount_rate;

            }
            else if (discount.mode == "Fixed Amount")
            {
                currentFixedDiscount = discount.discount_rate;
            }
            isVatExempt = discount.vat_exempt > 0;
            OverallDiscountApplied = true;
            calculate();
        }

        private void txt_peso_amount_TextChanged(object sender, EventArgs e)
        {
            if (discountAppliedAlready)
            {
                txt_peso_amount.ReadOnly = true;
                return;
            }
            if (!string.IsNullOrWhiteSpace(txt_peso_amount.Text))
            {
                if (decimal.TryParse(txt_peso_amount.Text, out decimal discount))
                {
                    currentFixedDiscount = discount;
                    currentPercentDiscount = 0;
                    txt_percent_amount.Text = string.Empty;
                    calculate();

                }

            }
            else
            {
                currentFixedDiscount = 0m;
                calculate();
            }
        }

        private void txt_percent_amount_TextChanged(object sender, EventArgs e)
        {
            if (discountAppliedAlready)
            {
                txt_percent_amount.ReadOnly = true;
                return;
            }
            if (!string.IsNullOrWhiteSpace(txt_percent_amount.Text))
            {
                PremadeDiscountButtons(txt_percent_amount.Text.ToString());
                currentFixedDiscount = 0;
                txt_percent_amount.Text = string.Empty;
            }
            else
            {
                currentPercentDiscount = 0m;
                calculate();
            }
        }

        private void dgv_cart_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;



            if (e.RowIndex >= 0 && dgv_cart_product.Columns[e.ColumnIndex].Name == "col_btn_cart_apply_discount")
            {
                var service = dgv_cart_product.Rows[e.RowIndex].DataBoundItem as RetailProduct;

                if (service.HasDiscountApplied)
                {
                    MessageBox.Show("Discount already applied to this service."); return;
                }

                if (OverallDiscountApplied)
                {
                    MessageBox.Show("A discount has already been applied. Only one discount is allowed per transaction.");
                    return;
                }

                using (var discountForm = new DiscountModelForm(service.product_name, service.quantity, service.selling_price, "POS"))
                {
                    if (discountForm.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected discount rate from the discount form
                        decimal discountAmount = 0m;
                        decimal finalPrice = service.selling_price;

                        if (discountForm.isVatExempt)
                        {
                            service.IsVatExempt = discountForm.isVatExempt;
                            service.HasDiscountApplied = true;
                            service.DiscountedQty = discountForm.discountedQty;
                            service.DiscountPercent = discountForm.discountRate;
                            service.QtyVatExempt = discountForm.discountedQty;

                            var basePrice = service.selling_price / 1.12m;
                            service.DiscountAmount = basePrice * (discountForm.discountRate / 100m) * service.DiscountedQty;


                            discountAppliedAlready = true;

                        }
                        else if (discountForm.fixedDiscount > 0)
                        {
                            service.HasDiscountApplied = true;
                            service.DiscountedQty = discountForm.discountedQty;
                            service.DiscountAmount = discountForm.fixedDiscount;
                            service.DiscountPercent = 0;
                            //service.DiscountAmount = discountAmount;
                            //service.DiscountPercent = (discountAmount / service.Price) * 100m;

                            discountAppliedAlready = true;

                        }
                        else if (discountForm.discountRate > 0)
                        {
                            service.HasDiscountApplied = true;
                            service.IsFreeReward = discountForm.IsFreeReward;
                            service.DiscountedQty = discountForm.discountedQty;
                            service.DiscountPercent = discountForm.discountRate;
                            service.DiscountAmount = service.selling_price * (discountForm.discountRate / 100m) * service.DiscountedQty;
                            //finalPrice = service.Price - discountAmount;

                            //service.DiscountPercent = discountForm.discountRate;
                            //service.DiscountAmount = discountAmount;

                            discountAppliedAlready = true;

                        }


                        RecalculateSummary();
                        dgv_cart_product.Refresh();

                    }
                }
            }
        }

        private void RecalculateSummary()
        {
            decimal subtotal = 0m;
            decimal vatAmount = 0m;
            decimal discountTotal = 0m;
            decimal vatRate = 0.12m;

            foreach (var item in cart)
            {
                subtotal += item.FinalPrice;
                discountTotal += item.DiscountAmount;

                int taxableQty = item.quantity - item.QtyVatExempt;
                int exemptQty = item.QtyVatExempt;

                if (taxableQty > 0)
                {
                    decimal grossTaxable = item.selling_price * taxableQty;
                    decimal baseTaxable = grossTaxable / (1 + vatRate);
                    vatAmount += grossTaxable - baseTaxable;
                }

                // exemptQty contributes to subtotal but no VAT
            }


            lbl_sub_total.Text = subtotal.ToString("N2");
            lbl_vat.Text = vatAmount.ToString("N2");
            lbl_discount_name.Text = discountTotal.ToString("N2");

            decimal grandTotal = subtotal; // subtract loyalty points etc. here
            lbl_total.Text = grandTotal.ToString("N2");
        }

        private void btn_promo_Click(object sender, EventArgs e)
        {
            using (var form = new PromoForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    currentPercentDiscount = form.promo_rate;
                    currentFixedDiscount = form.promo_fixed_amount;
                    isVatExempt = form.vat_exempt > 0;
                    calculate();
                }

            }
        }

        // END OF POS SYSTEM



        // SETTINGS

        public void LoadBusinessHours()
        {
            var repo = new BusinessHourRepository();
            var controller = new TimeSlotController(repo);


            var businessHours = controller.GetBusinessHours();

            if (businessHours != null)
            {
                dtp_opening.Value = DateTime.Today.Add(businessHours.open_time);
                dtp_closing.Value = DateTime.Today.Add(businessHours.close_time);

            }
            else 
            {
                dtp_opening.Value = DateTime.Today;
                dtp_closing.Value = DateTime.Today;
            }

        }
        private void btn_save_business_Click(object sender, EventArgs e)
        {

        }
        public void LoadDiscount() 
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var discounts = controller.getAllDiscount();

            var filteredSorted = discounts.Where(d => d.is_deleted == 0).OrderBy(d => d.discount_type).ToList();

            dgv_discount.AutoGenerateColumns = false;

            col_discount_id.DataPropertyName = "discount_id";
            col_discount_name.DataPropertyName = "discount_type";
            col_discount_promo_name.DataPropertyName = "promo_code";
            col_discount_value.DataPropertyName = "discount_rate";
            col_discount_mode.DataPropertyName = "mode";
            col_discount_status_discount_status.DataPropertyName = "discount_status";
            col_discount_status.DataPropertyName = "status";
            col_discount_vat_exempt.DataPropertyName = "vat_exempt";
            col_discount_defined.DataPropertyName = "is_defined";
            col_discount_start_date.DataPropertyName = "start_date";
            col_discount_end_date.DataPropertyName = "end_date";
                

            dgv_discount.DataSource = filteredSorted;

        }
        private void btn_critical_level_Click(object sender, EventArgs e)
        {
            var repo = new InventoryRepository();
            var controller =new InventoryController(repo);

            var result = MessageBox.Show($"“Do you want to update this record? Confirm to apply changes.”", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                if (controller.UpdateInventoryCriticalLevel(Convert.ToInt32(txt_critical_level.Value))) 
                {
                    MessageBox.Show("Your changes have been saved successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadInventory(currentPage,pageSize);
                }
            }
        }


        private void LoadOwnerEmailAndBusinessName() 
        {

            owner_controller = new OwnerEmailController(owner_repo);
            var load = owner_controller.GetOwnerEmail();

            if (load != null) 
            {
                txt_business_name.Text = load.shop_name.ToString();
                txt_email.Text = load.email.ToString();
                txt_password.Text = load.pass.ToString();

            }
        }
        private void btn_owner_email_Click(object sender, EventArgs e)
        {

        }

        public void LoadPaymentMethod()
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);
            var paymentMethod = controller.GetAllPaymentMethod();


            var filteredSorted = paymentMethod.Where(pm => pm.is_active).OrderBy(pm => pm.name).ToList();


            dgv_payment_method.AutoGenerateColumns = false;
     

            col_payment_method_id.DataPropertyName = "id";
            col_payment_method_name.DataPropertyName = "name";
            col_payment_method_required_display_text.DataPropertyName = "required_text";
            col_payment_method_required.DataPropertyName = "required_reference";
            col_payment_method_status.DataPropertyName = "is_active";
            col_payment_method_status_display_text.DataPropertyName = "status_text";


            dgv_payment_method.DataSource = filteredSorted;
            
  

        }

        private void btn_add_payment_method_Click(object sender, EventArgs e)
        {
            using (var form = new PaymentMethodForm(this)) 
            {
                form.ShowDialog();
            }
        }

        private void dgv_payment_method_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_payment_method.Columns[e.ColumnIndex].Name == "col_payment_method_update")
            {
                var model = dgv_payment_method.Rows[e.RowIndex].DataBoundItem as PaymentMethodModel;

                using (var form = new PaymentMethodForm(this, model))
                {
                    form.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_payment_method.Columns[e.ColumnIndex].Name == "col_payment_method_delete") 
            {
                var model = dgv_payment_method.Rows[e.RowIndex].DataBoundItem as PaymentMethodModel;

                var result = MessageBox.Show($"Are  you sure you want to delete {model.name} ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    var repo = new PaymentMethodRepository();
                    var controller = new PaymentMethodController(repo);

                    if (controller.SoftDeletePaymentMethod(model.id)) 
                    {
                        MessageBox.Show($"{model.name} has been deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Categories", $"Deleted category '{model.name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                        InsertDeletedRecord(model.id, null, "Payment Method", model.name, UserSession.CurrentUser.first_Name, DateTime.Today);
                        LoadPaymentMethod();
                    }
                }
            }
        }

        private void cmb_payment_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment_method.SelectedItem is PaymentMethodModel selectedMethod)
            {
                if (selectedMethod.required_reference)
                {
                    lbl_reference.Visible = true;
                    txt_reference.Visible = true;
                }
                else
                {
                    lbl_reference.Visible = false;
                    txt_reference.Visible = false;
                }

            }
        }

        private void txt_received_Click(object sender, EventArgs e)
        {

        }

        private async void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_discount.Columns[e.ColumnIndex].Name == "col_btn_discount_update")
            {
                var discount_model = dgv_discount.Rows[e.RowIndex].DataBoundItem as DiscountModel;

                using (var form = new DiscountForm(this, discount_model))
                {
                    form.ShowDialog();
                }
            }
            else if (e.RowIndex >= 0 && dgv_discount.Columns[e.ColumnIndex].Name == "col_btn_discount_delete") 
            {
                var discount_model = dgv_discount.Rows[e.RowIndex].DataBoundItem as DiscountModel;

                var result = MessageBox.Show($"Are you sure you want to delete this {discount_model.discount_type} ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    var repo = new DiscountRepository();
                    var controller = new DiscountController(repo);

                    controller.DeleteDiscount(discount_model.discount_id);

                    MessageBox.Show($"{discount_model.discount_type} has been deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Discount", $"Deleted discount '{discount_model.discount_type}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

                    InsertDeletedRecord(discount_model.discount_id, null, "Manage Discount", discount_model.discount_type, UserSession.CurrentUser.first_Name, DateTime.Today);
                    LoadDiscount();
                   await FilterdDeletedRecords(currentPage,pageSize);
                }
                
            }

        }

        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            using (var form = new DiscountForm(this))
            {
                form.ShowDialog();
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_supplier_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void materialCard17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_report_total_sales_Click(object sender, EventArgs e)
        {

        }

        private void materialCard37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_smtp_Click(object sender, EventArgs e)
        {
            txt_business_name.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_password.ReadOnly = false;
            btn_update_smtp.Visible = true;
            btn_edit_smtp.Visible = false;
        }

        private void btn_update_smtp_Click(object sender, EventArgs e)
        {
            txt_business_name.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_password.ReadOnly = true;
            btn_update_smtp.Visible = false;
            btn_edit_smtp.Visible = true;

            var model = new OwnerEmaillModel
            {
                shop_name = txt_business_name.Text,
                email = txt_email.Text,
                pass = txt_password.Text,

            };
            owner_controller = new OwnerEmailController(owner_repo);
            var updated = owner_controller.Update(model);
            if (updated)
            {
                MessageBox.Show("SMTP configuration updated successully!");
            }
        }

        private void btn_save_smtp_Click(object sender, EventArgs e)
        {
            var model = new OwnerEmaillModel 
            {
                shop_name = txt_business_name.Text,
                email = txt_email.Text,
                pass = txt_password.Text,
                
            };
            owner_controller = new OwnerEmailController(owner_repo);
            var saved = owner_controller.Create(model);
            if (saved) 
            {
                MessageBox.Show("Save");
            }
        }

        private async void btn_back_up_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select folder to save backup";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string backupFile = Path.Combine(
                        fbd.SelectedPath,
                        $"backup_{DateTime.Now:yyyyMMdd_HHmm}.sql"
                    );

                    var helper = new DatabaseHelper(
                        "Server=localhost;Database=hcsansor;Uid=root;Pwd=",
                        @"C:\xampp\mysql\bin"
                    );
                    bool cancelled = false;

                    using (var progressForm = new progressForm())
                    {
                        progressForm.CancelRequested += (s, e2) => cancelled = true;

                        progressForm.Show();
                        progressForm.UpdateStatus("Starting backup...");

                        await Task.Run(() => { if (!cancelled) helper.BackupDatabase(backupFile); });


                        if (cancelled) 
                        { 
                            progressForm.Complete("Backup cancelled!");
                        }
                        else {
                            progressForm.Complete();
                        }


                     
                        await Task.Delay(1000); 
                        progressForm.Close();
                    }


                    if (!cancelled) MessageBox.Show("✅ Backup completed: " + backupFile);
                    else MessageBox.Show("❌ Backup cancelled.");
                }
            }
        }



        private void btn_browse_back_up_Click(object sender, EventArgs e)
        {

        }

        private void btn_restore_db_Click(object sender, EventArgs e)
        {
           
        }

        private async void btn_back_up_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select folder to save backup";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string backupFile = Path.Combine(
                        fbd.SelectedPath,
                        $"backup_{DateTime.Now:yyyyMMdd_HHmm}.sql"
                    );

                    var helper = new DatabaseHelper(
                        "Server=localhost;Database=hcsansor;Uid=root;Pwd=",
                        @"C:\xampp\mysql\bin"
                    );
                    bool cancelled = false;

                    using (var progressForm = new progressForm())
                    {
                        progressForm.CancelRequested += (s, e2) => cancelled = true;
                        progressForm.SetTitle("Backup Progress");
                        progressForm.Show();
                        progressForm.UpdateStatus("Starting backup...");

                        await Task.Run(() => { if (!cancelled) helper.BackupDatabase(backupFile); });


                        if (cancelled)
                        {
                            progressForm.Complete("Backup cancelled!");
                        }
                        else
                        {
                            progressForm.Complete();
                        }



                        await Task.Delay(1000);
                        progressForm.Close();
                    }


                    if (!cancelled) MessageBox.Show("✅ Backup completed: " + backupFile);
                    else MessageBox.Show("❌ Backup cancelled.");
                }
            }
        }

        private async void btn_restore_Click(object sender, EventArgs e)
        {
            var helper = new DatabaseHelper(
                "Server=localhost;Database=hcsansor;Uid=root;Pwd=",
                @"C:\xampp\mysql\bin"
            );

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SQL files (*.sql)|*.sql";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var progressForm = new progressForm())
                    {
                        progressForm.SetTitle("Restore  Progress");
                        progressForm.Show();
                        progressForm.UpdateStatus("Starting restore...");

                        try
                        {
                            await Task.Run(() => helper.RestoreDatabase(ofd.FileName));
                            progressForm.Complete("Restore completed!");
                        }
                        catch (Exception ex)
                        {
                            progressForm.Complete("Error: " + ex.Message);
                        }

                        await Task.Delay(1000);
                        progressForm.Close();
                    }

                    MessageBox.Show("✅ Restore completed from: " + ofd.FileName);
                }
            }
        }

        private async void btn_test_smtp_connection_Click(object sender, EventArgs e)
        {
            btn_test_email_connection.Enabled = false;

            using (var loading = new LoadingScreenEmail())
            {
                loading.Show();
                loading.Refresh(); // force immediate paint so the user sees it

                try
                {
                    bool sent = await SendEmail(txt_email.Text, txt_password.Text, txt_business_name.Text);

                    if (sent)
                    {
                        MessageBox.Show("Connection successful! Test email sent.");
                    }
                    else
                    {
                        MessageBox.Show("Connection failed. Could not send test email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}");
                }
                finally
                {
                    loading.Close(); // close the loading screen
                    btn_test_email_connection.Enabled = true;
                }
            }
        }

        private async Task<bool> SendEmail(string email, string password, string shop_name)
        {
            return await EmailMessage.SendTestEmailConnection(email, password, shop_name);
        }

    }
}


