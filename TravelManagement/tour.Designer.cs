namespace TravelManagement
{
    partial class tour
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
            this.tourimagepanel = new System.Windows.Forms.Panel();
            this.left = new Guna.UI.WinForms.GunaImageButton();
            this.right = new Guna.UI.WinForms.GunaImageButton();
            this.tourtext = new System.Windows.Forms.Label();
            this.tourimagepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourimagepanel
            // 
            this.tourimagepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourimagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tourimagepanel.Controls.Add(this.left);
            this.tourimagepanel.Controls.Add(this.right);
            this.tourimagepanel.Controls.Add(this.tourtext);
            this.tourimagepanel.Location = new System.Drawing.Point(0, 0);
            this.tourimagepanel.Name = "tourimagepanel";
            this.tourimagepanel.Size = new System.Drawing.Size(807, 400);
            this.tourimagepanel.TabIndex = 1;
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
            this.left.TabIndex = 25;
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
            this.right.Location = new System.Drawing.Point(757, 180);
            this.right.Name = "right";
            this.right.OnHoverImage = null;
            this.right.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.right.Size = new System.Drawing.Size(36, 39);
            this.right.TabIndex = 24;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // tourtext
            // 
            this.tourtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourtext.AutoSize = true;
            this.tourtext.BackColor = System.Drawing.Color.Transparent;
            this.tourtext.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourtext.ForeColor = System.Drawing.Color.White;
            this.tourtext.Location = new System.Drawing.Point(239, 111);
            this.tourtext.Name = "tourtext";
            this.tourtext.Size = new System.Drawing.Size(353, 61);
            this.tourtext.TabIndex = 1;
            this.tourtext.Text = "TOUR IN NEPAL";
            // 
            // tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tourimagepanel);
            this.Name = "tour";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.tour_Load);
            this.tourimagepanel.ResumeLayout(false);
            this.tourimagepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tourimagepanel;
        private Guna.UI.WinForms.GunaImageButton left;
        private Guna.UI.WinForms.GunaImageButton right;
        private System.Windows.Forms.Label tourtext;
    }
}
