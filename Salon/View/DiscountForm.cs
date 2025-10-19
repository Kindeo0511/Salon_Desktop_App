using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
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
    public partial class DiscountForm : MaterialForm
    {
        private MainForm main;
        private DiscountModel discountModel;
        public DiscountForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = mainForm;
        }
        public DiscountForm(MainForm mainForm, DiscountModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = mainForm;
            this.discountModel = model;

            if (discountModel != null)
            {
                // Defensive null checks for numeric fields
                cmb_discount_type.Hint = string.Empty;
                cmb_discount_type.Text = discountModel.discount_type;
                txt_discount.Text = discountModel.discount_rate.ToString("0.##");
                txt_max_usage.Value = discountModel.max_usage;
                txt_customer_limit.Value = discountModel.per_customer_limit;
                sw_send_notif.Checked = discountModel.notif_on_create == 1;
                sw_expiry_notif.Checked = discountModel.notif_on_expired == 1;
                cmb_discount_type.Hint = "Select Discount Type";

                btn_add_discount.Visible = false;
                btn_update_discount.Visible = true;

                // Promo-specific fields
                if ((discountModel.discount_type ?? "").ToLower() == "promo")
                {

                    txt_promo_code.Visible = true;
                    dtp_discount_expiry_date.Visible = true;
                    materialLabel29.Visible = true;

                    txt_promo_code.Text = discountModel.promo_code ?? "";
                    dtp_discount_expiry_date.Value = discountModel.expiry_date ?? DateTime.Now;
                }
                else
                {
                    txt_promo_code.Visible = false;
                    dtp_discount_expiry_date.Visible = false;
                    materialLabel29.Visible = false;
                }

              

             
               
            }

        }


        private void btn_update_discount_Click(object sender, EventArgs e)
        {
            if (!DiscountValidated()) return;

            UpdateDiscount();
        }
        private void UpdateDiscount()
        {
            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var old = discount_controller.GetDiscountById(discountModel.discount_id);
            int notifOnCreate = sw_send_notif.Checked ? 1 : 0;
            int notifOnExpiry = sw_expiry_notif.Checked ? 1 : 0;
            string promo_code = "";
            DateTime? expiration_date;
            if (!string.IsNullOrWhiteSpace(txt_promo_code.Text))
            {
                promo_code = txt_promo_code.Text.Trim();
                expiration_date = dtp_discount_expiry_date.Value;
            }
            else
            {
                promo_code = "";
                expiration_date = null;
            }
            bool isMajorUpdate =
            old.promo_code != discountModel.promo_code ||
            old.discount_rate != discountModel.discount_rate ||
            old.expiry_date != discountModel.expiry_date ||
            old.max_usage != discountModel.max_usage ||
            old.per_customer_limit != discountModel.per_customer_limit;

        
            discountModel.discount_type = cmb_discount_type.Text;
            discountModel.promo_code = promo_code;
            discountModel.discount_rate = Convert.ToInt32(txt_discount.Text);
            discountModel.expiry_date = expiration_date;
            discountModel.max_usage = Convert.ToInt32(txt_max_usage.Value);
            discountModel.per_customer_limit = Convert.ToInt32(txt_customer_limit.Value);
            discountModel.notif_on_create = notifOnCreate;
            discountModel.notif_on_expired = notifOnExpiry;

          


            var update_repo = new DiscountRepository();
            var update_discount_controller = new DiscountController(update_repo);
            if (MessageBox.Show($"Are you sure you want to update {discountModel.discount_type}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                update_discount_controller.UpdateDiscount(discountModel);
                MessageBox.Show("Discount updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
          
                main.LoadDiscount();
                Audit.AuditLog(
                   DateTime.Now,
                   "Update",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Updated discount '{cmb_discount_type.Text}' with rate ({txt_discount.Text}%) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );

                if (notifOnCreate == 1)
                {
                    AddNotifyCustomer(discountModel.discount_id);
                    SendNotifications();
                }
                clear_discount_fields();
            }
        }
        private void AddDiscount()
        {
            string promo_code = "";
            DateTime? expiration_date;
            int notifOnCreate = sw_send_notif.Checked ? 1 : 0;
            int notifOnExpiry = sw_expiry_notif.Checked ? 1 : 0;
            if (!string.IsNullOrWhiteSpace(txt_promo_code.Text))
            {
                promo_code = txt_promo_code.Text.Trim();
                expiration_date = dtp_discount_expiry_date.Value;
            }
            else
            {
                promo_code = "";
                expiration_date = null;
            }



            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var discount = new DiscountModel
            {
                discount_type = cmb_discount_type.Text,
                promo_code = promo_code,
                discount_rate = Convert.ToInt32(txt_discount.Text),
                expiry_date = expiration_date,
                max_usage = Convert.ToInt32(txt_max_usage.Value),
                per_customer_limit = Convert.ToInt32(txt_customer_limit.Value),
                notif_on_create = notifOnCreate,
                notif_on_expired = notifOnExpiry
            };
            int id = discount_controller.AddDiscount(discount);
            AddNotifyCustomer(id);

            if (notifOnCreate == 1) 
            {
                SendNotifications();
            }

            MessageBox.Show("Discount added succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Audit.AuditLog(
                   DateTime.Now,
                   "Create",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Created discount '{cmb_discount_type.Text}' with rate ({txt_discount.Text}%) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );
            main.LoadDiscount();

        }

        private void AddNotifyCustomer(int discount_id) 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customers = controller.GetAllCustomer();
            int notifOnCreate = sw_send_notif.Checked ? 1 : 0;
            if (notifOnCreate == 1) 
            {
                var notif_repo = new DiscountNotificationRepository();
                var notif_controller = new DiscountNotificationController(notif_repo);
                foreach (var customer in customers) 
                {
                    var model = new DiscountNotificationModel
                    {
                        discount_id = discount_id,
                        customer_id = customer.customer_id,
                        status = "Pending"
                    };
                    notif_controller.AddDiscountNotif(model);
                    
                }
            }
        }
        public string BuildPromoMessage(int discountId)
        {

            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var promo = discount_controller.GetDiscountById(discountId);
            return $"Use promo code {promo.promo_code} to get {promo.discount_rate}% off. Valid until {promo.expiry_date:MMM dd}.";
        }

        public void SendNotifications() 
        {
            var repo = new DiscountNotificationRepository();
            var controller = new DiscountNotificationController(repo);
            var notifications = controller.GetAll();
          
            foreach (var notif in notifications) 
            {
                var message = BuildPromoMessage(notif.discount_id);
                var result = EmailMessage.SendEmailNotifDiscount(notif.customer_id, message); // or SendEmail()
                var sms = SmsSender.SendDiscountNotifSMS(notif.customer_id, message);
                controller.UpdateDiscountNotif(notif.notif_id);
            }
        }
        private void btn_cancel_discount_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private bool DiscountValidated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(cmb_discount_type, errorProvider1, "Discount type is required.");
            validated &= Validator.IsRequired(txt_discount, errorProvider1, "Discount rate is required.");



            if (cmb_discount_type.Text == "Promo")
            {
                validated &= Validator.IsRequired(txt_promo_code, errorProvider1, "Promo code is required.");

            }

            int excludeId = discountModel?.discount_id ?? 0;
            string code = txt_promo_code.Text.Trim();

          
            // Parse discount rate safely
            if (decimal.TryParse(txt_discount.Text.Trim(), out decimal rate))
            {
                validated &= Validator.IsDiscountExists(
                    cmb_discount_type,
                    errorProvider1,
                    "Discount already exists.",
                    cmb_discount_type.Text.Trim(),
                    code,
                    rate,
                    excludeId
                );
            }


            return validated;


        }
        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            if (!DiscountValidated()) return;
            AddDiscount();
            clear_discount_fields();
        }

        private void cmb_discount_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_discount_type.Text.ToLower() == "promo")
            {
                txt_promo_code.Visible = true;
                dtp_discount_expiry_date.Visible = true;
                materialLabel29.Visible = true;

            }
            else
            {
                txt_promo_code.Visible = false;
                dtp_discount_expiry_date.Visible = false;
                materialLabel29.Visible = false;

            }
        }
    }
}
