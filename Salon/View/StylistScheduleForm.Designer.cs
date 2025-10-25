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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_working = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_weekly_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_weekly_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.rad_week_no = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_week_yes = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmb_end_time = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_start_time = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_day = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.txt_reason = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
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
            this.weekly_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.weeklyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weekly_schedules)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.exceptionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exception_schedule)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekly_error)).BeginInit();
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.rad_week_no);
            this.materialCard1.Controls.Add(this.rad_week_yes);
            this.materialCard1.Controls.Add(this.cmb_end_time);
            this.materialCard1.Controls.Add(this.cmb_start_time);
            this.materialCard1.Controls.Add(this.txt_day);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.btn_add);
            this.materialCard1.Controls.Add(this.materialLabel1);
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
            // rad_week_no
            // 
            this.rad_week_no.AutoSize = true;
            this.rad_week_no.Depth = 0;
            this.rad_week_no.Location = new System.Drawing.Point(158, 187);
            this.rad_week_no.Margin = new System.Windows.Forms.Padding(0);
            this.rad_week_no.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_week_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_week_no.Name = "rad_week_no";
            this.rad_week_no.Ripple = true;
            this.rad_week_no.Size = new System.Drawing.Size(55, 37);
            this.rad_week_no.TabIndex = 17;
            this.rad_week_no.TabStop = true;
            this.rad_week_no.Text = "No";
            this.rad_week_no.UseVisualStyleBackColor = true;
            // 
            // rad_week_yes
            // 
            this.rad_week_yes.AutoSize = true;
            this.rad_week_yes.Depth = 0;
            this.rad_week_yes.Location = new System.Drawing.Point(52, 187);
            this.rad_week_yes.Margin = new System.Windows.Forms.Padding(0);
            this.rad_week_yes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_week_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_week_yes.Name = "rad_week_yes";
            this.rad_week_yes.Ripple = true;
            this.rad_week_yes.Size = new System.Drawing.Size(61, 37);
            this.rad_week_yes.TabIndex = 16;
            this.rad_week_yes.TabStop = true;
            this.rad_week_yes.Text = "Yes";
            this.rad_week_yes.UseVisualStyleBackColor = true;
            // 
            // cmb_end_time
            // 
            this.cmb_end_time.AutoResize = false;
            this.cmb_end_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_end_time.Depth = 0;
            this.cmb_end_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_end_time.DropDownHeight = 174;
            this.cmb_end_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_end_time.DropDownWidth = 121;
            this.cmb_end_time.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_end_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_end_time.FormattingEnabled = true;
            this.cmb_end_time.Hint = "End Time";
            this.cmb_end_time.IntegralHeight = false;
            this.cmb_end_time.ItemHeight = 43;
            this.cmb_end_time.Location = new System.Drawing.Point(598, 176);
            this.cmb_end_time.MaxDropDownItems = 4;
            this.cmb_end_time.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_end_time.Name = "cmb_end_time";
            this.cmb_end_time.Size = new System.Drawing.Size(277, 49);
            this.cmb_end_time.StartIndex = 0;
            this.cmb_end_time.TabIndex = 15;
            // 
            // cmb_start_time
            // 
            this.cmb_start_time.AutoResize = false;
            this.cmb_start_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_start_time.Depth = 0;
            this.cmb_start_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_start_time.DropDownHeight = 174;
            this.cmb_start_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_start_time.DropDownWidth = 121;
            this.cmb_start_time.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_start_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_start_time.FormattingEnabled = true;
            this.cmb_start_time.Hint = "Start Time";
            this.cmb_start_time.IntegralHeight = false;
            this.cmb_start_time.ItemHeight = 43;
            this.cmb_start_time.Location = new System.Drawing.Point(598, 39);
            this.cmb_start_time.MaxDropDownItems = 4;
            this.cmb_start_time.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_start_time.Name = "cmb_start_time";
            this.cmb_start_time.Size = new System.Drawing.Size(277, 49);
            this.cmb_start_time.StartIndex = 0;
            this.cmb_start_time.TabIndex = 14;
            // 
            // txt_day
            // 
            this.txt_day.AutoResize = false;
            this.txt_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_day.Depth = 0;
            this.txt_day.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txt_day.DropDownHeight = 174;
            this.txt_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_day.DropDownWidth = 121;
            this.txt_day.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_day.FormattingEnabled = true;
            this.txt_day.Hint = "-- Select Day --";
            this.txt_day.IntegralHeight = false;
            this.txt_day.ItemHeight = 43;
            this.txt_day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Thursday",
            "Wednesday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.txt_day.Location = new System.Drawing.Point(39, 39);
            this.txt_day.MaxDropDownItems = 4;
            this.txt_day.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(400, 49);
            this.txt_day.StartIndex = -1;
            this.txt_day.TabIndex = 11;
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
            this.btn_update.Location = new System.Drawing.Point(1136, 39);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(49, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Availability";
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
            this.dgv_exception_schedule.RowHeadersVisible = false;
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
            this.ex_start_time.Visible = false;
            // 
            // ex_end_time
            // 
            this.ex_end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ex_end_time.HeaderText = "End TIme";
            this.ex_end_time.MinimumWidth = 6;
            this.ex_end_time.Name = "ex_end_time";
            this.ex_end_time.ReadOnly = true;
            this.ex_end_time.Visible = false;
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
            // txt_reason
            // 
            this.txt_reason.AnimateReadOnly = false;
            this.txt_reason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.Depth = 0;
            this.txt_reason.HideSelection = true;
            this.txt_reason.Hint = "Reason";
            this.txt_reason.Location = new System.Drawing.Point(63, 114);
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
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(60, 30);
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
            this.dtp_date.Location = new System.Drawing.Point(63, 61);
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
            this.btn_update_exceptionSched.Location = new System.Drawing.Point(1109, 91);
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
            this.materialLabel4.Location = new System.Drawing.Point(638, 12);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "End Time";
            this.materialLabel4.Visible = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(887, 12);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Start Time";
            this.materialLabel5.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(363, 16);
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
            this.chk_no.Location = new System.Drawing.Point(487, 46);
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
            this.chk_yes.Location = new System.Drawing.Point(349, 46);
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
            this.dtp_exception_end_time.Location = new System.Drawing.Point(638, 34);
            this.dtp_exception_end_time.Name = "dtp_exception_end_time";
            this.dtp_exception_end_time.ShowUpDown = true;
            this.dtp_exception_end_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_exception_end_time.TabIndex = 2;
            this.dtp_exception_end_time.Value = new System.DateTime(2025, 10, 23, 0, 0, 0, 0);
            this.dtp_exception_end_time.Visible = false;
            // 
            // dtp_exception_start_time
            // 
            this.dtp_exception_start_time.CustomFormat = "hh:mm tt";
            this.dtp_exception_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_exception_start_time.Location = new System.Drawing.Point(887, 34);
            this.dtp_exception_start_time.Name = "dtp_exception_start_time";
            this.dtp_exception_start_time.ShowUpDown = true;
            this.dtp_exception_start_time.Size = new System.Drawing.Size(200, 22);
            this.dtp_exception_start_time.TabIndex = 1;
            this.dtp_exception_start_time.Value = new System.DateTime(2025, 10, 23, 0, 0, 0, 0);
            this.dtp_exception_start_time.Visible = false;
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
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // weekly_error
            // 
            this.weekly_error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.weekly_error.ContainerControl = this;
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
            this.Load += new System.EventHandler(this.StylistScheduleForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.weekly_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage weeklyTab;
        private System.Windows.Forms.TabPage exceptionTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_reason;
        private MaterialSkin.Controls.MaterialComboBox txt_day;
        private System.Windows.Forms.ErrorProvider weekly_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn exception_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_reason;
        private System.Windows.Forms.DataGridViewImageColumn ex_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn ex_btn_delete;
        private MaterialSkin.Controls.MaterialComboBox cmb_end_time;
        private MaterialSkin.Controls.MaterialComboBox cmb_start_time;
        private MaterialSkin.Controls.MaterialRadioButton rad_week_no;
        private MaterialSkin.Controls.MaterialRadioButton rad_week_yes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_working;
        private System.Windows.Forms.DataGridViewImageColumn btn_weekly_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_weekly_delete;
    }
}