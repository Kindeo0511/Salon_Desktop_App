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
using static System.Net.WebRequestMethods;

namespace Salon.View
{
    public partial class ForgotPasswordForm : MaterialForm
    {
        private LoginForm loginForm;
        private OtpEntryModel currentOtp;
        int countdown = 30;
        public ForgotPasswordForm(LoginForm loginForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.loginForm = loginForm;
        }

        private bool IsValidEmailOrSMS() 
        {
            var validated = true;

            if (rad_sms.Checked)
            {
                if (!Validator.IsRequiredTextField(txt_number, errorProvider1, "Phone number is required"))
                {
                    validated = false;
                }
                else if (!Validator.Pattern(txt_number, errorProvider1, @"^\d+$", "Phone number must contain digits only."))
                {
                    validated = false;
                }
                else if (!Validator.Pattern(txt_number, errorProvider1, @"^09\d{9}$", "Contact number should start with '09' and be 11 digits long."))
                {
                    validated = false;
                }
            }
            else if (rad_email.Checked) 
            {
                if (!Validator.IsRequiredTextField(txt_username, errorProvider1, "Email address should not be empty."))
                {
                    validated = false;
                }
                else if (txt_username.Text.Contains(" "))
                {
                    errorProvider1.SetError(txt_username, "Email address should not contain spaces.");
                    validated = false;
                }
                else if (txt_username.Text.Count(c => c == '@') != 1)
                {
                    errorProvider1.SetError(txt_username, "Email address must contain exactly one '@' symbol.");
                    validated = false;
                }
                else if (!Validator.Pattern(
                    txt_username,
                    errorProvider1,
                    @"^(?![._-])([a-zA-Z0-9]+[._-]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[-]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,}$",
                    "Email must be valid, contain '@' and a domain, and only allowed characters (letters, numbers, ., _, -)."
                ))
                {
                    validated = false;
                }


            }



            return validated;
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
                currentOtp = null;
                var otp = new OtpEntryModel
                {
                    Code = EmailMessage.GenerateOtp(),
                    Expiry = DateTime.Now.AddMinutes(5),
                    IsUsed = false
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
            if (!IsValidEmailOrSMS()) return;

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
            if (currentOtp.IsUsed)
            {
                MessageBox.Show("This OTP has already been used.");
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

        private bool IsValidOTP() 
        {
            var validated = true;


            if (!Validator.IsRequiredTextField(txt_otp, errorProvider1, "OTP is required."))
            {
                validated = false;
            }
            else if (!Validator.Pattern(
                txt_otp,
                errorProvider1,
                @"^\d{6}$",
                "OTP must be exactly 6 digits and contain digits only (0–9)."
            ))
            {
                validated = false;
            }


            return validated;
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            btn_confirm.Enabled = false; // Disable to prevent multiple clicks
            bool verified = VerifyOtp(txt_otp.Text);
   
            if (verified)
            {
                currentOtp.IsUsed = true;
                forgotPasswordTabControl.Selecting -= forgotPasswordTabControl_Selecting; // Temporarily allow switching
                forgotPasswordTabControl.SelectedIndex = 2; // Switch to Tab 2
                forgotPasswordTabControl.Selecting += forgotPasswordTabControl_Selecting; // Re-enable block

                // Disable resend button and start countdown
                send_otp.Enabled = false;
                StartCountdown();
            }
            else
            {
                btn_confirm.Enabled = true; // Re-enable if verification failed
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
            btn_confirm.Enabled = true;
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
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private void UpdateUserPassword() 
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);

            var model = new UsersModel
            {
                email = txt_username.Text,
                phone_Number = txt_number.Text,
                userPassword = HashPassword(txt_password.Text.Trim()),
            };

            controller.UpdateUserByOtp(model);
        }
        private bool IsValid() 
        {
            bool validated = true;
            if (!Validator.IsRequiredTextField(txt_password, errorProvider1, "Password is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_password, errorProvider1, "Password must be at least 8 characters.", 8))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_password, errorProvider1, "Password must not contain spaces."))
            {
                validated = false;
            }
            else if (!Validator.Pattern(
                     txt_password,
                     errorProvider1,
                     @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()_+\-=!?])[a-zA-Z\d@#$%^&*()_+\-=!?]{8,}$",
                     "Password must be at least 8 characters and include uppercase, lowercase, number, and special character (@#$%^&*()_+-=!?)."
                 ))
            {
                validated = false;
            }

            if (!Validator.IsRequiredTextField(txt_confirm_password, errorProvider1, "Password is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_confirm_password, errorProvider1, "Password must be at least 8 characters.", 8))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_confirm_password, errorProvider1, "Password must not contain spaces."))
            {
                validated = false;
            }
            else if (!Validator.Pattern(
                     txt_confirm_password,
                     errorProvider1,
                     @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()_+\-=!?])[a-zA-Z\d@#$%^&*()_+\-=!?]{8,}$",
                     "Password must be at least 8 characters and include uppercase, lowercase, number, and special character (@#$%^&*()_+-=!?)."
                 ))
            {
                validated = false;
            }
            else if (txt_password.Text != txt_confirm_password.Text)
            {
                errorProvider1.SetError(txt_confirm_password, "Passwords do not match.");
                validated = false;
            }


            return validated;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            UpdateUserPassword();
            MessageBox.Show("Password updated successfully!");

            loginForm.Show();
            this.Close();
        }

        private void send_otp_Click(object sender, EventArgs e)
        {
            string method = rad_email.Checked ? "Email" :
                rad_sms.Checked ? "SMS" : null;

            if (!IsValidEmailOrSMS()) return;
            var otp = new OtpEntryModel
            {
                Code = EmailMessage.GenerateOtp(),
                Expiry = DateTime.Now.AddMinutes(5)
            };

            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please select an OTP delivery method.");
                return;
            }
            bool userFound = GetUserByEmailOrPhone(txt_username.Text, txt_number.Text, method);

            // Disable resend button and start countdown
            send_otp.Enabled = false;
            StartCountdown();
        }


        private void StartCountdown()
        {
            countdown = 15;
            txt_count_down.Text = countdown.ToString();
            otp_timer.Interval = 1000; 
            otp_timer.Start();
        }

        private void otp_timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            txt_count_down.Text = countdown.ToString();

            if (countdown <= 0)
            {
                otp_timer.Stop();
                send_otp.Enabled = true;
                txt_count_down.Visible = false;
                btn_confirm.Enabled = true; // Re-enable if verification failed
            }
            else 
            {
                txt_count_down.Visible = true;
                btn_confirm.Enabled = false; // Re-enable if verification failed
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            txt_password.Password = true;
            txt_confirm_password.Password = true;
        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.Password = !chk_show_password.Checked;
            txt_confirm_password.Password = !chk_show_password.Checked;
        }
    }
}
