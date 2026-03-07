namespace Salon.View
{
    partial class ViewCustomerCard
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_close = new MaterialSkin.Controls.MaterialButton();
            this.lbl_customer = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_auto_generated_number = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_created_at = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_visit = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_visit_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(71, 170);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Card Number:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(71, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Customer:";
            // 
            // btn_close
            // 
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_close.Depth = 0;
            this.btn_close.HighEmphasis = true;
            this.btn_close.Icon = null;
            this.btn_close.Location = new System.Drawing.Point(779, 555);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_close.Name = "btn_close";
            this.btn_close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_close.Size = new System.Drawing.Size(66, 36);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "close";
            this.btn_close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_close.UseAccentColor = false;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Depth = 0;
            this.lbl_customer.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_customer.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_customer.Location = new System.Drawing.Point(337, 112);
            this.lbl_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(135, 24);
            this.lbl_customer.TabIndex = 14;
            this.lbl_customer.Text = "materialLabel3";
            // 
            // lbl_auto_generated_number
            // 
            this.lbl_auto_generated_number.AutoSize = true;
            this.lbl_auto_generated_number.Depth = 0;
            this.lbl_auto_generated_number.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_auto_generated_number.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_auto_generated_number.Location = new System.Drawing.Point(336, 161);
            this.lbl_auto_generated_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_auto_generated_number.Name = "lbl_auto_generated_number";
            this.lbl_auto_generated_number.Size = new System.Drawing.Size(45, 24);
            this.lbl_auto_generated_number.TabIndex = 13;
            this.lbl_auto_generated_number.Text = "0000";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(71, 228);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 24);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Created At:";
            // 
            // lbl_created_at
            // 
            this.lbl_created_at.AutoSize = true;
            this.lbl_created_at.Depth = 0;
            this.lbl_created_at.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_created_at.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_created_at.Location = new System.Drawing.Point(336, 228);
            this.lbl_created_at.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_created_at.Name = "lbl_created_at";
            this.lbl_created_at.Size = new System.Drawing.Size(45, 24);
            this.lbl_created_at.TabIndex = 18;
            this.lbl_created_at.Text = "0000";
            // 
            // dgv_visit
            // 
            this.dgv_visit.AllowUserToAddRows = false;
            this.dgv_visit.AllowUserToDeleteRows = false;
            this.dgv_visit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_visit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_visit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_visit.ColumnHeadersHeight = 40;
            this.dgv_visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_visit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_name,
            this.col_visit_req,
            this.col_required,
            this.col_progress});
            this.dgv_visit.EnableHeadersVisualStyles = false;
            this.dgv_visit.Location = new System.Drawing.Point(6, 333);
            this.dgv_visit.Name = "dgv_visit";
            this.dgv_visit.ReadOnly = true;
            this.dgv_visit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_visit.RowHeadersVisible = false;
            this.dgv_visit.RowHeadersWidth = 51;
            this.dgv_visit.RowTemplate.Height = 24;
            this.dgv_visit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visit.Size = new System.Drawing.Size(888, 191);
            this.dgv_visit.TabIndex = 19;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(18, 295);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(155, 24);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "VISIT PROGRESS";
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
            this.col_visit_req.HeaderText = "Visit";
            this.col_visit_req.MinimumWidth = 6;
            this.col_visit_req.Name = "col_visit_req";
            this.col_visit_req.ReadOnly = true;
            this.col_visit_req.Width = 59;
            // 
            // col_required
            // 
            this.col_required.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_required.HeaderText = "Required";
            this.col_required.MinimumWidth = 6;
            this.col_required.Name = "col_required";
            this.col_required.ReadOnly = true;
            // 
            // col_progress
            // 
            this.col_progress.HeaderText = "Progress";
            this.col_progress.MinimumWidth = 6;
            this.col_progress.Name = "col_progress";
            this.col_progress.ReadOnly = true;
            this.col_progress.Width = 125;
            // 
            // ViewCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dgv_visit);
            this.Controls.Add(this.lbl_created_at);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.lbl_auto_generated_number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewCustomerCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customer Card";
            this.Load += new System.EventHandler(this.ViewCustomerCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_close;
        private MaterialSkin.Controls.MaterialLabel lbl_customer;
        private MaterialSkin.Controls.MaterialLabel lbl_auto_generated_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lbl_created_at;
        private System.Windows.Forms.DataGridView dgv_visit;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_visit_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_required;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_progress;
    }
}