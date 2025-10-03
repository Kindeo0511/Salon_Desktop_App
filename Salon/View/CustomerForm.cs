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
using Salon.Models;
using Salon.Repository;
using Salon.Controller;

namespace Salon.View
{
    public partial class CustomerForm : MaterialForm
    {
        private MainForm mainform;
        private CustomerModel customer; 
        public CustomerForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
        }

        public CustomerForm(MainForm mainform, CustomerModel customer)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            this.customer = customer;

            if (customer != null) 
            {
                txt_first_name.Text = customer.firstName;
                txt_middle_name.Text = customer.middleName;
                txt_last_name.Text = customer.lastName;
                txt_contact.Text = customer.phoneNumber;
                txt_email.Text = customer.email;

                btn_save.Visible = false;
                btn_update.Visible = true;
                
            }
        }


        private void AddCustomer() 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customer = new CustomerModel
            {
                firstName = txt_first_name.Text,
                middleName = txt_middle_name.Text,
                lastName = txt_last_name.Text,
                phoneNumber = txt_contact.Text,
                email = txt_email.Text
            };

            controller.AddCustomer(customer);
        }
        private void UpdateCustomer() 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            customer.firstName = txt_first_name.Text;
            customer.middleName = txt_middle_name.Text;
            customer.lastName = txt_last_name.Text;
            customer.phoneNumber = txt_contact.Text;
            customer.email = txt_email.Text;
            controller.UpdateCustomer(customer);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddCustomer();
            mainform.LoadCustomers();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
            mainform.LoadCustomers();
        }
    }
}
