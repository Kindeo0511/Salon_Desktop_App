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
    public partial class ViewCustomerCard : MaterialForm
    {
        private int _customerId;
        public ViewCustomerCard(int customerId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _customerId = customerId;
        }


        private void LoadCardDetails()
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);
            var card = controller.GetCardByCustomerId(_customerId);

            if (card == null) return;

            lbl_customer.Text = card.customer_name;
            lbl_auto_generated_number.Text = card.card_number;
            lbl_created_at.Text = card.created_at.ToString("MMMM dd, yyyy");
        }


        private void LoadVisitProgress()
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);
            var progress = controller.GetVisitProgress(_customerId);

            dgv_visit.AutoGenerateColumns = false;


            col_service_name.DataPropertyName = "serviceName";
            col_visit_req.DataPropertyName = "visits";
            col_required.DataPropertyName = "required";
            col_progress.DataPropertyName = "progress";

            dgv_visit.DataSource = progress;
        }
        private void ViewCustomerCard_Load(object sender, EventArgs e)
        {
            LoadCardDetails();
            LoadVisitProgress();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
