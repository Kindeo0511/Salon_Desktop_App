namespace Salon.View
{
    partial class Walk_In_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Walk_In_Form));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.btn_search = new MaterialSkin.Controls.MaterialButton();
            this.btn_register_customer = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_exists = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_guest = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_add_service = new MaterialSkin.Controls.MaterialButton();
            this.dgv_service_selected = new System.Windows.Forms.DataGridView();
            this.col_appointment_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_mark_as_waiting = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_stylist = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_duration = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save_and_add_another = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.cmb_subcategory = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_services = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_prefix = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_prefix);
            this.materialCard1.Controls.Add(this.lbl_ID);
            this.materialCard1.Controls.Add(this.btn_search);
            this.materialCard1.Controls.Add(this.btn_register_customer);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.rad_exists);
            this.materialCard1.Controls.Add(this.rad_guest);
            this.materialCard1.Controls.Add(this.btn_add_service);
            this.materialCard1.Controls.Add(this.dgv_service_selected);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.cmb_stylist);
            this.materialCard1.Controls.Add(this.txt_price);
            this.materialCard1.Controls.Add(this.txt_duration);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_save_and_add_another);
            this.materialCard1.Controls.Add(this.btn_save);
            this.materialCard1.Controls.Add(this.cmb_subcategory);
            this.materialCard1.Controls.Add(this.cmb_services);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(15, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(885, 720);
            this.materialCard1.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(40, 30);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(10, 19);
            this.lbl_ID.TabIndex = 57;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = false;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_search.Depth = 0;
            this.btn_search.Enabled = false;
            this.btn_search.HighEmphasis = true;
            this.btn_search.Icon = ((System.Drawing.Image)(resources.GetObject("btn_search.Icon")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(270, 231);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_search.Size = new System.Drawing.Size(200, 40);
            this.btn_search.TabIndex = 55;
            this.btn_search.Text = " search member";
            this.btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_search.UseAccentColor = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_register_customer
            // 
            this.btn_register_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register_customer.AutoSize = false;
            this.btn_register_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_register_customer.Depth = 0;
            this.btn_register_customer.HighEmphasis = true;
            this.btn_register_customer.Icon = null;
            this.btn_register_customer.Location = new System.Drawing.Point(570, 231);
            this.btn_register_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register_customer.Name = "btn_register_customer";
            this.btn_register_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_register_customer.Size = new System.Drawing.Size(200, 40);
            this.btn_register_customer.TabIndex = 56;
            this.btn_register_customer.Text = "register Member";
            this.btn_register_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register_customer.UseAccentColor = false;
            this.btn_register_customer.UseVisualStyleBackColor = true;
            this.btn_register_customer.Click += new System.EventHandler(this.btn_register_customer_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(39, 129);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 24);
            this.materialLabel5.TabIndex = 54;
            this.materialLabel5.Text = "Client Type:";
            // 
            // rad_exists
            // 
            this.rad_exists.AutoSize = true;
            this.rad_exists.Depth = 0;
            this.rad_exists.Location = new System.Drawing.Point(521, 129);
            this.rad_exists.Margin = new System.Windows.Forms.Padding(0);
            this.rad_exists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_exists.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_exists.Name = "rad_exists";
            this.rad_exists.Ripple = true;
            this.rad_exists.Size = new System.Drawing.Size(101, 37);
            this.rad_exists.TabIndex = 53;
            this.rad_exists.TabStop = true;
            this.rad_exists.Text = "MEMBER";
            this.rad_exists.UseVisualStyleBackColor = true;
            this.rad_exists.CheckedChanged += new System.EventHandler(this.rad_exists_CheckedChanged);
            // 
            // rad_guest
            // 
            this.rad_guest.AutoSize = true;
            this.rad_guest.Depth = 0;
            this.rad_guest.Location = new System.Drawing.Point(282, 129);
            this.rad_guest.Margin = new System.Windows.Forms.Padding(0);
            this.rad_guest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_guest.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_guest.Name = "rad_guest";
            this.rad_guest.Ripple = true;
            this.rad_guest.Size = new System.Drawing.Size(85, 37);
            this.rad_guest.TabIndex = 52;
            this.rad_guest.TabStop = true;
            this.rad_guest.Text = "GUEST";
            this.rad_guest.UseVisualStyleBackColor = true;
            this.rad_guest.CheckedChanged += new System.EventHandler(this.rad_guest_CheckedChanged);
            // 
            // btn_add_service
            // 
            this.btn_add_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_service.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_service.Depth = 0;
            this.btn_add_service.HighEmphasis = true;
            this.btn_add_service.Icon = null;
            this.btn_add_service.Location = new System.Drawing.Point(30, 778);
            this.btn_add_service.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_service.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_service.Size = new System.Drawing.Size(168, 36);
            this.btn_add_service.TabIndex = 38;
            this.btn_add_service.Text = "Add Service to List ";
            this.btn_add_service.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_service.UseAccentColor = false;
            this.btn_add_service.UseVisualStyleBackColor = true;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click_1);
            // 
            // dgv_service_selected
            // 
            this.dgv_service_selected.AllowUserToAddRows = false;
            this.dgv_service_selected.AllowUserToDeleteRows = false;
            this.dgv_service_selected.AllowUserToResizeColumns = false;
            this.dgv_service_selected.AllowUserToResizeRows = false;
            this.dgv_service_selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_service_selected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_service_selected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service_selected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_appointment_service_id,
            this.col_service_id,
            this.col_service_name,
            this.col_stylist_id,
            this.col_stylist,
            this.col_duration,
            this.col_price,
            this.col_start_time,
            this.col_end_time,
            this.col_status,
            this.btn_mark_as_waiting,
            this.btn_remove});
            this.dgv_service_selected.Location = new System.Drawing.Point(17, 844);
            this.dgv_service_selected.Name = "dgv_service_selected";
            this.dgv_service_selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service_selected.RowHeadersVisible = false;
            this.dgv_service_selected.RowHeadersWidth = 51;
            this.dgv_service_selected.RowTemplate.Height = 24;
            this.dgv_service_selected.Size = new System.Drawing.Size(817, 278);
            this.dgv_service_selected.TabIndex = 37;
            this.dgv_service_selected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellClick);
            this.dgv_service_selected.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_service_selected_CellFormatting);
            this.dgv_service_selected.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellValueChanged);
            this.dgv_service_selected.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_service_selected_CurrentCellDirtyStateChanged);
            // 
            // col_appointment_service_id
            // 
            this.col_appointment_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_appointment_service_id.HeaderText = "aps_id";
            this.col_appointment_service_id.MinimumWidth = 6;
            this.col_appointment_service_id.Name = "col_appointment_service_id";
            this.col_appointment_service_id.Visible = false;
            this.col_appointment_service_id.Width = 125;
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id.HeaderText = "service_id";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.Visible = false;
            this.col_service_id.Width = 125;
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
            this.col_stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // col_duration
            // 
            this.col_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_duration.HeaderText = "Duration";
            this.col_duration.MinimumWidth = 6;
            this.col_duration.Name = "col_duration";
            this.col_duration.Width = 86;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.Width = 67;
            // 
            // col_start_time
            // 
            this.col_start_time.HeaderText = "start_time";
            this.col_start_time.MinimumWidth = 6;
            this.col_start_time.Name = "col_start_time";
            this.col_start_time.Visible = false;
            this.col_start_time.Width = 125;
            // 
            // col_end_time
            // 
            this.col_end_time.HeaderText = "end_time";
            this.col_end_time.MinimumWidth = 6;
            this.col_end_time.Name = "col_end_time";
            this.col_end_time.Visible = false;
            this.col_end_time.Width = 125;
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
            // btn_mark_as_waiting
            // 
            this.btn_mark_as_waiting.HeaderText = "Mark Waiting";
            this.btn_mark_as_waiting.MinimumWidth = 6;
            this.btn_mark_as_waiting.Name = "btn_mark_as_waiting";
            this.btn_mark_as_waiting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_mark_as_waiting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_mark_as_waiting.Text = "Waiting";
            this.btn_mark_as_waiting.UseColumnTextForButtonValue = true;
            this.btn_mark_as_waiting.Width = 125;
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_remove.HeaderText = "Delete";
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_remove.MinimumWidth = 6;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Width = 53;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(30, 1178);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(25, 615);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(199, 29);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Stylist Assignment";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(25, 341);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(186, 29);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Service Selection";
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
            this.cmb_stylist.Location = new System.Drawing.Point(17, 647);
            this.cmb_stylist.MaxDropDownItems = 4;
            this.cmb_stylist.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_stylist.Name = "cmb_stylist";
            this.cmb_stylist.Size = new System.Drawing.Size(817, 49);
            this.cmb_stylist.StartIndex = 0;
            this.cmb_stylist.TabIndex = 22;
            this.cmb_stylist.SelectedIndexChanged += new System.EventHandler(this.cmb_stylist_SelectedIndexChanged);
            // 
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = true;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(471, 514);
            this.txt_price.MaxLength = 50;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(350, 50);
            this.txt_price.TabIndex = 32;
            this.txt_price.Text = "";
            this.txt_price.TrailingIcon = null;
            // 
            // txt_duration
            // 
            this.txt_duration.AnimateReadOnly = true;
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_duration.Depth = 0;
            this.txt_duration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_duration.Hint = "Duration (mins)";
            this.txt_duration.LeadingIcon = null;
            this.txt_duration.Location = new System.Drawing.Point(17, 514);
            this.txt_duration.MaxLength = 50;
            this.txt_duration.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_duration.Multiline = false;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.ReadOnly = true;
            this.txt_duration.Size = new System.Drawing.Size(350, 50);
            this.txt_duration.TabIndex = 31;
            this.txt_duration.Text = "";
            this.txt_duration.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(38, 49);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 29);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Walk-In Code:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(727, 1178);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save_and_add_another
            // 
            this.btn_save_and_add_another.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_and_add_another.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save_and_add_another.Depth = 0;
            this.btn_save_and_add_another.HighEmphasis = true;
            this.btn_save_and_add_another.Icon = null;
            this.btn_save_and_add_another.Location = new System.Drawing.Point(339, 1178);
            this.btn_save_and_add_another.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save_and_add_another.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save_and_add_another.Name = "btn_save_and_add_another";
            this.btn_save_and_add_another.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save_and_add_another.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_save_and_add_another.Size = new System.Drawing.Size(195, 36);
            this.btn_save_and_add_another.TabIndex = 27;
            this.btn_save_and_add_another.Text = "Save and Add Another";
            this.btn_save_and_add_another.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save_and_add_another.UseAccentColor = false;
            this.btn_save_and_add_another.UseVisualStyleBackColor = true;
            this.btn_save_and_add_another.Visible = false;
            this.btn_save_and_add_another.Click += new System.EventHandler(this.btn_save_and_add_another_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(30, 1178);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_subcategory
            // 
            this.cmb_subcategory.AutoResize = false;
            this.cmb_subcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_subcategory.Depth = 0;
            this.cmb_subcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_subcategory.DropDownHeight = 174;
            this.cmb_subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subcategory.DropDownWidth = 121;
            this.cmb_subcategory.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_subcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_subcategory.FormattingEnabled = true;
            this.cmb_subcategory.Hint = "Select Category";
            this.cmb_subcategory.IntegralHeight = false;
            this.cmb_subcategory.ItemHeight = 43;
            this.cmb_subcategory.Location = new System.Drawing.Point(471, 407);
            this.cmb_subcategory.MaxDropDownItems = 4;
            this.cmb_subcategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_subcategory.Name = "cmb_subcategory";
            this.cmb_subcategory.Size = new System.Drawing.Size(350, 49);
            this.cmb_subcategory.StartIndex = 0;
            this.cmb_subcategory.TabIndex = 21;
            this.cmb_subcategory.SelectedIndexChanged += new System.EventHandler(this.cmb_subcategory_SelectedIndexChanged);
            // 
            // cmb_services
            // 
            this.cmb_services.AutoResize = false;
            this.cmb_services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_services.Depth = 0;
            this.cmb_services.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_services.DropDownHeight = 174;
            this.cmb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_services.DropDownWidth = 121;
            this.cmb_services.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_services.FormattingEnabled = true;
            this.cmb_services.Hint = "Select Services";
            this.cmb_services.IntegralHeight = false;
            this.cmb_services.ItemHeight = 43;
            this.cmb_services.Location = new System.Drawing.Point(17, 407);
            this.cmb_services.MaxDropDownItems = 4;
            this.cmb_services.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(350, 49);
            this.cmb_services.StartIndex = 0;
            this.cmb_services.TabIndex = 20;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
            this.cmb_services.SelectedValueChanged += new System.EventHandler(this.cmb_services_SelectedValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_prefix
            // 
            this.lbl_prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_prefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prefix.Location = new System.Drawing.Point(282, 49);
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(340, 30);
            this.lbl_prefix.TabIndex = 58;
            // 
            // Walk_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Walk_In_Form";
            this.Padding = new System.Windows.Forms.Padding(15, 80, 0, 0);
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                            Walk-In Appointment Form ";
            this.Load += new System.EventHandler(this.Walk_In_Form_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cmb_subcategory;
        private MaterialSkin.Controls.MaterialComboBox cmb_services;
        private MaterialSkin.Controls.MaterialComboBox cmb_stylist;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_save_and_add_another;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialTextBox txt_duration;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private System.Windows.Forms.DataGridView dgv_service_selected;
        private MaterialSkin.Controls.MaterialButton btn_add_service;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton rad_exists;
        private MaterialSkin.Controls.MaterialRadioButton rad_guest;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialButton btn_register_customer;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_appointment_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_mark_as_waiting;
        private System.Windows.Forms.DataGridViewImageColumn btn_remove;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox lbl_prefix;
    }
}