namespace Salon.View
{
    partial class CustomAmountForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_amount = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(73, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Amount:";
            // 
            // txt_amount
            // 
            this.txt_amount.AnimateReadOnly = false;
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Depth = 0;
            this.txt_amount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount.Hint = "Enter Amount";
            this.txt_amount.LeadingIcon = null;
            this.txt_amount.Location = new System.Drawing.Point(76, 84);
            this.txt_amount.MaxLength = 50;
            this.txt_amount.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_amount.Multiline = false;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(450, 50);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.Text = "";
            this.txt_amount.TrailingIcon = null;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txt_confirm.Depth = 0;
            this.txt_confirm.HighEmphasis = true;
            this.txt_confirm.Icon = null;
            this.txt_confirm.Location = new System.Drawing.Point(322, 184);
            this.txt_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txt_confirm.Size = new System.Drawing.Size(86, 36);
            this.txt_confirm.TabIndex = 2;
            this.txt_confirm.Text = "confirm";
            this.txt_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txt_confirm.UseAccentColor = false;
            this.txt_confirm.UseVisualStyleBackColor = true;
            this.txt_confirm.Click += new System.EventHandler(this.txt_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(484, 184);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CustomAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomAmountForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_amount;
        private MaterialSkin.Controls.MaterialButton txt_confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}