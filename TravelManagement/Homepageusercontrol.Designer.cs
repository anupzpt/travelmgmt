namespace TravelManagement
{
    partial class Homepageusercontrol
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
            this.homepage = new TravelManagement.homepage();
            this.hiking = new TravelManagement.hiking();
            this.explorenepal = new TravelManagement.explorenepal();
            this.search = new TravelManagement.search();
            this.lastpanel = new TravelManagement.lastpanel();
            this.lastpanelre = new TravelManagement.lastpanel();
            this.SuspendLayout();
            // 
            // homepage
            // 
            this.homepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepage.Location = new System.Drawing.Point(0, 0);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(933, 400);
            this.homepage.TabIndex = 4;
            // 
            // hiking
            // 
            this.hiking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiking.Location = new System.Drawing.Point(44, 0);
            this.hiking.Name = "hiking";
            this.hiking.Size = new System.Drawing.Size(950, 430);
            this.hiking.TabIndex = 3;
            // 
            // explorenepal
            // 
            this.explorenepal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorenepal.Location = new System.Drawing.Point(44, 0);
            this.explorenepal.Name = "explorenepal";
            this.explorenepal.Size = new System.Drawing.Size(950, 431);
            this.explorenepal.TabIndex = 2;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(44, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(950, 205);
            this.search.TabIndex = 0;
            // 
            // lastpanel
            // 
            this.lastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(783, 200);
            this.lastpanel.TabIndex = 5;
            // 
            // lastpanelre
            // 
            this.lastpanelre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanelre.Location = new System.Drawing.Point(0, 0);
            this.lastpanelre.Name = "lastpanelre";
            this.lastpanelre.Size = new System.Drawing.Size(679, 48);
            this.lastpanelre.TabIndex = 6;
            // 
            // Homepageusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.homepage);
            this.Controls.Add(this.hiking);
            this.Controls.Add(this.explorenepal);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lastpanel);
            this.Controls.Add(this.lastpanelre);
            this.Name = "Homepageusercontrol";
            this.Size = new System.Drawing.Size(670, 349);
            this.Load += new System.EventHandler(this.Homepageusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private search search;
        private explorenepal explorenepal;
        private hiking hiking;
        private homepage homepage;
        private lastpanel lastpanelre;
        private lastpanel lastpanel;
    }
}
