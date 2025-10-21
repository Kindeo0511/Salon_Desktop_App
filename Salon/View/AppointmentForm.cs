using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Services;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Salon.View
{
    public partial class AppointmentForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel model;
        private CustomerModel customerModel;
        private List<ServiceItemSelected> serviceSelected;
        private int duration_temp = 0;

        public AppointmentForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_table);
            this.mainForm = mainForm;
            cmb_Date.MinDate = DateTime.Today;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3); 


            for (int hour = 9; hour <= 21; hour++)
            {
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                cb_Time.Items.Add(formattedTime);
            }
        }
        public AppointmentForm(MainForm mainForm, AppointmentModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_table);
            this.mainForm = mainForm;
            this.model = model;
            cmb_Date.MinDate = DateTime.Today;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);

            for (int hour = 9; hour <= 21; hour++)
            {
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                cb_Time.Items.Add(formattedTime);
            }
            //customerModel.customer_name = model.CustomerName;
            //customerModel.phoneNumber = model.PhoneNumber;
            //customerModel.email = model.Email;
            //customerModel.customer_id = model.CustomerId;
            txt_FullName.Text = model.CustomerName;
            lbl_ID.Text = model.CustomerId.ToString();
            txt_Contact.Text = model.PhoneNumber;
            txt_Email.Text = model.Email;
            cb_book_type.Text = model.BookingType;
            cb_Time.Text = DateTime.Today.Add(model.StartTime).ToString("hh:mm tt");
            cmb_Date.Value = model.AppointmentDate;
            btn_update.Visible = true;
            btn_confirm.Visible = false;
            btn_check_available.Visible = false;
            reloadSelectedServices(model.AppointmentId);


        }
        private void reloadSelectedServices(int id) 
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);
            var services = controller.GetSelectedServices(id);

            foreach (var service in services) 
            {
                dgv_table.Rows.Add(service.ServiceId, service.ServiceName, service.SubCategoryname, service.Duration);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            customer_panel.Controls.Clear();

            if (txt_Search.TextLength >= 1)
            {
                var repo = new CustomerRepository();
                var customerController = new CustomerController(repo);
                var filteredCustomers = customerController
                    .GetCustomerBySearch(txt_Search.Text)
                    .Take(5); // Limit to 5 results

                foreach (var customer in filteredCustomers)
                {
                    var searchResult = new SearchResultControl();
                    searchResult.details(customer);
                    searchResult.ResultClicked += ResultControl_ResultClicked;
                    customer_panel.Controls.Add(searchResult);
                }
            }

            customer_panel.Height = customer_panel.Controls.Count * 80;
        }
        private void ResultControl_ResultClicked(object sender, CustomerModel customer)
        {
            txt_Search.Text = string.Empty;
            customer_panel.Controls.Clear();
            lbl_ID.Text = customer.customer_id.ToString();
            txt_FullName.Text = customer.customer_name;
            txt_Email.Text = customer.email;
            txt_Contact.Text = customer.phoneNumber;
        }

        private bool CustomerFieldMissing()
        {
            if (string.IsNullOrWhiteSpace(txt_FullName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Contact.Text) ||
                cb_Time.SelectedItem == null)
            {

                return true;
            }

            return false;
        }

        private void LoadTimeSlots(DateTime selectedDate)
        {
            var repo = new BusinessHourRepository();
            var generator = new TimeSlotGenerator();
            var timeSlotController = new TimeSlotController();
            var day = selectedDate.DayOfWeek.ToString();
            var hours = repo.GetHoursForDay(day);
            var slots = generator.GenerateSlots(hours, selectedDate);

            cb_Time.Items.Clear();
            var availableSlots = timeSlotController.GetTimeSlots(selectedDate);
            cb_Time.Items.AddRange(slots.Select(s => s.ToString()).ToArray());

        }

        private void cb_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Time.SelectedItem is DateTime selectedDate)
            {
                LoadTimeSlots(selectedDate);
            }

        }

        private void txt_search_services_TextChanged(object sender, EventArgs e)
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            service_panel.Controls.Clear();

            if (txt_search_services.TextLength >= 1)
            {
                var getService = serviceController
                    .getServiceByName(txt_search_services.Text.Trim())
                    .Take(5);

                foreach (var service in getService)
                {
                    var searchResult = new ServicesCard();
                    searchResult.details(service);
                    searchResult.AddToCartClicked += OnAddToCart;
                    service_panel.Controls.Add(searchResult);
                }
            }

            service_panel.Height = service_panel.Controls.Count * 100;
        }

        private void OnAddToCart(object sender, ServiceModel service)
        {
            txt_search_services.Text = string.Empty;
            // Optional: check for duplicates or validate
            if (!IsAlreadyInCart(service.serviceName))
            {
                dgv_table.Rows.Add(service.serviceName_id, service.serviceName, service.subCategoryName, service.duration);
            }


        }

        private bool IsAlreadyInCart(string serviceName)
        {
            foreach (DataGridViewRow row in dgv_table.Rows)
            {
                if (row.Cells["col_service_name"].Value?.ToString() == serviceName)
                    return true;
            }
            return false;
        }
        private void UpdateAppointment() 
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            int total_duration = 0;
            decimal total_price = 0;

            serviceSelected = new List<ServiceItemSelected>();



            foreach (DataGridViewRow row in dgv_table.Rows)
            {

                int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
                string name = row.Cells["col_service_name"].Value.ToString();
                string category = row.Cells["col_category_name"].Value.ToString();
                int duration = Convert.ToInt32(row.Cells["col_duration"].Value);


                total_duration += duration;
                var service = new ServiceItemSelected
                {
                    service_id = service_id,
                    service_name = name,
                    category_name = category,
                    total_duration = duration,
                    price = total_price

                };



                serviceSelected.Add(service);
            }

            if (serviceSelected.Count == 0)
            {
                MessageBox.Show("Please select at least one service before confirming.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CustomerFieldMissing())
            {
                MessageBox.Show("Please complete all required fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateAppointment(total_duration);
            }
        }
        private BookingSummary BuildBookingSummary(int total_duration)
        {
            var customer = new CustomerModel
            {
                customer_id = Convert.ToInt32(lbl_ID.Text),
                customer_name = txt_FullName.Text,
                email = txt_Email.Text,
                phoneNumber = txt_Contact.Text
            };

            var appointmentDate = cmb_Date.Value.Date;
            var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));
            var book_type = cb_book_type.Text;

            return new BookingSummary
            {
                CustomerModel = customer,
                SelectedServices = serviceSelected,
                AppointmentDate = appointmentDate,
                AppointmentTime = appointmentTime,
                AppointmentEndTime = appointmentEndTime,
                BookingType = book_type
            };
        }

        private void UpdateAppointment(int total_duration)
        {
            var summary = BuildBookingSummary(total_duration);
            var confirmationForm = new ConfirmationBooking(this, mainForm, summary, isUpdate: true, appointmentId: model.AppointmentId);
            if (confirmationForm.ShowDialog() == DialogResult.OK)
            {
                serviceSelected.Clear();
            }

            //var customer = new CustomerModel
            //{
            //    customer_id = Convert.ToInt32(lbl_ID.Text),
            //    customer_name = txt_FullName.Text,
            //    email = txt_Email.Text,
            //    phoneNumber = txt_Contact.Text
            //};


            //var appointmentDate = cmb_Date.Value.Date;
            //var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));
            //var book_type = cb_book_type.Text;

            //var summary = new BookingSummary
            //{
            //    CustomerModel = customer,
            //    SelectedServices = serviceSelected,
            //    AppointmentDate = appointmentDate,
            //    AppointmentTime = appointmentTime,
            //    AppointmentEndTime = appointmentEndTime,
            //    BookingType = book_type
            //};

            //var appointment = new Models.AppointmentModel
            //{
            //    AppointmentId = model.AppointmentId,
            //    CustomerId = model.CustomerId,
            //    AppointmentDate = appointmentDate,
            //    StartTime = appointmentTime,
            //    EndTime = appointmentEndTime,
            //    Status = model.Status,
            //    PaymentStatus = model.PaymentStatus,
            //    BookingType = book_type

            //};

            //var repo = new AppointmentRepository();
            //var appointmentController = new AppointmentController(repo);
            //int appointmentId = appointmentController.UpdatingTheAppointment(appointment);

            //var service_repo = new AppointmentServiceRepository();
            //var service_controller = new AppointmentServiceController(service_repo);

            //service_controller.ClearDeleteAllServicesForAppointment(appointmentId);

            //foreach (var service in serviceSelected)
            //{

            //var appointmentService = new AppointmentServicesModel
            //{

            //    AppointmentId = appointmentId,
            //    ServiceId = service.service_id

            //};
            //var appointmentServiceRepo = new Repository.AppointmentServiceRepository();
            // appointmentServiceRepo.AddAppointmentService(appointmentService);

            //}
            //MessageBox.Show("The appointment has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //mainForm.LoadAppointments();
            //mainForm.LoadTotalAppointments();
            //mainForm.LoadPopularServices();


            //this.Close();



        }
        private void SaveAppointment() 
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            int total_duration = 0;
            decimal total_price = 0;

           serviceSelected = new List<ServiceItemSelected>();



            foreach (DataGridViewRow row in dgv_table.Rows)
            {

                int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
                string name = row.Cells["col_service_name"].Value.ToString();
                string category = row.Cells["col_category_name"].Value.ToString();
                int duration = Convert.ToInt32(row.Cells["col_duration"].Value);

                duration_temp += duration;
                total_duration += duration;
                var service = new ServiceItemSelected
                {
                    service_id = service_id,
                    service_name = name,
                    category_name = category,
                    total_duration = duration,

                };



                serviceSelected.Add(service);
            }

            if (serviceSelected.Count == 0)
            {
                MessageBox.Show("Please select at least one service before confirming.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CustomerFieldMissing())
            {
                MessageBox.Show("Please complete all required fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveAppointment(total_duration);
            }

        }
        private void SaveAppointment(int total_duration)
        {
            var summary = BuildBookingSummary(total_duration);
            var confirmationForm = new ConfirmationBooking(this, mainForm, summary, isUpdate: false);
            if (confirmationForm.ShowDialog() == DialogResult.OK)
            {
                serviceSelected.Clear();
            }


            //var customer = new CustomerModel
            //{
            //    customer_id = Convert.ToInt32(lbl_ID.Text),
            //    customer_name = txt_FullName.Text,
            //    email = txt_Email.Text,
            //    phoneNumber = txt_Contact.Text
            //};

            //var appointmentDate = cmb_Date.Value.Date;
            //var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));
            //var book_type = cb_book_type.Text;

            //var summary = new BookingSummary
            //{
            //    CustomerModel = customer,
            //    SelectedServices = serviceSelected,
            //    AppointmentDate = appointmentDate,
            //    AppointmentTime = appointmentTime,
            //    AppointmentEndTime = appointmentEndTime,
            //    BookingType = book_type
            //};



            //var confirmationForm = new ConfirmationBooking(this, mainForm, summary);
            //confirmationForm.ShowDialog();
            //serviceSelected.Clear();


        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (model != null)
            {

                UpdateAppointment();
            }
            else 
            {
                SaveAppointment();
            }
               
        }

        private void dgv_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_table.CurrentRow == null || dgv_table.CurrentRow.Index < 0)
                return;

            if (e.RowIndex >= 0 && dgv_table.Columns[e.ColumnIndex].Name == "col_btn_delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (model != null)
                    {
                        var service_repo = new AppointmentServiceRepository();
                        var service_controller = new AppointmentServiceController(service_repo);
                        service_controller.ClearDeleteAllServicesForAppointment(model.AppointmentId);
                        dgv_table.Rows.RemoveAt(dgv_table.CurrentRow.Index);

                        btn_confirm.Enabled = false;
                    }
                    else 
                    {
                        dgv_table.Rows.RemoveAt(dgv_table.CurrentRow.Index);
                        btn_confirm.Enabled = false;
                    }
    
                    // Remove from the grid
                  
                }
            }


        }
        public void CommitAppointment(BookingSummary summary, bool isUpdate)
        {
            var appointment = new AppointmentModel
            {
                AppointmentId = isUpdate ? model.AppointmentId : 0,
                CustomerId = summary.CustomerModel.customer_id,
                AppointmentDate = summary.AppointmentDate,
                StartTime = summary.AppointmentTime,
                EndTime = summary.AppointmentEndTime,
                Status = "Scheduled",
                PaymentStatus = "Unpaid",
                BookingType = summary.BookingType
            };

            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);

            int appointmentId = isUpdate
                ? appointmentController.UpdatingTheAppointment(appointment)
                : appointmentController.CreateAppointment(appointment); 

            var serviceRepo = new AppointmentServiceRepository();
            var serviceController = new AppointmentServiceController(serviceRepo);

            if (isUpdate)
                serviceController.ClearDeleteAllServicesForAppointment(appointmentId);

            foreach (var service in summary.SelectedServices)
            {
                var appointmentService = new AppointmentServicesModel
                {
                    AppointmentId = appointmentId,
                    ServiceId = service.service_id
                };
                serviceRepo.AddAppointmentService(appointmentService);
            }

            MessageBox.Show("The appointment has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.LoadAppointments();
            mainForm.LoadTotalAppointments();
            mainForm.LoadPopularServices();
            this.Close();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateAppointment();


        }
        private bool Validated()
        {

            bool validated = true;
            
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_FullName, errorProvider1, "Full name is required.");
            validated &= Validator.IsRequired(txt_Contact, errorProvider1, "Contact is required.");
            validated &= Validator.IsRequired(txt_Email, errorProvider1, "Email is required.");
            validated &= Validator.IsRequired(cb_book_type, errorProvider1, "Booking Type is required.");
            validated &= Validator.IsRequired(cb_Time, errorProvider1, "Time is required.");
            validated &= Validator.IsRequired(cmb_Date, errorProvider1, "Time is required.");

            DateTime selectedDate = cmb_Date.Value;

            // 1. Prevent past dates
            if (selectedDate < DateTime.Today)
            {
                errorProvider1.SetError(cmb_Date, "Appointment date must be today or later.");
                validated = false;
            }

            // 2. Prevent booking too far in advance
            else if (selectedDate > DateTime.Today.AddMonths(3))
            {
                errorProvider1.SetError(cmb_Date, "Appointments can only be booked up to 3 months in advance.");
                validated = false;
            }




            return validated;


        }
        private async void btn_check_available_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            int totalDuration = 0;

            foreach (DataGridViewRow row in dgv_table.Rows)
            {
                if (row.Cells["col_duration"].Value != null)
                {
                    int durationn = Convert.ToInt32(row.Cells["col_duration"].Value);
                    totalDuration += durationn;
                }
            }

            if (totalDuration == 0)
            {
                MessageBox.Show("Please select at least one service before checking availability.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);
            var date = cmb_Date.Value.Date;
            var startTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            var duration = TimeSpan.FromMinutes(totalDuration);
            int  id = Convert.ToInt32(lbl_ID.Text.ToString());

            bool isCustomerAlreadyBooked = await controller.CustomerIsAlreadyBooked(date, startTime, duration, id);
            //bool isAvailable = await controller.CheckSlotRangeAvailable(date, startTime, duration);

            string message;
            MessageBoxIcon icon;

            //if (isCustomerAlreadyBooked)
            //{
            //    message = "❗ Customer is already booked for this slot.";
            //    icon = MessageBoxIcon.Warning;
            //    btn_confirm.Enabled = false;
            //}
            ////else if (!isAvailable)
            ////{
            ////    message = "❌ Slot is taken by another customer.";
            ////    icon = MessageBoxIcon.Warning;
            ////    btn_confirm.Enabled = false;
            ////}
            //else
            //{
            //    message = "✅ Slot is available.";
            //    icon = MessageBoxIcon.Information;
            //    btn_confirm.Enabled = true;
            //}

            if (isCustomerAlreadyBooked)
            {
                message = "❗ This customer is already booked for this time slot.";
                icon = MessageBoxIcon.Warning;
                btn_confirm.Enabled = false;
            }
            else
            {
                message = "✅ Slot is available for this customer.";
                icon = MessageBoxIcon.Information;
                btn_confirm.Enabled = true;
            }



            MessageBox.Show(message, "Slot Status", MessageBoxButtons.OK, icon);


        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (model != null) 
            {
                if (dgv_table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "You must select at least one service before closing.",
                        "Missing Services",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    e.Cancel = true; // Prevent form from closing
                }
            }
       

        }





        //public async Task<bool> IsSlotRangeAvailableAsync(DateTime date, TimeSpan startTime, TimeSpan duration)
        //{
        //    int slotsNeeded = (int)Math.Ceiling(duration.TotalHours);
        //    var repo = new AppointmentRepository();
        //    var controller = new AppointmentController(repo);
        //    for (int i = 0; i < slotsNeeded; i++)
        //    {
        //        var slotTime = startTime.Add(TimeSpan.FromHours(i));
        //        if (await controller.CheckIsSlotTaken(date, slotTime)) 
        //            return false;
        //    }

        //    return true;
        //}
    }
}
