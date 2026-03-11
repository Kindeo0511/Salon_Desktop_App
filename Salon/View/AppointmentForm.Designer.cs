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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_service_id = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_time_slot = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_service_selected = new System.Windows.Forms.DataGridView();
            this.btn_add_service = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_stylist = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_duration = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_subcategory = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_services = new MaterialSkin.Controls.MaterialComboBox();
            this.dgv_available_services = new System.Windows.Forms.DataGridView();
            this.col_service_id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_nam_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_category_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cmb_stylist = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_price_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remove_2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_exists = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_search = new MaterialSkin.Controls.MaterialButton();
            this.rad_guest = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.btn_register_customer = new MaterialSkin.Controls.MaterialButton();
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
            this.col_btn_remove = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available_services)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(46, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Client";
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_service_id);
            this.materialCard1.Controls.Add(this.cmb_time_slot);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_confirm);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.dgv_service_selected);
            this.materialCard1.Controls.Add(this.btn_add_service);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.cmb_stylist);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txt_price);
            this.materialCard1.Controls.Add(this.txt_duration);
            this.materialCard1.Controls.Add(this.cmb_subcategory);
            this.materialCard1.Controls.Add(this.cmb_services);
            this.materialCard1.Controls.Add(this.dgv_available_services);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(50, 14, 14, 25);
            this.materialCard1.Size = new System.Drawing.Size(1200, 1035);
            this.materialCard1.TabIndex = 38;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // lbl_service_id
            // 
            this.lbl_service_id.AutoSize = true;
            this.lbl_service_id.Depth = 0;
            this.lbl_service_id.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_service_id.Location = new System.Drawing.Point(79, 425);
            this.lbl_service_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_service_id.Name = "lbl_service_id";
            this.lbl_service_id.Size = new System.Drawing.Size(107, 19);
            this.lbl_service_id.TabIndex = 66;
            this.lbl_service_id.Text = "materialLabel8";
            this.lbl_service_id.Visible = false;
            // 
            // cmb_time_slot
            // 
            this.cmb_time_slot.AutoResize = false;
            this.cmb_time_slot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_time_slot.Depth = 0;
            this.cmb_time_slot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_time_slot.DropDownHeight = 174;
            this.cmb_time_slot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_time_slot.DropDownWidth = 121;
            this.cmb_time_slot.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_time_slot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_time_slot.FormattingEnabled = true;
            this.cmb_time_slot.Hint = "Select Time Slot";
            this.cmb_time_slot.IntegralHeight = false;
            this.cmb_time_slot.ItemHeight = 43;
            this.cmb_time_slot.Location = new System.Drawing.Point(82, 820);
            this.cmb_time_slot.MaxDropDownItems = 4;
            this.cmb_time_slot.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_time_slot.Name = "cmb_time_slot";
            this.cmb_time_slot.Size = new System.Drawing.Size(935, 49);
            this.cmb_time_slot.StartIndex = 0;
            this.cmb_time_slot.TabIndex = 65;
            this.cmb_time_slot.SelectedIndexChanged += new System.EventHandler(this.cmb_time_slot_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(982, 1341);
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
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.DrawShadows = false;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(678, 1341);
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
            this.btn_update.Location = new System.Drawing.Point(678, 1341);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(90, 777);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 24);
            this.materialLabel4.TabIndex = 64;
            this.materialLabel4.Text = "Time:";
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
            this.col_btn_remove});
            this.dgv_service_selected.Location = new System.Drawing.Point(78, 1018);
            this.dgv_service_selected.Name = "dgv_service_selected";
            this.dgv_service_selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service_selected.RowHeadersVisible = false;
            this.dgv_service_selected.RowHeadersWidth = 51;
            this.dgv_service_selected.RowTemplate.Height = 24;
            this.dgv_service_selected.Size = new System.Drawing.Size(1022, 219);
            this.dgv_service_selected.TabIndex = 62;
            this.dgv_service_selected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_selected_CellClick);
            // 
            // btn_add_service
            // 
            this.btn_add_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_service.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_service.Depth = 0;
            this.btn_add_service.HighEmphasis = true;
            this.btn_add_service.Icon = null;
            this.btn_add_service.Location = new System.Drawing.Point(86, 938);
            this.btn_add_service.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_service.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_service.Size = new System.Drawing.Size(168, 36);
            this.btn_add_service.TabIndex = 61;
            this.btn_add_service.Text = "Add Service to List ";
            this.btn_add_service.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_service.UseAccentColor = false;
            this.btn_add_service.UseVisualStyleBackColor = true;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(89, 651);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(199, 29);
            this.materialLabel7.TabIndex = 60;
            this.materialLabel7.Text = "Stylist Assignment";
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
            this.cmb_stylist.Location = new System.Drawing.Point(82, 699);
            this.cmb_stylist.MaxDropDownItems = 4;
            this.cmb_stylist.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_stylist.Name = "cmb_stylist";
            this.cmb_stylist.Size = new System.Drawing.Size(935, 49);
            this.cmb_stylist.StartIndex = 0;
            this.cmb_stylist.TabIndex = 59;
            this.cmb_stylist.SelectedIndexChanged += new System.EventHandler(this.cmb_stylist_SelectedIndexChanged);
            this.cmb_stylist.SelectedValueChanged += new System.EventHandler(this.cmb_stylist_SelectedValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(66, 381);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(186, 29);
            this.materialLabel6.TabIndex = 56;
            this.materialLabel6.Text = "Service Selection";
            // 
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = true;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(667, 554);
            this.txt_price.MaxLength = 50;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(350, 50);
            this.txt_price.TabIndex = 58;
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
            this.txt_duration.Location = new System.Drawing.Point(82, 554);
            this.txt_duration.MaxLength = 50;
            this.txt_duration.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_duration.Multiline = false;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.ReadOnly = true;
            this.txt_duration.Size = new System.Drawing.Size(350, 50);
            this.txt_duration.TabIndex = 57;
            this.txt_duration.Text = "";
            this.txt_duration.TrailingIcon = null;
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
            this.cmb_subcategory.Location = new System.Drawing.Point(569, 395);
            this.cmb_subcategory.MaxDropDownItems = 4;
            this.cmb_subcategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_subcategory.Name = "cmb_subcategory";
            this.cmb_subcategory.Size = new System.Drawing.Size(350, 49);
            this.cmb_subcategory.StartIndex = 0;
            this.cmb_subcategory.TabIndex = 55;
            this.cmb_subcategory.Visible = false;
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
            this.cmb_services.Location = new System.Drawing.Point(82, 447);
            this.cmb_services.MaxDropDownItems = 4;
            this.cmb_services.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(935, 49);
            this.cmb_services.StartIndex = 0;
            this.cmb_services.TabIndex = 54;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
            this.cmb_services.SelectedValueChanged += new System.EventHandler(this.cmb_services_SelectedValueChanged);
            // 
            // dgv_available_services
            // 
            this.dgv_available_services.AllowUserToAddRows = false;
            this.dgv_available_services.AllowUserToDeleteRows = false;
            this.dgv_available_services.AllowUserToResizeColumns = false;
            this.dgv_available_services.AllowUserToResizeRows = false;
            this.dgv_available_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_available_services.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_available_services.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_available_services.ColumnHeadersHeight = 50;
            this.dgv_available_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_available_services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id_2,
            this.col_service_nam_2,
            this.col_service_category_2,
            this.col_cmb_stylist,
            this.col_price_2,
            this.col_qty_2,
            this.col_duration_2,
            this.col_remove_2});
            this.dgv_available_services.Location = new System.Drawing.Point(1013, 395);
            this.dgv_available_services.Name = "dgv_available_services";
            this.dgv_available_services.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_available_services.RowHeadersVisible = false;
            this.dgv_available_services.RowHeadersWidth = 51;
            this.dgv_available_services.RowTemplate.Height = 24;
            this.dgv_available_services.Size = new System.Drawing.Size(67, 42);
            this.dgv_available_services.TabIndex = 45;
            this.dgv_available_services.Visible = false;
            this.dgv_available_services.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_available_services_CellClick);
            this.dgv_available_services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_available_services_CellContentClick);
            this.dgv_available_services.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_available_services_CellValueChanged);
            this.dgv_available_services.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_available_services_CurrentCellDirtyStateChanged);
            this.dgv_available_services.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_available_services_DataError);
            // 
            // col_service_id_2
            // 
            this.col_service_id_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id_2.HeaderText = "service_id";
            this.col_service_id_2.MinimumWidth = 6;
            this.col_service_id_2.Name = "col_service_id_2";
            this.col_service_id_2.Visible = false;
            this.col_service_id_2.Width = 98;
            // 
            // col_service_nam_2
            // 
            this.col_service_nam_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_nam_2.HeaderText = "Service Name";
            this.col_service_nam_2.MinimumWidth = 6;
            this.col_service_nam_2.Name = "col_service_nam_2";
            this.col_service_nam_2.ReadOnly = true;
            // 
            // col_service_category_2
            // 
            this.col_service_category_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_category_2.HeaderText = "Category";
            this.col_service_category_2.MinimumWidth = 6;
            this.col_service_category_2.Name = "col_service_category_2";
            this.col_service_category_2.ReadOnly = true;
            // 
            // col_cmb_stylist
            // 
            this.col_cmb_stylist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_cmb_stylist.HeaderText = "Stylist";
            this.col_cmb_stylist.MinimumWidth = 6;
            this.col_cmb_stylist.Name = "col_cmb_stylist";
            this.col_cmb_stylist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_cmb_stylist.Sorted = true;
            this.col_cmb_stylist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_price_2
            // 
            this.col_price_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price_2.HeaderText = "Price";
            this.col_price_2.MinimumWidth = 6;
            this.col_price_2.Name = "col_price_2";
            this.col_price_2.ReadOnly = true;
            this.col_price_2.Width = 67;
            // 
            // col_qty_2
            // 
            this.col_qty_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_2.HeaderText = "Qty";
            this.col_qty_2.MinimumWidth = 6;
            this.col_qty_2.Name = "col_qty_2";
            this.col_qty_2.Width = 56;
            // 
            // col_duration_2
            // 
            this.col_duration_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_duration_2.HeaderText = "Duration";
            this.col_duration_2.MinimumWidth = 6;
            this.col_duration_2.Name = "col_duration_2";
            this.col_duration_2.ReadOnly = true;
            this.col_duration_2.Width = 86;
            // 
            // col_remove_2
            // 
            this.col_remove_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_remove_2.HeaderText = "Remove";
            this.col_remove_2.MinimumWidth = 6;
            this.col_remove_2.Name = "col_remove_2";
            this.col_remove_2.Width = 65;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(82, 980);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(190, 24);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "SELECTED SERVICES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Date);
            this.panel1.Controls.Add(this.txt_FullName);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialProgressBar1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.rad_exists);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.rad_guest);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Controls.Add(this.btn_register_customer);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(53, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 340);
            this.panel1.TabIndex = 52;
            // 
            // cmb_Date
            // 
            this.cmb_Date.Location = new System.Drawing.Point(410, 115);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(500, 22);
            this.cmb_Date.TabIndex = 5;
            this.cmb_Date.ValueChanged += new System.EventHandler(this.cmb_Date_ValueChanged);
            // 
            // txt_FullName
            // 
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FullName.Location = new System.Drawing.Point(410, 50);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.ReadOnly = true;
            this.txt_FullName.Size = new System.Drawing.Size(500, 22);
            this.txt_FullName.TabIndex = 50;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(46, 171);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 24);
            this.materialLabel5.TabIndex = 51;
            this.materialLabel5.Text = "Client Type:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialProgressBar1.Location = new System.Drawing.Point(0, 335);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(1027, 5);
            this.materialProgressBar1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(46, 114);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Date:";
            // 
            // rad_exists
            // 
            this.rad_exists.AutoSize = true;
            this.rad_exists.Depth = 0;
            this.rad_exists.Location = new System.Drawing.Point(653, 172);
            this.rad_exists.Margin = new System.Windows.Forms.Padding(0);
            this.rad_exists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_exists.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_exists.Name = "rad_exists";
            this.rad_exists.Ripple = true;
            this.rad_exists.Size = new System.Drawing.Size(153, 37);
            this.rad_exists.TabIndex = 26;
            this.rad_exists.TabStop = true;
            this.rad_exists.Text = "Registered Client";
            this.rad_exists.UseVisualStyleBackColor = true;
            this.rad_exists.CheckedChanged += new System.EventHandler(this.rad_exists_CheckedChanged_1);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = false;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_search.Depth = 0;
            this.btn_search.HighEmphasis = true;
            this.btn_search.Icon = ((System.Drawing.Image)(resources.GetObject("btn_search.Icon")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(410, 259);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_search.Size = new System.Drawing.Size(200, 40);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = " search member";
            this.btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_search.UseAccentColor = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rad_guest
            // 
            this.rad_guest.AutoSize = true;
            this.rad_guest.Depth = 0;
            this.rad_guest.Location = new System.Drawing.Point(410, 172);
            this.rad_guest.Margin = new System.Windows.Forms.Padding(0);
            this.rad_guest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_guest.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_guest.Name = "rad_guest";
            this.rad_guest.Ripple = true;
            this.rad_guest.Size = new System.Drawing.Size(171, 37);
            this.rad_guest.TabIndex = 25;
            this.rad_guest.TabStop = true;
            this.rad_guest.Text = "Guest Appointment";
            this.rad_guest.UseVisualStyleBackColor = true;
            this.rad_guest.CheckedChanged += new System.EventHandler(this.rad_guest_CheckedChanged_1);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(26, 11);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 19);
            this.lbl_ID.TabIndex = 28;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
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
            this.btn_register_customer.Location = new System.Drawing.Point(710, 259);
            this.btn_register_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register_customer.Name = "btn_register_customer";
            this.btn_register_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_register_customer.Size = new System.Drawing.Size(200, 40);
            this.btn_register_customer.TabIndex = 30;
            this.btn_register_customer.Text = "register Member";
            this.btn_register_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register_customer.UseAccentColor = false;
            this.btn_register_customer.UseVisualStyleBackColor = true;
            this.btn_register_customer.Click += new System.EventHandler(this.btn_register_customer_Click);
            // 
            // col_appointment_service_id
            // 
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
            // col_btn_remove
            // 
            this.col_btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_btn_remove.HeaderText = "Remove";
            this.col_btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("col_btn_remove.Image")));
            this.col_btn_remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_btn_remove.MinimumWidth = 6;
            this.col_btn_remove.Name = "col_btn_remove";
            this.col_btn_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_remove.Width = 88;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 1102);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BOOKING INFORMATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.Shown += new System.EventHandler(this.AppointmentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available_services)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialButton btn_register_customer;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialRadioButton rad_exists;
        private MaterialSkin.Controls.MaterialRadioButton rad_guest;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker cmb_Date;
        private System.Windows.Forms.DataGridView dgv_available_services;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txt_FullName;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialTextBox txt_duration;
        private MaterialSkin.Controls.MaterialComboBox cmb_subcategory;
        private MaterialSkin.Controls.MaterialComboBox cmb_services;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cmb_stylist;
        private MaterialSkin.Controls.MaterialButton btn_add_service;
        private System.Windows.Forms.DataGridView dgv_service_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_nam_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_category_2;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_cmb_stylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration_2;
        private System.Windows.Forms.DataGridViewButtonColumn col_remove_2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmb_time_slot;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialLabel lbl_service_id;
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
        private System.Windows.Forms.DataGridViewImageColumn col_btn_remove;
    }
}