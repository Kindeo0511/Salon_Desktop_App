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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_day_of_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_last_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_first_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contact = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_role = new MaterialSkin.Controls.MaterialComboBox();
            this.chk_show_password = new MaterialSkin.Controls.MaterialCheckbox();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.userTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_account_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_account = new MaterialSkin.Controls.MaterialButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.userTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.tabPage1);
            this.userTabControl.Controls.Add(this.tabPage2);
            this.userTabControl.Depth = 0;
            this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTabControl.Location = new System.Drawing.Point(0, 72);
            this.userTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTabControl.Multiline = true;
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(900, 728);
            this.userTabControl.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.dtp_day_of_birth);
            this.tabPage1.Controls.Add(this.txt_last_name);
            this.tabPage1.Controls.Add(this.txt_middle_name);
            this.tabPage1.Controls.Add(this.txt_first_name);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.txt_contact);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(39, 1001);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 24);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.AnimateReadOnly = false;
            this.txt_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.Depth = 0;
            this.txt_address.HideSelection = true;
            this.txt_address.Hint = "Enter address";
            this.txt_address.Location = new System.Drawing.Point(257, 975);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
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
            this.txt_address.Size = new System.Drawing.Size(500, 150);
            this.txt_address.TabIndex = 19;
            this.txt_address.TabStop = false;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(39, 848);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(119, 24);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Date of Birth:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(46, 710);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(112, 24);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Contact No.:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(50, 558);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 24);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Email:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(50, 402);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(103, 24);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Last Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(50, 248);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(125, 24);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Middle Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(50, 99);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 24);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "First Name:";
            // 
            // dtp_day_of_birth
            // 
            this.dtp_day_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_day_of_birth.Location = new System.Drawing.Point(257, 850);
            this.dtp_day_of_birth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.dtp_day_of_birth.Name = "dtp_day_of_birth";
            this.dtp_day_of_birth.Size = new System.Drawing.Size(500, 22);
            this.dtp_day_of_birth.TabIndex = 5;
            // 
            // txt_last_name
            // 
            this.txt_last_name.AnimateReadOnly = false;
            this.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_last_name.Hint = "Last Name";
            this.txt_last_name.LeadingIcon = null;
            this.txt_last_name.Location = new System.Drawing.Point(257, 391);
            this.txt_last_name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_last_name.MaxLength = 50;
            this.txt_last_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_last_name.Multiline = false;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(500, 50);
            this.txt_last_name.TabIndex = 2;
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
            this.txt_middle_name.Location = new System.Drawing.Point(257, 238);
            this.txt_middle_name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_middle_name.MaxLength = 50;
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_middle_name.Multiline = false;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.Size = new System.Drawing.Size(500, 50);
            this.txt_middle_name.TabIndex = 1;
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
            this.txt_first_name.Location = new System.Drawing.Point(257, 85);
            this.txt_first_name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_first_name.MaxLength = 50;
            this.txt_first_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_first_name.Multiline = false;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(500, 50);
            this.txt_first_name.TabIndex = 0;
            this.txt_first_name.Text = "";
            this.txt_first_name.TrailingIcon = null;
            this.txt_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_name_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(257, 544);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(500, 50);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
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
            this.txt_contact.Location = new System.Drawing.Point(257, 697);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_contact.MaxLength = 11;
            this.txt_contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contact.Multiline = false;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(500, 50);
            this.txt_contact.TabIndex = 3;
            this.txt_contact.Text = "";
            this.txt_contact.TrailingIcon = null;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txt_confirm_password);
            this.tabPage2.Controls.Add(this.txt_password);
            this.tabPage2.Controls.Add(this.btn_account_cancel);
            this.tabPage2.Controls.Add(this.btn_update_account);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.cmb_role);
            this.tabPage2.Controls.Add(this.chk_show_password);
            this.tabPage2.Controls.Add(this.txt_username);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(46, 560);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(170, 24);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Confirm Password:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(46, 399);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(94, 24);
            this.materialLabel10.TabIndex = 16;
            this.materialLabel10.Text = "Password:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(46, 250);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(97, 24);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Username:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(53, 99);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(45, 24);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Role:";
            // 
            // cmb_role
            // 
            this.cmb_role.AutoResize = false;
            this.cmb_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_role.Depth = 0;
            this.cmb_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_role.DropDownHeight = 174;
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.DropDownWidth = 121;
            this.cmb_role.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Hint = "Selecct a role";
            this.cmb_role.IntegralHeight = false;
            this.cmb_role.ItemHeight = 43;
            this.cmb_role.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmb_role.Location = new System.Drawing.Point(257, 85);
            this.cmb_role.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.cmb_role.MaxDropDownItems = 4;
            this.cmb_role.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(500, 49);
            this.cmb_role.StartIndex = -1;
            this.cmb_role.TabIndex = 11;
            // 
            // chk_show_password
            // 
            this.chk_show_password.AutoSize = true;
            this.chk_show_password.BackColor = System.Drawing.SystemColors.Control;
            this.chk_show_password.Depth = 0;
            this.chk_show_password.Location = new System.Drawing.Point(257, 616);
            this.chk_show_password.Margin = new System.Windows.Forms.Padding(0);
            this.chk_show_password.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_show_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_show_password.Name = "chk_show_password";
            this.chk_show_password.ReadOnly = false;
            this.chk_show_password.Ripple = true;
            this.chk_show_password.Size = new System.Drawing.Size(149, 37);
            this.chk_show_password.TabIndex = 10;
            this.chk_show_password.Text = "Show Password";
            this.chk_show_password.UseVisualStyleBackColor = false;
            this.chk_show_password.CheckedChanged += new System.EventHandler(this.chk_show_password_CheckedChanged_1);
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Enter username";
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(257, 237);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(500, 50);
            this.txt_username.TabIndex = 7;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // userTabSelector
            // 
            this.userTabSelector.BaseTabControl = this.userTabControl;
            this.userTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.userTabSelector.Depth = 0;
            this.userTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.userTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userTabSelector.Location = new System.Drawing.Point(0, 24);
            this.userTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTabSelector.Name = "userTabSelector";
            this.userTabSelector.Size = new System.Drawing.Size(900, 48);
            this.userTabSelector.TabIndex = 18;
            this.userTabSelector.Text = "materialTabSelector1";
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(434, 1269);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_save_KeyDown);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(434, 1269);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            this.btn_update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_update_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(680, 1269);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_account_cancel
            // 
            this.btn_account_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_account_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_account_cancel.Depth = 0;
            this.btn_account_cancel.Enabled = false;
            this.btn_account_cancel.HighEmphasis = true;
            this.btn_account_cancel.Icon = null;
            this.btn_account_cancel.Location = new System.Drawing.Point(680, 717);
            this.btn_account_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_account_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_account_cancel.Name = "btn_account_cancel";
            this.btn_account_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_account_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_account_cancel.TabIndex = 26;
            this.btn_account_cancel.Text = "cancel";
            this.btn_account_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_account_cancel.UseAccentColor = false;
            this.btn_account_cancel.UseVisualStyleBackColor = true;
            this.btn_account_cancel.Click += new System.EventHandler(this.btn_account_cancel_Click);
            // 
            // btn_update_account
            // 
            this.btn_update_account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_account.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_account.Depth = 0;
            this.btn_update_account.Enabled = false;
            this.btn_update_account.HighEmphasis = true;
            this.btn_update_account.Icon = null;
            this.btn_update_account.Location = new System.Drawing.Point(466, 717);
            this.btn_update_account.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_account.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_account.Name = "btn_update_account";
            this.btn_update_account.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_account.Size = new System.Drawing.Size(129, 36);
            this.btn_update_account.TabIndex = 25;
            this.btn_update_account.Text = "save changes";
            this.btn_update_account.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_account.UseAccentColor = false;
            this.btn_update_account.UseVisualStyleBackColor = true;
            this.btn_update_account.Click += new System.EventHandler(this.btn_update_account_Click);
            this.btn_update_account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_update_account_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(257, 390);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(500, 22);
            this.txt_password.TabIndex = 27;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Location = new System.Drawing.Point(257, 560);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(500, 22);
            this.txt_confirm_password.TabIndex = 28;
            this.txt_confirm_password.UseSystemPasswordChar = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.userTabControl);
            this.Controls.Add(this.userTabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.userTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabSelector userTabSelector;
        private MaterialSkin.Controls.MaterialTabControl userTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox txt_first_name;
        private MaterialSkin.Controls.MaterialTextBox txt_middle_name;
        private MaterialSkin.Controls.MaterialTextBox txt_last_name;
        private System.Windows.Forms.DateTimePicker dtp_day_of_birth;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCheckbox chk_show_password;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_address;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_role;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_account_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update_account;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.TextBox txt_password;
    }
}