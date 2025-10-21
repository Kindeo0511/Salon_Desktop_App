namespace Salon.View
{
    partial class CategoryForm
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
            this.txt_category_name = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.cmb_category_type = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_category_name
            // 
            this.txt_category_name.AnimateReadOnly = false;
            this.txt_category_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_category_name.Depth = 0;
            this.txt_category_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_category_name.Hint = "Category Name";
            this.txt_category_name.LeadingIcon = null;
            this.txt_category_name.Location = new System.Drawing.Point(46, 155);
            this.txt_category_name.MaxLength = 50;
            this.txt_category_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_category_name.Multiline = false;
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(300, 50);
            this.txt_category_name.TabIndex = 12;
            this.txt_category_name.Text = "";
            this.txt_category_name.TrailingIcon = null;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(323, 359);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(77, 36);
            this.btn_update.TabIndex = 20;
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
            this.btn_cancel.Location = new System.Drawing.Point(567, 359);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 19;
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
            this.btn_save.Location = new System.Drawing.Point(323, 359);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_category_type
            // 
            this.cmb_category_type.AutoResize = false;
            this.cmb_category_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_category_type.Depth = 0;
            this.cmb_category_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_category_type.DropDownHeight = 174;
            this.cmb_category_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category_type.DropDownWidth = 121;
            this.cmb_category_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_category_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_category_type.FormattingEnabled = true;
            this.cmb_category_type.Hint = "Select Category Type";
            this.cmb_category_type.IntegralHeight = false;
            this.cmb_category_type.ItemHeight = 43;
            this.cmb_category_type.Items.AddRange(new object[] {
            "Service",
            "Product"});
            this.cmb_category_type.Location = new System.Drawing.Point(445, 156);
            this.cmb_category_type.MaxDropDownItems = 4;
            this.cmb_category_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_category_type.Name = "cmb_category_type";
            this.cmb_category_type.Size = new System.Drawing.Size(300, 49);
            this.cmb_category_type.StartIndex = -1;
            this.cmb_category_type.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_category_type);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_category_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_category_name;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialComboBox cmb_category_type;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}