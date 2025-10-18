using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class ConfirmationBooking : MaterialForm
    {
        private MainForm mainForm;
        private BookingSummary summary;
        private AppointmentForm appointmentForm;
        private bool isUpdate;
        private int existingAppointmentId;


        public ConfirmationBooking(AppointmentForm appointment, MainForm mainForm, BookingSummary summary, bool isUpdate = false, int appointmentId = 0)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.summary = summary;
            this.appointmentForm = appointment;
            this.isUpdate = isUpdate;
            this.existingAppointmentId = appointmentId;
            DisplaySummary();

        }

        private void DisplaySummary()
        {

            DateTime startTime = DateTime.Today.Add(summary.AppointmentTime);
            DateTime endTime = DateTime.Today.Add(summary.AppointmentEndTime);

            string formattedStartTime = startTime.ToString("hh:mm tt");
            string formattedEndTime = endTime.ToString("hh:mm tt");

            lbl_CustomerName.Text = summary.CustomerModel.customer_name;
            lbl_Contact.Text = summary.CustomerModel.phoneNumber;
            lbl_Email.Text = summary.CustomerModel.email;
          
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
            lbl_book_type.Text = summary.BookingType;
            lbl_Date.Text = summary.AppointmentDate.ToString();

            foreach (var service in summary.SelectedServices)
            {
                lbl_Services.Text += $"- {service.service_name}\n";
            }



        }

        private async void btn_Confirm_Click(object sender, EventArgs e)
        {

            DateTime startTime = DateTime.Today.Add(summary.AppointmentTime);
            string formattedStartTime = startTime.ToString("hh:mm tt");

            var model = new AppointmentModel
            {
                AppointmentId = isUpdate ? existingAppointmentId : 0,
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
            int appointmentId;

            if (isUpdate)
            {
                appointmentId = appointmentController.UpdatingTheAppointment(model);

                var serviceRepo = new AppointmentServiceRepository();
                var serviceController = new AppointmentServiceController(serviceRepo);
                serviceController.ClearDeleteAllServicesForAppointment(appointmentId);

                Audit.AuditLog(
                DateTime.Now,
                "Update",
                UserSession.CurrentUser.first_Name,
                "Appointment",
                $"Updated appointment for '{summary.CustomerModel.customer_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            }
            else
            {
                appointmentId = appointmentController.CreateAppointment(model);

                Audit.AuditLog(
                DateTime.Now,
                "Create",
                UserSession.CurrentUser.first_Name,
                "Appointment",
                 $"Created appointment for '{summary.CustomerModel.customer_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            }

            foreach (var service in summary.SelectedServices)
            {
                var appointmentService = new AppointmentServicesModel
                {
                    AppointmentId = appointmentId,
                    ServiceId = service.service_id
                };

                var appointmentServiceRepo = new AppointmentServiceRepository();
                appointmentServiceRepo.AddAppointmentService(appointmentService);
            }






            try
            {
                //await EmailMessage.SendNotificationEmailAsync(
                //to: summary.CustomerModel.email,
                //recipientName: summary.CustomerModel.customer_name,
                //appointmentTime: $"{summary.AppointmentDate} at {formattedStartTime}",
                //services: lbl_Services.Text,
                //customMessage: "Your appointment has been confirmed. Please arrive 10 minutes early and bring your ID.");

                //await SmsSender.SendSmsNotificationAsync(
                //phone: summary.CustomerModel.phoneNumber,
                //customerName: summary.CustomerModel.customer_name,
                //appointmentDate: summary.AppointmentDate.ToString("MM/dd/yyyy"),
                //startTime: formattedStartTime);

                MessageBox.Show($"The appointment has been {(isUpdate ? "updated" : "booked")} successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }




            mainForm.LoadAppointments();
            mainForm.LoadTotalAppointments();
            mainForm.LoadPopularServices();
            mainForm.LoadAllTransactions();
            this.DialogResult = DialogResult.OK;
            this.Close();
            appointmentForm.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
