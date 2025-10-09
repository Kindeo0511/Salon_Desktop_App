namespace Salon.View
{
    partial class StylistScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StylistScheduleForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.weeklyTab = new System.Windows.Forms.TabPage();
            this.dgv_weekly_schedules = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_no = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_yes = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtp_end_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_start_time = new System.Windows.Forms.DateTimePicker();
            this.txt_day = new MaterialSkin.Controls.MaterialTextBox();
            this.exceptionTab = new System.Windows.Forms.TabPage();
            this.dgv_exception_schedule = new System.Windows.Forms.DataGridView();
            this.exception_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.ex_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel_exceptionSched = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_exceptionSched = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_ExceptionSched = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chk_no = new MaterialSkin.Controls.MaterialRadioButton();
            this.chk_yes = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtp_exception_end_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_exception_start_time = new System.Windows.Forms.DateTimePicker();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_working = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_weekly_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_weekly_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_reason = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialTabControl1.SuspendLayout();
            this.weeklyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weekly_schedules)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.exceptionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exception_schedule)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.weeklyTab);
            this.materialTabControl1.Controls.Add(this.exceptionTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 112);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1394, 607);
            this.materialTabControl1.TabIndex = 0;
            // 
            // weeklyTab
            // 
            this.weeklyTab.Controls.Add(this.dgv_weekly_schedules);
            this.weeklyTab.Controls.Add(this.materialCard1);
            this.weeklyTab.Location = new System.Drawing.Point(4, 25);
            this.weeklyTab.Name = "weeklyTab";
            this.weeklyTab.Padding = new System.Windows.Forms.Padding(25);
            this.weeklyTab.Size = new System.Drawing.Size(1386, 578);
            this.weeklyTab.TabIndex = 0;
            this.weeklyTab.Text = "Weekly Schedules";
            this.weeklyTab.UseVisualStyleBackColor = true;
            // 
            // dgv_weekly_schedules
            // 
            this.dgv_weekly_schedules.AllowUserToAddRows = false;
            this.dgv_weekly_schedules.AllowUserToDeleteRows = false;
            this.dgv_weekly_schedules.AllowUserToResizeColumns = false;
            this.dgv_weekly_schedules.AllowUserToResizeRows = false;
            this.dgv_weekly_schedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_weekly_schedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_weekly_schedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_weekly_schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_weekly_schedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.col_stylist_id,
            this.day,
            this.start_time,
            this.end_time,
            this.is_working,
            this.btn_weekly_update,
            this.btn_weekly_delete});
            this.dgv_weekly_schedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_weekly_schedules.Location = new System.Drawing.Point(25, 288);
            this.dgv_weekly_schedules.Name = "dgv_weekly_schedules";
            this.dgv_weekly_schedules.ReadOnly = true;
            this.dgv_weekly_schedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_weekly_schedules.RowHeadersVisible = false;
            this.dgv_weekly_schedules.RowHeadersWidth = 51;
            this.dgv_weekly_schedules.RowTemplate.Height = 24;
            this.dgv_weekly_schedules.Size = new System.Drawing.Size(1336, 265);
            this.dgv_weekly_schedules.TabIndex = 1;
            this.dgv_weekly_schedules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_weekly_schedules_CellClick);
            this.dgv_weekly_schedules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_weekly_schedules_CellFormatting);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.btn_add);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.rad_no);
            this.materialCard1.Controls.Add(this.rad_yes);
            this.materialCard1.Controls.Add(this.dtp_end_time);
            this.materialCard1.Controls.Add(this.dtp_start_time);
            this.materialCard1.Controls.Add(this.txt_day);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(25, 25);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1336, 263);
            this.materialCard1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1138, 111);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(1138, 42);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(1138, 41);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(127, 36);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Schedule";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(599, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "End Time";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(599, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Start Time";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(36, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Available";
            // 
            // rad_no
            // 
            this.rad_no.AutoSize = true;
            this.rad_no.Depth = 0;
            this.rad_no.Location = new System.Drawing.Point(171, 162);
            this.rad_no.Margin = new System.Windows.Forms.Padding(0);
            this.rad_no.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_no.Name = "rad_no";
            this.rad_no.Ripple = true;
            this.rad_no.Size = new System.Drawing.Size(55, 37);
            this.rad_no.TabIndex = 4;
            this.rad_no.TabStop = true;
            this.rad_no.Text = "No";
            this.rad_no.UseVisualStyleBackColor = true;
            // 
            // rad_yes
            // 
            this.rad_yes.AutoSize = true;
            this.rad_yes.Depth = 0;
            this.rad_yes.Location = new System.Drawing.Point(33, 162);
            this.rad_yes.Margin = new System.Windows.Forms.Padding(0);
            this.rad_yes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_yes.Name = "rad_yes";
            this.rad_yes.Ripple = true;
            this.rad_yes.Size = new System.Drawing.Size(61, 37);
            this.rad_yes.TabIndex = 3;
            this.rad_yes.TabStop = true;
            this.rad_yes.Text = "Yes";
            this.rad_yes.UseVisualStyleBackColor = true;
            // 
            // dtp_end_time
            // 
            this.dtp_end_time.CustomFormat = "hh:mm tt";
            this.dtp_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end_time.Location = new System.Drawing.Point(599, 167);
            this.dtp_end_time.Name = "dtp_end_time";
            this.dtp_end_time.ShowUpDown = true;
            this.dtp_end_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_end_time.TabIndex = 2;
            // 
            // dtp_start_time
            // 
            this.dtp_start_time.CustomFormat = "hh:mm tt";
            this.dtp_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_time.Location = new System.Drawing.Point(599, 64);
            this.dtp_start_time.Name = "dtp_start_time";
            this.dtp_start_time.ShowUpDown = true;
            this.dtp_start_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_start_time.TabIndex = 1;
            // 
            // txt_day
            // 
            this.txt_day.AnimateReadOnly = false;
            this.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_day.Depth = 0;
            this.txt_day.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_day.Hint = "Day";
            this.txt_day.LeadingIcon = null;
            this.txt_day.Location = new System.Drawing.Point(39, 42);
            this.txt_day.MaxLength = 50;
            this.txt_day.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_day.Multiline = false;
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(400, 50);
            this.txt_day.TabIndex = 0;
            this.txt_day.Text = "";
            this.txt_day.TrailingIcon = null;
            // 
            // exceptionTab
            // 
            this.exceptionTab.Controls.Add(this.dgv_exception_schedule);
            this.exceptionTab.Controls.Add(this.materialCard2);
            this.exceptionTab.Location = new System.Drawing.Point(4, 25);
            this.exceptionTab.Name = "exceptionTab";
            this.exceptionTab.Padding = new System.Windows.Forms.Padding(25);
            this.exceptionTab.Size = new System.Drawing.Size(1386, 578);
            this.exceptionTab.TabIndex = 1;
            this.exceptionTab.Text = "Exception Schedules";
            this.exceptionTab.UseVisualStyleBackColor = true;
            // 
            // dgv_exception_schedule
            // 
            this.dgv_exception_schedule.AllowUserToAddRows = false;
            this.dgv_exception_schedule.AllowUserToDeleteRows = false;
            this.dgv_exception_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exception_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exception_id,
            this.ex_stylist_id,
            this.ex_date,
            this.ex_start_time,
            this.ex_end_time,
            this.ex_available,
            this.ex_reason,
            this.ex_btn_update,
            this.ex_btn_delete});
            this.dgv_exception_schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_exception_schedule.Location = new System.Drawing.Point(25, 288);
            this.dgv_exception_schedule.Name = "dgv_exception_schedule";
            this.dgv_exception_schedule.ReadOnly = true;
            this.dgv_exception_schedule.RowHeadersWidth = 51;
            this.dgv_exception_schedule.RowTemplate.Height = 24;
            this.dgv_exception_schedule.Size = new System.Drawing.Size(1336, 265);
            this.dgv_exception_schedule.TabIndex = 2;
            this.dgv_exception_schedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_exception_schedule_CellClick);
            this.dgv_exception_schedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_exception_schedule_CellFormatting);
            // 
            // exception_id
            // 
            this.exception_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exception_id.HeaderText = "ID";
            this.exception_id.MinimumWidth = 6;
            this.exception_id.Name = "exception_id";
            this.exception_id.ReadOnly = true;
            this.exception_id.Visible = false;
            // 
            // ex_stylist_id
            // 
            this.ex_stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_stylist_id.HeaderText = "stylist_id";
            this.ex_stylist_id.MinimumWidth = 6;
            this.ex_stylist_id.Name = "ex_stylist_id";
            this.ex_stylist_id.ReadOnly = true;
            this.ex_stylist_id.Visible = false;
            // 
            // ex_date
            // 
            this.ex_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_date.HeaderText = "Day";
            this.ex_date.MinimumWidth = 6;
            this.ex_date.Name = "ex_date";
            this.ex_date.ReadOnly = true;
            // 
            // ex_start_time
            // 
            this.ex_start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_start_time.HeaderText = "Start Time";
            this.ex_start_time.MinimumWidth = 6;
            this.ex_start_time.Name = "ex_start_time";
            this.ex_start_time.ReadOnly = true;
            // 
            // ex_end_time
            // 
            this.ex_end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_end_time.HeaderText = "End TIme";
            this.ex_end_time.MinimumWidth = 6;
            this.ex_end_time.Name = "ex_end_time";
            this.ex_end_time.ReadOnly = true;
            // 
            // ex_available
            // 
            this.ex_available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_available.HeaderText = "Available";
            this.ex_available.MinimumWidth = 6;
            this.ex_available.Name = "ex_available";
            this.ex_available.ReadOnly = true;
            // 
            // ex_reason
            // 
            this.ex_reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_reason.HeaderText = "Reason";
            this.ex_reason.MinimumWidth = 6;
            this.ex_reason.Name = "ex_reason";
            this.ex_reason.ReadOnly = true;
            // 
            // ex_btn_update
            // 
            this.ex_btn_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_btn_update.HeaderText = "";
            this.ex_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("ex_btn_update.Image")));
            this.ex_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ex_btn_update.MinimumWidth = 6;
            this.ex_btn_update.Name = "ex_btn_update";
            this.ex_btn_update.ReadOnly = true;
            // 
            // ex_btn_delete
            // 
            this.ex_btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_btn_delete.HeaderText = "";
            this.ex_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("ex_btn_delete.Image")));
            this.ex_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ex_btn_delete.MinimumWidth = 6;
            this.ex_btn_delete.Name = "ex_btn_delete";
            this.ex_btn_delete.ReadOnly = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txt_reason);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.dtp_date);
            this.materialCard2.Controls.Add(this.btn_cancel_exceptionSched);
            this.materialCard2.Controls.Add(this.btn_update_exceptionSched);
            this.materialCard2.Controls.Add(this.btn_add_ExceptionSched);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.chk_no);
            this.materialCard2.Controls.Add(this.chk_yes);
            this.materialCard2.Controls.Add(this.dtp_exception_end_time);
            this.materialCard2.Controls.Add(this.dtp_exception_start_time);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(25, 25);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1336, 263);
            this.materialCard2.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(60, 16);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(34, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Date";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(63, 47);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 22);
            this.dtp_date.TabIndex = 12;
            // 
            // btn_cancel_exceptionSched
            // 
            this.btn_cancel_exceptionSched.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_exceptionSched.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_exceptionSched.Depth = 0;
            this.btn_cancel_exceptionSched.HighEmphasis = true;
            this.btn_cancel_exceptionSched.Icon = null;
            this.btn_cancel_exceptionSched.Location = new System.Drawing.Point(1109, 139);
            this.btn_cancel_exceptionSched.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_exceptionSched.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_exceptionSched.Name = "btn_cancel_exceptionSched";
            this.btn_cancel_exceptionSched.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_exceptionSched.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel_exceptionSched.TabIndex = 10;
            this.btn_cancel_exceptionSched.Text = "cancel";
            this.btn_cancel_exceptionSched.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_exceptionSched.UseAccentColor = false;
            this.btn_cancel_exceptionSched.UseVisualStyleBackColor = true;
            this.btn_cancel_exceptionSched.Visible = false;
            this.btn_cancel_exceptionSched.Click += new System.EventHandler(this.btn_cancel_exceptionSched_Click);
            // 
            // btn_update_exceptionSched
            // 
            this.btn_update_exceptionSched.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_exceptionSched.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_exceptionSched.Depth = 0;
            this.btn_update_exceptionSched.HighEmphasis = true;
            this.btn_update_exceptionSched.Icon = null;
            this.btn_update_exceptionSched.Location = new System.Drawing.Point(1109, 70);
            this.btn_update_exceptionSched.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_exceptionSched.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_exceptionSched.Name = "btn_update_exceptionSched";
            this.btn_update_exceptionSched.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_exceptionSched.Size = new System.Drawing.Size(154, 36);
            this.btn_update_exceptionSched.TabIndex = 9;
            this.btn_update_exceptionSched.Text = "update schedule";
            this.btn_update_exceptionSched.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_exceptionSched.UseAccentColor = false;
            this.btn_update_exceptionSched.UseVisualStyleBackColor = true;
            this.btn_update_exceptionSched.Visible = false;
            this.btn_update_exceptionSched.Click += new System.EventHandler(this.btn_update_exceptionSched_Click);
            // 
            // btn_add_ExceptionSched
            // 
            this.btn_add_ExceptionSched.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_ExceptionSched.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_ExceptionSched.Depth = 0;
            this.btn_add_ExceptionSched.HighEmphasis = true;
            this.btn_add_ExceptionSched.Icon = null;
            this.btn_add_ExceptionSched.Location = new System.Drawing.Point(1109, 69);
            this.btn_add_ExceptionSched.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_ExceptionSched.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_ExceptionSched.Name = "btn_add_ExceptionSched";
            this.btn_add_ExceptionSched.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_ExceptionSched.Size = new System.Drawing.Size(127, 36);
            this.btn_add_ExceptionSched.TabIndex = 8;
            this.btn_add_ExceptionSched.Text = "Add Schedule";
            this.btn_add_ExceptionSched.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_ExceptionSched.UseAccentColor = false;
            this.btn_add_ExceptionSched.UseVisualStyleBackColor = true;
            this.btn_add_ExceptionSched.Click += new System.EventHandler(this.btn_add_ExceptionSched_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(63, 191);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "End Time";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(63, 114);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Start Time";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(422, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Available";
            // 
            // chk_no
            // 
            this.chk_no.AutoSize = true;
            this.chk_no.Depth = 0;
            this.chk_no.Location = new System.Drawing.Point(546, 56);
            this.chk_no.Margin = new System.Windows.Forms.Padding(0);
            this.chk_no.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_no.Name = "chk_no";
            this.chk_no.Ripple = true;
            this.chk_no.Size = new System.Drawing.Size(55, 37);
            this.chk_no.TabIndex = 4;
            this.chk_no.TabStop = true;
            this.chk_no.Text = "No";
            this.chk_no.UseVisualStyleBackColor = true;
            // 
            // chk_yes
            // 
            this.chk_yes.AutoSize = true;
            this.chk_yes.Depth = 0;
            this.chk_yes.Location = new System.Drawing.Point(408, 56);
            this.chk_yes.Margin = new System.Windows.Forms.Padding(0);
            this.chk_yes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_yes.Name = "chk_yes";
            this.chk_yes.Ripple = true;
            this.chk_yes.Size = new System.Drawing.Size(61, 37);
            this.chk_yes.TabIndex = 3;
            this.chk_yes.TabStop = true;
            this.chk_yes.Text = "Yes";
            this.chk_yes.UseVisualStyleBackColor = true;
            // 
            // dtp_exception_end_time
            // 
            this.dtp_exception_end_time.CustomFormat = "hh:mm tt";
            this.dtp_exception_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_exception_end_time.Location = new System.Drawing.Point(63, 213);
            this.dtp_exception_end_time.Name = "dtp_exception_end_time";
            this.dtp_exception_end_time.ShowUpDown = true;
            this.dtp_exception_end_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_exception_end_time.TabIndex = 2;
            // 
            // dtp_exception_start_time
            // 
            this.dtp_exception_start_time.CustomFormat = "hh:mm tt";
            this.dtp_exception_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_exception_start_time.Location = new System.Drawing.Point(63, 136);
            this.dtp_exception_start_time.Name = "dtp_exception_start_time";
            this.dtp_exception_start_time.ShowUpDown = true;
            this.dtp_exception_start_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_exception_start_time.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1394, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // col_stylist_id
            // 
            this.col_stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stylist_id.HeaderText = "stylist_id";
            this.col_stylist_id.MinimumWidth = 6;
            this.col_stylist_id.Name = "col_stylist_id";
            this.col_stylist_id.ReadOnly = true;
            this.col_stylist_id.Visible = false;
            // 
            // day
            // 
            this.day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.day.HeaderText = "Day";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_time.HeaderText = "Start Time";
            this.start_time.MinimumWidth = 6;
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_time.HeaderText = "End TIme";
            this.end_time.MinimumWidth = 6;
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            // 
            // is_working
            // 
            this.is_working.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_working.HeaderText = "Available";
            this.is_working.MinimumWidth = 6;
            this.is_working.Name = "is_working";
            this.is_working.ReadOnly = true;
            // 
            // btn_weekly_update
            // 
            this.btn_weekly_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_weekly_update.HeaderText = "";
            this.btn_weekly_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_weekly_update.Image")));
            this.btn_weekly_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_weekly_update.MinimumWidth = 6;
            this.btn_weekly_update.Name = "btn_weekly_update";
            this.btn_weekly_update.ReadOnly = true;
            // 
            // btn_weekly_delete
            // 
            this.btn_weekly_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_weekly_delete.HeaderText = "";
            this.btn_weekly_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_weekly_delete.Image")));
            this.btn_weekly_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_weekly_delete.MinimumWidth = 6;
            this.btn_weekly_delete.Name = "btn_weekly_delete";
            this.btn_weekly_delete.ReadOnly = true;
            // 
            // txt_reason
            // 
            this.txt_reason.AnimateReadOnly = false;
            this.txt_reason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.Depth = 0;
            this.txt_reason.HideSelection = true;
            this.txt_reason.Hint = "Reason";
            this.txt_reason.Location = new System.Drawing.Point(402, 125);
            this.txt_reason.MaxLength = 32767;
            this.txt_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.PasswordChar = '\0';
            this.txt_reason.ReadOnly = false;
            this.txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_reason.SelectedText = "";
            this.txt_reason.SelectionLength = 0;
            this.txt_reason.SelectionStart = 0;
            this.txt_reason.ShortcutsEnabled = true;
            this.txt_reason.Size = new System.Drawing.Size(479, 121);
            this.txt_reason.TabIndex = 14;
            this.txt_reason.TabStop = false;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_reason.UseSystemPasswordChar = false;
            // 
            // StylistScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 722);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "StylistScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCHEDULE";
            this.materialTabControl1.ResumeLayout(false);
            this.weeklyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weekly_schedules)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.exceptionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exception_schedule)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage weeklyTab;
        private System.Windows.Forms.TabPage exceptionTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rad_no;
        private MaterialSkin.Controls.MaterialRadioButton rad_yes;
        private System.Windows.Forms.DateTimePicker dtp_end_time;
        private System.Windows.Forms.DateTimePicker dtp_start_time;
        private MaterialSkin.Controls.MaterialTextBox txt_day;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridView dgv_weekly_schedules;
        private System.Windows.Forms.DataGridView dgv_exception_schedule;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private MaterialSkin.Controls.MaterialButton btn_cancel_exceptionSched;
        private MaterialSkin.Controls.MaterialButton btn_update_exceptionSched;
        private MaterialSkin.Controls.MaterialButton btn_add_ExceptionSched;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton chk_no;
        private MaterialSkin.Controls.MaterialRadioButton chk_yes;
        private System.Windows.Forms.DateTimePicker dtp_exception_end_time;
        private System.Windows.Forms.DateTimePicker dtp_exception_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exception_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_reason;
        private System.Windows.Forms.DataGridViewImageColumn ex_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn ex_btn_delete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_working;
        private System.Windows.Forms.DataGridViewImageColumn btn_weekly_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_weekly_delete;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_reason;
    }
}