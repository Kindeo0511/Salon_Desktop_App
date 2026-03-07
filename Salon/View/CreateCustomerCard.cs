using Laundry.Data;
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
    public partial class CreateCustomerCard : MaterialForm
    {
        private MainForm mainform;
        private CustomerModel customer;

        public CreateCustomerCard(MainForm main, CustomerModel customer)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = main;
            this.customer = customer;
        }

        private string GenerateCardNumber() 
        {

            var date = DateTime.Now.ToString("yyyyMMdd");
            var lastCard = GetLastCardNumber();  // get last card number from DB
            var sequence = (lastCard + 1).ToString("D4");  // 0001, 0002, 0003...

            return $"LC-{date}-{sequence}";
        }

        public int GetLastCardNumber()
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);

            return controller.GetLastCardNumber();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveCustomerCard();
            this.Close();
        }

        private void CreateCustomerCard_Load(object sender, EventArgs e)
        {
            lbl_id.Text = customer.customer_id.ToString();
            lbl_customer.Text = customer.fullName;
            lbl_auto_generated_number.Text = GenerateCardNumber();
            LoadServiceRewards();
        }

        private void SaveCustomerCard() 
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);

            int customer_id = customer.customer_id;
            string card_number = lbl_auto_generated_number.Text;


            bool Is_Saved = controller.CreateCustomerCard(customer_id, card_number);
            if (Is_Saved)
            {

                MessageBox.Show("Loyalty card created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to create loyalty card. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadServiceRewards()
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);


            dgv_services.AutoGenerateColumns = false;


            col_service_name.DataPropertyName = "serviceName";
            col_visit_req.DataPropertyName = "visit_required";
            col_description.DataPropertyName = "description";

            dgv_services.DataSource = controller.GetLoyaltyCardModels();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
