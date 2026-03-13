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
        private bool IsSaving = false;
        private bool IsUpdating = false;
        public SpecialistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            main = mainForm;
            IsSaving = true;
            this.AcceptButton = btn_save;
        }
        public SpecialistForm(MainForm mainForm, SpecialistModel specialistModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            IsUpdating = true;
            main = mainForm;
            model = specialistModel;

            txt_name.Text = model.name;
            this.AcceptButton = btn_update;

        }

        private bool IsValid()
        {
            int excludeId = model?.specialist_id ?? 0;
            bool validated = true;
            int deleted_specialist_id = 0;

            if (IsSaving) 
            {
                deleted_specialist_id = ExistingSpecialistButDeleted(txt_name.Text.Trim());
            }
     
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
            else if (deleted_specialist_id > 0) 
            {
                var result = MessageBox.Show("This specialist  exists but is deleted. Do you want to restore it?",
                                     "Restore Specialist",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {



                    RestoreSpecialist(deleted_specialist_id);

                }
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

           


            return validated;
        }
        private bool IsDuplicate(string name, int id)
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);
            return controller.SpecialistExists(name, id);
           
        }
        private int ExistingSpecialistButDeleted(string name)
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);

            return controller.SpecialistExistsButDeleted(name);
        }
        public void RestoreSpecialist(int id)
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);


            if (controller.RestoreSpecilist(id))
            {
                main.DeleteDeletedRecord(id);
                MessageBox.Show("Specialist restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadSpecialist();
                this.Close();
            }


        }
        private bool SaveSpecialist()
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);

            var model = new SpecialistModel()
            {
                name = txt_name.Text.Trim()
            };

            return controller.CreateSpecialist(model);
        }
        private bool UpdateSpecialist()
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);

            model.name = txt_name.Text.Trim();

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
