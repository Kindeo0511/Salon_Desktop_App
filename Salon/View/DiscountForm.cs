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
        private bool is_saving = false;
        private bool is_updating = false;
        private int isSystemDefined = 0;
        private string mode ;
        public DiscountForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            is_saving = true;
            this.main = mainForm;
        
        }
        public DiscountForm(MainForm mainForm, DiscountModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = mainForm;
            this.discountModel = model;
            is_updating = true;

          
                // Defensive null checks for numeric fields
               
                cmb_discount_type.SelectedItem = discountModel.discount_type;
            txt_promo_name.Text = discountModel.promo_code;
            txt_discount.Text = discountModel.discount_rate.ToString("0.##");

            mode = this.discountModel.mode.Trim();

            string discount_status = discountModel.discount_status;

            if (discount_status == "Draft")
            {
                rad_draft.Checked = true;
                rad_published.Checked = false;
            }
            else if (discount_status == "Published")
            {
                LockPublishedFields();
                rad_published.Checked = true;
                rad_draft.Checked = false;
            }

            dtp_start.Value = discountModel.start_date ?? DateTime.Now;
            dtp_end.Value = discountModel.end_date ?? DateTime.Now;


            chk_is_active.Checked = discountModel.status == 1;
                chk_vat_exempt.Checked = (discountModel.vat_exempt == 1);


            btn_save_draft.Visible = false;
            btn_update_draft.Visible = true;




            UpdateEmailPreview();





        }

        private void LockPublishedFields()
        { 
            cmb_discount_type.Enabled = false; 
            txt_promo_name.ReadOnly = true; 
            txt_discount.ReadOnly = true;
            rad_percent.Enabled = false;
            rad_fixed.Enabled = false;
            dtp_start.Enabled = false; 
            dtp_end.Enabled = false;
            chk_is_active.Enabled = false;
            chk_vat_exempt.Enabled = false;
            btn_update_draft.Enabled = false;
            btn_save_draft.Enabled = false;
            btn_published.Enabled = false;
            rad_draft.Enabled = false;
            rad_published.Enabled = false; 
        
        }
        private  void btn_update_discount_Click(object sender, EventArgs e)
        {
           

            //UpdateDiscount();
          
            this.Close();
        }
        private void UpdateDiscount(string discount_status)
        {
            int id = discountModel.discount_id;
            string discount_type = cmb_discount_type.Text;
            string promo_name = txt_promo_name.Text.Trim();
            int discount_value = Convert.ToInt32(txt_discount.Value);
            string mode = rad_percent.Checked ? rad_percent.Text : rad_fixed.Text;
            int vat_exempt = chk_vat_exempt.Checked ? 1 : 0;
            int is_active = chk_is_active.Checked ? 1 : 0;

            DateTime start_date = dtp_start.Value;
            DateTime end_date = dtp_end.Value;

            var discount = new DiscountModel
            {
                discount_id = id,
                discount_type = discount_type,
                promo_code = promo_name,
                discount_rate = discount_value,
                mode = mode,
                discount_status = discount_status,
                vat_exempt = vat_exempt,
                is_defined = isSystemDefined,
                start_date = start_date,
                end_date = end_date,
                status = is_active

            };
            var update_repo = new DiscountRepository();
            var update_discount_controller = new DiscountController(update_repo);
            if (MessageBox.Show($"Are you sure you want to update {discountModel.discount_type}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                update_discount_controller.UpdateDiscount(discount);
                MessageBox.Show("Discount updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
          
     
                Audit.AuditLog(
                   DateTime.Now,
                   "Update",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Updated discount '{cmb_discount_type.Text}' with rate ({txt_discount.Text}%) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );

                main.LoadDiscount();
            }
        }
        private void AddDiscount(string discount_status)
        {
            string discount_type = cmb_discount_type.Text;
            string promo_name = txt_promo_name.Text.Trim();
            int discount_value = Convert.ToInt32(txt_discount.Value);
            string mode = rad_percent.Checked ? rad_percent.Text : rad_fixed.Text;
            int vat_exempt = chk_vat_exempt.Checked ? 1 : 0;
            int is_active = chk_is_active.Checked ? 1 : 0;

            DateTime? start_date = (dtp_start.Visible && dtp_start.Checked) ? dtp_start.Value : (DateTime?)null;
            DateTime? end_date = (dtp_end.Visible && dtp_end.Checked) ? dtp_end.Value : (DateTime?)null;


            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var discount = new DiscountModel
            {
                discount_type = discount_type,
                promo_code = promo_name,
                discount_rate = discount_value,
                mode = mode,
                discount_status = discount_status,  
               vat_exempt = vat_exempt,
               is_defined = isSystemDefined,
               start_date = start_date,
               end_date = end_date,
               status = is_active
               
            };
            int id = discount_controller.AddDiscount(discount);
            

            if(id > 0) 
            {
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
           
       

        }

       
     
      
        private void btn_cancel_discount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear_discount_fields()
        {
           
            cmb_discount_type.SelectedIndex = -1;
            rad_fixed.Checked = false;
            rad_percent.Checked = false;
            chk_is_active.Checked = false;
            rad_draft.Checked = false;
            rad_published.Checked = false;
            txt_promo_name.Text = "";
    
           
        }
     
       
        private async void btn_add_discount_Click(object sender, EventArgs e)
        {
           
            //AddDiscount();
            clear_discount_fields();
           
            this.Close();
        }
       

        

        private void txt_promo_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
            if (char.IsControl(c))
                return;

            // Allow letters, digits, hyphen, underscore
            if (char.IsLetterOrDigit(c) || c == '-' || c == '_')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_discount_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selected = cmb_discount_type.SelectedItem?.ToString();
            if (is_saving)
                {
                if (selected == "PWD" || selected == "Senior")
                {
                        txt_promo_name.Enabled = false;
                        rad_percent.Checked = true;
                        chk_vat_exempt.Checked = (selected == "PWD" || selected == "Senior");
                        chk_is_active.Checked = true;
                       txt_promo_name.Text = string.Empty;
                        isSystemDefined = 1;
                        email_flow_panel.Height = 0;
                        dtp_start.Enabled = false;
                        dtp_end.Enabled = false;
                }
                    else 
                    {
                        isSystemDefined = 0;
                        txt_promo_name.Enabled = true;
                        rad_percent.Checked = false;
                        chk_vat_exempt.Checked = false;
                        chk_is_active.Checked = false;
                        email_flow_panel.Height = 600;
                        dtp_start.Enabled = true;
                        dtp_end.Enabled = true;

                }
                }
                else if (is_updating) 
                {
                if (selected == "PWD" || selected == "Senior")
                {
                    txt_promo_name.Enabled = false;
                    isSystemDefined = 1;
                    txt_promo_name.Text = string.Empty;
                    email_flow_panel.Height = 0;
                    dtp_start.Enabled = false;
                    dtp_end.Enabled = false;
                }
                else
                {
                    isSystemDefined = 0;
                    txt_promo_name.Text = discountModel.promo_code;
                    email_flow_panel.Height = 600;
                    dtp_start.Enabled = true;
                    dtp_end.Enabled = true;
                }
            }


               
            }
        private string GenerateEmailHtmlPreview()
        {
            string title = txt_promo_name.Text;
            string discount = $"{txt_discount.Text} {(rad_percent.Checked ? "%" : "₱")}";
            string start_date = dtp_start.Value.ToShortDateString();
            string end_date = dtp_end.Value.ToShortDateString();
            string custom_message = txt_optional_message.Text;

            return $@"
<html>
<head>
    <style>
        body {{
            font-family: 'Segoe UI', Arial, sans-serif;
            background-color: #f0f2f5;
            margin: 0;
            padding: 30px;
            color: #333;
        }}
        .voucher {{
            max-width: 500px;
            margin: auto;
            background: #ffffff;
            border: 2px dashed #d63384;
            border-radius: 12px;
            box-shadow: 0 6px 16px rgba(0,0,0,0.12);
            overflow: hidden;
            position: relative;
        }}
        .voucher-header {{
            background: #d63384;
            color: #fff;
            padding: 20px;
            text-align: center;
        }}
        .voucher-header h2 {{
            color: #fff;
            margin: 0;
            font-size: 22px;
        }}
        .voucher-body {{
            padding: 20px;
            text-align: center;
        }}
        .voucher-body h3 {{
            color: #007bff;
            margin-top: 0;
            font-size: 20px;
        }}
        .discount-highlight {{
            background: #ffefef;
            border: 2px solid #d63384;
            padding: 20px;
            margin: 20px 0;
            font-size: 24px;
            font-weight: bold;
            color: #d63384;
            border-radius: 8px;
        }}
        .dates {{
            font-style: italic;
            color: #555;
            margin-bottom: 15px;
        }}
        .cta {{
            display: inline-block;
            background: #d63384;
            color: #fff;
            padding: 12px 24px;
            border-radius: 6px;
            text-decoration: none;
            font-weight: bold;
            margin-top: 10px;
        }}
        .voucher-footer {{
            background: #f9f9f9;
            padding: 15px;
            text-align: center;
            font-size: 14px;
            color: #666;
            border-top: 2px dashed #d63384;
        }}
    </style>
</head>
<body>
    <div class='voucher'>
        <div class='voucher-header'>
            <h2>Exclusive Promo for kindeo</h2>
        </div>
        <div class='voucher-body'>
            <h3 style='color:#d63384;'>{title}</h3>
            <div class='discount-highlight'>
                {discount} OFF on salon services & products
            </div>
            <p class='dates'>Valid from {start_date} to {end_date}</p>
            <p>{custom_message}</p>
            <a href='#' class='cta'>Redeem Now</a>
        </div>
        <div class='voucher-footer'>
            Presented by <strong>HCSANSOR</strong>
        </div>
    </div>
</body>
</html>";
        }




        private void UpdateEmailPreview()
        {
            string html = GenerateEmailHtmlPreview();
            email_preview.DocumentText = html;
        }
         
        private void DiscountForm_Load(object sender, EventArgs e)
        {
           

            if (mode == "Percentage")
            {
                rad_percent.Checked = true;
                rad_fixed.Checked = false;
            }
            else if (mode == "Fixed Amount")
            {
                rad_fixed.Checked = true;
                rad_percent.Checked = false;
            }

        }

        private void txt_promo_name_TextChanged(object sender, EventArgs e)
        {
          UpdateEmailPreview();
        }

        private void txt_discount_ValueChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void txt_optional_message_TextChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void rad_fixed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void rad_percent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmailPreview();
        }

        private void btn_save_draft_Click(object sender, EventArgs e)
        {
            AddDiscount("Draft");
            clear_discount_fields();

            this.Close();
        }

        private async void btn_published_Click(object sender, EventArgs e)
        {
            string discount_type = cmb_discount_type.Text;

            if (is_saving) 
            {
                AddDiscount("Published");
              
            }
            else if(is_updating)
            {
                string currentStatus = discountModel.discount_status;
          
            
                 UpdateDiscount("Published");
                   
                
                
               

            }

            if (discount_type == "Promo")
            {
                using (var form = new LoadingScreenEmail()) 
                {
                    form.Show();
                    form.Refresh();

                    try
                    {
                        QueueEmailNotifications();
                        await ProcessEmailQueue();
                    }
                    finally 
                    {
                        form.Close();
                    }
                }
                
            }

        }

        private void btn_update_draft_Click(object sender, EventArgs e)
        {
            UpdateDiscount("Draft");

            this.Close();
        }

        // EMAIL NOTIFCATIONS
        private void QueueEmailNotifications() 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customers = controller.GetAllCustomer();

            var email_repo = new DiscountNotificationRepository();
            var email_controller = new DiscountNotificationController(email_repo);

            foreach (var customer in customers) 
            {
                string body = GenerateEmailBody(customer.customer_name);
                var discount_model = new DiscountNotificationModel 
                {
                    customer_email = customer.email,
                    customer_name = customer.customer_name + ", " + customer.lastName,
                    subject = txt_email_subject.Text,
                    body = body,
                };

                email_controller.AddDiscountNotif(discount_model);
            }
          
        }
        private string GenerateEmailBody(string name)
        {
            string title = txt_promo_name.Text;
            string discount = $"{txt_discount.Text} {(rad_percent.Checked ? "%" : "₱")}";
            string start_date = dtp_start.Value.ToShortDateString();
            string end_date = dtp_end.Value.ToShortDateString();
            string custom_message = txt_optional_message.Text;

            return $@"
<html>
<head>
    <style>
        body {{
            font-family: 'Segoe UI', Arial, sans-serif;
            background-color: #f0f2f5;
            margin: 0;
            padding: 30px;
            color: #333;
        }}
        .voucher {{
            max-width: 500px;
            margin: auto;
            background: #ffffff;
            border: 2px dashed #d63384;
            border-radius: 12px;
            box-shadow: 0 6px 16px rgba(0,0,0,0.12);
            overflow: hidden;
            position: relative;
        }}
        .voucher-header {{
            background: #d63384;
            color: #fff;
            padding: 20px;
            text-align: center;
        }}
        .voucher-header h2 {{
            color: #fff;
            margin: 0;
            font-size: 22px;
        }}
        .voucher-body {{
            padding: 20px;
            text-align: center;
        }}
        .voucher-body h3 {{
            color: #007bff;
            margin-top: 0;
            font-size: 20px;
        }}
        .discount-highlight {{
            background: #ffefef;
            border: 2px solid #d63384;
            padding: 20px;
            margin: 20px 0;
            font-size: 24px;
            font-weight: bold;
            color: #d63384;
            border-radius: 8px;
        }}
        .dates {{
            font-style: italic;
            color: #555;
            margin-bottom: 15px;
        }}
        .cta {{
            display: inline-block;
            background: #d63384;
            color: #fff;
            padding: 12px 24px;
            border-radius: 6px;
            text-decoration: none;
            font-weight: bold;
            margin-top: 10px;
        }}
        .voucher-footer {{
            background: #f9f9f9;
            padding: 15px;
            text-align: center;
            font-size: 14px;
            color: #666;
            border-top: 2px dashed #d63384;
        }}
    </style>
</head>
<body>
    <div class='voucher'>
        <div class='voucher-header'>
            <h2>Exclusive Promo for kindeo</h2>
        </div>
        <div class='voucher-body'>
            <h3 style='color:#d63384;'>{name}</h3>
            <div class='discount-highlight'>
                {discount} OFF on salon services & products
            </div>
            <p class='dates'>Valid from {start_date} to {end_date}</p>
            <p>{custom_message}</p>
            <a href='#' class='cta'>Redeem Now</a>
        </div>
        <div class='voucher-footer'>
            Presented by <strong>HCSANSOR</strong>
        </div>
    </div>
</body>
</html>";
            
        }

        private async Task ProcessEmailQueue()
        {
            try
            {
                // Disable cancel while sending
                btn_cancel_discount.Enabled = false;

                var email_repo = new DiscountNotificationRepository();
                var email_controller = new DiscountNotificationController(email_repo);
                var customer_email = email_controller.GetAll();

                foreach (var email in customer_email)
                {
                    string to = email.customer_email;
                    string subject = email.subject;
                    string body = email.body;
                    int id = email.notif_id;

                    bool sent = await SendEmail(to, subject, body);

                    if (sent)
                    {
                        MarkEmailAsSent(id);
                    }
                }
            }
            finally
            {
                // Re‑enable cancel after sending completes
                btn_cancel_discount.Enabled = true;
            }
        }


        private async Task<bool> SendEmail(string to, string subject, string body)
        {
            return await EmailMessage.SendEmailNotifDiscount(to, subject, body);
        }

        private void MarkEmailAsSent(int emailId) 
        {
            var email_repo = new DiscountNotificationRepository();
            var email_controller = new DiscountNotificationController(email_repo);
            email_controller.UpdateDiscountNotif(emailId);
        }

        private void StartEmailQueueProcessor() 
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Interval = 60000;
            timer.Tick += (s, e) => Task.Run(() => ProcessEmailQueue());
            timer.Start();
        }
    }
}
