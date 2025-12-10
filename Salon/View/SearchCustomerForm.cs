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
        public SearchCustomerForm(AppointmentForm appointmentForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadCustomers();
            this.appointmentForm = appointmentForm;
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
                    appointmentForm.CustomerId = customer.customer_id.ToString();
                    appointmentForm.FullName = customer.fullName;
                    appointmentForm.Email = customer.email;
                    appointmentForm.Contact = customer.phoneNumber;

                    this.Close();
                }
            }
        }
    }
}
