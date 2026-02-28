namespace Salon.View
{
    partial class ProductSizeForm
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
            this.txt_content = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cost_price = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_product_size_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_save = new MaterialSkin.Controls.MaterialButton();
            this.txt_size_label = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_selling_price = new MaterialSkin.Controls.MaterialTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_content
            // 
            this.txt_content.AnimateReadOnly = false;
            this.txt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_content.Depth = 0;
            this.txt_content.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_content.Hint = "Enter content";
            this.txt_content.LeadingIcon = null;
            this.txt_content.Location = new System.Drawing.Point(315, 203);
            this.txt_content.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_content.MaxLength = 50;
            this.txt_content.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_content.Multiline = false;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(500, 50);
            this.txt_content.TabIndex = 59;
            this.txt_content.Text = "";
            this.txt_content.TrailingIcon = null;
            // 
            // txt_cost_price
            // 
            this.txt_cost_price.AnimateReadOnly = false;
            this.txt_cost_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cost_price.Depth = 0;
            this.txt_cost_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cost_price.Hint = "Enter cost price";
            this.txt_cost_price.LeadingIcon = null;
            this.txt_cost_price.Location = new System.Drawing.Point(315, 288);
            this.txt_cost_price.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_cost_price.MaxLength = 50;
            this.txt_cost_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cost_price.Multiline = false;
            this.txt_cost_price.Name = "txt_cost_price";
            this.txt_cost_price.Size = new System.Drawing.Size(500, 50);
            this.txt_cost_price.TabIndex = 58;
            this.txt_cost_price.Text = "";
            this.txt_cost_price.TrailingIcon = null;
            // 
            // btn_product_size_cancel
            // 
            this.btn_product_size_cancel.AutoSize = false;
            this.btn_product_size_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_cancel.Depth = 0;
            this.btn_product_size_cancel.HighEmphasis = true;
            this.btn_product_size_cancel.Icon = null;
            this.btn_product_size_cancel.Location = new System.Drawing.Point(686, 501);
            this.btn_product_size_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_cancel.Name = "btn_product_size_cancel";
            this.btn_product_size_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_cancel.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_cancel.TabIndex = 56;
            this.btn_product_size_cancel.Text = "cancel";
            this.btn_product_size_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_cancel.UseAccentColor = false;
            this.btn_product_size_cancel.UseVisualStyleBackColor = true;
            this.btn_product_size_cancel.Click += new System.EventHandler(this.btn_product_size_cancel_Click);
            // 
            // btn_product_size_update
            // 
            this.btn_product_size_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_update.Depth = 0;
            this.btn_product_size_update.DrawShadows = false;
            this.btn_product_size_update.HighEmphasis = true;
            this.btn_product_size_update.Icon = null;
            this.btn_product_size_update.Location = new System.Drawing.Point(283, 501);
            this.btn_product_size_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_update.Name = "btn_product_size_update";
            this.btn_product_size_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_update.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_update.TabIndex = 57;
            this.btn_product_size_update.Text = "save changes";
            this.btn_product_size_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_update.UseAccentColor = false;
            this.btn_product_size_update.UseVisualStyleBackColor = true;
            this.btn_product_size_update.Visible = false;
            this.btn_product_size_update.Click += new System.EventHandler(this.btn_product_size_update_Click);
            // 
            // btn_product_size_save
            // 
            this.btn_product_size_save.AutoSize = false;
            this.btn_product_size_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_save.Depth = 0;
            this.btn_product_size_save.HighEmphasis = true;
            this.btn_product_size_save.Icon = null;
            this.btn_product_size_save.Location = new System.Drawing.Point(283, 501);
            this.btn_product_size_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_save.Name = "btn_product_size_save";
            this.btn_product_size_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_save.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_save.TabIndex = 55;
            this.btn_product_size_save.Text = "save";
            this.btn_product_size_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_save.UseAccentColor = false;
            this.btn_product_size_save.UseVisualStyleBackColor = true;
            this.btn_product_size_save.Click += new System.EventHandler(this.btn_product_size_save_Click);
            // 
            // txt_size_label
            // 
            this.txt_size_label.AnimateReadOnly = false;
            this.txt_size_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_size_label.Depth = 0;
            this.txt_size_label.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_size_label.Hint = "Enter size label";
            this.txt_size_label.LeadingIcon = null;
            this.txt_size_label.Location = new System.Drawing.Point(315, 118);
            this.txt_size_label.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_size_label.MaxLength = 50;
            this.txt_size_label.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_size_label.Multiline = false;
            this.txt_size_label.Name = "txt_size_label";
            this.txt_size_label.Size = new System.Drawing.Size(500, 50);
            this.txt_size_label.TabIndex = 51;
            this.txt_size_label.Text = "";
            this.txt_size_label.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(101, 299);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 24);
            this.materialLabel2.TabIndex = 54;
            this.materialLabel2.Text = "Cost Price:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(101, 135);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(98, 24);
            this.materialLabel8.TabIndex = 52;
            this.materialLabel8.Text = "Size Label:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(101, 219);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 24);
            this.materialLabel5.TabIndex = 53;
            this.materialLabel5.Text = "Content:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(101, 389);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 24);
            this.materialLabel1.TabIndex = 60;
            this.materialLabel1.Text = "Selling Price";
            this.materialLabel1.Visible = false;
            // 
            // txt_selling_price
            // 
            this.txt_selling_price.AnimateReadOnly = false;
            this.txt_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_selling_price.Depth = 0;
            this.txt_selling_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_selling_price.Hint = "Enter selling price";
            this.txt_selling_price.LeadingIcon = null;
            this.txt_selling_price.Location = new System.Drawing.Point(315, 373);
            this.txt_selling_price.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_selling_price.MaxLength = 50;
            this.txt_selling_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_selling_price.Multiline = false;
            this.txt_selling_price.Name = "txt_selling_price";
            this.txt_selling_price.Size = new System.Drawing.Size(500, 50);
            this.txt_selling_price.TabIndex = 61;
            this.txt_selling_price.Text = "";
            this.txt_selling_price.TrailingIcon = null;
            this.txt_selling_price.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 608);
            this.Controls.Add(this.txt_selling_price);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_cost_price);
            this.Controls.Add(this.btn_product_size_cancel);
            this.Controls.Add(this.btn_product_size_update);
            this.Controls.Add(this.btn_product_size_save);
            this.Controls.Add(this.txt_size_label);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel5);
            this.Name = "ProductSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductSizeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_content;
        private MaterialSkin.Controls.MaterialTextBox txt_cost_price;
        private MaterialSkin.Controls.MaterialButton btn_product_size_cancel;
        private MaterialSkin.Controls.MaterialButton btn_product_size_update;
        private MaterialSkin.Controls.MaterialButton btn_product_size_save;
        private MaterialSkin.Controls.MaterialTextBox txt_size_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_selling_price;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}