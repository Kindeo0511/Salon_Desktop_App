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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_prefix = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_subcategory = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_services = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_stylist = new MaterialSkin.Controls.MaterialComboBox();
            this.time_slot_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_save_and_add_another = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_duration = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.dtp_date);
            this.materialCard1.Controls.Add(this.cmb_stylist);
            this.materialCard1.Controls.Add(this.txt_price);
            this.materialCard1.Controls.Add(this.txt_duration);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_save_and_add_another);
            this.materialCard1.Controls.Add(this.btn_save);
            this.materialCard1.Controls.Add(this.time_slot_panel);
            this.materialCard1.Controls.Add(this.cmb_subcategory);
            this.materialCard1.Controls.Add(this.cmb_services);
            this.materialCard1.Controls.Add(this.lbl_prefix);
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
            // lbl_prefix
            // 
            this.lbl_prefix.AutoSize = true;
            this.lbl_prefix.Depth = 0;
            this.lbl_prefix.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_prefix.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_prefix.Location = new System.Drawing.Point(284, 40);
            this.lbl_prefix.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(126, 29);
            this.lbl_prefix.TabIndex = 0;
            this.lbl_prefix.Text = "prefix_code";
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
            this.cmb_subcategory.Location = new System.Drawing.Point(484, 201);
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
            this.cmb_services.Location = new System.Drawing.Point(30, 201);
            this.cmb_services.MaxDropDownItems = 4;
            this.cmb_services.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(350, 49);
            this.cmb_services.StartIndex = 0;
            this.cmb_services.TabIndex = 20;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
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
            this.cmb_stylist.Location = new System.Drawing.Point(30, 457);
            this.cmb_stylist.MaxDropDownItems = 4;
            this.cmb_stylist.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_stylist.Name = "cmb_stylist";
            this.cmb_stylist.Size = new System.Drawing.Size(817, 49);
            this.cmb_stylist.StartIndex = 0;
            this.cmb_stylist.TabIndex = 22;
            this.cmb_stylist.SelectedIndexChanged += new System.EventHandler(this.cmb_stylist_SelectedIndexChanged);
            // 
            // time_slot_panel
            // 
            this.time_slot_panel.Location = new System.Drawing.Point(36, 669);
            this.time_slot_panel.Name = "time_slot_panel";
            this.time_slot_panel.Size = new System.Drawing.Size(800, 200);
            this.time_slot_panel.TabIndex = 25;
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(43, 892);
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
            // btn_save_and_add_another
            // 
            this.btn_save_and_add_another.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_and_add_another.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save_and_add_another.Depth = 0;
            this.btn_save_and_add_another.HighEmphasis = true;
            this.btn_save_and_add_another.Icon = null;
            this.btn_save_and_add_another.Location = new System.Drawing.Point(370, 892);
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
            this.btn_save_and_add_another.Click += new System.EventHandler(this.btn_save_and_add_another_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(736, 892);
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
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(38, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 29);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Walk-In Code:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(38, 135);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(186, 29);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Service Selection";
            // 
            // txt_duration
            // 
            this.txt_duration.AnimateReadOnly = true;
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_duration.Depth = 0;
            this.txt_duration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_duration.Hint = "Duration (mins)";
            this.txt_duration.LeadingIcon = null;
            this.txt_duration.Location = new System.Drawing.Point(30, 308);
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
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = true;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(484, 308);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(38, 395);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(199, 29);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Stylist Assignment";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(38, 571);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(205, 29);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = " Appointment Time";
            // 
            // dtp_date
            // 
            this.dtp_date.Enabled = false;
            this.dtp_date.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(36, 623);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(350, 32);
            this.dtp_date.TabIndex = 35;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(43, 892);
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
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Walk_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lbl_prefix;
        private MaterialSkin.Controls.MaterialComboBox cmb_subcategory;
        private MaterialSkin.Controls.MaterialComboBox cmb_services;
        private MaterialSkin.Controls.MaterialComboBox cmb_stylist;
        private System.Windows.Forms.FlowLayoutPanel time_slot_panel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_save_and_add_another;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialTextBox txt_duration;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private MaterialSkin.Controls.MaterialButton btn_update;
    }
}