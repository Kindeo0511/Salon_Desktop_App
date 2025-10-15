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
using Salon.Repository;
using Salon.Controller;
using Salon.Models;

namespace Salon.View
{
    public partial class ForgotPasswordForm : MaterialForm
    {
        private LoginForm loginForm;
        private OtpEntryModel currentOtp;

        public ForgotPasswordForm(LoginForm loginForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.loginForm = loginForm;
        }

        private bool GetUserByEmailOrPhone(string email, string phone, string method)
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);
            UsersModel user = null;

            if (!string.IsNullOrEmpty(email))
            {
                user = controller.GetUser(email);
            }
            else if (!string.IsNullOrEmpty(phone))
            {
                user = controller.GetUserByPhone(phone);
            }

            if (user != null)
            {
                var otp = new OtpEntryModel
                {
                    Code = EmailMessage.GenerateOtp(),
                    Expiry = DateTime.Now.AddMinutes(5)
                };

                currentOtp = otp;
                MessageBox.Show("OTP SENT");

                // 🔐 Send OTP based on selected method
                if (method == "Email" && !string.IsNullOrEmpty(user.email))
                {
                    _ = EmailMessage.EmailOTPNotification(user.email, user.first_Name, otp.Code);
                }
                else if (method == "SMS" && !string.IsNullOrEmpty(user.phone_Number))
                {
                    _ = SmsSender.SendOtpAsync(user.phone_Number, user.first_Name, otp.Code); // You’ll need to implement this
                }

     
                return true;
            }
            else
            {
                MessageBox.Show("User not found...");
         
                return false;
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            string method = rad_email.Checked ? "Email" :
                 rad_sms.Checked ? "SMS" : null;


            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please select an OTP delivery method.");
                return;
            }



            bool userFound = GetUserByEmailOrPhone(txt_username.Text, txt_number.Text, method);

            if (userFound)
            {
                forgotPasswordTabControl.Selecting -= forgotPasswordTabControl_Selecting;
                forgotPasswordTabControl.SelectedIndex = 1;
                forgotPasswordTabControl.Selecting += forgotPasswordTabControl_Selecting;
            }

            


        }


        private bool VerifyOtp(string input)
        {
            if (currentOtp == null)
            {
                MessageBox.Show("No OTP was generated.");
                return false;
            }

            if (DateTime.Now > currentOtp.Expiry)
            {
                MessageBox.Show("OTP has expired.");
                return false;
            }

            if (input == currentOtp.Code)
            {
                MessageBox.Show("OTP verified successfully!");
                return true;
            }
            else
            {
                MessageBox.Show("Invalid OTP.");
                return false;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            bool verified = VerifyOtp(txt_otp.Text);

            if (verified)
            {
                forgotPasswordTabControl.Selecting -= forgotPasswordTabControl_Selecting; // Temporarily allow switching
                forgotPasswordTabControl.SelectedIndex = 2; // Switch to Tab 2
                forgotPasswordTabControl.Selecting += forgotPasswordTabControl_Selecting; // Re-enable block
            }




        }

        private void btn_back_to_step_1_Click(object sender, EventArgs e)
        {


            forgotPasswordTabControl.Selecting -= forgotPasswordTabControl_Selecting; // Temporarily allow switching
            forgotPasswordTabControl.SelectedIndex = 0; // Switch to Tab 2
            forgotPasswordTabControl.Selecting += forgotPasswordTabControl_Selecting; // Re-enable block


        }

        private void btn_back_to_step_2_Click(object sender, EventArgs e)
        {

            forgotPasswordTabControl.Selecting -= forgotPasswordTabControl_Selecting; 
            forgotPasswordTabControl.SelectedIndex = 1;
            forgotPasswordTabControl.Selecting += forgotPasswordTabControl_Selecting; 
        }

        private void forgotPasswordTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Cancel tab selection if triggered by user click
            if (e.Action == TabControlAction.Selecting)
            {
                e.Cancel = true;
            }


        }

        private void rad_sms_CheckedChanged(object sender, EventArgs e)
        {
            txt_number.Visible = rad_sms.Checked;
            lbl_number.Visible = rad_sms.Checked;
        }

        private void rad_email_CheckedChanged(object sender, EventArgs e)
        {
            lbl_email.Visible = rad_email.Checked;
            txt_username.Visible = rad_email.Checked;
        }

        private void UpdateUserPassword() 
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);

            var model = new UsersModel
            {
                email = txt_username.Text,
                phone_Number = txt_number.Text,
                userPassword = txt_confirm_password.Text,
            };

            controller.UpdateUserByOtp(model);
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_confirm_password.Text)
            {
                MessageBox.Show("Password does not match!");
            }
            else 
            {
                UpdateUserPassword();
                MessageBox.Show("Password updated successfully!");

                loginForm.Show();
                    this.Close();

               

            }
        }
    }
}
