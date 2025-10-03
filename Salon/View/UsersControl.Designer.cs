namespace Salon.View
{
    partial class UsersControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_first_name,
            this.col_middle_name,
            this.col_last_name,
            this.col_phone,
            this.col_email,
            this.col_address,
            this.col_username,
            this.col_password,
            this.col_role,
            this.btn_update,
            this.btn_delete});
            this.dataGridView1.Location = new System.Drawing.Point(80, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(80, 174);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(158, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Create new user";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 125;
            // 
            // col_first_name
            // 
            this.col_first_name.HeaderText = "First Name";
            this.col_first_name.MinimumWidth = 6;
            this.col_first_name.Name = "col_first_name";
            this.col_first_name.ReadOnly = true;
            this.col_first_name.Width = 125;
            // 
            // col_middle_name
            // 
            this.col_middle_name.HeaderText = "Middle Name";
            this.col_middle_name.MinimumWidth = 6;
            this.col_middle_name.Name = "col_middle_name";
            this.col_middle_name.ReadOnly = true;
            this.col_middle_name.Width = 125;
            // 
            // col_last_name
            // 
            this.col_last_name.HeaderText = "Last Name";
            this.col_last_name.MinimumWidth = 6;
            this.col_last_name.Name = "col_last_name";
            this.col_last_name.ReadOnly = true;
            this.col_last_name.Width = 125;
            // 
            // col_phone
            // 
            this.col_phone.HeaderText = "Contact";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            this.col_phone.Width = 125;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            this.col_email.Width = 125;
            // 
            // col_address
            // 
            this.col_address.HeaderText = "Address";
            this.col_address.MinimumWidth = 6;
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            this.col_address.Width = 125;
            // 
            // col_username
            // 
            this.col_username.HeaderText = "Username";
            this.col_username.MinimumWidth = 6;
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            this.col_username.Width = 125;
            // 
            // col_password
            // 
            this.col_password.HeaderText = "Password";
            this.col_password.MinimumWidth = 6;
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            this.col_password.Width = 125;
            // 
            // col_role
            // 
            this.col_role.HeaderText = "Role";
            this.col_role.MinimumWidth = 6;
            this.col_role.Name = "col_role";
            this.col_role.ReadOnly = true;
            this.col_role.Width = 125;
            // 
            // btn_update
            // 
            this.btn_update.HeaderText = "Update";
            this.btn_update.MinimumWidth = 6;
            this.btn_update.Name = "btn_update";
            this.btn_update.ReadOnly = true;
            this.btn_update.Width = 125;
            // 
            // btn_delete
            // 
            this.btn_delete.HeaderText = "Delete";
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Width = 125;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1000, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_add;
    }
}
