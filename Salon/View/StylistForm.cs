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
using Salon.Models;

namespace Salon.View
{
    public partial class StylistForm : MaterialForm
    {
        private readonly MainForm _mainForm;
        private StylistModel _stylist;
        public StylistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);
        }
        public StylistForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            _stylist = stylist;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);

            if (_stylist != null)
            {
                txt_first_name.Text = _stylist.firstName;
                txt_middle_name.Text = _stylist.middleName;
                txt_last_name.Text = _stylist.lastName;
                dtp_day_of_birth.Value = _stylist.birth_date;
                txt_contact.Text = _stylist.contactNumber;
                txt_email.Text = _stylist.email;
                txt_address.Text = _stylist.address;
                txt_daily_wage.Text = _stylist.daily_wage.ToString();

                btn_save.Visible = false;
                btn_update.Visible = true;

            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;
            }
        }

        private void SaveStylist() 
        {
            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            var stylist = new StylistModel 
            {
                firstName = txt_first_name.Text,
                middleName = txt_middle_name.Text,
                lastName = txt_last_name.Text,
                birth_date = dtp_day_of_birth.Value,
                contactNumber = txt_contact.Text,
                email = txt_email.Text,
                address = txt_address.Text,
                daily_wage = Convert.ToDecimal(txt_daily_wage.Text)
                
                };

            stylistController.Add(stylist);
        }

        private void UpdateStylist()
        {
            if (_stylist != null) 
            {
            _stylist.firstName = txt_first_name.Text;
            _stylist.middleName = txt_middle_name.Text;
            _stylist.lastName = txt_last_name.Text;
            _stylist.birth_date = dtp_day_of_birth.Value;
            _stylist.contactNumber = txt_contact.Text;
            _stylist.email = txt_email.Text;
            _stylist.address = txt_address.Text;
            _stylist.daily_wage = Convert.ToDecimal(txt_daily_wage.Text);

            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            stylistController.Update(_stylist);
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            // Run validation on UI thread
            if (!Validated()) return;
        

            MessageBox.Show("Stylist added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveStylist();
            _mainForm.LoadStylist();
      
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            if (!Validated()) 
            {
                MessageBox.Show("Validation failed");
                return;
            } 

            MessageBox.Show("Stylist updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateStylist();
            _mainForm.LoadStylist();
            this.Close();
        }

        private bool Validated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_first_name, errorProvider1, "First name is required.");
            validated &= Validator.IsRequired(txt_middle_name, errorProvider1, "Middle name is required.");
            validated &= Validator.IsRequired(txt_last_name, errorProvider1, "Last name is required.");
            validated &= Validator.IsRequired(txt_email, errorProvider1, "Email is required.");
            validated &= Validator.IsRequired(txt_contact, errorProvider1, "Contact number is required.");
            validated &= Validator.IsRequired(txt_address, errorProvider1, "Address is required.");
            validated &= Validator.IsRequired(txt_daily_wage, errorProvider1, "Daily wage is required.");

            // VALID EMAIL
            validated &= Validator.IsValidEmail(txt_email, errorProvider1);
            // VAILD PHONE NUMBER
            validated &= Validator.IsValidPhone(txt_contact, errorProvider1);

            // EXISTS VALIDATION
            int excludeId = _stylist?.stylist_id ?? 0;

            validated &= Validator.IsStylistEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId);
            validated &= Validator.IsStylistPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId);

            return validated;


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
