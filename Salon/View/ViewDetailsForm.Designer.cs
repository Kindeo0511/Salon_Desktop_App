namespace Salon.View
{
    partial class ViewDetailsForm
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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_exists = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_guest = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_prefix = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_service_selected = new System.Windows.Forms.DataGridView();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_appointment = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_walk_in = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.col_aps_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_change_stylist = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_mark_as_completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_start_service = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(44, 119);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 24);
            this.materialLabel5.TabIndex = 59;
            this.materialLabel5.Text = "Client Type:";
            // 
            // rad_exists
            // 
            this.rad_exists.AutoSize = true;
            this.rad_exists.Depth = 0;
            this.rad_exists.Location = new System.Drawing.Point(573, 119);
            this.rad_exists.Margin = new System.Windows.Forms.Padding(0);
            this.rad_exists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_exists.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_exists.Name = "rad_exists";
            this.rad_exists.Ripple = true;
            this.rad_exists.Size = new System.Drawing.Size(101, 37);
            this.rad_exists.TabIndex = 58;
            this.rad_exists.TabStop = true;
            this.rad_exists.Text = "MEMBER";
            this.rad_exists.UseVisualStyleBackColor = true;
            // 
            // rad_guest
            // 
            this.rad_guest.AutoSize = true;
            this.rad_guest.Depth = 0;
            this.rad_guest.Location = new System.Drawing.Point(316, 119);
            this.rad_guest.Margin = new System.Windows.Forms.Padding(0);
            this.rad_guest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_guest.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_guest.Name = "rad_guest";
            this.rad_guest.Ripple = true;
            this.rad_guest.Size = new System.Drawing.Size(85, 37);
            this.rad_guest.TabIndex = 57;
            this.rad_guest.TabStop = true;
            this.rad_guest.Text = "GUEST";
            this.rad_guest.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(43, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 29);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "Client Name:";
            // 
            // lbl_prefix
            // 
            this.lbl_prefix.AutoSize = true;
            this.lbl_prefix.Depth = 0;
            this.lbl_prefix.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_prefix.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_prefix.Location = new System.Drawing.Point(311, 55);
            this.lbl_prefix.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(126, 29);
            this.lbl_prefix.TabIndex = 55;
            this.lbl_prefix.Text = "prefix_code";
            // 
            // dgv_service_selected
            // 
            this.dgv_service_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service_selected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_aps_id,
            this.col_service_id,
            this.col_service_name,
            this.col_stylist_id,
            this.col_stylist,
            this.col_time,
            this.col_status,
            this.col_service_time,
            this.col_change_stylist,
            this.col_mark_as_completed,
            this.col_start_service,
            this.col_remove});
            this.dgv_service_selected.Location = new System.Drawing.Point(36, 345);
            this.dgv_service_selected.Name = "dgv_service_selected";
            this.dgv_service_selected.RowHeadersVisible = false;
            this.dgv_service_selected.RowHeadersWidth = 51;
            this.dgv_service_selected.RowTemplate.Height = 24;
            this.dgv_service_selected.Size = new System.Drawing.Size(817, 278);
            this.dgv_service_selected.TabIndex = 60;
            this.dgv_service_selected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellClick);
            this.dgv_service_selected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellContentClick);
            this.dgv_service_selected.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_service_selected_CellFormatting);
            this.dgv_service_selected.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellValueChanged);
            this.dgv_service_selected.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_service_selected_CurrentCellDirtyStateChanged);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(588, 642);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_save.Size = new System.Drawing.Size(86, 36);
            this.btn_save.TabIndex = 61;
            this.btn_save.Text = "Confirm";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(776, 642);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 62;
            this.materialButton1.Text = "cancel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(44, 196);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(127, 24);
            this.materialLabel2.TabIndex = 63;
            this.materialLabel2.Text = "Booking Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_appointment);
            this.panel1.Controls.Add(this.rad_walk_in);
            this.panel1.Location = new System.Drawing.Point(304, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 74);
            this.panel1.TabIndex = 64;
            // 
            // rad_appointment
            // 
            this.rad_appointment.AutoSize = true;
            this.rad_appointment.Depth = 0;
            this.rad_appointment.Location = new System.Drawing.Point(269, 14);
            this.rad_appointment.Margin = new System.Windows.Forms.Padding(0);
            this.rad_appointment.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_appointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_appointment.Name = "rad_appointment";
            this.rad_appointment.Ripple = true;
            this.rad_appointment.Size = new System.Drawing.Size(145, 37);
            this.rad_appointment.TabIndex = 59;
            this.rad_appointment.TabStop = true;
            this.rad_appointment.Text = "APPOINTMENT";
            this.rad_appointment.UseVisualStyleBackColor = true;
            // 
            // rad_walk_in
            // 
            this.rad_walk_in.AutoSize = true;
            this.rad_walk_in.Depth = 0;
            this.rad_walk_in.Location = new System.Drawing.Point(12, 14);
            this.rad_walk_in.Margin = new System.Windows.Forms.Padding(0);
            this.rad_walk_in.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_walk_in.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_walk_in.Name = "rad_walk_in";
            this.rad_walk_in.Ripple = true;
            this.rad_walk_in.Size = new System.Drawing.Size(97, 37);
            this.rad_walk_in.TabIndex = 58;
            this.rad_walk_in.TabStop = true;
            this.rad_walk_in.Text = "WALK-IN";
            this.rad_walk_in.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(36, 300);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(158, 36);
            this.btn_add.TabIndex = 65;
            this.btn_add.Text = "add new service";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // col_aps_id
            // 
            this.col_aps_id.HeaderText = "aps_id";
            this.col_aps_id.MinimumWidth = 6;
            this.col_aps_id.Name = "col_aps_id";
            this.col_aps_id.Visible = false;
            this.col_aps_id.Width = 125;
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id.HeaderText = "service_id";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.Visible = false;
            this.col_service_id.Width = 75;
            // 
            // col_service_name
            // 
            this.col_service_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_name.HeaderText = "Name";
            this.col_service_name.MinimumWidth = 6;
            this.col_service_name.Name = "col_service_name";
            // 
            // col_stylist_id
            // 
            this.col_stylist_id.HeaderText = "stylist_id";
            this.col_stylist_id.MinimumWidth = 6;
            this.col_stylist_id.Name = "col_stylist_id";
            this.col_stylist_id.Visible = false;
            this.col_stylist_id.Width = 125;
            // 
            // col_stylist
            // 
            this.col_stylist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stylist.HeaderText = "Stylist";
            this.col_stylist.MinimumWidth = 6;
            this.col_stylist.Name = "col_stylist";
            // 
            // col_time
            // 
            this.col_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_time.HeaderText = "Time";
            this.col_time.MinimumWidth = 6;
            this.col_time.Name = "col_time";
            this.col_time.Width = 67;
            // 
            // col_status
            // 
            this.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_status.Width = 73;
            // 
            // col_service_time
            // 
            this.col_service_time.HeaderText = "service_duration";
            this.col_service_time.MinimumWidth = 6;
            this.col_service_time.Name = "col_service_time";
            this.col_service_time.Visible = false;
            this.col_service_time.Width = 125;
            // 
            // col_change_stylist
            // 
            this.col_change_stylist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_change_stylist.HeaderText = "Assign Stylist";
            this.col_change_stylist.MinimumWidth = 6;
            this.col_change_stylist.Name = "col_change_stylist";
            this.col_change_stylist.Text = "Change Stylist";
            this.col_change_stylist.UseColumnTextForButtonValue = true;
            this.col_change_stylist.Width = 92;
            // 
            // col_mark_as_completed
            // 
            this.col_mark_as_completed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_mark_as_completed.HeaderText = "Mark as Completed";
            this.col_mark_as_completed.MinimumWidth = 6;
            this.col_mark_as_completed.Name = "col_mark_as_completed";
            this.col_mark_as_completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_mark_as_completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_mark_as_completed.Width = 140;
            // 
            // col_start_service
            // 
            this.col_start_service.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_start_service.HeaderText = "Start Service";
            this.col_start_service.MinimumWidth = 6;
            this.col_start_service.Name = "col_start_service";
            this.col_start_service.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_start_service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_start_service.Text = "Start";
            this.col_start_service.UseColumnTextForButtonValue = true;
            this.col_start_service.Width = 125;
            // 
            // col_remove
            // 
            this.col_remove.HeaderText = "Remove";
            this.col_remove.MinimumWidth = 6;
            this.col_remove.Name = "col_remove";
            this.col_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_remove.Text = "Remove";
            this.col_remove.UseColumnTextForButtonValue = true;
            this.col_remove.Width = 125;
            // 
            // ViewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_service_selected);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.rad_exists);
            this.Controls.Add(this.rad_guest);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbl_prefix);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ViewDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDetailsForm";
            this.Load += new System.EventHandler(this.ViewDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton rad_exists;
        private MaterialSkin.Controls.MaterialRadioButton rad_guest;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_prefix;
        private System.Windows.Forms.DataGridView dgv_service_selected;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton rad_appointment;
        private MaterialSkin.Controls.MaterialRadioButton rad_walk_in;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aps_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_time;
        private System.Windows.Forms.DataGridViewButtonColumn col_change_stylist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_mark_as_completed;
        private System.Windows.Forms.DataGridViewButtonColumn col_start_service;
        private System.Windows.Forms.DataGridViewButtonColumn col_remove;
    }
}