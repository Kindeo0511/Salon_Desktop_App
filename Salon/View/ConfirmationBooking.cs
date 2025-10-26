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
            lbl_id.Text = summary.CustomerModel.customer_id.ToString();
            lbl_CustomerName.Text = summary.CustomerModel.customer_name;
            lbl_Contact.Text = summary.CustomerModel.phoneNumber;
            lbl_Email.Text = summary.CustomerModel.email;
            
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
            lbl_book_type.Text = summary.BookingType;
            txt_customer_type.Text = summary.CustomerModel.customer_type;
            lbl_Date.Text = summary.AppointmentDate.ToString();

            foreach (var service in summary.SelectedServices)
            {
                lbl_Services.Text += $"- {service.service_name}\n";
            }



        }
        private async void btn_Confirm_Click(object sender, EventArgs e)
        {
            btn_Confirm.Enabled = false;
            btn_cancel.Enabled = false;

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

            // ✅ Check stylist availability before confirming
            var stylistController = new StylistController(new StylistRepository());
            var assignedStylists = stylistController.GetAssignedStylist(
                model.AppointmentDate,
                model.StartTime,
                model.EndTime
            );

           

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
                    "Reschedule",
                    UserSession.CurrentUser.first_Name,
                    "Appointment",
                    $"Rescheduled appointment for '{summary.CustomerModel.customer_name}' to {model.AppointmentDate:yyyy-MM-dd} at {formattedStartTime}");
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

            // ✅ Save selected services
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

            // ✅ Send notifications if registered
            try
            {
                if (txt_customer_type.Text.ToLower() == "registered")
                {
                    var loading = new LoadingScreenEmail();
                    loading.Show();
                    Application.DoEvents();

                    try
                    {
                        await SendNotificationsAsync(summary, formattedStartTime, lbl_Services.Text, isUpdate ? "Rescheduled" : "Booked");
                    }
                    finally
                    {
                        if (loading.InvokeRequired)
                            loading.Invoke(new Action(() => loading.Close()));
                        else
                            loading.Close();
                    }
                }

                MessageBox.Show($"The appointment has been {(isUpdate ? "rescheduled" : "booked")} successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex is System.Net.WebException || ex.Message.Contains("network") || ex.Message.Contains("internet"))
                {
                    MessageBox.Show("Failed to send confirmation. Please check your internet connection and try again.",
                        "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("SMS") || ex.Message.Contains("gateway") || ex.Message.Contains("connection refused"))
                {
                    MessageBox.Show("Unable to connect to the SMS gateway. Please verify your SMS service configuration.",
                        "SMS Gateway Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred while sending the confirmation. Please try again or contact support.",
                        "Notification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // ✅ Final UI refresh and close
            btn_Confirm.Enabled = true;
            btn_cancel.Enabled = true;
            await mainForm.RefreshAppointmentAsync();
            await mainForm.RefreshTotalAppointment();
            await mainForm.RefreshPopularServices();
            await mainForm.RefreshTransactionAsync();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //private async void btn_Confirm_Click(object sender, EventArgs e)
        //{
        //    btn_Confirm.Enabled = false;
        //    btn_cancel.Enabled = false;
        //    DateTime startTime = DateTime.Today.Add(summary.AppointmentTime);
        //    string formattedStartTime = startTime.ToString("hh:mm tt");

        //    var model = new AppointmentModel
        //    {
        //        AppointmentId = isUpdate ? existingAppointmentId : 0,
        //        CustomerId = summary.CustomerModel.customer_id,
        //        AppointmentDate = summary.AppointmentDate,
        //        StartTime = summary.AppointmentTime,
        //        EndTime = summary.AppointmentEndTime,
        //        Status = "Scheduled",
        //        PaymentStatus = "Unpaid",
        //        BookingType = summary.BookingType
        //    };

        //    var repo = new AppointmentRepository();
        //    var appointmentController = new AppointmentController(repo);
        //    int appointmentId;

        //    if (isUpdate)
        //    {
        //        appointmentId = appointmentController.UpdatingTheAppointment(model);

        //        var serviceRepo = new AppointmentServiceRepository();
        //        var serviceController = new AppointmentServiceController(serviceRepo);
        //        serviceController.ClearDeleteAllServicesForAppointment(appointmentId);

        //        Audit.AuditLog(
        //        DateTime.Now,
        //        "Update",
        //        UserSession.CurrentUser.first_Name,
        //        "Appointment",
        //        $"Updated appointment for '{summary.CustomerModel.customer_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
        //    }
        //    else
        //    {
        //        appointmentId = appointmentController.CreateAppointment(model);

        //        Audit.AuditLog(
        //        DateTime.Now,
        //        "Create",
        //        UserSession.CurrentUser.first_Name,
        //        "Appointment",
        //         $"Created appointment for '{summary.CustomerModel.customer_name}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
        //    }

        //    foreach (var service in summary.SelectedServices)
        //    {
        //        var appointmentService = new AppointmentServicesModel
        //        {
        //            AppointmentId = appointmentId,
        //            ServiceId = service.service_id
        //        };

        //        var appointmentServiceRepo = new AppointmentServiceRepository();
        //        appointmentServiceRepo.AddAppointmentService(appointmentService);
        //    }






        //    try
        //    {
        //        if (txt_customer_type.Text.ToLower() == "registered")
        //        {
        //            var loading = new LoadingScreenEmail();
        //            loading.Show();
        //            Application.DoEvents(); // ✅ Forces UI to render

        //            try
        //            {
        //                await SendNotificationsAsync(summary, formattedStartTime, lbl_Services.Text);
        //            }
        //            finally
        //            {
        //                // ✅ Ensure this runs on UI thread
        //                if (loading.InvokeRequired)
        //                    loading.Invoke(new Action(() => loading.Close()));
        //                else
        //                    loading.Close();
        //            }
        //        }

        //        MessageBox.Show($"The appointment has been {(isUpdate ? "updated" : "booked")} successfully!",
        //            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex is System.Net.WebException || ex.Message.Contains("network") || ex.Message.Contains("internet"))
        //        {
        //            MessageBox.Show("Failed to send confirmation. Please check your internet connection and try again.",
        //                "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (ex.Message.Contains("SMS") || ex.Message.Contains("gateway") || ex.Message.Contains("connection refused"))
        //        {
        //            MessageBox.Show("Unable to connect to the SMS gateway. Please verify your SMS service configuration.",
        //                "SMS Gateway Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            MessageBox.Show("An unexpected error occurred while sending the confirmation. Please try again or contact support.",
        //                "Notification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }





        //    btn_Confirm.Enabled = true;
        //    btn_Confirm.Enabled = true;
        //    await mainForm.RefreshAppointmentAsync();
        //    await mainForm.RefreshTotalAppointment();
        //    await mainForm.RefreshPopularServices();
        //    await mainForm.RefreshTransactionAsync();
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();

        //}
        private async Task SendNotificationsAsync(BookingSummary summary, string formattedStartTime, string servicesText, string bookingStatus)
        {
            await EmailMessage.SendNotificationEmailAsync(
             to: summary.CustomerModel.email,
             recipientName: summary.CustomerModel.customer_name,
             appointmentTime: $"{summary.AppointmentDate} at {formattedStartTime}",
             services: servicesText,
             customMessage: $"Your appointment has been {bookingStatus.ToLower()}. Please arrive 10 minutes early and bring your ID.");

           
            await SmsSender.SendSmsNotificationAsync(
            phone: summary.CustomerModel.phoneNumber,
            customerName: summary.CustomerModel.customer_name,
            appointmentDate: summary.AppointmentDate.ToString("MM/dd/yyyy"),
            startTime: formattedStartTime,
            status: bookingStatus.ToLower()
            );

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
