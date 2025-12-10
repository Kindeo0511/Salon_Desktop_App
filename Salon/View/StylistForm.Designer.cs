namespace Salon.View
{
    partial class StylistForm
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
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.dtp_day_of_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contact = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_last_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_first_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(665, 622);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(854, 622);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(730, 622);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_day_of_birth
            // 
            this.dtp_day_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_day_of_birth.Location = new System.Drawing.Point(46, 451);
            this.dtp_day_of_birth.Name = "dtp_day_of_birth";
            this.dtp_day_of_birth.Size = new System.Drawing.Size(400, 22);
            this.dtp_day_of_birth.TabIndex = 23;
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(557, 232);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(400, 50);
            this.txt_email.TabIndex = 19;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // txt_contact
            // 
            this.txt_contact.AnimateReadOnly = false;
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Depth = 0;
            this.txt_contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contact.Hint = "Contact #";
            this.txt_contact.LeadingIcon = null;
            this.txt_contact.Location = new System.Drawing.Point(557, 126);
            this.txt_contact.MaxLength = 50;
            this.txt_contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contact.Multiline = false;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(400, 50);
            this.txt_contact.TabIndex = 18;
            this.txt_contact.Text = "";
            this.txt_contact.TrailingIcon = null;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // txt_last_name
            // 
            this.txt_last_name.AnimateReadOnly = false;
            this.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_last_name.Hint = "Last Name";
            this.txt_last_name.LeadingIcon = null;
            this.txt_last_name.Location = new System.Drawing.Point(43, 337);
            this.txt_last_name.MaxLength = 50;
            this.txt_last_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_last_name.Multiline = false;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(400, 50);
            this.txt_last_name.TabIndex = 16;
            this.txt_last_name.Text = "";
            this.txt_last_name.TrailingIcon = null;
            this.txt_last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_last_name_KeyPress);
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.AnimateReadOnly = false;
            this.txt_middle_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_middle_name.Hint = "Middle Name";
            this.txt_middle_name.LeadingIcon = null;
            this.txt_middle_name.Location = new System.Drawing.Point(46, 232);
            this.txt_middle_name.MaxLength = 50;
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_middle_name.Multiline = false;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.Size = new System.Drawing.Size(400, 50);
            this.txt_middle_name.TabIndex = 15;
            this.txt_middle_name.Text = "";
            this.txt_middle_name.TrailingIcon = null;
            this.txt_middle_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_middle_name_KeyPress);
            // 
            // txt_first_name
            // 
            this.txt_first_name.AnimateReadOnly = false;
            this.txt_first_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_first_name.Hint = "First Name";
            this.txt_first_name.LeadingIcon = null;
            this.txt_first_name.Location = new System.Drawing.Point(43, 126);
            this.txt_first_name.MaxLength = 50;
            this.txt_first_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_first_name.Multiline = false;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(400, 50);
            this.txt_first_name.TabIndex = 14;
            this.txt_first_name.Text = "";
            this.txt_first_name.TrailingIcon = null;
            this.txt_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_name_KeyPress);
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
            this.txt_address.Location = new System.Drawing.Point(557, 337);
            this.txt_address.MaxLength = 32767;
            this.txt_address.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = false;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(400, 143);
            this.txt_address.TabIndex = 29;
            this.txt_address.TabStop = false;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(43, 429);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Date of Birth";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // StylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_day_of_birth);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_middle_name);
            this.Controls.Add(this.txt_first_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StylistForm";
            this.Padding = new System.Windows.Forms.Padding(40, 64, 40, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STYLIST INFORMATION";
            this.Load += new System.EventHandler(this.StylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private System.Windows.Forms.DateTimePicker dtp_day_of_birth;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialTextBox txt_last_name;
        private MaterialSkin.Controls.MaterialTextBox txt_middle_name;
        private MaterialSkin.Controls.MaterialTextBox txt_first_name;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_address;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}