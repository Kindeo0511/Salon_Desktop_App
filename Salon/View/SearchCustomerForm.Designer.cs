namespace Salon.View
{
    partial class SearchCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.txt_search = new MaterialSkin.Controls.MaterialTextBox();
            this.col_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_selected = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            this.dgv_customer.AllowUserToResizeColumns = false;
            this.dgv_customer.AllowUserToResizeRows = false;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_customer_id,
            this.col_name,
            this.col_phone_number,
            this.col_email,
            this.col_selected});
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_customer.Location = new System.Drawing.Point(3, 141);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(794, 306);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.AnimateReadOnly = false;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Depth = 0;
            this.txt_search.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.Hint = "Search Customer";
            this.txt_search.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_search.LeadingIcon")));
            this.txt_search.Location = new System.Drawing.Point(102, 55);
            this.txt_search.MaxLength = 50;
            this.txt_search.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(585, 50);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "";
            this.txt_search.TrailingIcon = null;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // col_customer_id
            // 
            this.col_customer_id.HeaderText = "ID";
            this.col_customer_id.MinimumWidth = 6;
            this.col_customer_id.Name = "col_customer_id";
            this.col_customer_id.Visible = false;
            this.col_customer_id.Width = 125;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            // 
            // col_phone_number
            // 
            this.col_phone_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_phone_number.HeaderText = "Contact";
            this.col_phone_number.MinimumWidth = 6;
            this.col_phone_number.Name = "col_phone_number";
            this.col_phone_number.Width = 81;
            // 
            // col_email
            // 
            this.col_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.Width = 70;
            // 
            // col_selected
            // 
            this.col_selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_selected.HeaderText = "Action";
            this.col_selected.MinimumWidth = 6;
            this.col_selected.Name = "col_selected";
            this.col_selected.Text = "Select";
            this.col_selected.UseColumnTextForButtonValue = true;
            this.col_selected.Width = 50;
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_customer);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customer;
        private MaterialSkin.Controls.MaterialTextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewButtonColumn col_selected;
    }
}