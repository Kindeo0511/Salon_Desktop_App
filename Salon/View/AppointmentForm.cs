using MaterialSkin.Controls;
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
namespace Salon.View
{
    public partial class AppointmentForm : MaterialForm
    {
        private MainForm mainForm;
        private List<ServiceItemSelected> serviceSelected;
        public AppointmentForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_table);
            this.mainForm = mainForm;


            for (int hour = 9; hour <= 21; hour++)
            {
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                cb_Time.Items.Add(formattedTime);
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

            var summary = new BookingSummary
            {
                CustomerModel = customer,
                SelectedServices = serviceSelected,
                AppointmentDate = appointmentDate,
                AppointmentTime = appointmentTime,
                AppointmentEndTime = appointmentEndTime,
                BookingType = book_type
            };



            var confirmationForm = new ConfirmationBooking(this,mainForm, summary);
            confirmationForm.ShowDialog();

        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SaveAppointment();
        }
    }
}
