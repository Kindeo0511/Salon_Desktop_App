namespace Salon.View
{
    partial class ProductForm
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
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.txt_unit_volume = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_product_name = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_category = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_unit_type = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_usage_type = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(642, 466);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "save changes";
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
            this.btn_cancel.Location = new System.Drawing.Point(857, 466);
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
            this.btn_save.Location = new System.Drawing.Point(642, 466);
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
            // txt_unit_volume
            // 
            this.txt_unit_volume.AnimateReadOnly = false;
            this.txt_unit_volume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_unit_volume.Depth = 0;
            this.txt_unit_volume.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_unit_volume.Hint = "Unit Volume";
            this.txt_unit_volume.LeadingIcon = null;
            this.txt_unit_volume.Location = new System.Drawing.Point(60, 341);
            this.txt_unit_volume.MaxLength = 50;
            this.txt_unit_volume.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_unit_volume.Multiline = false;
            this.txt_unit_volume.Name = "txt_unit_volume";
            this.txt_unit_volume.Size = new System.Drawing.Size(400, 50);
            this.txt_unit_volume.TabIndex = 20;
            this.txt_unit_volume.Text = "";
            this.txt_unit_volume.TrailingIcon = null;
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = false;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(60, 234);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_brand.Multiline = false;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(400, 50);
            this.txt_brand.TabIndex = 19;
            this.txt_brand.Text = "";
            this.txt_brand.TrailingIcon = null;
            // 
            // txt_product_name
            // 
            this.txt_product_name.AnimateReadOnly = false;
            this.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_name.Depth = 0;
            this.txt_product_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_product_name.Hint = "Product Name";
            this.txt_product_name.LeadingIcon = null;
            this.txt_product_name.Location = new System.Drawing.Point(60, 129);
            this.txt_product_name.MaxLength = 50;
            this.txt_product_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_product_name.Multiline = false;
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(400, 50);
            this.txt_product_name.TabIndex = 18;
            this.txt_product_name.Text = "";
            this.txt_product_name.TrailingIcon = null;
            // 
            // cmb_category
            // 
            this.cmb_category.AutoResize = false;
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_category.Depth = 0;
            this.cmb_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_category.DropDownHeight = 174;
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.DropDownWidth = 121;
            this.cmb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Hint = "Category";
            this.cmb_category.IntegralHeight = false;
            this.cmb_category.ItemHeight = 43;
            this.cmb_category.Location = new System.Drawing.Point(534, 127);
            this.cmb_category.MaxDropDownItems = 4;
            this.cmb_category.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(400, 49);
            this.cmb_category.StartIndex = 0;
            this.cmb_category.TabIndex = 26;
            // 
            // cmb_unit_type
            // 
            this.cmb_unit_type.AutoResize = false;
            this.cmb_unit_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_unit_type.Depth = 0;
            this.cmb_unit_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_unit_type.DropDownHeight = 174;
            this.cmb_unit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unit_type.DropDownWidth = 121;
            this.cmb_unit_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_unit_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_unit_type.FormattingEnabled = true;
            this.cmb_unit_type.Hint = "Unit Type";
            this.cmb_unit_type.IntegralHeight = false;
            this.cmb_unit_type.ItemHeight = 43;
            this.cmb_unit_type.Items.AddRange(new object[] {
            "ml",
            "g",
            "kg"});
            this.cmb_unit_type.Location = new System.Drawing.Point(534, 235);
            this.cmb_unit_type.MaxDropDownItems = 4;
            this.cmb_unit_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_unit_type.Name = "cmb_unit_type";
            this.cmb_unit_type.Size = new System.Drawing.Size(400, 49);
            this.cmb_unit_type.StartIndex = -1;
            this.cmb_unit_type.TabIndex = 27;
            // 
            // cmb_usage_type
            // 
            this.cmb_usage_type.AutoResize = false;
            this.cmb_usage_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_usage_type.Depth = 0;
            this.cmb_usage_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_usage_type.DropDownHeight = 174;
            this.cmb_usage_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usage_type.DropDownWidth = 121;
            this.cmb_usage_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_usage_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_usage_type.FormattingEnabled = true;
            this.cmb_usage_type.Hint = "Usage Type";
            this.cmb_usage_type.IntegralHeight = false;
            this.cmb_usage_type.ItemHeight = 43;
            this.cmb_usage_type.Items.AddRange(new object[] {
            "Pump",
            "Scoop",
            "Spray"});
            this.cmb_usage_type.Location = new System.Drawing.Point(534, 342);
            this.cmb_usage_type.MaxDropDownItems = 4;
            this.cmb_usage_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_usage_type.Name = "cmb_usage_type";
            this.cmb_usage_type.Size = new System.Drawing.Size(400, 49);
            this.cmb_usage_type.StartIndex = -1;
            this.cmb_usage_type.TabIndex = 28;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.cmb_usage_type);
            this.Controls.Add(this.cmb_unit_type);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_unit_volume);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_product_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT INFORMATION";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox txt_unit_volume;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialTextBox txt_product_name;
        private MaterialSkin.Controls.MaterialComboBox cmb_category;
        private MaterialSkin.Controls.MaterialComboBox cmb_unit_type;
        private MaterialSkin.Controls.MaterialComboBox cmb_usage_type;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}