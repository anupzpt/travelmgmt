namespace TravelManagement
{
    partial class Aboutus
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
            this.aboutuspanel = new System.Windows.Forms.Panel();
            this.aboutustext = new System.Windows.Forms.Label();
            this.aboutuspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutuspanel
            // 
            this.aboutuspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutuspanel.BackgroundImage = global::TravelManagement.Properties.Resources.balaji_srinivasan_Q_MPJF7MbAI_unsplash;
            this.aboutuspanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutuspanel.Controls.Add(this.aboutustext);
            this.aboutuspanel.Location = new System.Drawing.Point(0, 0);
            this.aboutuspanel.Name = "aboutuspanel";
            this.aboutuspanel.Size = new System.Drawing.Size(840, 400);
            this.aboutuspanel.TabIndex = 1;
            // 
            // aboutustext
            // 
            this.aboutustext.AutoSize = true;
            this.aboutustext.BackColor = System.Drawing.Color.Transparent;
            this.aboutustext.Font = new System.Drawing.Font("Franklin Gothic Demi", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutustext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutustext.Location = new System.Drawing.Point(311, 62);
            this.aboutustext.Name = "aboutustext";
            this.aboutustext.Size = new System.Drawing.Size(237, 54);
            this.aboutustext.TabIndex = 0;
            this.aboutustext.Text = "ABOUT US";
            // 
            // Aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aboutuspanel);
            this.Name = "Aboutus";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.Aboutus_Load);
            this.aboutuspanel.ResumeLayout(false);
            this.aboutuspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutuspanel;
        private System.Windows.Forms.Label aboutustext;
    }
}
