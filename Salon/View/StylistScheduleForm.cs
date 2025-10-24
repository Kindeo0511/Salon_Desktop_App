using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities;
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
namespace Salon.View
{
    public partial class StylistScheduleForm : MaterialForm
    {
        private MainForm mainForm;
        private StylistModel _stylist;
        private int schedule_id;
        private StylistScheduleModel _stylistSchedule;
        private ExceptionScheduleModel _exceptionSchedule;
        public StylistScheduleForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_weekly_schedules);
            ThemeManager.StyleDataGridView(dgv_exception_schedule);
            this.mainForm = mainForm;
            _stylist = stylist;
     
            dtp_date.MinDate = DateTime.Today;
         
            LoadSchedules(_stylist.stylist_id);

            LoadExceptionSchedules(_stylist.stylist_id);
        }
        // WEEKLY SCHEDULES
        private void LoadSchedules(int stylist_id)
        {

            dgv_weekly_schedules.AutoGenerateColumns = false;
            id.DataPropertyName = "ScheduleId";
            col_stylist_id.DataPropertyName = "StylistId";
            day.DataPropertyName = "DayOfWeek";
            start_time.DataPropertyName = "StartTime";
            end_time.DataPropertyName = "EndTime";
            is_working.DataPropertyName = "IsWorking";


            var stylistSchedulesRepo = new Repository.StylistSchedulesRepository();
            var StylistSchedulesController = new StylistSchedulesController(stylistSchedulesRepo);
            var schedules = StylistSchedulesController.GetAllSchedules(stylist_id);
            dgv_weekly_schedules.DataSource = schedules;
        }
        private bool WeeklyValidated()
        {

            bool validated = true;
            // REQUIRED FIELD

            if (!Validator.IsComboBoxSelected(txt_day, weekly_error, "Day is Required"))
            {
                validated = false;
            }


            //validated &= Validator.IsTimeSelected(dtp_start_time, errorProvider1, "Start time is required.");

            //validated &= Validator.IsTimeSelected(dtp_end_time, errorProvider1, "End time is required.");

            if (dtp_start_time.Value.TimeOfDay >= dtp_end_time.Value.TimeOfDay)
            {
                weekly_error.SetError(dtp_end_time, "End time must be after start time.");
                validated = false;
            }

            if (!check_yes.Checked)
            {
                weekly_error.SetError(check_yes, "Availability is required.");
                validated = false;
            }
            else
            {
                weekly_error.SetError(check_yes, "");
        
            }


            // EXISTS VALIDATION
      
            int weekly_id = _stylistSchedule?.ScheduleId ?? 0;
            TimeSpan startTime = dtp_start_time.Value.TimeOfDay;
            TimeSpan endTime = dtp_end_time.Value.TimeOfDay;

            validated &= Validator.IsScheduleConflict(
              new Control[] { txt_day, dtp_start_time, dtp_end_time }, 
              errorProvider1,
              "Schedule already exists.",
              _stylist.stylist_id,
              startTime,
              endTime,
              weekly_id
          );

           


            return validated;


        }
        private bool ExceptionValidated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_reason, errorProvider1, "Reason is required.");

      

            if (!chk_yes.Checked && !chk_no.Checked)
            {
                errorProvider1.SetError(chk_yes, "Availability is required.");
                errorProvider1.SetError(chk_no, "Availability is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(chk_yes, "");
                errorProvider1.SetError(chk_no, "");
            }


            // EXISTS VALIDATION
         
            int exception_id = _exceptionSchedule?.id ?? 0;
  
            DateTime date = dtp_date.Value;

            if (!Validator.IsExScheduleExists(dtp_date, errorProvider1, "Schedule already exists.", _stylist.stylist_id, exception_id, date)) 
            {
                validated = false;
            }




            return validated;


        }
        private void AddSchedule()
        {
            var stylistSchedule = new StylistScheduleModel
            {
                StylistId = _stylist.stylist_id,
                DayOfWeek = txt_day.SelectedItem.ToString(),
                StartTime = dtp_start_time.Value.TimeOfDay,
                EndTime = dtp_end_time.Value.TimeOfDay,
                IsWorking = check_yes.Checked,

            };
            var stylistSchedulesRepo = new StylistSchedulesRepository();
            var stylistSchedulesController = new StylistSchedulesController(stylistSchedulesRepo);
            stylistSchedulesController.AddSchedule(stylistSchedule);
            MessageBox.Show("Schedule added successfully!");
            LoadSchedules(_stylist.stylist_id);
            clear();
        }
        private void UpdateSchedule()
        {

            var stylistSchedulesRepo = new StylistSchedulesRepository();
            var stylistSchedulesController = new StylistSchedulesController(stylistSchedulesRepo);


                 _stylistSchedule.StylistId = _stylist.stylist_id;
            _stylistSchedule.DayOfWeek = txt_day.SelectedItem.ToString();
                _stylistSchedule.StartTime = dtp_start_time.Value.TimeOfDay;
                _stylistSchedule.EndTime = dtp_end_time.Value.TimeOfDay;
                _stylistSchedule.IsWorking = check_yes.Checked;


         
                stylistSchedulesController.UpdateSchedule(_stylistSchedule);
                MessageBox.Show("Schedule updated successfully!");
                LoadSchedules(_stylist.stylist_id);
                clear();
                btn_add.Visible = true;
                btn_update.Visible = false;
                btn_cancel.Visible = false;
            



        }

        private void clear()
        {
            txt_day.Text = "";
            dtp_start_time.Value = DateTime.Today;
            dtp_end_time.Value = DateTime.Today;
            check_yes.Checked = false;
     
     ;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!WeeklyValidated()) 
            {
               
                return;


            }
            var day = txt_day.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist, Schedule", $"Created schedule for '{day}' (Stylist: {_stylist.firstName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            AddSchedule();
        }

        private void dgv_weekly_schedules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_weekly_schedules.Columns[e.ColumnIndex].DataPropertyName == "StartTime" || dgv_weekly_schedules.Columns[e.ColumnIndex].DataPropertyName == "EndTime")
            {
                if (e.Value is TimeSpan time)
                {
                    DateTime formattedTime = DateTime.Today.Add(time);
                    e.Value = formattedTime.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (dgv_weekly_schedules.Columns[e.ColumnIndex].Name == "is_working" && e.Value != null)
            {
                bool isWorking = Convert.ToBoolean(e.Value);
                e.Value = isWorking ? "Yes" : "No";
                e.CellStyle.ForeColor = isWorking ? Color.Green : Color.Red;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold); // optional: bold for emphasis

                e.FormattingApplied = true;
            }
        }

        private async void dgv_weekly_schedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txt_day.Hint = string.Empty;
            if (e.RowIndex >= 0 && dgv_weekly_schedules.Columns[e.ColumnIndex].Name == "btn_weekly_update")
            {
                _stylistSchedule = dgv_weekly_schedules.Rows[e.RowIndex].DataBoundItem as StylistScheduleModel;

                //schedule_id = Convert.ToInt32(_stylistSchedule.ScheduleId.ToString());
                txt_day.SelectedItem = _stylistSchedule.DayOfWeek;
                dtp_start_time.Value = DateTime.Today.Add(_stylistSchedule.StartTime);
                dtp_end_time.Value = DateTime.Today.Add(_stylistSchedule.EndTime);
                bool isWorking = _stylistSchedule.IsWorking;
                chk_yes.Checked = isWorking;
                chk_no.Checked = !isWorking;
                check_yes.Checked = isWorking;



                btn_add.Visible = false;
                btn_update.Visible = true;
                btn_cancel.Visible = true;

                txt_day.Hint = "-- Select Day --";


            }
            else if (e.RowIndex >= 0 && dgv_weekly_schedules.Columns[e.ColumnIndex].Name == "btn_weekly_delete")
            {
                var schedules = dgv_weekly_schedules.Rows[e.RowIndex].DataBoundItem as StylistScheduleModel;
                var stylistSchedulesRepo = new StylistSchedulesRepository();
                var stylistSchedulesController = new StylistSchedulesController(stylistSchedulesRepo);

                if (MessageBox.Show("Are you sure you want to delete the schedule? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes) 
                {
                    stylistSchedulesController.DeleteSchedule(schedules.ScheduleId);
                    MessageBox.Show("Schedule deleted successfully!");
                    LoadSchedules(_stylist.stylist_id);
                    mainForm.InsertDeletedRecord(schedules.ScheduleId, "Manage Stylist, Schedule", schedules.DayOfWeek, UserSession.CurrentUser.first_Name, DateTime.Today);
                    await mainForm.FilterdDeletedRecords();
                    var day = txt_day.Text;
                    Audit.AuditLog(DateTime.Now, "Delete", UserSession.CurrentUser.first_Name, "Manage Stylist, Schedule", $"Deleted schedule for '{day}' (Stylist: {_stylist.firstName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                    clear();
                }
               
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_cancel.Visible = false;

            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!WeeklyValidated()) return;


            
            UpdateSchedule();
            var day = txt_day.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Stylist, Schedule", $"Updated schedule for '{day}' (Stylist: {_stylist.firstName}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
        }
        // END OF WEEKLY SCHEDULES

        // EXCEPTIONS SCHEDULES

        private void LoadExceptionSchedules(int stylist_id)
        {
            dgv_exception_schedule.AutoGenerateColumns = false;
            exception_id.DataPropertyName = "id";
            ex_stylist_id.DataPropertyName = "stylist_id";
            ex_date.DataPropertyName = "date";
            ex_start_time.DataPropertyName = "start_time";
            ex_end_time.DataPropertyName = "end_time";
            ex_available.DataPropertyName = "is_available";
            ex_reason.DataPropertyName = "reason";
            var stylistSchedulesRepo = new Repository.ExceptionSchedulesRepository();
            var StylistSchedulesController = new ExceptionSchedulesController(stylistSchedulesRepo);
            var schedules = StylistSchedulesController.LoadExceptionSchedules(stylist_id);
            dgv_exception_schedule.DataSource = schedules;
        }

        private void AddExceptionSchedule()
        {
            var exceptionSchedule = new ExceptionScheduleModel
            {
                stylist_id = _stylist.stylist_id,
                date = dtp_date.Value.Date,
                is_available = chk_yes.Checked,
                reason = txt_reason.Text
            };
            var stylistSchedulesRepo = new Repository.ExceptionSchedulesRepository();
            var StylistSchedulesController = new ExceptionSchedulesController(stylistSchedulesRepo);
            StylistSchedulesController.Create_ExceptionSchedule(exceptionSchedule);
            LoadExceptionSchedules(_stylist.stylist_id);

        }
        private void UpdateExceptionSchedule()
        {
            if (_exceptionSchedule != null)
            {
                _exceptionSchedule.date = dtp_date.Value.Date;
                _exceptionSchedule.start_time = dtp_exception_start_time.Value.TimeOfDay;
                _exceptionSchedule.end_time = dtp_exception_end_time.Value.TimeOfDay;
                _exceptionSchedule.is_available = chk_yes.Checked;
                _exceptionSchedule.reason = txt_reason.Text;
                var stylistSchedulesRepo = new Repository.ExceptionSchedulesRepository();
                var StylistSchedulesController = new ExceptionSchedulesController(stylistSchedulesRepo);
                StylistSchedulesController.Update_ExceptionSchedule(_exceptionSchedule);
                LoadExceptionSchedules(_stylist.stylist_id);
            }

        }

        private void btn_add_ExceptionSched_Click(object sender, EventArgs e)
        {
            if (!ExceptionValidated()) return;
            var reason = txt_reason.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist, Exception Schedule", $"Created exception schedule for Stylist: '{_stylist.firstName}' (Reason: {reason}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            AddExceptionSchedule();
            MessageBox.Show("Exception schedule added successfully!");
        }

        private void btn_update_exceptionSched_Click(object sender, EventArgs e)
        {
            if (!ExceptionValidated()) return;
            var reason = txt_reason.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Stylist, Exception Schedule", $"Updated exception schedule for Stylist: '{_stylist.firstName}' (Reason: {reason}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            UpdateExceptionSchedule();
            btn_update_exceptionSched.Visible = false;
            btn_add_ExceptionSched.Visible = true;
            btn_cancel_exceptionSched.Visible = false;
            MessageBox.Show("Exception schedule updated successfully!");
        }

        private async void dgv_exception_schedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_exception_schedule.Columns[e.ColumnIndex].Name == "ex_btn_update")
            {
                _exceptionSchedule = dgv_exception_schedule.Rows[e.RowIndex].DataBoundItem as ExceptionScheduleModel;

                // Safely assign date
                DateTime safeDate = _exceptionSchedule.date.Date;
                if (safeDate >= dtp_date.MinDate && safeDate <= dtp_date.MaxDate)
                {
                    dtp_date.Value = safeDate;
                }
                else
                {
                    dtp_date.Value = DateTime.Today; // fallback
                }

                // Safely assign start time
                DateTime safeStart = DateTime.Today.Add(_exceptionSchedule.start_time);
                if (safeStart >= dtp_exception_start_time.MinDate && safeStart <= dtp_exception_start_time.MaxDate)
                {
                    dtp_exception_start_time.Value = safeStart;
                }
                else
                {
                    dtp_exception_start_time.Value = DateTime.Today;
                }

                // Safely assign end time
                DateTime safeEnd = DateTime.Today.Add(_exceptionSchedule.end_time);
                if (safeEnd >= dtp_exception_end_time.MinDate && safeEnd <= dtp_exception_end_time.MaxDate)
                {
                    dtp_exception_end_time.Value = safeEnd;
                }
                else
                {
                    dtp_exception_end_time.Value = DateTime.Today;
                }

                chk_yes.Checked = _exceptionSchedule.is_available;
                chk_no.Checked = !_exceptionSchedule.is_available;
                txt_reason.Text = _exceptionSchedule.reason;

                btn_add_ExceptionSched.Visible = false;
                btn_update_exceptionSched.Visible = true;
                btn_cancel_exceptionSched.Visible = true;




            }
            else if (e.RowIndex >= 0 && dgv_exception_schedule.Columns[e.ColumnIndex].Name == "ex_btn_delete")
            {
                var schedules = dgv_exception_schedule.Rows[e.RowIndex].DataBoundItem as ExceptionScheduleModel;
                var stylistSchedulesRepo = new ExceptionSchedulesRepository();
                var stylistSchedulesController = new ExceptionSchedulesController(stylistSchedulesRepo);
                stylistSchedulesController.Delete_ExceptionSchedule(schedules.id);
                MessageBox.Show("Schedule deleted successfully!");
                LoadExceptionSchedules(_stylist.stylist_id);
                mainForm.InsertDeletedRecord(schedules.id, "Manage Stylist, Exception Schedule",  _stylist.firstName + $"({schedules.date})", UserSession.CurrentUser.first_Name, DateTime.Today);
                await mainForm.FilterdDeletedRecords();
                var reason = txt_reason.Text;
                Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist, Exception Schedule", $"Created exception schedule for Stylist: '{_stylist.firstName}' (Reason: {reason}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                clear();
            }
        }

        private void dgv_exception_schedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_exception_schedule.Columns[e.ColumnIndex].DataPropertyName == "start_time" || dgv_exception_schedule.Columns[e.ColumnIndex].DataPropertyName == "end_time")
            {
                if (e.Value is TimeSpan time)
                {
                    DateTime formattedTime = DateTime.Today.Add(time);
                    e.Value = formattedTime.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (dgv_exception_schedule.Columns[e.ColumnIndex].Name == "ex_available" && e.Value != null)
            {
                bool isAvailable = Convert.ToBoolean(e.Value);
                e.Value = isAvailable ? "Yes" : "No";
                e.FormattingApplied = true;
            }
        }

        private void btn_cancel_exceptionSched_Click(object sender, EventArgs e)
        {
            btn_add_ExceptionSched.Visible = true;
            btn_update_exceptionSched.Visible = false;
            btn_cancel_exceptionSched.Visible = false;
            ClearExceptionForm();
        }
        private void ClearExceptionForm()
        {
            dtp_date.Value = DateTime.Today;
            dtp_exception_start_time.Value = DateTime.Today;
            dtp_exception_end_time.Value = DateTime.Today;
            chk_yes.Checked = false;
            chk_no.Checked = false;
            txt_reason.Text = "";
        }

        private void StylistScheduleForm_Load(object sender, EventArgs e)
        {
      

        }
    }
}
