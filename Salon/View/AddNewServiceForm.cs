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
    public partial class AddNewServiceForm : MaterialForm
    {
        private readonly ViewDetailsForm _model;
        private int appointment_id;
        private int total_duration;
        private decimal price;

        public AddNewServiceForm(ViewDetailsForm model, int appointment_id)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadServices();
            _model = model;
            this.appointment_id = appointment_id;
        }

        private void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServices();

            cmb_services.DataSource = null;

            cmb_services.ValueMember = "serviceName_id";
            cmb_services.DisplayMember = "serviceName";


            cmb_services.DataSource = services;

            cmb_services.SelectedIndex = -1;
      
  


        }
        private void LoadStylist(int id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetStylistSpecialistById(id);

            cmb_stylist.DataSource = null;
            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;

        }
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        private void SaveInvoiceServices(ServiceCart cart)
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

        }
        private void cmb_services_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {

                LoadStylist(selectedService.category_id);




            }
        }
        private bool IsAddNewServiceValid() 
        {
            bool validated = true;


            if (string.IsNullOrEmpty(cmb_services.Text))
            {
                errorProvider1.SetError(cmb_services, "Please select a service.");
                validated = false;
            }
            else if (IsServiceExists()) 
            {
                errorProvider1.SetError(cmb_services, "Service already exists.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(cmb_services, "");
            }

            if (string.IsNullOrEmpty(cmb_stylist.Text))
            {
                errorProvider1.SetError(cmb_stylist, "Please select a stylist.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(cmb_stylist, "");
            }

            return validated;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!IsAddNewServiceValid()) return;

             AddService();

            this.Close();
        }
        private bool IsServiceExists() 
        {
            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);
            int service_id = Convert.ToInt32(cmb_services.SelectedValue);
            bool serviceExistInAppointment = service_controller.CheckIfServiceExists(appointment_id, service_id);

            return serviceExistInAppointment;
        }
        public void AddService() 
        {
            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);
            int service_id = Convert.ToInt32(cmb_services.SelectedValue);
            int stylist_id = Convert.ToInt32(cmb_stylist.SelectedValue);
            int invoice_id = GetInvoiceId(appointment_id);


            service_controller.AddServicesToAppointment(appointment_id, service_id, stylist_id, null, null, "Waiting");

            var invoiceServiceCart = new ServiceCart
            {
                InvoiceId = invoice_id,
                ServiceId = service_id,
                StylistId = stylist_id,
                ItemType = "Service",
                Quantity = 1,
                Price = price,
                Duration = total_duration
            };

            SaveInvoiceServices(invoiceServiceCart);

            MessageBox.Show("Service has been successfully added.",
                 "Service Added",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {

                total_duration = selectedService.duration;
                price = selectedService.servicePrice;
                lbl_duration.Text = selectedService.duration.ToString() + " mins";
                


            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
