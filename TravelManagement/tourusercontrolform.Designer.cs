namespace TravelManagement
{
    partial class tourusercontrolform
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
            this.tour = new TravelManagement.tour();
            this.tourinnepal = new TravelManagement.tourinnepal();
            this.tourlastpanel = new TravelManagement.lastpanel();
            this.SuspendLayout();
            // 
            // tour
            // 
            this.tour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tour.Location = new System.Drawing.Point(0, 0);
            this.tour.Name = "tour";
            this.tour.Size = new System.Drawing.Size(806, 400);
            this.tour.TabIndex = 2;
            // 
            // tourinnepal
            // 
            this.tourinnepal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourinnepal.Location = new System.Drawing.Point(0, 0);
            this.tourinnepal.Name = "tourinnepal";
            this.tourinnepal.Size = new System.Drawing.Size(806, 400);
            this.tourinnepal.TabIndex = 3;
            // 
            // tourlastpanel
            // 
            this.tourlastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourlastpanel.Location = new System.Drawing.Point(0, 0);
            this.tourlastpanel.Name = "tourlastpanel";
            this.tourlastpanel.Size = new System.Drawing.Size(806, 207);
            this.tourlastpanel.TabIndex = 4;
            // 
            // tourusercontrolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tourinnepal);
            this.Controls.Add(this.tour);
            this.Controls.Add(this.tourlastpanel);
            this.Name = "tourusercontrolform";
            this.Size = new System.Drawing.Size(806, 400);
            this.Load += new System.EventHandler(this.tourusercontrolform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private tour tour;
        private tourinnepal tourinnepal;
        private lastpanel tourlastpanel;
    }
}
