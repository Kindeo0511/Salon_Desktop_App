namespace Salon.Util
{
    partial class PaginationControl
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
            this.lbl_current_pages = new MaterialSkin.Controls.MaterialLabel();
            this.btn_last = new MaterialSkin.Controls.MaterialButton();
            this.btn_next = new MaterialSkin.Controls.MaterialButton();
            this.btn_prev = new MaterialSkin.Controls.MaterialButton();
            this.btn_first = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_current_pages
            // 
            this.lbl_current_pages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_current_pages.AutoSize = true;
            this.lbl_current_pages.Depth = 0;
            this.lbl_current_pages.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_current_pages.Location = new System.Drawing.Point(177, 16);
            this.lbl_current_pages.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_current_pages.Name = "lbl_current_pages";
            this.lbl_current_pages.Size = new System.Drawing.Size(26, 19);
            this.lbl_current_pages.TabIndex = 4;
            this.lbl_current_pages.Text = "1/1";
            // 
            // btn_last
            // 
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_last.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_last.Depth = 0;
            this.btn_last.HighEmphasis = true;
            this.btn_last.Icon = null;
            this.btn_last.Location = new System.Drawing.Point(318, 6);
            this.btn_last.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_last.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_last.Name = "btn_last";
            this.btn_last.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_last.Size = new System.Drawing.Size(64, 36);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = "last";
            this.btn_last.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_last.UseAccentColor = false;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_next.Depth = 0;
            this.btn_next.HighEmphasis = true;
            this.btn_next.Icon = null;
            this.btn_next.Location = new System.Drawing.Point(246, 6);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_next.Size = new System.Drawing.Size(64, 36);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "next";
            this.btn_next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_next.UseAccentColor = false;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_prev.Depth = 0;
            this.btn_prev.Enabled = false;
            this.btn_prev.HighEmphasis = true;
            this.btn_prev.Icon = null;
            this.btn_prev.Location = new System.Drawing.Point(76, 6);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_prev.Size = new System.Drawing.Size(64, 36);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "Prev";
            this.btn_prev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_prev.UseAccentColor = false;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_first.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_first.Depth = 0;
            this.btn_first.Enabled = false;
            this.btn_first.HighEmphasis = true;
            this.btn_first.Icon = null;
            this.btn_first.Location = new System.Drawing.Point(4, 6);
            this.btn_first.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_first.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_first.Name = "btn_first";
            this.btn_first.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_first.Size = new System.Drawing.Size(64, 36);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "First";
            this.btn_first.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_first.UseAccentColor = false;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // PaginationControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbl_current_pages);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "PaginationControl";
            this.Size = new System.Drawing.Size(388, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_current_pages;
        private MaterialSkin.Controls.MaterialButton btn_last;
        private MaterialSkin.Controls.MaterialButton btn_next;
        private MaterialSkin.Controls.MaterialButton btn_prev;
        private MaterialSkin.Controls.MaterialButton btn_first;
    }
}
