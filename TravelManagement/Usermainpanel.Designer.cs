namespace TravelManagement
{
    partial class Usermainpanel
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
            this.components = new System.ComponentModel.Container();
            this.backpanel = new System.Windows.Forms.Panel();
            this.Refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.logout = new TravelManagement.logout();
            this.changepassword = new TravelManagement.changepassword();
            this.sendmessage = new TravelManagement.receiveuser();
            this.profile = new TravelManagement.user();
            this.backpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backpanel
            // 
            this.backpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backpanel.Controls.Add(this.logout);
            this.backpanel.Controls.Add(this.changepassword);
            this.backpanel.Controls.Add(this.sendmessage);
            this.backpanel.Controls.Add(this.profile);
            this.backpanel.Location = new System.Drawing.Point(0, 0);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(857, 450);
            this.backpanel.TabIndex = 0;
            // 
            // Refreshtimer
            // 
            this.Refreshtimer.Tick += new System.EventHandler(this.Refreshtimer_Tick);
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.Location = new System.Drawing.Point(208, 106);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(345, 236);
            this.logout.TabIndex = 3;
            // 
            // changepassword
            // 
            this.changepassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changepassword.Location = new System.Drawing.Point(185, 0);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(396, 415);
            this.changepassword.TabIndex = 2;
            // 
            // sendmessage
            // 
            this.sendmessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendmessage.BackColor = System.Drawing.Color.Lavender;
            this.sendmessage.Location = new System.Drawing.Point(0, 0);
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Size = new System.Drawing.Size(854, 450);
            this.sendmessage.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.Location = new System.Drawing.Point(0, 0);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(838, 450);
            this.profile.TabIndex = 0;
            // 
            // Usermainpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backpanel);
            this.Name = "Usermainpanel";
            this.Size = new System.Drawing.Size(857, 450);
            this.Load += new System.EventHandler(this.Usermainpanel_Load);
            this.backpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backpanel;
        private user profile;
        private receiveuser sendmessage;
        private changepassword changepassword;
        private logout logout;
        private System.Windows.Forms.Timer Refreshtimer;
    }
}
