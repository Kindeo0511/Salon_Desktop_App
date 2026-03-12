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

namespace Salon.View
{
    public partial class SearchCustomerForm : MaterialForm
    {
        private AppointmentForm appointmentForm;
        private CreateCustomerCard CustomerCard;
        private MainForm mainForm;
        private Walk_In_Form walk_in_form;
        private bool IsPos;
        private bool isWalkin;
        private bool IsCustomerCard = false;

        public SearchCustomerForm(AppointmentForm appointmentForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadCustomers();
            this.appointmentForm = appointmentForm;
            this.isWalkin = false;
        }
      
        public SearchCustomerForm(Walk_In_Form walk_in_form, bool Is_Walkin)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadCustomers();
            this.walk_in_form = walk_in_form;
            this.isWalkin = Is_Walkin;
        }
        public SearchCustomerForm(MainForm main, bool IsPos)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadCustomers();
            mainForm = main;
            this.IsPos = IsPos;

        }

        public void LoadCustomers()
        {
            var repo = new CustomerRepository();
            var customerController = new CustomerController(repo);
            var customers = customerController.GetAllCustomer();

            dgv_customer.AutoGenerateColumns = false;
            dgv_customer.DataSource = null;
            col_customer_id.DataPropertyName = "customer_id";
            col_name.DataPropertyName = "fullName";
            col_email.DataPropertyName = "email";
            col_phone_number.DataPropertyName = "phoneNumber";
            dgv_customer.DataSource = customers;


        }
        public void LoadCustomers(string key = "")
        {
            var repo = new CustomerRepository();
            var customerController = new CustomerController(repo);
            var customers = customerController.GetCustomerBySearch(key);

            dgv_customer.AutoGenerateColumns = false;
            dgv_customer.DataSource = null;
            col_customer_id.DataPropertyName = "customer_id";
            col_name.DataPropertyName = "fullName";
            col_email.DataPropertyName = "email";
            col_phone_number.DataPropertyName = "phoneNumber";
            dgv_customer.DataSource = customers;


        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                LoadCustomers(txt_search.Text);
            }
            else 
            {
                LoadCustomers();
            }
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (e.RowIndex >= 0 && dgv_customer.Columns[e.ColumnIndex].Name == "col_selected") 
            {
                var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as CustomerModel;

                if (customer != null) 
                {
                    if (isWalkin)
                    {
                        walk_in_form.CustomerId = customer.customer_id.ToString();
                        walk_in_form.FullName = customer.fullName;
                    }
                    else if (IsPos) 
                    {
                        mainForm.pos_customer_name = customer.fullName;
                    }


                    else
                    {
                        appointmentForm.CustomerId = customer.customer_id.ToString();
                        appointmentForm.FullName = customer.fullName;
                    }
                  

                    this.Close();
                }
            }
        }
    }
}
