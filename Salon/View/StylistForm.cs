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
        }
        public StylistForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            _stylist = stylist;

            if (_stylist != null)
            {
                txt_first_name.Text = _stylist.firstName;
                txt_middle_name.Text = _stylist.middleName;
                txt_last_name.Text = _stylist.lastName;
                dtp_day_of_birth.Value = _stylist.birth_date;
                txt_contact.Text = _stylist.contactNumber;
                txt_email.Text = _stylist.email;
                txt_address.Text = _stylist.address;


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
                address = txt_address.Text
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


            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            stylistController.Update(_stylist);
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveStylist();
            _mainForm.LoadStylist();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateStylist();
            _mainForm.LoadStylist();
        }
    }
}
