namespace TravelManagement
{
    partial class homepage
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
            this.homepagepanel = new System.Windows.Forms.Panel();
            this.right = new Guna.UI.WinForms.GunaImageButton();
            this.left = new Guna.UI.WinForms.GunaImageButton();
            this.homepagetext = new System.Windows.Forms.Label();
            this.homepagepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepagepanel
            // 
            this.homepagepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homepagepanel.Controls.Add(this.homepagetext);
            this.homepagepanel.Controls.Add(this.right);
            this.homepagepanel.Controls.Add(this.left);
            this.homepagepanel.Location = new System.Drawing.Point(0, 0);
            this.homepagepanel.Name = "homepagepanel";
            this.homepagepanel.Size = new System.Drawing.Size(840, 405);
            this.homepagepanel.TabIndex = 23;
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.BackgroundImage = global::TravelManagement.Properties.Resources.right;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right.DialogResult = System.Windows.Forms.DialogResult.None;
            this.right.Image = null;
            this.right.ImageSize = new System.Drawing.Size(64, 64);
            this.right.Location = new System.Drawing.Point(801, 180);
            this.right.Name = "right";
            this.right.OnHoverImage = null;
            this.right.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.right.Size = new System.Drawing.Size(36, 39);
            this.right.TabIndex = 23;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.BackgroundImage = global::TravelManagement.Properties.Resources.left;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left.DialogResult = System.Windows.Forms.DialogResult.None;
            this.left.Image = null;
            this.left.ImageSize = new System.Drawing.Size(64, 64);
            this.left.Location = new System.Drawing.Point(3, 180);
            this.left.Name = "left";
            this.left.OnHoverImage = null;
            this.left.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.left.Size = new System.Drawing.Size(36, 39);
            this.left.TabIndex = 22;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // homepagetext
            // 
            this.homepagetext.AutoSize = true;
            this.homepagetext.BackColor = System.Drawing.Color.Transparent;
            this.homepagetext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepagetext.Font = new System.Drawing.Font("Playfair Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagetext.ForeColor = System.Drawing.Color.Azure;
            this.homepagetext.Location = new System.Drawing.Point(527, 75);
            this.homepagetext.Name = "homepagetext";
            this.homepagetext.Size = new System.Drawing.Size(410, 64);
            this.homepagetext.TabIndex = 24;
            this.homepagetext.Text = "EXPLORE NEPAL";
            this.homepagetext.Click += new System.EventHandler(this.homepagetext_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homepagepanel);
            this.Name = "homepage";
            this.Size = new System.Drawing.Size(840, 405);
            this.Load += new System.EventHandler(this.homepage_Load_1);
            this.homepagepanel.ResumeLayout(false);
            this.homepagepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homepagepanel;
        private Guna.UI.WinForms.GunaImageButton right;
        private Guna.UI.WinForms.GunaImageButton left;
        private System.Windows.Forms.Label homepagetext;
    }
}
