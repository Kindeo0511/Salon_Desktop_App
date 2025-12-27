using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
using Salon.Card;
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
        private AppointmentModel model;
        private bool isUpdate;
        private int existingAppointmentId;

        private int customer_id;
        private int stylist_id;
        private int service_id;
        private string email;
        private string contact;
        private DateTime date;
        private TimeSpan start_time;
        private TimeSpan end_time;
        private string stylist_name;
        private string services;
        private int invoice_id;

        public ConfirmationBooking(AppointmentModel model, MainForm mainForm, AppointmentForm appointmentForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.model = model;
            this.mainForm = mainForm;
            this.appointmentForm = appointmentForm;

            lbl_CustomerName.Text = model.CustomerName;
          

            // Format the date as Month/Day/Year
            lbl_Date.Text = model.AppointmentDate.ToString("MMMM dd, yyyy");
            // Example: "November 21, 2025"

            // Format the time as 12-hour with AM/PM
            lbl_Time.Text = DateTime.Today.Add(model.StartTime).ToString("hh:mm tt")
               + " - "
               + DateTime.Today.Add(model.EndTime).ToString("hh:mm tt");
            // Example: "02:00 PM - 03:00 PM"

            //lbl_Services.Text = model.Services;
            txt_stylist.Text = model.StylistName;


            customer_id = model.CustomerId ?? 0;
            service_id = model.ServiceId;
            stylist_id = model.StylistId;
            date = model.AppointmentDate;
            start_time = model.StartTime;
            end_time = model.EndTime;
            services = model.Services;
            stylist_name = model.StylistName;

            DisplaySummary();


        }
        public ConfirmationBooking(AppointmentForm appointment, MainForm mainForm, AppointmentModel model, bool isUpdate)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.appointmentForm = appointment;
            this.mainForm = mainForm;
            this.existingAppointmentId = model.AppointmentId;
            lbl_id.Text = model.CustomerId.ToString();
            txt_stylist.Tag = model.StylistId;
            //lbl_Services.Tag = model.ServiceId;

        
            this.isUpdate = isUpdate;
            this.model = model;
            DisplaySummary();
           

        }

        private void DisplaySummary()
        {
          
            DateTime startTime = DateTime.Today.Add(model.StartTime);
            DateTime endTime = DateTime.Today.Add(model.EndTime);

            string formattedStartTime = startTime.ToString("hh:mm tt");
            string formattedEndTime = endTime.ToString("hh:mm tt");
            lbl_id.Text = model.CustomerId.ToString();
            lbl_CustomerName.Text = model.CustomerName;
           
            
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
      
            txt_stylist.Text = model.StylistName;
            lbl_Date.Text = model.AppointmentDate.ToString();

            foreach (var service in appointmentForm.selectedServices)
            {
                var summary_service_card = new SummaryServiceCard();

                summary_service_card.SetServiceDetails(service.ItemName);
                fl_services.Controls.Add(summary_service_card);
             

            }
           
      


        }
        public bool DeleteServiceFromCart(int invoice_id)
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            return controller.DeleteServiceFromInvoiceCart(invoice_id);


        }
        private int SaveInvoice(InvoiceModel model) 
        {
            var repo = new InvoiceRepository();
            var invoiceController = new InvoiceController(repo);
            var invoice_id = invoiceController.AddInvoice(model);

            return invoice_id;
        }
        private void SaveInvoiceServices(ServiceCart cart) 
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

        }
        private int GetIdAfterSaveItem(ItemModel model) 
        {
            var repo = new ItemRepository();
            var itemController = new ItemController(repo);
            var item_id = itemController.AddItem(model);

            return item_id;
        }
        private string GenerateInvoiceNumber()
        {
            string prefix = "INV";
            string datePart = DateTime.Now.ToString("yyyyMMdd-HHmm");
            return $"{prefix}-{datePart}";
        }
        private void SaveAppointment(AppointmentModel model)
        {
            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);

            int appointment_id = model.CustomerType == "Member"
                ? appointmentController.CreateAppointment(model)
                : appointmentController.CreateWalkInAppointment(model);

            var invoiceModel = new InvoiceModel
            {
                AppointmentID = appointment_id,
                InvoiceNumber = GenerateInvoiceNumber(),
                TotalAmount = 0,
                VATAmount = 0,
                DiscountAmount = 0,
                PaymentMethod = "Unpaid",
                Timestamp = null,
                CustomerID = model.CustomerType == "Member" ? model.CustomerId : (int?)null
            };

            int invoice_id = SaveInvoice(invoiceModel);

            foreach (var service in appointmentForm.selectedServices)
            {
              

                var invoiceServiceCart = new ServiceCart
                {
                    InvoiceId = invoice_id,
                    ProductId = service.ProductId,
                    ServiceId = service.ServiceId,
                    ItemType = service.ItemType,
                    Quantity = service.Quantity,
                    Price = service.Price,
                    Duration = service.Duration
                };
                SaveInvoiceServices(invoiceServiceCart);
            }
        }

        private void UpdateAppointment(AppointmentModel model)
        {
            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);

            // Call the right update method based on booking type
            if (model.CustomerType == "Member")
                appointmentController.UpdateTheAppointment(model);
            else
                appointmentController.UpdateWalkin(model);

            // Shared logic
            int invoice_id = appointmentForm.GetInvoiceId(existingAppointmentId);
            DeleteServiceFromCart(invoice_id);

            foreach (var service in appointmentForm.selectedServices)
            {
                var invoiceServiceCart = new ServiceCart
                {
                    InvoiceId = invoice_id,
                    ProductId = service.ProductId,
                    ServiceId = service.ServiceId,
                    ItemType = service.ItemType,
                    Quantity = service.Quantity,
                    Price = service.Price,
                    Duration = service.Duration
                };

               

                SaveInvoiceServices(invoiceServiceCart);
            }
        }

        private void Clear()
        {
            lbl_id.Text = string.Empty;
            lbl_CustomerName.Text = string.Empty;
           
            lbl_Time.Text = string.Empty;
            txt_stylist.Text = string.Empty;

        }
       
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {

            
                
                    UpdateAppointment(model);
                    MessageBox.Show($"The appointment has been updated successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


                //     UpdateAppointment(model);
                //     MessageBox.Show($"The appointment has been updated successfully!",
                //"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SaveAppointment(model);
                MessageBox.Show($"The appointment has been booked successfully!",
           "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            this.DialogResult = DialogResult.OK;
            this.Close();
            appointmentForm.Close();
            mainForm.LoadAppointments();


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

        private void btn_add_another_Click(object sender, EventArgs e)
        {
            //ConfirmBooking();

            MessageBox.Show($"The appointment has been booked successfully!",
                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            //appointmentForm.Clear();

       
        }
       
    }
}
