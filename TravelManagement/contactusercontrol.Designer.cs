namespace TravelManagement
{
    partial class contactusercontrol
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
            this.lastpanel = new TravelManagement.lastpanel();
            this.contactusdetail = new TravelManagement.Contactusdetail();
            this.contactus = new TravelManagement.Contactus();
            this.SuspendLayout();
            // 
            // lastpanel
            // 
            this.lastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(653, 207);
            this.lastpanel.TabIndex = 0;
            // 
            // contactusdetail
            // 
            this.contactusdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactusdetail.Location = new System.Drawing.Point(0, 0);
            this.contactusdetail.Name = "contactusdetail";
            this.contactusdetail.Size = new System.Drawing.Size(653, 450);
            this.contactusdetail.TabIndex = 1;
            // 
            // contactus
            // 
            this.contactus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactus.Location = new System.Drawing.Point(0, 0);
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(653, 400);
            this.contactus.TabIndex = 2;
            // 
            // contactusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.contactus);
            this.Controls.Add(this.contactusdetail);
            this.Controls.Add(this.lastpanel);
            this.Name = "contactusercontrol";
            this.Size = new System.Drawing.Size(653, 403);
            this.Load += new System.EventHandler(this.contactusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private lastpanel lastpanel;
        private Contactusdetail contactusdetail;
        private Contactus contactus;
    }
}
