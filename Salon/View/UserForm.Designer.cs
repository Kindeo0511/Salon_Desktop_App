namespace Salon.View
{
    partial class UserForm
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
            this.txt_first_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_last_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contact = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_confirm_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.dtp_day_of_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_show_password = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_first_name
            // 
            this.txt_first_name.AnimateReadOnly = false;
            this.txt_first_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_first_name.Hint = "First Name";
            this.txt_first_name.LeadingIcon = null;
            this.txt_first_name.Location = new System.Drawing.Point(23, 39);
            this.txt_first_name.MaxLength = 50;
            this.txt_first_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_first_name.Multiline = false;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(400, 50);
            this.txt_first_name.TabIndex = 0;
            this.txt_first_name.Text = "";
            this.txt_first_name.TrailingIcon = null;
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.AnimateReadOnly = false;
            this.txt_middle_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_middle_name.Hint = "Middle Name";
            this.txt_middle_name.LeadingIcon = null;
            this.txt_middle_name.Location = new System.Drawing.Point(23, 131);
            this.txt_middle_name.MaxLength = 50;
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_middle_name.Multiline = false;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.Size = new System.Drawing.Size(400, 50);
            this.txt_middle_name.TabIndex = 1;
            this.txt_middle_name.Text = "";
            this.txt_middle_name.TrailingIcon = null;
            // 
            // txt_last_name
            // 
            this.txt_last_name.AnimateReadOnly = false;
            this.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_last_name.Hint = "Last Name";
            this.txt_last_name.LeadingIcon = null;
            this.txt_last_name.Location = new System.Drawing.Point(23, 225);
            this.txt_last_name.MaxLength = 50;
            this.txt_last_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_last_name.Multiline = false;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(400, 50);
            this.txt_last_name.TabIndex = 2;
            this.txt_last_name.Text = "";
            this.txt_last_name.TrailingIcon = null;
            // 
            // txt_contact
            // 
            this.txt_contact.AnimateReadOnly = false;
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Depth = 0;
            this.txt_contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contact.Hint = "Contact #";
            this.txt_contact.LeadingIcon = null;
            this.txt_contact.Location = new System.Drawing.Point(477, 39);
            this.txt_contact.MaxLength = 50;
            this.txt_contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contact.Multiline = false;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(400, 50);
            this.txt_contact.TabIndex = 3;
            this.txt_contact.Text = "";
            this.txt_contact.TrailingIcon = null;
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(477, 131);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(400, 50);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.AnimateReadOnly = true;
            this.txt_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_password.Depth = 0;
            this.txt_confirm_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirm_password.Hint = "Confirm Password";
            this.txt_confirm_password.LeadingIcon = null;
            this.txt_confirm_password.Location = new System.Drawing.Point(57, 225);
            this.txt_confirm_password.MaxLength = 50;
            this.txt_confirm_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_confirm_password.Multiline = false;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Password = true;
            this.txt_confirm_password.Size = new System.Drawing.Size(400, 50);
            this.txt_confirm_password.TabIndex = 9;
            this.txt_confirm_password.Text = "";
            this.txt_confirm_password.TrailingIcon = null;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = true;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Hint = "Password";
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(57, 131);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Password = true;
            this.txt_password.Size = new System.Drawing.Size(400, 50);
            this.txt_password.TabIndex = 8;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Username";
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(57, 39);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(400, 50);
            this.txt_username.TabIndex = 7;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            // 
            // dtp_day_of_birth
            // 
            this.dtp_day_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_day_of_birth.Location = new System.Drawing.Point(477, 240);
            this.dtp_day_of_birth.Name = "dtp_day_of_birth";
            this.dtp_day_of_birth.Size = new System.Drawing.Size(400, 22);
            this.dtp_day_of_birth.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1479, 640);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(1286, 640);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(1351, 640);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_first_name);
            this.groupBox1.Controls.Add(this.txt_middle_name);
            this.groupBox1.Controls.Add(this.txt_last_name);
            this.groupBox1.Controls.Add(this.dtp_day_of_birth);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox1.Size = new System.Drawing.Size(900, 475);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFORMATION";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(474, 218);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Date of Birth:";
            // 
            // txt_address
            // 
            this.txt_address.AnimateReadOnly = false;
            this.txt_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.Depth = 0;
            this.txt_address.HideSelection = true;
            this.txt_address.Hint = "Address";
            this.txt_address.Location = new System.Drawing.Point(23, 322);
            this.txt_address.MaxLength = 255;
            this.txt_address.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = false;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(666, 122);
            this.txt_address.TabIndex = 6;
            this.txt_address.TabStop = false;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chk_show_password);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Controls.Add(this.txt_confirm_password);
            this.groupBox2.Location = new System.Drawing.Point(1003, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.groupBox2.Size = new System.Drawing.Size(500, 475);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCOUNT";
            // 
            // chk_show_password
            // 
            this.chk_show_password.AutoSize = true;
            this.chk_show_password.Depth = 0;
            this.chk_show_password.Location = new System.Drawing.Point(57, 336);
            this.chk_show_password.Margin = new System.Windows.Forms.Padding(0);
            this.chk_show_password.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_show_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_show_password.Name = "chk_show_password";
            this.chk_show_password.ReadOnly = false;
            this.chk_show_password.Ripple = true;
            this.chk_show_password.Size = new System.Drawing.Size(149, 37);
            this.chk_show_password.TabIndex = 10;
            this.chk_show_password.Text = "Show Password";
            this.chk_show_password.UseVisualStyleBackColor = true;
            this.chk_show_password.CheckedChanged += new System.EventHandler(this.chk_show_password_CheckedChanged_1);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.groupBox2);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 94);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1520, 526);
            this.materialCard1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Padding = new System.Windows.Forms.Padding(40, 94, 40, 80);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_first_name;
        private MaterialSkin.Controls.MaterialTextBox txt_middle_name;
        private MaterialSkin.Controls.MaterialTextBox txt_last_name;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private MaterialSkin.Controls.MaterialTextBox txt_confirm_password;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private System.Windows.Forms.DateTimePicker dtp_day_of_birth;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_address;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckbox chk_show_password;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}