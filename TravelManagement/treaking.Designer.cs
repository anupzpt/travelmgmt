namespace TravelManagement
{
    partial class treaking
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
            this.trekimagepanel = new System.Windows.Forms.Panel();
            this.trektext = new System.Windows.Forms.Label();
            this.left = new Guna.UI.WinForms.GunaImageButton();
            this.right = new Guna.UI.WinForms.GunaImageButton();
            this.trekimagepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trekimagepanel
            // 
            this.trekimagepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trekimagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trekimagepanel.Controls.Add(this.trektext);
            this.trekimagepanel.Controls.Add(this.left);
            this.trekimagepanel.Controls.Add(this.right);
            this.trekimagepanel.Location = new System.Drawing.Point(0, 0);
            this.trekimagepanel.Name = "trekimagepanel";
            this.trekimagepanel.Size = new System.Drawing.Size(840, 400);
            this.trekimagepanel.TabIndex = 4;
            // 
            // trektext
            // 
            this.trektext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trektext.AutoSize = true;
            this.trektext.BackColor = System.Drawing.Color.Transparent;
            this.trektext.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trektext.ForeColor = System.Drawing.Color.White;
            this.trektext.Location = new System.Drawing.Point(244, 170);
            this.trektext.Name = "trektext";
            this.trektext.Size = new System.Drawing.Size(454, 61);
            this.trektext.TabIndex = 28;
            this.trektext.Text = "TREKKING IN NEPAL";
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
            this.left.TabIndex = 27;
            this.left.Click += new System.EventHandler(this.left_Click);
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
            this.right.Location = new System.Drawing.Point(790, 180);
            this.right.Name = "right";
            this.right.OnHoverImage = null;
            this.right.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.right.Size = new System.Drawing.Size(36, 39);
            this.right.TabIndex = 26;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // treaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trekimagepanel);
            this.Name = "treaking";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.treaking_Load);
            this.trekimagepanel.ResumeLayout(false);
            this.trekimagepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trekimagepanel;
        private System.Windows.Forms.Label trektext;
        private Guna.UI.WinForms.GunaImageButton left;
        private Guna.UI.WinForms.GunaImageButton right;
    }
}
