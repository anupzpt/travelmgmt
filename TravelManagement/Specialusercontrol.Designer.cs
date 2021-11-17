namespace TravelManagement
{
    partial class Specialusercontrol
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
            this.specialdetail = new TravelManagement.specialdetail();
            this.lastpanel = new TravelManagement.lastpanel();
            this.special = new TravelManagement.special();
            this.SuspendLayout();
            // 
            // specialdetail
            // 
            this.specialdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialdetail.Location = new System.Drawing.Point(0, 0);
            this.specialdetail.Name = "specialdetail";
            this.specialdetail.Size = new System.Drawing.Size(823, 400);
            this.specialdetail.TabIndex = 0;
            // 
            // lastpanel
            // 
            this.lastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(823, 224);
            this.lastpanel.TabIndex = 1;
            // 
            // special
            // 
            this.special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.special.Location = new System.Drawing.Point(0, 0);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(823, 400);
            this.special.TabIndex = 2;
            // 
            // Specialusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.special);
            this.Controls.Add(this.lastpanel);
            this.Controls.Add(this.specialdetail);
            this.Name = "Specialusercontrol";
            this.Size = new System.Drawing.Size(823, 400);
            this.Load += new System.EventHandler(this.Specialusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private specialdetail specialdetail;
        private lastpanel lastpanel;
        private special special;
    }
}
