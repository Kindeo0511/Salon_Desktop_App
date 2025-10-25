namespace Salon.View
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_FullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Contact = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_book_type = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_Date = new System.Windows.Forms.DateTimePicker();
            this.cb_Time = new MaterialSkin.Controls.MaterialComboBox();
            this.customer_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.txt_search_services = new MaterialSkin.Controls.MaterialTextBox();
            this.service_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_check_available = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_create = new System.Windows.Forms.PictureBox();
            this.txt_customer_type = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_create)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.AnimateReadOnly = false;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Depth = 0;
            this.txt_Search.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.Hint = "Search Customer";
            this.txt_Search.LeadingIcon = null;
            this.txt_Search.Location = new System.Drawing.Point(25, 99);
            this.txt_Search.MaxLength = 50;
            this.txt_Search.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(500, 50);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.Text = "";
            this.txt_Search.TrailingIcon = null;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // txt_FullName
            // 
            this.txt_FullName.AnimateReadOnly = true;
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FullName.Depth = 0;
            this.txt_FullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_FullName.Hint = "Full Name";
            this.txt_FullName.LeadingIcon = null;
            this.txt_FullName.Location = new System.Drawing.Point(25, 204);
            this.txt_FullName.MaxLength = 50;
            this.txt_FullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_FullName.Multiline = false;
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.ReadOnly = true;
            this.txt_FullName.Size = new System.Drawing.Size(400, 50);
            this.txt_FullName.TabIndex = 1;
            this.txt_FullName.Text = "";
            this.txt_FullName.TrailingIcon = null;
            // 
            // txt_Email
            // 
            this.txt_Email.AnimateReadOnly = true;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Depth = 0;
            this.txt_Email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Email.Hint = "Email";
            this.txt_Email.LeadingIcon = null;
            this.txt_Email.Location = new System.Drawing.Point(25, 299);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(400, 50);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.Text = "";
            this.txt_Email.TrailingIcon = null;
            // 
            // txt_Contact
            // 
            this.txt_Contact.AnimateReadOnly = true;
            this.txt_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contact.Depth = 0;
            this.txt_Contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Contact.Hint = "Contact";
            this.txt_Contact.LeadingIcon = null;
            this.txt_Contact.Location = new System.Drawing.Point(482, 204);
            this.txt_Contact.MaxLength = 50;
            this.txt_Contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Contact.Multiline = false;
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.ReadOnly = true;
            this.txt_Contact.Size = new System.Drawing.Size(400, 50);
            this.txt_Contact.TabIndex = 3;
            this.txt_Contact.Text = "";
            this.txt_Contact.TrailingIcon = null;
            // 
            // cb_book_type
            // 
            this.cb_book_type.AutoResize = false;
            this.cb_book_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_book_type.Depth = 0;
            this.cb_book_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_book_type.DropDownHeight = 174;
            this.cb_book_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_book_type.DropDownWidth = 121;
            this.cb_book_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_book_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_book_type.FormattingEnabled = true;
            this.cb_book_type.Hint = "Select Booking Type";
            this.cb_book_type.IntegralHeight = false;
            this.cb_book_type.ItemHeight = 43;
            this.cb_book_type.Items.AddRange(new object[] {
            "Walk-In",
            "Online",
            "Phone Call"});
            this.cb_book_type.Location = new System.Drawing.Point(482, 300);
            this.cb_book_type.MaxDropDownItems = 4;
            this.cb_book_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_book_type.Name = "cb_book_type";
            this.cb_book_type.Size = new System.Drawing.Size(400, 49);
            this.cb_book_type.StartIndex = -1;
            this.cb_book_type.TabIndex = 4;
            // 
            // cmb_Date
            // 
            this.cmb_Date.Location = new System.Drawing.Point(955, 327);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(400, 22);
            this.cmb_Date.TabIndex = 5;
            // 
            // cb_Time
            // 
            this.cb_Time.AutoResize = false;
            this.cb_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Time.Depth = 0;
            this.cb_Time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Time.DropDownHeight = 174;
            this.cb_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Time.DropDownWidth = 121;
            this.cb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_Time.FormattingEnabled = true;
            this.cb_Time.Hint = "Appointment Time";
            this.cb_Time.IntegralHeight = false;
            this.cb_Time.ItemHeight = 43;
            this.cb_Time.Location = new System.Drawing.Point(955, 204);
            this.cb_Time.MaxDropDownItems = 4;
            this.cb_Time.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_Time.Name = "cb_Time";
            this.cb_Time.Size = new System.Drawing.Size(400, 49);
            this.cb_Time.StartIndex = 0;
            this.cb_Time.TabIndex = 6;
            this.cb_Time.SelectedIndexChanged += new System.EventHandler(this.cb_Time_SelectedIndexChanged);
            // 
            // customer_panel
            // 
            this.customer_panel.Location = new System.Drawing.Point(25, 155);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(500, 10);
            this.customer_panel.TabIndex = 7;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(38, 267);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 19);
            this.lbl_ID.TabIndex = 8;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // txt_search_services
            // 
            this.txt_search_services.AnimateReadOnly = false;
            this.txt_search_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search_services.Depth = 0;
            this.txt_search_services.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search_services.Hint = "Search Services";
            this.txt_search_services.LeadingIcon = null;
            this.txt_search_services.Location = new System.Drawing.Point(25, 469);
            this.txt_search_services.MaxLength = 50;
            this.txt_search_services.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_search_services.Multiline = false;
            this.txt_search_services.Name = "txt_search_services";
            this.txt_search_services.Size = new System.Drawing.Size(700, 50);
            this.txt_search_services.TabIndex = 9;
            this.txt_search_services.Text = "";
            this.txt_search_services.TrailingIcon = null;
            this.txt_search_services.TextChanged += new System.EventHandler(this.txt_search_services_TextChanged);
            // 
            // service_panel
            // 
            this.service_panel.Location = new System.Drawing.Point(25, 525);
            this.service_panel.Name = "service_panel";
            this.service_panel.Size = new System.Drawing.Size(700, 10);
            this.service_panel.TabIndex = 8;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_service_name,
            this.col_category_name,
            this.col_duration,
            this.col_btn_delete});
            this.dgv_table.Location = new System.Drawing.Point(25, 597);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(1369, 226);
            this.dgv_table.TabIndex = 10;
            this.dgv_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_id.HeaderText = "ID";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.ReadOnly = true;
            // 
            // col_service_name
            // 
            this.col_service_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_name.HeaderText = "Service Name";
            this.col_service_name.MinimumWidth = 6;
            this.col_service_name.Name = "col_service_name";
            this.col_service_name.ReadOnly = true;
            // 
            // col_category_name
            // 
            this.col_category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category_name.HeaderText = "Category";
            this.col_category_name.MinimumWidth = 6;
            this.col_category_name.Name = "col_category_name";
            this.col_category_name.ReadOnly = true;
            // 
            // col_duration
            // 
            this.col_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_duration.HeaderText = "Duration";
            this.col_duration.MinimumWidth = 6;
            this.col_duration.Name = "col_duration";
            this.col_duration.ReadOnly = true;
            // 
            // col_btn_delete
            // 
            this.col_btn_delete.HeaderText = "Remove";
            this.col_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_btn_delete.Image")));
            this.col_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_btn_delete.MinimumWidth = 6;
            this.col_btn_delete.Name = "col_btn_delete";
            this.col_btn_delete.ReadOnly = true;
            this.col_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_delete.Width = 125;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.Enabled = false;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(1225, 552);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 11;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(1042, 552);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Save Changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_check_available
            // 
            this.btn_check_available.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_check_available.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_check_available.Depth = 0;
            this.btn_check_available.HighEmphasis = true;
            this.btn_check_available.Icon = null;
            this.btn_check_available.Location = new System.Drawing.Point(827, 552);
            this.btn_check_available.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_check_available.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_check_available.Name = "btn_check_available";
            this.btn_check_available.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_check_available.Size = new System.Drawing.Size(167, 36);
            this.btn_check_available.TabIndex = 13;
            this.btn_check_available.Text = "Check Availability";
            this.btn_check_available.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_check_available.UseAccentColor = false;
            this.btn_check_available.UseVisualStyleBackColor = true;
            this.btn_check_available.Click += new System.EventHandler(this.btn_check_available_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(956, 305);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Date:";
            // 
            // btn_create
            // 
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.Location = new System.Drawing.Point(531, 99);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(66, 50);
            this.btn_create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_create.TabIndex = 16;
            this.btn_create.TabStop = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_customer_type
            // 
            this.txt_customer_type.AnimateReadOnly = true;
            this.txt_customer_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customer_type.Depth = 0;
            this.txt_customer_type.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_customer_type.Hint = "Customer Type";
            this.txt_customer_type.LeadingIcon = null;
            this.txt_customer_type.Location = new System.Drawing.Point(25, 392);
            this.txt_customer_type.MaxLength = 50;
            this.txt_customer_type.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_customer_type.Multiline = false;
            this.txt_customer_type.Name = "txt_customer_type";
            this.txt_customer_type.ReadOnly = true;
            this.txt_customer_type.Size = new System.Drawing.Size(400, 50);
            this.txt_customer_type.TabIndex = 17;
            this.txt_customer_type.Text = "";
            this.txt_customer_type.TrailingIcon = null;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.txt_customer_type);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_check_available);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.service_panel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.txt_search_services);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.customer_panel);
            this.Controls.Add(this.cb_Time);
            this.Controls.Add(this.cmb_Date);
            this.Controls.Add(this.cb_book_type);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.txt_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BOOKING INFORMATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_create)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_Search;
        private MaterialSkin.Controls.MaterialTextBox txt_FullName;
        private MaterialSkin.Controls.MaterialTextBox txt_Email;
        private MaterialSkin.Controls.MaterialTextBox txt_Contact;
        private MaterialSkin.Controls.MaterialComboBox cb_book_type;
        private System.Windows.Forms.DateTimePicker cmb_Date;
        private MaterialSkin.Controls.MaterialComboBox cb_Time;
        private System.Windows.Forms.FlowLayoutPanel customer_panel;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialTextBox txt_search_services;
        private System.Windows.Forms.FlowLayoutPanel service_panel;
        private System.Windows.Forms.DataGridView dgv_table;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration;
        private System.Windows.Forms.DataGridViewImageColumn col_btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_check_available;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btn_create;
        private MaterialSkin.Controls.MaterialTextBox txt_customer_type;
    }
}