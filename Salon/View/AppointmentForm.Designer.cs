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
            this.txt_FullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Contact = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_stylist = new MaterialSkin.Controls.MaterialComboBox();
            this.time_slot_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_register_customer = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_exists = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_guest = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_appointment_product = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_services = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_add_to_cart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.col_app_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_app_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_app_product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_app_product_unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_app_product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_app_btn_product_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment_product)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_FullName
            // 
            this.txt_FullName.AnimateReadOnly = true;
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FullName.Depth = 0;
            this.txt_FullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_FullName.Hint = "Full Name";
            this.txt_FullName.LeadingIcon = null;
            this.txt_FullName.Location = new System.Drawing.Point(25, 164);
            this.txt_FullName.MaxLength = 50;
            this.txt_FullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_FullName.Multiline = false;
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.ReadOnly = true;
            this.txt_FullName.Size = new System.Drawing.Size(400, 50);
            this.txt_FullName.TabIndex = 1;
            this.txt_FullName.Text = "";
            this.txt_FullName.TrailingIcon = null;
            this.txt_FullName.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.AnimateReadOnly = true;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Depth = 0;
            this.txt_Email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Email.Hint = "Email";
            this.txt_Email.LeadingIcon = null;
            this.txt_Email.Location = new System.Drawing.Point(25, 242);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(400, 50);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.Text = "";
            this.txt_Email.TrailingIcon = null;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Contact
            // 
            this.txt_Contact.AnimateReadOnly = true;
            this.txt_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contact.Depth = 0;
            this.txt_Contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Contact.Hint = "Contact";
            this.txt_Contact.LeadingIcon = null;
            this.txt_Contact.Location = new System.Drawing.Point(499, 164);
            this.txt_Contact.MaxLength = 50;
            this.txt_Contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Contact.Multiline = false;
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.ReadOnly = true;
            this.txt_Contact.Size = new System.Drawing.Size(400, 50);
            this.txt_Contact.TabIndex = 3;
            this.txt_Contact.Text = "";
            this.txt_Contact.TrailingIcon = null;
            this.txt_Contact.TextChanged += new System.EventHandler(this.txt_Contact_TextChanged);
            // 
            // cmb_Date
            // 
            this.cmb_Date.Location = new System.Drawing.Point(66, 43);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(500, 22);
            this.cmb_Date.TabIndex = 5;
            this.cmb_Date.ValueChanged += new System.EventHandler(this.cmb_Date_ValueChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(1554, 1057);
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = false;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_search.Depth = 0;
            this.btn_search.HighEmphasis = true;
            this.btn_search.Icon = ((System.Drawing.Image)(resources.GetObject("btn_search.Icon")));
            this.errorProvider1.SetIconAlignment(this.btn_search, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(25, 50);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_search.Size = new System.Drawing.Size(200, 40);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = " ";
            this.btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_search.UseAccentColor = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(22, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Date:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(32, 142);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 19);
            this.lbl_ID.TabIndex = 8;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // cmb_stylist
            // 
            this.cmb_stylist.AutoResize = false;
            this.cmb_stylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_stylist.Depth = 0;
            this.cmb_stylist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_stylist.DropDownHeight = 174;
            this.cmb_stylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stylist.DropDownWidth = 121;
            this.cmb_stylist.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_stylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_stylist.FormattingEnabled = true;
            this.cmb_stylist.Hint = "Select Stylist";
            this.cmb_stylist.IntegralHeight = false;
            this.cmb_stylist.ItemHeight = 43;
            this.cmb_stylist.Location = new System.Drawing.Point(25, 48);
            this.cmb_stylist.MaxDropDownItems = 4;
            this.cmb_stylist.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_stylist.Name = "cmb_stylist";
            this.cmb_stylist.Size = new System.Drawing.Size(875, 49);
            this.cmb_stylist.StartIndex = 0;
            this.cmb_stylist.TabIndex = 17;
            this.cmb_stylist.SelectedIndexChanged += new System.EventHandler(this.cmb_stylist_SelectedIndexChanged);
            // 
            // time_slot_panel
            // 
            this.time_slot_panel.Location = new System.Drawing.Point(66, 93);
            this.time_slot_panel.Name = "time_slot_panel";
            this.time_slot_panel.Size = new System.Drawing.Size(783, 219);
            this.time_slot_panel.TabIndex = 16;
            this.time_slot_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.time_slot_panel_Paint);
            // 
            // btn_register_customer
            // 
            this.btn_register_customer.AutoSize = false;
            this.btn_register_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_register_customer.Depth = 0;
            this.btn_register_customer.HighEmphasis = true;
            this.btn_register_customer.Icon = null;
            this.btn_register_customer.Location = new System.Drawing.Point(305, 50);
            this.btn_register_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register_customer.Name = "btn_register_customer";
            this.btn_register_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_register_customer.Size = new System.Drawing.Size(200, 40);
            this.btn_register_customer.TabIndex = 22;
            this.btn_register_customer.Text = "New Customer";
            this.btn_register_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register_customer.UseAccentColor = false;
            this.btn_register_customer.UseVisualStyleBackColor = true;
            this.btn_register_customer.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1827, 1057);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(1365, 1057);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_exists);
            this.groupBox1.Controls.Add(this.rad_guest);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_FullName);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_register_customer);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.txt_Contact);
            this.groupBox1.Location = new System.Drawing.Point(29, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 317);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER INFO";
            // 
            // rad_exists
            // 
            this.rad_exists.AutoSize = true;
            this.rad_exists.Depth = 0;
            this.rad_exists.Location = new System.Drawing.Point(305, 105);
            this.rad_exists.Margin = new System.Windows.Forms.Padding(0);
            this.rad_exists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_exists.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_exists.Name = "rad_exists";
            this.rad_exists.Ripple = true;
            this.rad_exists.Size = new System.Drawing.Size(192, 37);
            this.rad_exists.TabIndex = 24;
            this.rad_exists.TabStop = true;
            this.rad_exists.Text = "EXISTING CUSTOMER";
            this.rad_exists.UseVisualStyleBackColor = true;
            this.rad_exists.CheckedChanged += new System.EventHandler(this.rad_exists_CheckedChanged);
            // 
            // rad_guest
            // 
            this.rad_guest.AutoSize = true;
            this.rad_guest.Depth = 0;
            this.rad_guest.Location = new System.Drawing.Point(25, 105);
            this.rad_guest.Margin = new System.Windows.Forms.Padding(0);
            this.rad_guest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_guest.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_guest.Name = "rad_guest";
            this.rad_guest.Ripple = true;
            this.rad_guest.Size = new System.Drawing.Size(105, 37);
            this.rad_guest.TabIndex = 23;
            this.rad_guest.TabStop = true;
            this.rad_guest.Text = "WALK - IN";
            this.rad_guest.UseVisualStyleBackColor = true;
            this.rad_guest.CheckedChanged += new System.EventHandler(this.rad_guest_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_stylist);
            this.groupBox2.Location = new System.Drawing.Point(987, 539);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 142);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STYLIST";
            // 
            // dgv_appointment_product
            // 
            this.dgv_appointment_product.AllowUserToAddRows = false;
            this.dgv_appointment_product.AllowUserToDeleteRows = false;
            this.dgv_appointment_product.AllowUserToResizeColumns = false;
            this.dgv_appointment_product.AllowUserToResizeRows = false;
            this.dgv_appointment_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_appointment_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_appointment_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_appointment_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appointment_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_app_product_id,
            this.col_app_product_name,
            this.col_app_product_brand,
            this.col_app_product_unit_type,
            this.col_app_product_price,
            this.col_app_btn_product_add});
            this.dgv_appointment_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_appointment_product.EnableHeadersVisualStyles = false;
            this.dgv_appointment_product.Location = new System.Drawing.Point(3, 3);
            this.dgv_appointment_product.Name = "dgv_appointment_product";
            this.dgv_appointment_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_appointment_product.RowHeadersVisible = false;
            this.dgv_appointment_product.RowHeadersWidth = 51;
            this.dgv_appointment_product.RowTemplate.Height = 24;
            this.dgv_appointment_product.Size = new System.Drawing.Size(903, 472);
            this.dgv_appointment_product.TabIndex = 0;
            this.dgv_appointment_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appointment_product_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.materialLabel1);
            this.groupBox5.Controls.Add(this.cmb_Date);
            this.groupBox5.Controls.Add(this.time_slot_panel);
            this.groupBox5.Location = new System.Drawing.Point(987, 704);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(917, 333);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATE & TIME";
            // 
            // dgv_services
            // 
            this.dgv_services.AllowUserToAddRows = false;
            this.dgv_services.AllowUserToDeleteRows = false;
            this.dgv_services.AllowUserToResizeColumns = false;
            this.dgv_services.AllowUserToResizeRows = false;
            this.dgv_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_services.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_services.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_service,
            this.col_category,
            this.col_price,
            this.col_duration,
            this.col_btn_add_to_cart});
            this.dgv_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_services.EnableHeadersVisualStyles = false;
            this.dgv_services.Location = new System.Drawing.Point(3, 3);
            this.dgv_services.Name = "dgv_services";
            this.dgv_services.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_services.RowHeadersVisible = false;
            this.dgv_services.RowHeadersWidth = 51;
            this.dgv_services.RowTemplate.Height = 24;
            this.dgv_services.Size = new System.Drawing.Size(903, 472);
            this.dgv_services.TabIndex = 0;
            this.dgv_services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_services_CellContentClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id.HeaderText = "ID";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.Visible = false;
            this.col_service_id.Width = 125;
            // 
            // col_service
            // 
            this.col_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service.HeaderText = "Service";
            this.col_service.MinimumWidth = 6;
            this.col_service.Name = "col_service";
            this.col_service.ReadOnly = true;
            this.col_service.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col_category
            // 
            this.col_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_category.HeaderText = "Category";
            this.col_category.MinimumWidth = 6;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            this.col_category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_category.Width = 89;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_price.Width = 65;
            // 
            // col_duration
            // 
            this.col_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_duration.HeaderText = "Duration";
            this.col_duration.MinimumWidth = 6;
            this.col_duration.Name = "col_duration";
            this.col_duration.ReadOnly = true;
            this.col_duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_duration.Width = 84;
            // 
            // col_btn_add_to_cart
            // 
            this.col_btn_add_to_cart.HeaderText = "Action";
            this.col_btn_add_to_cart.MinimumWidth = 6;
            this.col_btn_add_to_cart.Name = "col_btn_add_to_cart";
            this.col_btn_add_to_cart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_add_to_cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_add_to_cart.Width = 125;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(29, 505);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(917, 48);
            this.materialTabSelector1.TabIndex = 32;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageService);
            this.materialTabControl1.Controls.Add(this.tabPageProduct);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(29, 559);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(917, 507);
            this.materialTabControl1.TabIndex = 33;
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.dgv_services);
            this.tabPageService.Location = new System.Drawing.Point(4, 25);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(909, 478);
            this.tabPageService.TabIndex = 0;
            this.tabPageService.Text = "SERVICES";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.dgv_appointment_product);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(909, 478);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "PRODUCTS";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToResizeColumns = false;
            this.dgv_cart.AllowUserToResizeRows = false;
            this.dgv_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_item_invoice_id,
            this.col_item_product_id,
            this.col_item_service_id,
            this.col_item,
            this.col_item_type,
            this.col_item_price,
            this.col_item_duration,
            this.col_item_qty,
            this.col_btn_remove});
            this.dgv_cart.EnableHeadersVisualStyles = false;
            this.dgv_cart.Location = new System.Drawing.Point(1003, 107);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidth = 51;
            this.dgv_cart.RowTemplate.Height = 24;
            this.dgv_cart.Size = new System.Drawing.Size(901, 383);
            this.dgv_cart.TabIndex = 34;
            this.dgv_cart.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_cart_CellBeginEdit);
            this.dgv_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cart_CellContentClick);
            // 
            // col_app_product_id
            // 
            this.col_app_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_app_product_id.HeaderText = "Product_ID";
            this.col_app_product_id.MinimumWidth = 6;
            this.col_app_product_id.Name = "col_app_product_id";
            this.col_app_product_id.Visible = false;
            this.col_app_product_id.Width = 77;
            // 
            // col_app_product_name
            // 
            this.col_app_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_app_product_name.HeaderText = "Name";
            this.col_app_product_name.MinimumWidth = 6;
            this.col_app_product_name.Name = "col_app_product_name";
            this.col_app_product_name.ReadOnly = true;
            // 
            // col_app_product_brand
            // 
            this.col_app_product_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_app_product_brand.HeaderText = "Brand";
            this.col_app_product_brand.MinimumWidth = 6;
            this.col_app_product_brand.Name = "col_app_product_brand";
            this.col_app_product_brand.ReadOnly = true;
            this.col_app_product_brand.Width = 70;
            // 
            // col_app_product_unit_type
            // 
            this.col_app_product_unit_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_app_product_unit_type.HeaderText = "Unit of Measure";
            this.col_app_product_unit_type.MinimumWidth = 6;
            this.col_app_product_unit_type.Name = "col_app_product_unit_type";
            this.col_app_product_unit_type.ReadOnly = true;
            this.col_app_product_unit_type.Width = 117;
            // 
            // col_app_product_price
            // 
            this.col_app_product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_app_product_price.HeaderText = "Price";
            this.col_app_product_price.MinimumWidth = 6;
            this.col_app_product_price.Name = "col_app_product_price";
            this.col_app_product_price.ReadOnly = true;
            this.col_app_product_price.Width = 65;
            // 
            // col_app_btn_product_add
            // 
            this.col_app_btn_product_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_app_btn_product_add.HeaderText = "Action";
            this.col_app_btn_product_add.MinimumWidth = 6;
            this.col_app_btn_product_add.Name = "col_app_btn_product_add";
            this.col_app_btn_product_add.ReadOnly = true;
            this.col_app_btn_product_add.Width = 71;
            // 
            // col_item_invoice_id
            // 
            this.col_item_invoice_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_invoice_id.HeaderText = "invoice_id";
            this.col_item_invoice_id.MinimumWidth = 6;
            this.col_item_invoice_id.Name = "col_item_invoice_id";
            this.col_item_invoice_id.Visible = false;
            this.col_item_invoice_id.Width = 72;
            // 
            // col_item_product_id
            // 
            this.col_item_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_product_id.HeaderText = "product_id";
            this.col_item_product_id.MinimumWidth = 6;
            this.col_item_product_id.Name = "col_item_product_id";
            this.col_item_product_id.Visible = false;
            this.col_item_product_id.Width = 74;
            // 
            // col_item_service_id
            // 
            this.col_item_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_service_id.HeaderText = "service_id";
            this.col_item_service_id.MinimumWidth = 6;
            this.col_item_service_id.Name = "col_item_service_id";
            this.col_item_service_id.Visible = false;
            this.col_item_service_id.Width = 73;
            // 
            // col_item
            // 
            this.col_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_item.HeaderText = "Item";
            this.col_item.MinimumWidth = 6;
            this.col_item.Name = "col_item";
            this.col_item.ReadOnly = true;
            // 
            // col_item_type
            // 
            this.col_item_type.HeaderText = "Item Type";
            this.col_item_type.MinimumWidth = 6;
            this.col_item_type.Name = "col_item_type";
            this.col_item_type.Width = 125;
            // 
            // col_item_price
            // 
            this.col_item_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_price.HeaderText = "Price";
            this.col_item_price.MinimumWidth = 6;
            this.col_item_price.Name = "col_item_price";
            this.col_item_price.ReadOnly = true;
            this.col_item_price.Width = 65;
            // 
            // col_item_duration
            // 
            this.col_item_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_duration.HeaderText = "Duration";
            this.col_item_duration.MinimumWidth = 6;
            this.col_item_duration.Name = "col_item_duration";
            this.col_item_duration.ReadOnly = true;
            this.col_item_duration.Width = 84;
            // 
            // col_item_qty
            // 
            this.col_item_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_qty.HeaderText = "Qty";
            this.col_item_qty.MinimumWidth = 6;
            this.col_item_qty.Name = "col_item_qty";
            this.col_item_qty.Width = 54;
            // 
            // col_btn_remove
            // 
            this.col_btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_btn_remove.HeaderText = "Action";
            this.col_btn_remove.MinimumWidth = 6;
            this.col_btn_remove.Name = "col_btn_remove";
            this.col_btn_remove.ReadOnly = true;
            this.col_btn_remove.Width = 48;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.dgv_cart);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BOOKING INFORMATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment_product)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageService.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_FullName;
        private MaterialSkin.Controls.MaterialTextBox txt_Email;
        private MaterialSkin.Controls.MaterialTextBox txt_Contact;
        private System.Windows.Forms.DateTimePicker cmb_Date;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private System.Windows.Forms.FlowLayoutPanel time_slot_panel;
        private MaterialSkin.Controls.MaterialComboBox cmb_stylist;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialButton btn_register_customer;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_appointment_product;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialRadioButton rad_exists;
        private MaterialSkin.Controls.MaterialRadioButton rad_guest;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.DataGridView dgv_services;
        private System.Windows.Forms.TabPage tabPageProduct;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_add_to_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_product_unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_app_btn_product_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_qty;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_remove;
    }
}