namespace TravelManagement
{
    partial class mandaladesign
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
            this.designpanel = new System.Windows.Forms.Panel();
            this.Crossbutton = new System.Windows.Forms.Button();
            this.designpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // designpanel
            // 
            this.designpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.designpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.designpanel.Controls.Add(this.Crossbutton);
            this.designpanel.Location = new System.Drawing.Point(0, 0);
            this.designpanel.Name = "designpanel";
            this.designpanel.Size = new System.Drawing.Size(900, 471);
            this.designpanel.TabIndex = 2;
            // 
            // Crossbutton
            // 
            this.Crossbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Crossbutton.BackColor = System.Drawing.Color.Transparent;
            this.Crossbutton.BackgroundImage = global::TravelManagement.Properties.Resources.left_52px;
            this.Crossbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crossbutton.FlatAppearance.BorderSize = 0;
            this.Crossbutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crossbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.Crossbutton.Location = new System.Drawing.Point(423, 208);
            this.Crossbutton.Name = "Crossbutton";
            this.Crossbutton.Size = new System.Drawing.Size(55, 54);
            this.Crossbutton.TabIndex = 19;
            this.Crossbutton.UseVisualStyleBackColor = false;
            // 
            // mandaladesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.designpanel);
            this.Name = "mandaladesign";
            this.Size = new System.Drawing.Size(900, 471);
            this.designpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designpanel;
        private System.Windows.Forms.Button Crossbutton;
    }
}
