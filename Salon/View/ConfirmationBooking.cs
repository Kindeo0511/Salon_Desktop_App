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
using System.Windows.Forms;
namespace Salon.View
{
    public partial class ConfirmationBooking : MaterialForm
    {
        private MainForm mainForm;
        private BookingSummary summary;
        private AppointmentForm appointmentForm;
        public ConfirmationBooking(AppointmentForm appointment,MainForm mainForm, BookingSummary summary)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.summary = summary;
            this.appointmentForm = appointment;
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
            lbl_Date.Text = summary.AppointmentDate.ToString("MMMM dd, yyyy");
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
            lbl_book_type.Text = summary.BookingType;

            foreach (var service in summary.SelectedServices)
            {
                lbl_Services.Text += $"- {service.service_name}\n";
            }



        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);
            int appointmentId = appointmentController.CreateAppointment(
              summary.CustomerModel.customer_id,
              summary.AppointmentDate,
              summary.AppointmentTime,
              summary.AppointmentEndTime.Add(TimeSpan.FromMinutes(30 * summary.SelectedServices.Count)),
              "Scheduled",
              "Unpaid",
              summary.BookingType
              );
            foreach (var service in summary.SelectedServices)
            {
                var appointmentService = new AppointmentServicesModel
                {
                    AppointmentId = appointmentId,
                    ServiceId = service.service_id,
                };
                var appointmentServiceRepo = new Repository.AppointmentServiceRepository();
                appointmentServiceRepo.AddAppointmentService(appointmentService);
            }
            MessageBox.Show("The appointment has been booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            mainForm.LoadAppointments();
            mainForm.LoadTotalAppointments();
            mainForm.LoadPopularServices();


            this.Close();
            appointmentForm.Close();


        }
    }
}
