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
            ThemeManager.StyleDataGridView(dgv_visit);
            _customerId = customerId;
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
        private void LoadCardDetails()
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);
            var card = controller.GetCardByCustomerId(_customerId);

            if (card == null) return;
            lbl_card_id.Text = card.card_id.ToString();
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

            col_service_id.DataPropertyName = "service_id";
            col_service_name.DataPropertyName = "serviceName";
            col_visit_req.DataPropertyName = "total_visits";
            col_required.DataPropertyName = "visit_required";
            col_progress.DataPropertyName = "progress";

            dgv_visit.DataSource = progress;
        }
        private void ViewCustomerCard_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_customerId.ToString());
            LoadCardDetails();
            LoadVisitProgress();


            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);

            bool IsAllRedeemed = controller.IsAllMilestonesRedeemed(_customerId);

            if (!IsAllRedeemed)
            {
                btn_new_card.Visible = false;
                btn_stamp_card.Visible = true;
            }
            else 
            {
                btn_new_card.Visible = true;
                btn_stamp_card.Visible = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_stamp_card_Click(object sender, EventArgs e)
        {

            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);
            int card_id = Convert.ToInt32(lbl_card_id.Text);



            //✔ Check if already stamped today
            //if (controller.IsAlreadyStampedToday(card_id))
            //{
            //    MessageBox.Show(
            //        "This card has already been stamped today.",
            //        "Already Stamped",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //    return;
            //}


            var result = MessageBox.Show(
                           "Stamp visit for this customer?",
                           "Stamp Visit",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {



                bool success = controller.StampVisit(card_id);


                if (success)
                {

                    // Check if milestone reached
                    int totalVisits = controller.GetTotalVisit(card_id);
                    var milestone = controller.GetMileStone(totalVisits);

                    if (milestone != null)
                    {
                        MessageBox.Show(
                            $"🎉 Milestone reached! Customer gets a free {milestone.service_name}!",
                            "Milestone Reached!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Visit stamped successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadVisitProgress();  // refresh
                }

            }



        }

        private void dgv_visit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgv_visit.Columns[e.ColumnIndex].Name != "col_action") return;

            var statusCell = dgv_visit.Rows[e.RowIndex].Cells["col_progress"];
            if (statusCell == null || statusCell.Value == null) return;

            var status = statusCell.Value.ToString();

            // ✔ Only show Redeem button if milestone reached
            e.Value = status == "Redeemed" ? "-" :
                      status == "Milestone Reached!" ? "Redeem" : "-";


        }

        private void dgv_visit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgv_visit.Columns[e.ColumnIndex].Name != "col_action") return;

            var statusCell = dgv_visit.Rows[e.RowIndex].Cells["col_progress"];
            if (statusCell == null || statusCell.Value == null) return;

            if (statusCell.Value.ToString() != "Milestone Reached!") return;

            // Get card_id
            int card_id = Convert.ToInt32(lbl_card_id.Text);
            int service_id = Convert.ToInt32(dgv_visit.Rows[e.RowIndex].Cells["col_service_id"].Value);
            // Ask which service to redeem
            RedeemFreeService(card_id, service_id);
        }

        private void RedeemFreeService(int card_id, int service_id)
        {

            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);
            bool success = controller.RedeemFreeService(card_id, service_id);

            if (success)
            {
                MessageBox.Show("Free service redeemed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVisitProgress();
            }

        }

        private void btn_new_card_Click(object sender, EventArgs e)
        {
            var repo = new LoyaltyCardRepository();
            var controller = new LoyaltyCardController(repo);

            bool allUsed = controller.IsAllMilestonesRedeemed(_customerId);

            //if (!allUsed)
            //{
            //    MessageBox.Show(
            //        "Customer still has unredeemed milestones.\nPlease redeem all before reissuing.",
            //        "Cannot Reissue",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //    return;
            //}
            var result = MessageBox.Show(
                   "Reissue a new loyalty card for this customer?",
                   "Reissue Card",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 1. Deactivate old card
                string newCardNumber = GenerateCardNumber();
                int card_id = Convert.ToInt32(lbl_card_id.Text);
                // 1. Delete old card visits
                controller.DeleteCardVisit(card_id);
                controller.DeleteCard(card_id);


      
                // 2. Create new card
              
                bool success = controller.CreateCustomerCard(_customerId, newCardNumber);

                if (success)
                {
                    MessageBox.Show(
                        $"New card issued: {newCardNumber}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }
    }
}
