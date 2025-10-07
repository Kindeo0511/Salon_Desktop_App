namespace Salon.View
{
    partial class ServicesCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ServiceName = new MaterialSkin.Controls.MaterialLabel();
            this.category = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_to_cart = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_ServiceName
            // 
            this.lbl_ServiceName.AutoSize = true;
            this.lbl_ServiceName.Depth = 0;
            this.lbl_ServiceName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ServiceName.Location = new System.Drawing.Point(41, 36);
            this.lbl_ServiceName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ServiceName.Name = "lbl_ServiceName";
            this.lbl_ServiceName.Size = new System.Drawing.Size(52, 19);
            this.lbl_ServiceName.TabIndex = 0;
            this.lbl_ServiceName.Text = "Service";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Depth = 0;
            this.category.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.category.Location = new System.Drawing.Point(230, 36);
            this.category.MouseState = MaterialSkin.MouseState.HOVER;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(52, 19);
            this.category.TabIndex = 1;
            this.category.Text = "Service";
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_to_cart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_to_cart.Depth = 0;
            this.btn_add_to_cart.HighEmphasis = true;
            this.btn_add_to_cart.Icon = null;
            this.btn_add_to_cart.Location = new System.Drawing.Point(413, 26);
            this.btn_add_to_cart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_to_cart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_to_cart.Size = new System.Drawing.Size(64, 36);
            this.btn_add_to_cart.TabIndex = 2;
            this.btn_add_to_cart.Text = " Add";
            this.btn_add_to_cart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_to_cart.UseAccentColor = false;
            this.btn_add_to_cart.UseVisualStyleBackColor = true;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click_1);
            // 
            // ServicesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add_to_cart);
            this.Controls.Add(this.category);
            this.Controls.Add(this.lbl_ServiceName);
            this.Name = "ServicesCard";
            this.Size = new System.Drawing.Size(700, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_ServiceName;
        private MaterialSkin.Controls.MaterialLabel category;
        private MaterialSkin.Controls.MaterialButton btn_add_to_cart;
    }
}
