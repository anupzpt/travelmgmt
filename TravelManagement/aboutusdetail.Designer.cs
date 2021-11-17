namespace TravelManagement
{
    partial class aboutusdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutusdetail));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.imagepanel = new System.Windows.Forms.Panel();
            this.aboutustext = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.imagepanel);
            this.gunaShadowPanel1.Controls.Add(this.aboutustext);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(49, 17);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(748, 389);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // imagepanel
            // 
            this.imagepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagepanel.BackgroundImage = global::TravelManagement.Properties.Resources.team;
            this.imagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagepanel.Location = new System.Drawing.Point(266, 8);
            this.imagepanel.Name = "imagepanel";
            this.imagepanel.Size = new System.Drawing.Size(469, 372);
            this.imagepanel.TabIndex = 3;
            // 
            // aboutustext
            // 
            this.aboutustext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutustext.AutoSize = true;
            this.aboutustext.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutustext.Location = new System.Drawing.Point(12, 55);
            this.aboutustext.Name = "aboutustext";
            this.aboutustext.Size = new System.Drawing.Size(718, 286);
            this.aboutustext.TabIndex = 2;
            this.aboutustext.Text = resources.GetString("aboutustext.Text");
            // 
            // aboutusdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "aboutusdetail";
            this.Size = new System.Drawing.Size(840, 430);
            this.Load += new System.EventHandler(this.aboutusdetail_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel imagepanel;
        private System.Windows.Forms.Label aboutustext;
    }
}
