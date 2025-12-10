using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
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
using System.Windows.Ink;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Salon.View
{
    public partial class Walk_In_Form : MaterialForm
    {
        private DateTime selectedTime;
        private int totalDuration = 0;
        private MainForm _mainForm;
        private WalkInModel _model;
        public Walk_In_Form(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;


            LoadSubcategory();

            LoadServices();

            LoadStylist();

           
             LoadWalkInCode();


        }
        public Walk_In_Form(MainForm mainForm, WalkInModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            _model = model;


            LoadSubcategory();

            LoadServices();

            LoadStylist();


            LoadWalkInCode();
            LoadTimeSlots();

            LoadSelectedData(_model);
        }
        private void LoadSelectedData(WalkInModel model) 
        {
            cmb_stylist.MouseWheel += cmb_stylist_MouseWheel;

            lbl_prefix.Text = model.name;
            cmb_services.SelectedValue = model.serviceName_id;
            cmb_subcategory.SelectedValue = model.subCategoryId > 0 ? model.subCategoryId : 0;
            cmb_stylist.SelectedValue = model.stylist_id;
            dtp_date.Value = model.date;

            LoadTimeSlots(model.start_time != null ? model.date + model.start_time : (DateTime?)null);

            btn_save.Visible = false;
            btn_update.Visible = true;
            btn_save_and_add_another.Visible = false;

        }

        private void LoadTimeSlots()
        {

            time_slot_panel.Controls.Clear();
            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;
                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);

            }

        }
        private void LoadTimeSlots(DateTime? previousSelectedTime = null)
        {
            time_slot_panel.Controls.Clear();

            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;

                // If this button matches the previously selected time, highlight it
                if (previousSelectedTime.HasValue &&
                    time.ToString("hh:mm tt") == previousSelectedTime.Value.ToString("hh:mm tt"))
                {
                    button.UseAccentColor = true;
                    selectedTime = previousSelectedTime.Value; // keep it in sync
                }

                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);
            }
        }
        private void LoadWalkInCode() 
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            int walkInCode = controller.GetWalkInCode();

            string prefix_code = $"W-{walkInCode.ToString().PadLeft(4, '0')}";

            lbl_prefix.Text = prefix_code;
        }
        private void LoadSubcategory()
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var services = controller.getSubCategory();


            cmb_subcategory.ValueMember = "subCategory_id";
            cmb_subcategory.DisplayMember = "subCategoryName";

            cmb_subcategory.DataSource = services;
            cmb_subcategory.SelectedIndex = -1;

        }
        private void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServices();
            
            cmb_services.DataSource = null;

            cmb_services.ValueMember = "serviceName_id";
            cmb_services.DisplayMember = "serviceName";

            cmb_services.DataSource = services;

            cmb_services.SelectedIndex = -1;
            txt_duration.Text = string.Empty;
            txt_price.Text = string.Empty;


        }
        private void LoadServices(int id)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServicesById(id);

            cmb_services.DataSource = null;
            cmb_services.ValueMember = "serviceName_id";
            cmb_services.DisplayMember = "serviceName";

            cmb_services.DataSource = services;
        
        }
        private void LoadStylist()
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetAll();


            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }

        private void cmb_stylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_stylist.Text.Length > 0)
            {
                LoadTimeSlots();
            }
            else
            {
                time_slot_panel.Controls.Clear();
            }
        }
        private void Clear() 
        {
            cmb_services.SelectedIndex = -1;
            txt_duration.Text = string.Empty;
            txt_price.Text = string.Empty;
            cmb_subcategory.SelectedIndex = -1;
            cmb_stylist.SelectedIndex = -1;
            time_slot_panel.Controls.Clear();
            LoadWalkInCode();
        }

        private void SaveWalkIn() 
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
    

            var model = new WalkInModel()
            {
                name = lbl_prefix.Text,
                stylist_id = Convert.ToInt32(cmb_stylist.SelectedValue),
                serviceName_id = Convert.ToInt32(cmb_services.SelectedValue),
                date = dtp_date.Value.Date,
                start_time = selectedTime.TimeOfDay,
                end_time = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                status = "Scheduled",
                payment_status = "Unpaid",
            };
            controller.AddWalkIn(model);
        }
        private void UpdateWalkIn() 
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);


            var model = new WalkInModel()
            {
                id = _model.id,
                name = lbl_prefix.Text,
                stylist_id = Convert.ToInt32(cmb_stylist.SelectedValue),
                serviceName_id = Convert.ToInt32(cmb_services.SelectedValue),
                date = dtp_date.Value.Date,
                start_time = selectedTime.TimeOfDay,
                end_time = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                status = "Scheduled",
                payment_status = "Unpaid",
            };
            controller.UpdateWalkIn(model);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveWalkIn();
            MessageBox.Show("Walk-In appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            this.Close();

        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {
                
                totalDuration = selectedService.duration;
                txt_duration.Text = selectedService.duration.ToString() + " mins";
                txt_price.Text = selectedService.servicePrice.ToString("C2");

            }
        }

        private void cmb_subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_model == null)
            {

                LoadServices(Convert.ToInt32(cmb_subcategory.SelectedValue));
            }
        }

        private void btn_save_and_add_another_Click(object sender, EventArgs e)
        {
            SaveWalkIn();
            MessageBox.Show("Walk-In appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            Clear();
        }

        public class NoScrollComboBox : ComboBox
        {
            protected override void OnMouseWheel(MouseEventArgs e)
            {
                // Do nothing: disables scroll wheel changing selection
            }
        }
     
        private void cmb_stylist_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateWalkIn();
            MessageBox.Show("Walk-In appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            this.Close();

        }
    }
}
