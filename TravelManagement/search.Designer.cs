namespace TravelManagement
{
    partial class search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.findyourdestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BackgroundImage = global::TravelManagement.Properties.Resources.Untitled_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.findyourdestination);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 205);
            this.panel1.TabIndex = 1;
            // 
            // findyourdestination
            // 
            this.findyourdestination.AutoSize = true;
            this.findyourdestination.BackColor = System.Drawing.Color.Transparent;
            this.findyourdestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findyourdestination.Font = new System.Drawing.Font("Playfair Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findyourdestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.findyourdestination.Location = new System.Drawing.Point(348, 30);
            this.findyourdestination.Name = "findyourdestination";
            this.findyourdestination.Size = new System.Drawing.Size(676, 64);
            this.findyourdestination.TabIndex = 6;
            this.findyourdestination.Text = "WELCOME TO TRAVEL.COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(422, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "ENJOY YOUR TRAVEL WITH US";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "search";
            this.Size = new System.Drawing.Size(840, 205);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label findyourdestination;
        private System.Windows.Forms.Label label1;
    }
}
