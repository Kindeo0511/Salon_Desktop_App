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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
namespace Salon.View
{
    public partial class AssignStylistForm : MaterialForm

    {
        private MainForm main;
        private int appointment_service_id;
        private int service_id;
        public AssignStylistForm(MainForm main, int appointment_service_id, int ServiceId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = main;
            this.appointment_service_id = appointment_service_id;
            this.service_id = ServiceId;

           
            LoadStylist(ServiceId);
        }

        private void LoadStylist(int id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetStylistSpecialistById(id);


            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }
        private bool AssignStylist(int appointment_service_id, int service_id) 
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);

            return controller.ChangeStylist(appointment_service_id, service_id);
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to assign this stylist?", "Confirm Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (cmb_stylist.SelectedValue != null)
                {
                    int stylistId = (int)cmb_stylist.SelectedValue;
                    bool success = AssignStylist(appointment_service_id, stylistId);
                    if (success)
                    {
                        MessageBox.Show("Stylist assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign stylist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a stylist before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmb_stylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
