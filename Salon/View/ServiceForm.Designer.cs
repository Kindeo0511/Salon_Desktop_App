namespace Salon.View
{
    partial class ServiceForm
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
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.txt_service_name = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_sub_category = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_status = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_duration = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(298, 377);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(77, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "update";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(542, 377);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(298, 377);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_service_name
            // 
            this.txt_service_name.AnimateReadOnly = false;
            this.txt_service_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_service_name.Depth = 0;
            this.txt_service_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_service_name.Hint = "First Name";
            this.txt_service_name.LeadingIcon = null;
            this.txt_service_name.Location = new System.Drawing.Point(87, 96);
            this.txt_service_name.MaxLength = 50;
            this.txt_service_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_service_name.Multiline = false;
            this.txt_service_name.Name = "txt_service_name";
            this.txt_service_name.Size = new System.Drawing.Size(212, 50);
            this.txt_service_name.TabIndex = 18;
            this.txt_service_name.Text = "";
            this.txt_service_name.TrailingIcon = null;
            // 
            // cmb_sub_category
            // 
            this.cmb_sub_category.AutoResize = false;
            this.cmb_sub_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_sub_category.Depth = 0;
            this.cmb_sub_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_sub_category.DropDownHeight = 174;
            this.cmb_sub_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sub_category.DropDownWidth = 121;
            this.cmb_sub_category.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_sub_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_sub_category.FormattingEnabled = true;
            this.cmb_sub_category.Hint = "Select Category";
            this.cmb_sub_category.IntegralHeight = false;
            this.cmb_sub_category.ItemHeight = 43;
            this.cmb_sub_category.Location = new System.Drawing.Point(87, 200);
            this.cmb_sub_category.MaxDropDownItems = 4;
            this.cmb_sub_category.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_sub_category.Name = "cmb_sub_category";
            this.cmb_sub_category.Size = new System.Drawing.Size(212, 49);
            this.cmb_sub_category.StartIndex = 0;
            this.cmb_sub_category.TabIndex = 26;
            // 
            // cmb_status
            // 
            this.cmb_status.AutoResize = false;
            this.cmb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_status.Depth = 0;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_status.DropDownHeight = 174;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.DropDownWidth = 121;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.IntegralHeight = false;
            this.cmb_status.ItemHeight = 43;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_status.Location = new System.Drawing.Point(407, 95);
            this.cmb_status.MaxDropDownItems = 4;
            this.cmb_status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(212, 49);
            this.cmb_status.StartIndex = 0;
            this.cmb_status.TabIndex = 27;
            // 
            // txt_duration
            // 
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duration.Location = new System.Drawing.Point(407, 227);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(212, 22);
            this.txt_duration.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(404, 200);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Duration: (mins)";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.cmb_sub_category);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_service_name);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox txt_service_name;
        private MaterialSkin.Controls.MaterialComboBox cmb_sub_category;
        private MaterialSkin.Controls.MaterialComboBox cmb_status;
        private System.Windows.Forms.NumericUpDown txt_duration;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}