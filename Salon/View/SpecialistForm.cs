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
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
namespace Salon.View
{
    public partial class SpecialistForm : MaterialForm
    {
        private int specialistId = 0; // 0 indicates new specialist, >0 for editing existing
        private readonly MainForm main;
        private readonly SpecialistModel model;
        public SpecialistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            main = mainForm;

        }
        public SpecialistForm(MainForm mainForm, SpecialistModel specialistModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            main = mainForm;
            model = specialistModel;

            txt_name.Text = model.name;
            if (model.status == "Active")
            {
                rad_active.Checked = true;
            }
            else
            {
                rad_inactive.Checked = true;
            }
        }

        private bool IsValid()
        {
            int excludeId = model?.specialist_id ?? 0;
            bool validated = true;

            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                errorProvider1.SetError(txt_name, "Specialist name is required.");
                validated = false;
            }
            else if (txt_name.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txt_name, "Specialist name must be at least 3 characters.");
                validated = false;
            }
            else if (IsDuplicate(txt_name.Text, excludeId)) 
            {
                errorProvider1.SetError(txt_name, "A specialist with this name already exists.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_name, string.Empty);
            }

            // Status check
            if (!rad_active.Checked && !rad_inactive.Checked)
            {
                // Attach error to one of them (or both)
                errorProvider1.SetError(rad_active, "Please select a status.");
                errorProvider1.SetError(rad_inactive, "Please select a status.");
                validated = false;
            }
            else
            {
                // Clear errors on both
                errorProvider1.SetError(rad_active, string.Empty);
                errorProvider1.SetError(rad_inactive, string.Empty);
            }


            return validated;
        }
        private bool IsDuplicate(string name, int id)
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);
            return controller.SpecialistExists(name, id);
           
        }
        private bool SaveSpecialist()
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);

            var model = new SpecialistModel()
            {
                name = txt_name.Text.Trim(),
                status = rad_active.Checked ? "Active" : "Inactive"
            };

            return controller.CreateSpecialist(model);
        }
        private bool UpdateSpecialist()
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);

            model.name = txt_name.Text.Trim();
            model.status = rad_active.Checked ? "Active" : "Inactive";

            return controller.CreateSpecialist(model);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            if (SaveSpecialist()) 
            {
                MessageBox.Show("Specialist saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadSpecialist();
                this.Close();
            }
       
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

  
            if (UpdateSpecialist())
            {
                MessageBox.Show("Specialist updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadSpecialist();
                this.Close();
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
