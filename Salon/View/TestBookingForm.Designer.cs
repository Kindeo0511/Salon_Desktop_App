namespace Salon.View
{
    partial class TestBookingForm
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
            this.txt_search = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.AnimateReadOnly = false;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Depth = 0;
            this.txt_search.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.Hint = "Search...";
            this.txt_search.LeadingIcon = null;
            this.txt_search.Location = new System.Drawing.Point(98, 97);
            this.txt_search.MaxLength = 50;
            this.txt_search.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(632, 50);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "";
            this.txt_search.TrailingIcon = null;
            // 
            // TestBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_search);
            this.Name = "TestBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_search;
    }
}