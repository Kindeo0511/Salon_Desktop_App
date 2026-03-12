using iText.Kernel.Geom;
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
    public partial class ScheduleForm : MaterialForm
    {
        private readonly MainForm mainForm;
        private readonly StylistModel model;

        public ScheduleForm(MainForm main, StylistModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_sched);
            this.mainForm = main;
            this.model = model;

            DisplaySchedules(model.stylist_id);

        }

        public void DisplaySchedules(int id) 
        {
            var repo = new StylistScheduleRepository();
            var controller = new StylistSchedulesController(repo);

            var schedules = controller.GetAllScheduleById(id);

            dgv_sched.AutoGenerateColumns = true;

            col_id.DataPropertyName = "weekly_id";
            day_of_week.DataPropertyName = "day_of_week";
            stylist_id.DataPropertyName = "stylist_id";
            is_duty.DataPropertyName = "is_duty";
            dgv_sched.DataSource = schedules;

           
            if (dgv_sched.Columns["is_duty"] is DataGridViewCheckBoxColumn chkCol)
            {
                chkCol.TrueValue = 1;
                chkCol.FalseValue = 0;
            }



        }

        public void SaveOrUpdate() 
        {
            var repo = new StylistScheduleRepository();
            var controller = new StylistScheduleRepository();


            foreach (DataGridViewRow row in dgv_sched.Rows) 
            {
                // Skip new row placeholder
                if (row.IsNewRow) continue;

                // Get the bound model
                var schedule = row.DataBoundItem as StylistScheduleModel;
                if (schedule == null) continue;

                // Save or update in DB
                repo.SaveOrUpdateSchedule(schedule,model.stylist_id);

            }

        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();
            MessageBox.Show("Schedules saved successfully!");

            this.Close();
            await mainForm.RefreshStylistAsync(1, 25);
             mainForm.LoadStylistTrackPanel();

        }

     

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
