namespace Salon.Card
{
    partial class ServiceCard
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_duration = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_price = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_services = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_remove = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(377, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Duration";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Depth = 0;
            this.lbl_duration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_duration.Location = new System.Drawing.Point(377, 62);
            this.lbl_duration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(10, 19);
            this.lbl_duration.TabIndex = 3;
            this.lbl_duration.Text = "0";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Depth = 0;
            this.lbl_price.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_price.Location = new System.Drawing.Point(477, 62);
            this.lbl_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(32, 19);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "0.00";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(477, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Service";
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
            this.cmb_services.Hint = "Select Service";
            this.cmb_services.IntegralHeight = false;
            this.cmb_services.ItemHeight = 43;
            this.cmb_services.Location = new System.Drawing.Point(17, 32);
            this.cmb_services.MaxDropDownItems = 4;
            this.cmb_services.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(336, 49);
            this.cmb_services.StartIndex = 0;
            this.cmb_services.TabIndex = 7;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSize = true;
            this.btn_remove.Depth = 0;
            this.btn_remove.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_remove.ForeColor = System.Drawing.Color.Red;
            this.btn_remove.Location = new System.Drawing.Point(536, 0);
            this.btn_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(11, 19);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Text = "X";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.cmb_services);
            this.materialCard1.Controls.Add(this.btn_remove);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lbl_duration);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lbl_price);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(550, 100);
            this.materialCard1.TabIndex = 9;
            // 
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "ServiceCard";
            this.Size = new System.Drawing.Size(550, 100);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_duration;
        private MaterialSkin.Controls.MaterialLabel lbl_price;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmb_services;
        private MaterialSkin.Controls.MaterialLabel btn_remove;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
