using MaterialSkin.Controls;
using Salon.Controller;
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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => txt_user_name.Focus()));
            txt_password.Password = true;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                log_in();
            }
        }
        private bool IsValid()
        {
            bool validated = true;

            // USERNAME: Required first, then length
            if (!Validator.IsRequiredTextField(txt_user_name, errorProvider1, "Username is required."))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_user_name, errorProvider1, "Username should not contain spaces."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_user_name, errorProvider1, "Username must be at least 4 characters.", 4))
            {
                validated = false;
            }
            else if (!Validator.Pattern(txt_user_name, errorProvider1, @"^[a-zA-Z0-9]+$", "Username can only contain letters and numbers."))
            {
                validated = false;
            }

            // PASSWORD: Required first, then length
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
            //else if (!Validator.Pattern(
            //         txt_password,
            //         errorProvider1,
            //         @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()_+\-=!?])[a-zA-Z\d@#$%^&*()_+\-=!?]{8,}$",
            //         "Password must be at least 8 characters and include uppercase, lowercase, number, and special character (@#$%^&*()_+-=!?)."
            //     ))
            //{
            //    validated = false;
            //}




            return validated;
        }

        private void log_in()
        {
            string username = txt_user_name.Text.Trim();
            string password = txt_password.Text.Trim();
            var repo = new UserRepository();
            var controler = new UserController(repo);
            var user = controler.AuthenticateUser(username, password);

            if (user != null)
            {
                // ✅ Success: proceed to dashboard
                UserSession.CurrentUser = user;
                MessageBox.Show($"Welcome {user.userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Audit.AuditLog(
                      DateTime.Now,
                      "Log In",
                      UserSession.CurrentUser.first_Name,
                      "User",
                      $"Log In '{UserSession.CurrentUser.first_Name}'on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                  );
                var form = new MainForm(this);
                form.ShowDialog();
                this.Hide();
                //this.Close();




            }
            else
            {
                // ❌ Failure: show error
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.Hint = string.Empty;
            txt_password.Password = !chk_show_password.Checked;
            txt_password.Hint = "Password";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lnk_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form = new ForgotPasswordForm(this);
            
                form.Show();
              
            
        }

        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_user_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (e.g., Backspace)
            if (char.IsControl(c))
                return;

            // Allow only letters and digits
            if (!char.IsLetterOrDigit(c))
            {
                e.Handled = true; // Block the key
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Allow letters, digits, and allowed special characters
            string allowedSpecials = "@#$%^&*()_+-=!?";
            if (!char.IsLetterOrDigit(c) && !allowedSpecials.Contains(c))
            {
                e.Handled = true; // Block the key
            }
        }
    }
}
