namespace TravelManagement
{
    partial class afterloggeduser
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.userlabel = new System.Windows.Forms.Label();
            this.logoutbutton = new Guna.UI.WinForms.GunaButton();
            this.passwordbutton = new Guna.UI.WinForms.GunaButton();
            this.emailbutton = new Guna.UI.WinForms.GunaButton();
            this.profilebutton = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Lavender;
            this.gunaShadowPanel1.Controls.Add(this.userlabel);
            this.gunaShadowPanel1.Controls.Add(this.logoutbutton);
            this.gunaShadowPanel1.Controls.Add(this.passwordbutton);
            this.gunaShadowPanel1.Controls.Add(this.emailbutton);
            this.gunaShadowPanel1.Controls.Add(this.profilebutton);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(288, 307);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(89, 14);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(79, 32);
            this.userlabel.TabIndex = 10;
            this.userlabel.Text = "USER";
            this.userlabel.Click += new System.EventHandler(this.userlabel_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.AnimationHoverSpeed = 0.07F;
            this.logoutbutton.AnimationSpeed = 0.03F;
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutbutton.BorderColor = System.Drawing.Color.Transparent;
            this.logoutbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutbutton.FocusedColor = System.Drawing.Color.Empty;
            this.logoutbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Image = global::TravelManagement.Properties.Resources.logout;
            this.logoutbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutbutton.Location = new System.Drawing.Point(29, 250);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.logoutbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.logoutbutton.OnHoverImage = null;
            this.logoutbutton.OnPressedColor = System.Drawing.Color.Black;
            this.logoutbutton.Radius = 2;
            this.logoutbutton.Size = new System.Drawing.Size(230, 42);
            this.logoutbutton.TabIndex = 9;
            this.logoutbutton.Text = "LOG OUT";
            this.logoutbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // passwordbutton
            // 
            this.passwordbutton.AnimationHoverSpeed = 0.07F;
            this.passwordbutton.AnimationSpeed = 0.03F;
            this.passwordbutton.BackColor = System.Drawing.Color.Transparent;
            this.passwordbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.passwordbutton.BorderColor = System.Drawing.Color.Transparent;
            this.passwordbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.passwordbutton.FocusedColor = System.Drawing.Color.Empty;
            this.passwordbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbutton.ForeColor = System.Drawing.Color.White;
            this.passwordbutton.Image = global::TravelManagement.Properties.Resources.key;
            this.passwordbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.passwordbutton.Location = new System.Drawing.Point(29, 187);
            this.passwordbutton.Name = "passwordbutton";
            this.passwordbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.passwordbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.passwordbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.passwordbutton.OnHoverImage = null;
            this.passwordbutton.OnPressedColor = System.Drawing.Color.Black;
            this.passwordbutton.Radius = 2;
            this.passwordbutton.Size = new System.Drawing.Size(230, 42);
            this.passwordbutton.TabIndex = 8;
            this.passwordbutton.Text = "PASSWORD";
            this.passwordbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordbutton.Click += new System.EventHandler(this.passwordbutton_Click);
            // 
            // emailbutton
            // 
            this.emailbutton.AnimationHoverSpeed = 0.07F;
            this.emailbutton.AnimationSpeed = 0.03F;
            this.emailbutton.BackColor = System.Drawing.Color.Transparent;
            this.emailbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.emailbutton.BorderColor = System.Drawing.Color.Transparent;
            this.emailbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.emailbutton.FocusedColor = System.Drawing.Color.Empty;
            this.emailbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbutton.ForeColor = System.Drawing.Color.White;
            this.emailbutton.Image = global::TravelManagement.Properties.Resources.inbox;
            this.emailbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.emailbutton.Location = new System.Drawing.Point(29, 121);
            this.emailbutton.Name = "emailbutton";
            this.emailbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.emailbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.emailbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.emailbutton.OnHoverImage = null;
            this.emailbutton.OnPressedColor = System.Drawing.Color.Black;
            this.emailbutton.Radius = 2;
            this.emailbutton.Size = new System.Drawing.Size(230, 42);
            this.emailbutton.TabIndex = 7;
            this.emailbutton.Text = "MESSAGE";
            this.emailbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailbutton.Click += new System.EventHandler(this.emailbutton_Click);
            // 
            // profilebutton
            // 
            this.profilebutton.AnimationHoverSpeed = 0.07F;
            this.profilebutton.AnimationSpeed = 0.03F;
            this.profilebutton.BackColor = System.Drawing.Color.Transparent;
            this.profilebutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.profilebutton.BorderColor = System.Drawing.Color.Transparent;
            this.profilebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.profilebutton.FocusedColor = System.Drawing.Color.Empty;
            this.profilebutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebutton.ForeColor = System.Drawing.Color.White;
            this.profilebutton.Image = global::TravelManagement.Properties.Resources.human;
            this.profilebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.profilebutton.Location = new System.Drawing.Point(29, 62);
            this.profilebutton.Name = "profilebutton";
            this.profilebutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.profilebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.profilebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.profilebutton.OnHoverImage = null;
            this.profilebutton.OnPressedColor = System.Drawing.Color.Black;
            this.profilebutton.Radius = 2;
            this.profilebutton.Size = new System.Drawing.Size(230, 42);
            this.profilebutton.TabIndex = 6;
            this.profilebutton.Text = "PROFILE";
            this.profilebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.profilebutton.Click += new System.EventHandler(this.profilebutton_Click);
            // 
            // afterloggeduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "afterloggeduser";
            this.Size = new System.Drawing.Size(288, 307);
            this.Load += new System.EventHandler(this.afterloggeduser_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label userlabel;
        private Guna.UI.WinForms.GunaButton logoutbutton;
        private Guna.UI.WinForms.GunaButton passwordbutton;
        private Guna.UI.WinForms.GunaButton emailbutton;
        private Guna.UI.WinForms.GunaButton profilebutton;
    }
}
