namespace Salon.View
{
    partial class ConfirmationBooking
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
            this.lbl_CustomerName = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Contact = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Email = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Date = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Time = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Services = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_Confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.txt_stylist = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_id = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_another = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AnimateReadOnly = false;
            this.lbl_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_CustomerName.Depth = 0;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_CustomerName.Hint = "Customer Name";
            this.lbl_CustomerName.LeadingIcon = null;
            this.lbl_CustomerName.Location = new System.Drawing.Point(44, 109);
            this.lbl_CustomerName.MaxLength = 50;
            this.lbl_CustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_CustomerName.Multiline = false;
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(400, 50);
            this.lbl_CustomerName.TabIndex = 0;
            this.lbl_CustomerName.Text = "";
            this.lbl_CustomerName.TrailingIcon = null;
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AnimateReadOnly = false;
            this.lbl_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Contact.Depth = 0;
            this.lbl_Contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Contact.Hint = "Contact #";
            this.lbl_Contact.LeadingIcon = null;
            this.lbl_Contact.Location = new System.Drawing.Point(44, 204);
            this.lbl_Contact.MaxLength = 50;
            this.lbl_Contact.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Contact.Multiline = false;
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(400, 50);
            this.lbl_Contact.TabIndex = 1;
            this.lbl_Contact.Text = "";
            this.lbl_Contact.TrailingIcon = null;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AnimateReadOnly = false;
            this.lbl_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Email.Depth = 0;
            this.lbl_Email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Email.Hint = "Email";
            this.lbl_Email.LeadingIcon = null;
            this.lbl_Email.Location = new System.Drawing.Point(44, 306);
            this.lbl_Email.MaxLength = 50;
            this.lbl_Email.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Email.Multiline = false;
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(400, 50);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "";
            this.lbl_Email.TrailingIcon = null;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AnimateReadOnly = false;
            this.lbl_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Date.Depth = 0;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Date.Hint = "Date";
            this.lbl_Date.LeadingIcon = null;
            this.lbl_Date.Location = new System.Drawing.Point(558, 109);
            this.lbl_Date.MaxLength = 50;
            this.lbl_Date.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Date.Multiline = false;
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(400, 50);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "";
            this.lbl_Date.TrailingIcon = null;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AnimateReadOnly = false;
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Time.Depth = 0;
            this.lbl_Time.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Time.Hint = "Time";
            this.lbl_Time.LeadingIcon = null;
            this.lbl_Time.Location = new System.Drawing.Point(558, 204);
            this.lbl_Time.MaxLength = 50;
            this.lbl_Time.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Time.Multiline = false;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(400, 50);
            this.lbl_Time.TabIndex = 5;
            this.lbl_Time.Text = "";
            this.lbl_Time.TrailingIcon = null;
            // 
            // lbl_Services
            // 
            this.lbl_Services.AnimateReadOnly = false;
            this.lbl_Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_Services.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lbl_Services.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Services.Depth = 0;
            this.lbl_Services.HideSelection = true;
            this.lbl_Services.Hint = "Selected Services";
            this.lbl_Services.Location = new System.Drawing.Point(558, 306);
            this.lbl_Services.MaxLength = 32767;
            this.lbl_Services.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Services.Name = "lbl_Services";
            this.lbl_Services.PasswordChar = '\0';
            this.lbl_Services.ReadOnly = false;
            this.lbl_Services.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_Services.SelectedText = "";
            this.lbl_Services.SelectionLength = 0;
            this.lbl_Services.SelectionStart = 0;
            this.lbl_Services.ShortcutsEnabled = true;
            this.lbl_Services.Size = new System.Drawing.Size(400, 138);
            this.lbl_Services.TabIndex = 6;
            this.lbl_Services.TabStop = false;
            this.lbl_Services.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lbl_Services.UseSystemPasswordChar = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Confirm.Depth = 0;
            this.btn_Confirm.HighEmphasis = true;
            this.btn_Confirm.Icon = null;
            this.btn_Confirm.Location = new System.Drawing.Point(498, 524);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "confirm";
            this.btn_Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Confirm.UseAccentColor = false;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(881, 524);
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
            // txt_stylist
            // 
            this.txt_stylist.AnimateReadOnly = false;
            this.txt_stylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stylist.Depth = 0;
            this.txt_stylist.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_stylist.Hint = "Stylist Name";
            this.txt_stylist.LeadingIcon = null;
            this.txt_stylist.Location = new System.Drawing.Point(44, 394);
            this.txt_stylist.MaxLength = 50;
            this.txt_stylist.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_stylist.Multiline = false;
            this.txt_stylist.Name = "txt_stylist";
            this.txt_stylist.Size = new System.Drawing.Size(400, 50);
            this.txt_stylist.TabIndex = 9;
            this.txt_stylist.Text = "";
            this.txt_stylist.TrailingIcon = null;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Depth = 0;
            this.lbl_id.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_id.Location = new System.Drawing.Point(495, 87);
            this.lbl_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(107, 19);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "materialLabel1";
            this.lbl_id.Visible = false;
            // 
            // btn_add_another
            // 
            this.btn_add_another.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_another.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_another.Depth = 0;
            this.btn_add_another.HighEmphasis = true;
            this.btn_add_another.Icon = null;
            this.btn_add_another.Location = new System.Drawing.Point(621, 524);
            this.btn_add_another.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_another.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_another.Name = "btn_add_another";
            this.btn_add_another.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_another.Size = new System.Drawing.Size(224, 36);
            this.btn_add_another.TabIndex = 11;
            this.btn_add_another.Text = "confirm and add another";
            this.btn_add_another.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_another.UseAccentColor = false;
            this.btn_add_another.UseVisualStyleBackColor = true;
            this.btn_add_another.Click += new System.EventHandler(this.btn_add_another_Click);
            // 
            // ConfirmationBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_add_another);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_stylist);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Services);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.lbl_CustomerName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmationBooking";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUMMARY BOOKING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox lbl_CustomerName;
        private MaterialSkin.Controls.MaterialTextBox lbl_Contact;
        private MaterialSkin.Controls.MaterialTextBox lbl_Email;
        private MaterialSkin.Controls.MaterialTextBox lbl_Date;
        private MaterialSkin.Controls.MaterialTextBox lbl_Time;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 lbl_Services;
        private MaterialSkin.Controls.MaterialButton btn_Confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialTextBox txt_stylist;
        private MaterialSkin.Controls.MaterialLabel lbl_id;
        private MaterialSkin.Controls.MaterialButton btn_add_another;
    }
}