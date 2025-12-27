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
            this.btn_search = new MaterialSkin.Controls.MaterialButton();
            this.btn_register_customer = new MaterialSkin.Controls.MaterialButton();
            this.txt_FullName = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.rad_exists = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_guest = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_Date = new System.Windows.Forms.DateTimePicker();
            this.time_slot_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmb_stylist = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_service = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fl_service = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.materialLabel2.Location = new System.Drawing.Point(17, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Client";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.btn_search);
            this.materialCard1.Controls.Add(this.btn_register_customer);
            this.materialCard1.Controls.Add(this.txt_FullName);
            this.materialCard1.Controls.Add(this.lbl_ID);
            this.materialCard1.Controls.Add(this.rad_exists);
            this.materialCard1.Controls.Add(this.rad_guest);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1942, 137);
            this.materialCard1.TabIndex = 38;
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
            this.btn_search.Location = new System.Drawing.Point(1381, 70);
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
            // btn_register_customer
            // 
            this.btn_register_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register_customer.AutoSize = false;
            this.btn_register_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_register_customer.Depth = 0;
            this.btn_register_customer.HighEmphasis = true;
            this.btn_register_customer.Icon = null;
            this.btn_register_customer.Location = new System.Drawing.Point(1697, 70);
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
            // txt_FullName
            // 
            this.txt_FullName.AnimateReadOnly = true;
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FullName.Depth = 0;
            this.txt_FullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_FullName.Hint = "Full Name";
            this.txt_FullName.LeadingIcon = null;
            this.txt_FullName.Location = new System.Drawing.Point(17, 70);
            this.txt_FullName.MaxLength = 50;
            this.txt_FullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_FullName.Multiline = false;
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.ReadOnly = true;
            this.txt_FullName.Size = new System.Drawing.Size(400, 50);
            this.txt_FullName.TabIndex = 27;
            this.txt_FullName.Text = "";
            this.txt_FullName.TrailingIcon = null;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(104, 43);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 19);
            this.lbl_ID.TabIndex = 28;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // rad_exists
            // 
            this.rad_exists.AutoSize = true;
            this.rad_exists.Depth = 0;
            this.rad_exists.Location = new System.Drawing.Point(736, 73);
            this.rad_exists.Margin = new System.Windows.Forms.Padding(0);
            this.rad_exists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_exists.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_exists.Name = "rad_exists";
            this.rad_exists.Ripple = true;
            this.rad_exists.Size = new System.Drawing.Size(101, 37);
            this.rad_exists.TabIndex = 26;
            this.rad_exists.TabStop = true;
            this.rad_exists.Text = "MEMBER";
            this.rad_exists.UseVisualStyleBackColor = true;
            this.rad_exists.CheckedChanged += new System.EventHandler(this.rad_exists_CheckedChanged_1);
            // 
            // rad_guest
            // 
            this.rad_guest.AutoSize = true;
            this.rad_guest.Depth = 0;
            this.rad_guest.Location = new System.Drawing.Point(543, 73);
            this.rad_guest.Margin = new System.Windows.Forms.Padding(0);
            this.rad_guest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_guest.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_guest.Name = "rad_guest";
            this.rad_guest.Ripple = true;
            this.rad_guest.Size = new System.Drawing.Size(105, 37);
            this.rad_guest.TabIndex = 25;
            this.rad_guest.TabStop = true;
            this.rad_guest.Text = "WALK - IN";
            this.rad_guest.UseVisualStyleBackColor = true;
            this.rad_guest.CheckedChanged += new System.EventHandler(this.rad_guest_CheckedChanged_1);
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
            // 
            // cmb_Date
            // 
            this.cmb_Date.Location = new System.Drawing.Point(66, 43);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(500, 22);
            this.cmb_Date.TabIndex = 5;
            // 
            // time_slot_panel
            // 
            this.time_slot_panel.Location = new System.Drawing.Point(66, 93);
            this.time_slot_panel.Name = "time_slot_panel";
            this.time_slot_panel.Size = new System.Drawing.Size(783, 219);
            this.time_slot_panel.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.materialLabel1);
            this.groupBox5.Controls.Add(this.cmb_Date);
            this.groupBox5.Controls.Add(this.time_slot_panel);
            this.groupBox5.Location = new System.Drawing.Point(898, 511);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(917, 333);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATE & TIME";
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
            this.cmb_stylist.Size = new System.Drawing.Size(855, 49);
            this.cmb_stylist.StartIndex = 0;
            this.cmb_stylist.TabIndex = 17;
            this.cmb_stylist.SelectedIndexChanged += new System.EventHandler(this.cmb_stylist_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_stylist);
            this.groupBox2.Location = new System.Drawing.Point(898, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 119);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STYLIST";
            // 
            // btn_add_service
            // 
            this.btn_add_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_service.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_service.Depth = 0;
            this.btn_add_service.HighEmphasis = true;
            this.btn_add_service.Icon = null;
            this.btn_add_service.Location = new System.Drawing.Point(14, 16);
            this.btn_add_service.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_service.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_service.Size = new System.Drawing.Size(112, 36);
            this.btn_add_service.TabIndex = 1;
            this.btn_add_service.Text = "Add Service";
            this.btn_add_service.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_service.UseAccentColor = false;
            this.btn_add_service.UseVisualStyleBackColor = true;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_add_service);
            this.panel1.Controls.Add(this.fl_service);
            this.panel1.Location = new System.Drawing.Point(20, 250);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 330);
            this.panel1.TabIndex = 44;
            // 
            // fl_service
            // 
            this.fl_service.AutoScroll = true;
            this.fl_service.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fl_service.Location = new System.Drawing.Point(10, 61);
            this.fl_service.Name = "fl_service";
            this.fl_service.Size = new System.Drawing.Size(780, 259);
            this.fl_service.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(1424, 967);
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
            this.btn_update.Location = new System.Drawing.Point(1234, 967);
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
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1670, 967);
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
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
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
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialButton btn_register_customer;
        private MaterialSkin.Controls.MaterialTextBox txt_FullName;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialRadioButton rad_exists;
        private MaterialSkin.Controls.MaterialRadioButton rad_guest;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker cmb_Date;
        private System.Windows.Forms.FlowLayoutPanel time_slot_panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialComboBox cmb_stylist;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_add_service;
        private System.Windows.Forms.FlowLayoutPanel fl_service;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
    }
}