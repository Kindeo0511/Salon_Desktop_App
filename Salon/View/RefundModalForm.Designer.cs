namespace Salon.View
{
    partial class RefundModalForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_product = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_reason = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(52, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Product:";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Depth = 0;
            this.lbl_product.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_product.Location = new System.Drawing.Point(269, 133);
            this.lbl_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(99, 19);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "product name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(52, 217);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(29, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Qty:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(52, 306);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Reason:";
            // 
            // cmb_reason
            // 
            this.cmb_reason.AutoResize = false;
            this.cmb_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_reason.Depth = 0;
            this.cmb_reason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_reason.DropDownHeight = 174;
            this.cmb_reason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reason.DropDownWidth = 121;
            this.cmb_reason.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_reason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_reason.FormattingEnabled = true;
            this.cmb_reason.Hint = "Select a reason";
            this.cmb_reason.IntegralHeight = false;
            this.cmb_reason.ItemHeight = 43;
            this.cmb_reason.Items.AddRange(new object[] {
            "Damaged",
            "Expired",
            "Opened",
            "Wrong Item",
            "Wrong Size",
            "Customer Changed Mind",
            "Duplicate Entry",
            "Other"});
            this.cmb_reason.Location = new System.Drawing.Point(253, 286);
            this.cmb_reason.MaxDropDownItems = 4;
            this.cmb_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.Size = new System.Drawing.Size(450, 49);
            this.cmb_reason.StartIndex = -1;
            this.cmb_reason.TabIndex = 5;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(272, 204);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(120, 22);
            this.txt_qty.TabIndex = 6;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(357, 380);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(575, 380);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // RefundModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.cmb_reason);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RefundModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund Product";
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_product;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmb_reason;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
    }
}