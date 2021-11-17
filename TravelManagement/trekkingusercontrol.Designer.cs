namespace TravelManagement
{
    partial class trekkingusercontrol
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
            this.trekkinginnepal = new TravelManagement.treakinginnepal();
            this.trekking = new TravelManagement.treaking();
            this.SuspendLayout();
            // 
            // lastpanel
            // 
            this.lastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(755, 207);
            this.lastpanel.TabIndex = 0;
            // 
            // trekkinginnepal
            // 
            this.trekkinginnepal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trekkinginnepal.Location = new System.Drawing.Point(0, 0);
            this.trekkinginnepal.Name = "trekkinginnepal";
            this.trekkinginnepal.Size = new System.Drawing.Size(755, 400);
            this.trekkinginnepal.TabIndex = 1;
            // 
            // trekking
            // 
            this.trekking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trekking.Location = new System.Drawing.Point(0, 0);
            this.trekking.Name = "trekking";
            this.trekking.Size = new System.Drawing.Size(755, 400);
            this.trekking.TabIndex = 2;
            // 
            // trekkingusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.trekking);
            this.Controls.Add(this.trekkinginnepal);
            this.Controls.Add(this.lastpanel);
            this.Name = "trekkingusercontrol";
            this.Size = new System.Drawing.Size(755, 400);
            this.Load += new System.EventHandler(this.trekkingusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private lastpanel lastpanel;
        private treakinginnepal trekkinginnepal;
        private treaking trekking;
    }
}
