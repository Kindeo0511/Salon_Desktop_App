using Salon.Controller;
using Salon.Models;
using Salon.Repository;
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
    public partial class SearchResultControl : UserControl
    {
        public static int temp_id;
        public static string id;
        public event EventHandler<CustomerModel> ResultClicked;
        public SearchResultControl()
        {
            InitializeComponent();
        }


        public void details(CustomerModel customerModel)
        {
            lbl_ID.Text = customerModel.customer_id.ToString();
            lbl_FullName.Text = customerModel.fullName;
            lbl_Email.Text = customerModel.email;
            lbl_contact.Text = customerModel.phoneNumber;
            temp_id = Convert.ToInt32(customerModel.customer_id.ToString());
            lbl_customer_type.Text = customerModel.customer_type.ToString();
        }

        public void searchResult(string key)
        {
            var repo = new CustomerRepository();
            var customerController = new CustomerController(repo);
            CustomerModel customerModel = new CustomerModel();
            customerController.GetCustomerBySearch(key);
            lbl_Email.Text = customerModel.email;
            lbl_ID.Text = customerModel.customer_id.ToString();
            lbl_FullName.Text = customerModel.fullName;
        }

       
        public static bool isSelected = false;
        public void SearchResultClicked()
        {
            isSelected = true;
            this.BackColor = Color.LightBlue;
            ResultClicked?.Invoke(this, new CustomerModel
            {

                customer_id = temp_id,
                customer_name = lbl_FullName.Text,
                email = lbl_Email.Text,
                phoneNumber = lbl_contact.Text,
                customer_type = lbl_customer_type.Text
                
            });
        }

        private void SearchResultControl_MouseClick(object sender, MouseEventArgs e)
        {
            SearchResultClicked();


        }

        private void lbl_FullName_Click(object sender, EventArgs e)
        {
            SearchResultClicked();
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {
            SearchResultClicked();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_MouseClick(object sender, MouseEventArgs e)
        {
            SearchResultClicked();
        }
    }
}
