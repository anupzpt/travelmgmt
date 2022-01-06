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
            this.special = new TravelManagement.special();
            this.tourlastpanel = new TravelManagement.lastpanel();
            this.specialdetail = new TravelManagement.specialdetail();
            this.lastpanel = new TravelManagement.lastpanel();
            this.SuspendLayout();
            // 
            // special
            // 
            this.special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.special.Location = new System.Drawing.Point(0, 0);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(840, 400);
            this.special.TabIndex = 2;
            // 
            // tourlastpanel
            // 
            this.tourlastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourlastpanel.Location = new System.Drawing.Point(0, 0);
            this.tourlastpanel.Name = "tourlastpanel";
            this.tourlastpanel.Size = new System.Drawing.Size(631, 224);
            this.tourlastpanel.TabIndex = 1;
            // 
            // specialdetail
            // 
            this.specialdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialdetail.Location = new System.Drawing.Point(0, 0);
            this.specialdetail.Name = "specialdetail";
            this.specialdetail.Size = new System.Drawing.Size(631, 400);
            this.specialdetail.TabIndex = 0;
            // 
            // lastpanel
            // 
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(840, 48);
            this.lastpanel.TabIndex = 3;
            // 
            // Specialusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.special);
            this.Controls.Add(this.tourlastpanel);
            this.Controls.Add(this.specialdetail);
            this.Controls.Add(this.lastpanel);
            this.Name = "Specialusercontrol";
            this.Size = new System.Drawing.Size(806, 383);
            this.Load += new System.EventHandler(this.Specialusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private specialdetail specialdetail;
        private lastpanel tourlastpanel;
        private special special;
        private lastpanel lastpanel;
    }
}
