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
using MaterialSkin.Controls;
using Salon.Card;
using System.Runtime.InteropServices;
using Salon.Repository;
using Salon.Controller;
using Salon.Models;
namespace Salon.View
{
    public partial class TestAppointmentForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel model;
        private List<ServiceModel> _services;
        private List<ProductModel> _products;
        public List<ServiceCart> selectedServices = new List<ServiceCart>();
        private DateTime selectedTime;
        private int totalDuration = 0;


        public string CustomerId
        {
            get => lbl_ID.Text;
            set => lbl_ID.Text = value;
        }

        public string FullName
        {
            get => txt_FullName.Text;
            set => txt_FullName.Text = value;
        }

       
        public TestAppointmentForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            cmb_Date.MinDate = DateTime.Today;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);
            LoadStylist();
        }
       
       
        private void LoadStylist()
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetAll();


            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }
        private void LoadTimeSlots()
        {

            time_slot_panel.Controls.Clear();
            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;
                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);

            }

        }
        private void LoadTimeSlots(DateTime? previousSelectedTime = null)
        {
            time_slot_panel.Controls.Clear();

            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;

                // If this button matches the previously selected time, highlight it
                if (previousSelectedTime.HasValue &&
                    time.ToString("hh:mm tt") == previousSelectedTime.Value.ToString("hh:mm tt"))
                {
                    button.UseAccentColor = true;
                    selectedTime = previousSelectedTime.Value; // keep it in sync
                }

                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);
            }
        }
        private void btn_add_service_Click(object sender, EventArgs e)
        {

            // SERVICE CARD 
            var serviceCard = new ServiceCard();

            // Optional: hook up remove button
            serviceCard.OnRemove += (s, ev) => fl_service.Controls.Remove(serviceCard);
            serviceCard.SetServices(_services);
            fl_service.Controls.Add(serviceCard);


         


        }

        public void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            _services = controller.getServices().ToList();
        }

        public void LoadProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            _products = controller.GetRetailProduct().ToList();
        }


        private void TestAppointmentForm_Load(object sender, EventArgs e)
        {

            LoadServices(); // populate _services once
            LoadProduct();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            // PRODUCT CARD

            var productCard = new ProductCard();

            // Optional: hook up remove button
            productCard.OnRemove += (s, ev) => fl_product.Controls.Remove(productCard);
            productCard.SetProducts(_products);
            fl_product.Controls.Add(productCard);
        }

        private void cmb_stylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_stylist.Text.Length > 0)
            {
                LoadTimeSlots();
            }
            else
            {
                time_slot_panel.Controls.Clear();
            }
        }

        private void rad_guest_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_guest.Checked)
            {
                LoadWalkInCode();
                cmb_Date.Enabled = false;
            }
        }
        private void LoadWalkInCode()
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            int walkInCode = controller.GetWalkInCode();

            string prefix_code = $"W-{walkInCode.ToString().PadLeft(4, '0')}";

            txt_FullName.Text = prefix_code;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            selectedServices.Clear();
            foreach (ServiceCard card in fl_service.Controls.OfType<ServiceCard>())
            {
                int serviceId = (int)card.SelectedServiceID; 
                string name = card.ItemName;
                decimal price = card.Price;
                int duration = card.Duration;
                int quantity = card.Quantity;


                ServiceCart cartItem = new ServiceCart
                {
                    ProductId = null,
                    ServiceId = serviceId,
                    ItemName = name,
                    Price = price,
                    Duration = duration,
                    Quantity = quantity
                };
                totalDuration += cartItem.Duration;
                selectedServices.Add(cartItem);
            }
            foreach (ProductCard card in fl_product.Controls.OfType<ProductCard>())
            {
                int productId = (int)card.SelectedProductID;
                string name = card.ItemName;
                decimal price = card.Price;
                int duration = card.Duration;
                int quantity = card.Quantity;


                ServiceCart cartItem = new ServiceCart
                {
                    ProductId = productId,
                    ServiceId = null,
                    ItemName = name,
                    Price = price,
                    Duration = duration,
                    Quantity = quantity
                };
                totalDuration += cartItem.Duration;
                selectedServices.Add(cartItem);
            }

            if (rad_guest.Checked)
            {
                model = new AppointmentModel
                {
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Guest",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                model = new AppointmentModel
                {
                    CustomerId = Convert.ToInt32(lbl_ID.Text),
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Member",
                    PaymentStatus = "Unpaid",
                };
            }
            //using (var summaryForm = new ConfirmationBooking(model, mainForm, this))
            //{
            //    summaryForm.ShowDialog();
            //}
            //SaveAppointment(model);

        }
        public int SaveInvoice(InvoiceModel model)
        {
            var repo = new InvoiceRepository();
            var invoiceController = new InvoiceController(repo);
            var invoice_id = invoiceController.AddInvoice(model);

            return invoice_id;
        }
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        public void SaveInvoiceServices(ServiceCart cart)
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

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
                TotalAmount = 0,
                VATAmount = 0,
                DiscountAmount = 0,
                PaymentMethod = "Unpaid",
                Timestamp = null,
                CustomerID = model.CustomerType == "Member" ? model.CustomerId : (int?)null
            };

            int invoice_id = SaveInvoice(invoiceModel);

            foreach (var service in selectedServices)
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

       

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_register_customer_Click(object sender, EventArgs e)
        {
           
        }

        private void rad_exists_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
