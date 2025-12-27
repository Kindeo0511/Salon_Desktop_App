namespace Salon.Card
{
    partial class CheckOutCard
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_price = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_qty = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_service_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_service_name);
            this.materialCard1.Controls.Add(this.lbl_qty);
            this.materialCard1.Controls.Add(this.lbl_price);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Size = new System.Drawing.Size(299, 88);
            this.materialCard1.TabIndex = 0;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Depth = 0;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_price.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_price.Location = new System.Drawing.Point(165, 54);
            this.lbl_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(40, 24);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "0.00";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Depth = 0;
            this.lbl_qty.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_qty.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_qty.Location = new System.Drawing.Point(30, 54);
            this.lbl_qty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(12, 24);
            this.lbl_qty.TabIndex = 4;
            this.lbl_qty.Text = "0";
            this.lbl_qty.Click += new System.EventHandler(this.lbl_qty_Click);
            // 
            // lbl_service_name
            // 
            this.lbl_service_name.AutoSize = true;
            this.lbl_service_name.Depth = 0;
            this.lbl_service_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_service_name.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_service_name.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_service_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_service_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_service_name.Name = "lbl_service_name";
            this.lbl_service_name.Size = new System.Drawing.Size(150, 29);
            this.lbl_service_name.TabIndex = 1;
            this.lbl_service_name.Text = "Service Name";
            // 
            // CheckOutCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "CheckOutCard";
            this.Size = new System.Drawing.Size(299, 88);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lbl_service_name;
        private MaterialSkin.Controls.MaterialLabel lbl_price;
        private MaterialSkin.Controls.MaterialLabel lbl_qty;
    }
}
