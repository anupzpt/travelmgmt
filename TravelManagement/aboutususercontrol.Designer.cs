namespace TravelManagement
{
    partial class aboutususercontrol
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
            this.aboutus = new TravelManagement.Aboutus();
            this.aboutusdetail = new TravelManagement.aboutusdetail();
            this.lastpanel = new TravelManagement.lastpanel();
            this.SuspendLayout();
            // 
            // aboutus
            // 
            this.aboutus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutus.Location = new System.Drawing.Point(0, 0);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(704, 400);
            this.aboutus.TabIndex = 2;
            // 
            // aboutusdetail
            // 
            this.aboutusdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutusdetail.Location = new System.Drawing.Point(0, 0);
            this.aboutusdetail.Name = "aboutusdetail";
            this.aboutusdetail.Size = new System.Drawing.Size(704, 430);
            this.aboutusdetail.TabIndex = 1;
            // 
            // lastpanel
            // 
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(704, 48);
            this.lastpanel.TabIndex = 3;
            // 
            // aboutususercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.aboutus);
            this.Controls.Add(this.aboutusdetail);
            this.Controls.Add(this.lastpanel);
            this.Name = "aboutususercontrol";
            this.Size = new System.Drawing.Size(704, 383);
            this.Load += new System.EventHandler(this.aboutususercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private aboutusdetail aboutusdetail;
        private Aboutus aboutus;
        private lastpanel lastpanel;
    }
}
