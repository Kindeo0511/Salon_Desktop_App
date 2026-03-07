namespace Salon.View
{
    partial class CreateCustomerCard
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_services = new System.Windows.Forms.DataGridView();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_visit_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_auto_generated_number = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_customer = new MaterialSkin.Controls.MaterialLabel();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.lbl_id = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(72, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Customer:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(72, 184);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Card Number:";
            // 
            // dgv_services
            // 
            this.dgv_services.AllowUserToAddRows = false;
            this.dgv_services.AllowUserToDeleteRows = false;
            this.dgv_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_services.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_services.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_services.ColumnHeadersHeight = 40;
            this.dgv_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_name,
            this.col_visit_req,
            this.col_description});
            this.dgv_services.EnableHeadersVisualStyles = false;
            this.dgv_services.Location = new System.Drawing.Point(6, 280);
            this.dgv_services.Name = "dgv_services";
            this.dgv_services.ReadOnly = true;
            this.dgv_services.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_services.RowHeadersVisible = false;
            this.dgv_services.RowHeadersWidth = 51;
            this.dgv_services.RowTemplate.Height = 24;
            this.dgv_services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_services.Size = new System.Drawing.Size(888, 191);
            this.dgv_services.TabIndex = 2;
            // 
            // col_service_name
            // 
            this.col_service_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_name.HeaderText = "Service";
            this.col_service_name.MinimumWidth = 6;
            this.col_service_name.Name = "col_service_name";
            this.col_service_name.ReadOnly = true;
            // 
            // col_visit_req
            // 
            this.col_visit_req.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_visit_req.HeaderText = "Visit_ Required";
            this.col_visit_req.MinimumWidth = 6;
            this.col_visit_req.Name = "col_visit_req";
            this.col_visit_req.ReadOnly = true;
            this.col_visit_req.Width = 115;
            // 
            // col_description
            // 
            this.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_description.HeaderText = "Description";
            this.col_description.MinimumWidth = 6;
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            // 
            // lbl_auto_generated_number
            // 
            this.lbl_auto_generated_number.AutoSize = true;
            this.lbl_auto_generated_number.Depth = 0;
            this.lbl_auto_generated_number.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_auto_generated_number.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_auto_generated_number.Location = new System.Drawing.Point(337, 175);
            this.lbl_auto_generated_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_auto_generated_number.Name = "lbl_auto_generated_number";
            this.lbl_auto_generated_number.Size = new System.Drawing.Size(45, 24);
            this.lbl_auto_generated_number.TabIndex = 3;
            this.lbl_auto_generated_number.Text = "0000";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Depth = 0;
            this.lbl_customer.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_customer.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_customer.Location = new System.Drawing.Point(338, 126);
            this.lbl_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(135, 24);
            this.lbl_customer.TabIndex = 6;
            this.lbl_customer.Text = "materialLabel3";
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(569, 519);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(732, 519);
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
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Depth = 0;
            this.lbl_id.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_id.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_id.Location = new System.Drawing.Point(337, 93);
            this.lbl_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(12, 24);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "0";
            this.lbl_id.Visible = false;
            // 
            // CreateCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.lbl_auto_generated_number);
            this.Controls.Add(this.dgv_services);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCustomerCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create loyalty Card";
            this.Load += new System.EventHandler(this.CreateCustomerCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgv_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_visit_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private MaterialSkin.Controls.MaterialLabel lbl_auto_generated_number;
        private MaterialSkin.Controls.MaterialLabel lbl_customer;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel lbl_id;
    }
}