using MaterialSkin.Controls;
using Mysqlx.Crud;
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
using System.Windows.Controls;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class ConfigureSettingsForm : MaterialForm
    {
        public ConfigureSettingsForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
          

        }

  


        private void btn_personal_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }
                
            }
        }

        private void btn_account_tab_back_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_account_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }

        private void btn_vat_tab_back_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_vat_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }
        private int user_id;
        private int SaveUser()
        {
            var user = new UsersModel
            {
                first_Name = txt_first_name.Text.Trim(),
                middle_Name = txt_middle_name.Text.Trim(),
                last_Name = txt_last_name.Text.Trim(),
                birth_date = dtp_day_of_birth.Value,
                phone_Number = txt_contact.Text.Trim(),
                email = txt_email.Text.Trim(),
                address = txt_address.Text.Trim(),

            };
            var _repo = new UserRepository();
            var userController = new UserController(_repo);


            user_id = userController.AddUser(user);

            return user_id;

        }
        private void UpdateUserAccount()
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

            var user_model = new UsersModel
            {
                user_id = user_id,
                userName = txt_username.Text.Trim(),
                userPassword = HashPassword(txt_HashPassword.Text.Trim()),
                Position = "Admin"
            };
            userController.UpdateUserAccount(user_model);

        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private VatModel vatModel;
        private void AddVat()
        {
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);
            var tax_exists = tax_controller.checkTax();

            int tax_rate = Convert.ToInt32(txt_vat.Text.Trim());
        

                int tax_id = vatModel.tax_id;

                vatModel.tax_id = tax_id;
                vatModel.tax = tax_rate;
      
          
                var tax_model = new VatModel
                {
                    tax = tax_rate
                };
               
                tax_controller.CreateTax(tax_model);
                Audit.AuditLog(
                   DateTime.Now,
                   "Create",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Created Vat with rate '{tax_rate}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );



            
        }

        private void btn_smtp_next_Click(object sender, EventArgs e)
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);
            user_id = SaveUser();

            UpdateUserAccount();

            AddVat();

            CreateBusinessHour();

            CreateSMTPSettings();

            // Confirmation dialog
            var result = MessageBox.Show(
                "Settings saved successfully! Do you want to proceed to the login form?",
                "Success",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                var form = new LoginForm();
                form.Show();
                this.Hide();
            }


        }
        private void CreateSMTPSettings() 
        {
        var owner_repo = new OwnderEmailRepository();
        var owner_controller = new OwnerEmailController(owner_repo);

            var model = new OwnerEmaillModel
            {
                shop_name = txt_business_name.Text,
                email = txt_email.Text,
                pass = txt_password.Text,

            };
     
            var saved = owner_controller.Create(model);
         
        }
        public void LoadPaymentMethod()
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);
            var paymentMethod = controller.GetAllPaymentMethod();


            var filteredSorted = paymentMethod.Where(pm => pm.is_active).OrderBy(pm => pm.name).ToList();


            dgv_payment_method.AutoGenerateColumns = false;


            col_payment_method_id.DataPropertyName = "id";
            col_payment_method_name.DataPropertyName = "name";
            col_payment_method_required_display_text.DataPropertyName = "required_text";
            col_payment_method_required.DataPropertyName = "required_reference";
            col_payment_method_status.DataPropertyName = "is_active";
            col_payment_method_status_display_text.DataPropertyName = "status_text";


            dgv_payment_method.DataSource = filteredSorted;



        }
        private void CreateBusinessHour() 
        {
            var repo = new BusinessHourRepository();
            var controller = new TimeSlotController(repo);

                var businessHour = new BusinessHour
                {
                    open_time = dtp_opening.Value.TimeOfDay,
                    close_time = dtp_closing.Value.TimeOfDay,
                };
            controller.CreateOrUpdateBusinessHours(businessHour);
        }
        private void btn_add_payment_method_Click(object sender, EventArgs e)
        {
            using (var form = new PaymentMethodForm(this))
            {
                form.ShowDialog();
            }
        }
    }
}
