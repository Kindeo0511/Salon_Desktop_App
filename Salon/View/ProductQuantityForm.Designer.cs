namespace Salon.View
{
    partial class ProductQuantityForm
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
            this.txt_qtn = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txt_qtn
            // 
            this.txt_qtn.AnimateReadOnly = false;
            this.txt_qtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtn.Depth = 0;
            this.txt_qtn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qtn.Hint = "Enter quantity";
            this.txt_qtn.LeadingIcon = null;
            this.txt_qtn.Location = new System.Drawing.Point(60, 89);
            this.txt_qtn.MaxLength = 50;
            this.txt_qtn.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_qtn.Multiline = false;
            this.txt_qtn.Name = "txt_qtn";
            this.txt_qtn.Size = new System.Drawing.Size(370, 50);
            this.txt_qtn.TabIndex = 0;
            this.txt_qtn.Text = "";
            this.txt_qtn.TrailingIcon = null;
            this.txt_qtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qtn_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(56, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Quantity:";
            // 
            // ProductQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_qtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductQuantityForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductQuantityForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductQuantityForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_qtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}