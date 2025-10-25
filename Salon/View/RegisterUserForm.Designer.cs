namespace Salon.View
{
    partial class RegisterUserForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_customer_type = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_first_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_number = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_last_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmb_customer_type);
            this.flowLayoutPanel1.Controls.Add(this.txt_first_name);
            this.flowLayoutPanel1.Controls.Add(this.txt_last_name);
            this.flowLayoutPanel1.Controls.Add(this.txt_middle_name);
            this.flowLayoutPanel1.Controls.Add(this.txt_number);
            this.flowLayoutPanel1.Controls.Add(this.txt_email);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 540);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cmb_customer_type
            // 
            this.cmb_customer_type.AutoResize = false;
            this.cmb_customer_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_customer_type.Depth = 0;
            this.cmb_customer_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_customer_type.DropDownHeight = 174;
            this.cmb_customer_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer_type.DropDownWidth = 121;
            this.cmb_customer_type.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_customer_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_customer_type.FormattingEnabled = true;
            this.cmb_customer_type.Hint = "Select Customer Type";
            this.cmb_customer_type.IntegralHeight = false;
            this.cmb_customer_type.ItemHeight = 43;
            this.cmb_customer_type.Items.AddRange(new object[] {
            "Registered",
            "Walk-In"});
            this.cmb_customer_type.Location = new System.Drawing.Point(50, 50);
            this.cmb_customer_type.Margin = new System.Windows.Forms.Padding(25);
            this.cmb_customer_type.MaxDropDownItems = 4;
            this.cmb_customer_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_customer_type.Name = "cmb_customer_type";
            this.cmb_customer_type.Size = new System.Drawing.Size(650, 49);
            this.cmb_customer_type.StartIndex = -1;
            this.cmb_customer_type.TabIndex = 0;
            this.cmb_customer_type.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_type_SelectedIndexChanged);
            // 
            // txt_first_name
            // 
            this.txt_first_name.AnimateReadOnly = false;
            this.txt_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_first_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Enabled = false;
            this.txt_first_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_first_name.HideSelection = true;
            this.txt_first_name.Hint = "Enter first name";
            this.txt_first_name.LeadingIcon = null;
            this.txt_first_name.Location = new System.Drawing.Point(50, 149);
            this.txt_first_name.Margin = new System.Windows.Forms.Padding(25);
            this.txt_first_name.MaxLength = 32767;
            this.txt_first_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.PasswordChar = '\0';
            this.txt_first_name.PrefixSuffixText = null;
            this.txt_first_name.ReadOnly = false;
            this.txt_first_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_first_name.SelectedText = "";
            this.txt_first_name.SelectionLength = 0;
            this.txt_first_name.SelectionStart = 0;
            this.txt_first_name.ShortcutsEnabled = true;
            this.txt_first_name.Size = new System.Drawing.Size(300, 48);
            this.txt_first_name.TabIndex = 1;
            this.txt_first_name.TabStop = false;
            this.txt_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_first_name.TrailingIcon = null;
            this.txt_first_name.UseSystemPasswordChar = false;
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_email.Depth = 0;
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.HideSelection = true;
            this.txt_email.Hint = "Enter email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(50, 345);
            this.txt_email.Margin = new System.Windows.Forms.Padding(25);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txt_email.PrefixSuffixText = "@";
            this.txt_email.ReadOnly = false;
            this.txt_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(300, 48);
            this.txt_email.TabIndex = 2;
            this.txt_email.TabStop = false;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.TrailingIcon = null;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.AnimateReadOnly = false;
            this.txt_middle_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_middle_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Enabled = false;
            this.txt_middle_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_middle_name.HideSelection = true;
            this.txt_middle_name.Hint = "Enter middle name";
            this.txt_middle_name.LeadingIcon = null;
            this.txt_middle_name.Location = new System.Drawing.Point(50, 247);
            this.txt_middle_name.Margin = new System.Windows.Forms.Padding(25);
            this.txt_middle_name.MaxLength = 32767;
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.PasswordChar = '\0';
            this.txt_middle_name.PrefixSuffixText = null;
            this.txt_middle_name.ReadOnly = false;
            this.txt_middle_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_middle_name.SelectedText = "";
            this.txt_middle_name.SelectionLength = 0;
            this.txt_middle_name.SelectionStart = 0;
            this.txt_middle_name.ShortcutsEnabled = true;
            this.txt_middle_name.Size = new System.Drawing.Size(300, 48);
            this.txt_middle_name.TabIndex = 3;
            this.txt_middle_name.TabStop = false;
            this.txt_middle_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_middle_name.TrailingIcon = null;
            this.txt_middle_name.UseSystemPasswordChar = false;
            // 
            // txt_number
            // 
            this.txt_number.AnimateReadOnly = false;
            this.txt_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_number.Depth = 0;
            this.txt_number.Enabled = false;
            this.txt_number.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_number.HideSelection = true;
            this.txt_number.Hint = "Enter contact #";
            this.txt_number.LeadingIcon = null;
            this.txt_number.Location = new System.Drawing.Point(400, 247);
            this.txt_number.Margin = new System.Windows.Forms.Padding(25);
            this.txt_number.MaxLength = 32767;
            this.txt_number.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_number.Name = "txt_number";
            this.txt_number.PasswordChar = '\0';
            this.txt_number.PrefixSuffixText = "09";
            this.txt_number.ReadOnly = false;
            this.txt_number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_number.SelectedText = "";
            this.txt_number.SelectionLength = 0;
            this.txt_number.SelectionStart = 0;
            this.txt_number.ShortcutsEnabled = true;
            this.txt_number.Size = new System.Drawing.Size(300, 48);
            this.txt_number.TabIndex = 4;
            this.txt_number.TabStop = false;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_number.TrailingIcon = null;
            this.txt_number.UseSystemPasswordChar = false;
            // 
            // txt_last_name
            // 
            this.txt_last_name.AnimateReadOnly = false;
            this.txt_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_last_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Enabled = false;
            this.txt_last_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_last_name.HideSelection = true;
            this.txt_last_name.Hint = "Enter last name";
            this.txt_last_name.LeadingIcon = null;
            this.txt_last_name.Location = new System.Drawing.Point(400, 149);
            this.txt_last_name.Margin = new System.Windows.Forms.Padding(25);
            this.txt_last_name.MaxLength = 32767;
            this.txt_last_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.PasswordChar = '\0';
            this.txt_last_name.PrefixSuffixText = null;
            this.txt_last_name.ReadOnly = false;
            this.txt_last_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_last_name.SelectedText = "";
            this.txt_last_name.SelectionLength = 0;
            this.txt_last_name.SelectionStart = 0;
            this.txt_last_name.ShortcutsEnabled = true;
            this.txt_last_name.Size = new System.Drawing.Size(300, 48);
            this.txt_last_name.TabIndex = 5;
            this.txt_last_name.TabStop = false;
            this.txt_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_last_name.TrailingIcon = null;
            this.txt_last_name.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 54);
            this.panel1.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(653, 10);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(25, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(539, 10);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 25, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterUserForm";
            this.Padding = new System.Windows.Forms.Padding(20, 40, 20, 20);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterUserForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_customer_type;
        private MaterialSkin.Controls.MaterialTextBox2 txt_first_name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_email;
        private MaterialSkin.Controls.MaterialTextBox2 txt_middle_name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_number;
        private MaterialSkin.Controls.MaterialTextBox2 txt_last_name;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}