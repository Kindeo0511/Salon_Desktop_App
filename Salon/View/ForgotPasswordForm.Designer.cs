namespace Salon.View
{
    partial class ForgotPasswordForm
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
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_email = new MaterialSkin.Controls.MaterialLabel();
            this.g_step_1 = new System.Windows.Forms.GroupBox();
            this.lbl_number = new MaterialSkin.Controls.MaterialLabel();
            this.txt_number = new MaterialSkin.Controls.MaterialTextBox();
            this.rad_email = new MaterialSkin.Controls.MaterialRadioButton();
            this.rad_sms = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.g_step_3 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_confirm_password = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_reset = new MaterialSkin.Controls.MaterialButton();
            this.btn_back_to_step_1 = new MaterialSkin.Controls.MaterialButton();
            this.g_step_2 = new System.Windows.Forms.GroupBox();
            this.txt_count_down = new MaterialSkin.Controls.MaterialLabel();
            this.send_otp = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_otp = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_next = new MaterialSkin.Controls.MaterialButton();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_back_to_step_2 = new MaterialSkin.Controls.MaterialButton();
            this.forgotPasswordTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.otp_timer = new System.Windows.Forms.Timer(this.components);
            this.chk_show_password = new MaterialSkin.Controls.MaterialCheckbox();
            this.g_step_1.SuspendLayout();
            this.g_step_3.SuspendLayout();
            this.g_step_2.SuspendLayout();
            this.forgotPasswordTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Enter email";
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(79, 175);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(350, 50);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            this.txt_username.Visible = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Depth = 0;
            this.lbl_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_email.Location = new System.Drawing.Point(85, 153);
            this.lbl_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 19);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            this.lbl_email.Visible = false;
            // 
            // g_step_1
            // 
            this.g_step_1.Controls.Add(this.lbl_number);
            this.g_step_1.Controls.Add(this.txt_number);
            this.g_step_1.Controls.Add(this.rad_email);
            this.g_step_1.Controls.Add(this.rad_sms);
            this.g_step_1.Controls.Add(this.materialLabel4);
            this.g_step_1.Controls.Add(this.lbl_email);
            this.g_step_1.Controls.Add(this.txt_username);
            this.g_step_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_step_1.Location = new System.Drawing.Point(6, 47);
            this.g_step_1.Name = "g_step_1";
            this.g_step_1.Size = new System.Drawing.Size(677, 300);
            this.g_step_1.TabIndex = 4;
            this.g_step_1.TabStop = false;
            this.g_step_1.Text = "FORGOT PASSWORD     (STEP 1)";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Depth = 0;
            this.lbl_number.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_number.Location = new System.Drawing.Point(85, 153);
            this.lbl_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(120, 19);
            this.lbl_number.TabIndex = 7;
            this.lbl_number.Text = "Contact Number:";
            this.lbl_number.Visible = false;
            // 
            // txt_number
            // 
            this.txt_number.AnimateReadOnly = false;
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_number.Depth = 0;
            this.txt_number.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_number.Hint = "Enter contact number";
            this.txt_number.LeadingIcon = null;
            this.txt_number.Location = new System.Drawing.Point(79, 175);
            this.txt_number.MaxLength = 11;
            this.txt_number.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_number.Multiline = false;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(350, 50);
            this.txt_number.TabIndex = 6;
            this.txt_number.Text = "";
            this.txt_number.TrailingIcon = null;
            this.txt_number.Visible = false;
            // 
            // rad_email
            // 
            this.rad_email.AutoSize = true;
            this.rad_email.Depth = 0;
            this.rad_email.Location = new System.Drawing.Point(216, 94);
            this.rad_email.Margin = new System.Windows.Forms.Padding(0);
            this.rad_email.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_email.Name = "rad_email";
            this.rad_email.Ripple = true;
            this.rad_email.Size = new System.Drawing.Size(75, 37);
            this.rad_email.TabIndex = 5;
            this.rad_email.TabStop = true;
            this.rad_email.Text = "Email";
            this.rad_email.UseVisualStyleBackColor = true;
            this.rad_email.CheckedChanged += new System.EventHandler(this.rad_email_CheckedChanged);
            // 
            // rad_sms
            // 
            this.rad_sms.AutoSize = true;
            this.rad_sms.Depth = 0;
            this.rad_sms.Location = new System.Drawing.Point(88, 94);
            this.rad_sms.Margin = new System.Windows.Forms.Padding(0);
            this.rad_sms.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rad_sms.MouseState = MaterialSkin.MouseState.HOVER;
            this.rad_sms.Name = "rad_sms";
            this.rad_sms.Ripple = true;
            this.rad_sms.Size = new System.Drawing.Size(69, 37);
            this.rad_sms.TabIndex = 4;
            this.rad_sms.TabStop = true;
            this.rad_sms.Text = "SMS";
            this.rad_sms.UseVisualStyleBackColor = true;
            this.rad_sms.CheckedChanged += new System.EventHandler(this.rad_sms_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(29, 36);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(151, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Choose OTP Method:";
            // 
            // g_step_3
            // 
            this.g_step_3.AccessibleDescription = "";
            this.g_step_3.Controls.Add(this.chk_show_password);
            this.g_step_3.Controls.Add(this.materialLabel3);
            this.g_step_3.Controls.Add(this.txt_confirm_password);
            this.g_step_3.Controls.Add(this.materialLabel2);
            this.g_step_3.Controls.Add(this.txt_password);
            this.g_step_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_step_3.Location = new System.Drawing.Point(6, 47);
            this.g_step_3.Name = "g_step_3";
            this.g_step_3.Size = new System.Drawing.Size(677, 300);
            this.g_step_3.TabIndex = 5;
            this.g_step_3.TabStop = false;
            this.g_step_3.Text = "FORGOT PASSWORD     (STEP 3)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(66, 143);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Confirm Password:";
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.AnimateReadOnly = false;
            this.txt_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_password.Depth = 0;
            this.txt_confirm_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirm_password.Hint = "Enter confirm password";
            this.txt_confirm_password.LeadingIcon = null;
            this.txt_confirm_password.Location = new System.Drawing.Point(69, 165);
            this.txt_confirm_password.MaxLength = 50;
            this.txt_confirm_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_confirm_password.Multiline = false;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(350, 50);
            this.txt_confirm_password.TabIndex = 2;
            this.txt_confirm_password.Text = "";
            this.txt_confirm_password.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(66, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "New Password:";
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Hint = "Enter new password";
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(69, 75);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(350, 50);
            this.txt_password.TabIndex = 0;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reset.Depth = 0;
            this.btn_reset.HighEmphasis = true;
            this.btn_reset.Icon = null;
            this.btn_reset.Location = new System.Drawing.Point(503, 351);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reset.Size = new System.Drawing.Size(65, 36);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "reset";
            this.btn_reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reset.UseAccentColor = false;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back_to_step_1
            // 
            this.btn_back_to_step_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back_to_step_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_to_step_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back_to_step_1.Depth = 0;
            this.btn_back_to_step_1.HighEmphasis = true;
            this.btn_back_to_step_1.Icon = null;
            this.btn_back_to_step_1.Location = new System.Drawing.Point(356, 346);
            this.btn_back_to_step_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_back_to_step_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back_to_step_1.Name = "btn_back_to_step_1";
            this.btn_back_to_step_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back_to_step_1.Size = new System.Drawing.Size(64, 36);
            this.btn_back_to_step_1.TabIndex = 6;
            this.btn_back_to_step_1.Text = "back";
            this.btn_back_to_step_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back_to_step_1.UseAccentColor = false;
            this.btn_back_to_step_1.UseVisualStyleBackColor = true;
            this.btn_back_to_step_1.Click += new System.EventHandler(this.btn_back_to_step_1_Click);
            // 
            // g_step_2
            // 
            this.g_step_2.AccessibleDescription = "";
            this.g_step_2.Controls.Add(this.txt_count_down);
            this.g_step_2.Controls.Add(this.send_otp);
            this.g_step_2.Controls.Add(this.materialLabel6);
            this.g_step_2.Controls.Add(this.txt_otp);
            this.g_step_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_step_2.Location = new System.Drawing.Point(6, 47);
            this.g_step_2.Name = "g_step_2";
            this.g_step_2.Size = new System.Drawing.Size(677, 300);
            this.g_step_2.TabIndex = 7;
            this.g_step_2.TabStop = false;
            this.g_step_2.Text = "FORGOT PASSWORD     (STEP 2)";
            // 
            // txt_count_down
            // 
            this.txt_count_down.AutoSize = true;
            this.txt_count_down.Depth = 0;
            this.txt_count_down.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_count_down.Location = new System.Drawing.Point(76, 191);
            this.txt_count_down.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_count_down.Name = "txt_count_down";
            this.txt_count_down.Size = new System.Drawing.Size(32, 19);
            this.txt_count_down.TabIndex = 10;
            this.txt_count_down.Text = "0.00";
            // 
            // send_otp
            // 
            this.send_otp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.send_otp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_otp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.send_otp.Depth = 0;
            this.send_otp.Enabled = false;
            this.send_otp.HighEmphasis = true;
            this.send_otp.Icon = null;
            this.send_otp.Location = new System.Drawing.Point(79, 216);
            this.send_otp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.send_otp.MouseState = MaterialSkin.MouseState.HOVER;
            this.send_otp.Name = "send_otp";
            this.send_otp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.send_otp.Size = new System.Drawing.Size(107, 36);
            this.send_otp.TabIndex = 9;
            this.send_otp.Text = "send again";
            this.send_otp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.send_otp.UseAccentColor = false;
            this.send_otp.UseVisualStyleBackColor = true;
            this.send_otp.Click += new System.EventHandler(this.send_otp_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(76, 97);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Verify OTP:";
            // 
            // txt_otp
            // 
            this.txt_otp.AnimateReadOnly = false;
            this.txt_otp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_otp.Depth = 0;
            this.txt_otp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_otp.Hint = "Enter otp";
            this.txt_otp.LeadingIcon = null;
            this.txt_otp.Location = new System.Drawing.Point(79, 119);
            this.txt_otp.MaxLength = 6;
            this.txt_otp.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_otp.Multiline = false;
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.Size = new System.Drawing.Size(350, 50);
            this.txt_otp.TabIndex = 0;
            this.txt_otp.Text = "";
            this.txt_otp.TrailingIcon = null;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(368, 383);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_next
            // 
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_next.Depth = 0;
            this.btn_next.HighEmphasis = true;
            this.btn_next.Icon = null;
            this.btn_next.Location = new System.Drawing.Point(514, 383);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_next.Size = new System.Drawing.Size(64, 36);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_next.UseAccentColor = false;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(490, 346);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back_to_step_2
            // 
            this.btn_back_to_step_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back_to_step_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_to_step_2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back_to_step_2.Depth = 0;
            this.btn_back_to_step_2.HighEmphasis = true;
            this.btn_back_to_step_2.Icon = null;
            this.btn_back_to_step_2.Location = new System.Drawing.Point(361, 351);
            this.btn_back_to_step_2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_back_to_step_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back_to_step_2.Name = "btn_back_to_step_2";
            this.btn_back_to_step_2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back_to_step_2.Size = new System.Drawing.Size(64, 36);
            this.btn_back_to_step_2.TabIndex = 9;
            this.btn_back_to_step_2.Text = "back";
            this.btn_back_to_step_2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back_to_step_2.UseAccentColor = false;
            this.btn_back_to_step_2.UseVisualStyleBackColor = true;
            this.btn_back_to_step_2.Click += new System.EventHandler(this.btn_back_to_step_2_Click);
            // 
            // forgotPasswordTabControl
            // 
            this.forgotPasswordTabControl.Controls.Add(this.tabPage1);
            this.forgotPasswordTabControl.Controls.Add(this.tabPage2);
            this.forgotPasswordTabControl.Controls.Add(this.tabPage3);
            this.forgotPasswordTabControl.Depth = 0;
            this.forgotPasswordTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPasswordTabControl.Location = new System.Drawing.Point(3, 48);
            this.forgotPasswordTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.forgotPasswordTabControl.Multiline = true;
            this.forgotPasswordTabControl.Name = "forgotPasswordTabControl";
            this.forgotPasswordTabControl.SelectedIndex = 0;
            this.forgotPasswordTabControl.Size = new System.Drawing.Size(697, 549);
            this.forgotPasswordTabControl.TabIndex = 10;
            this.forgotPasswordTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.forgotPasswordTabControl_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.g_step_1);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.btn_next);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STEP 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.g_step_2);
            this.tabPage2.Controls.Add(this.btn_back_to_step_1);
            this.tabPage2.Controls.Add(this.btn_confirm);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "STEP 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_reset);
            this.tabPage3.Controls.Add(this.g_step_3);
            this.tabPage3.Controls.Add(this.btn_back_to_step_2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(689, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "STEP 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.forgotPasswordTabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(697, 48);
            this.materialTabSelector1.TabIndex = 11;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // otp_timer
            // 
            this.otp_timer.Tick += new System.EventHandler(this.otp_timer_Tick);
            // 
            // chk_show_password
            // 
            this.chk_show_password.AutoSize = true;
            this.chk_show_password.Depth = 0;
            this.chk_show_password.Location = new System.Drawing.Point(69, 235);
            this.chk_show_password.Margin = new System.Windows.Forms.Padding(0);
            this.chk_show_password.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_show_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_show_password.Name = "chk_show_password";
            this.chk_show_password.ReadOnly = false;
            this.chk_show_password.Ripple = true;
            this.chk_show_password.Size = new System.Drawing.Size(148, 37);
            this.chk_show_password.TabIndex = 4;
            this.chk_show_password.Text = "Show password";
            this.chk_show_password.UseVisualStyleBackColor = true;
            this.chk_show_password.CheckedChanged += new System.EventHandler(this.chk_show_password_CheckedChanged);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.forgotPasswordTabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.g_step_1.ResumeLayout(false);
            this.g_step_1.PerformLayout();
            this.g_step_3.ResumeLayout(false);
            this.g_step_3.PerformLayout();
            this.g_step_2.ResumeLayout(false);
            this.g_step_2.PerformLayout();
            this.forgotPasswordTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialLabel lbl_email;
        private System.Windows.Forms.GroupBox g_step_1;
        private System.Windows.Forms.GroupBox g_step_3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_confirm_password;
        private MaterialSkin.Controls.MaterialButton btn_reset;
        private MaterialSkin.Controls.MaterialButton btn_back_to_step_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox g_step_2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_otp;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_next;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_back_to_step_2;
        private MaterialSkin.Controls.MaterialTabControl forgotPasswordTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRadioButton rad_sms;
        private MaterialSkin.Controls.MaterialRadioButton rad_email;
        private MaterialSkin.Controls.MaterialTextBox txt_number;
        private MaterialSkin.Controls.MaterialLabel lbl_number;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialButton send_otp;
        private MaterialSkin.Controls.MaterialLabel txt_count_down;
        private System.Windows.Forms.Timer otp_timer;
        private MaterialSkin.Controls.MaterialCheckbox chk_show_password;
    }
}