namespace TravelManagement
{
    partial class afterloggedadmin
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.adminlabel = new System.Windows.Forms.Label();
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.modifydetailbutton = new Guna.UI.WinForms.GunaButton();
            this.addadmin = new Guna.UI.WinForms.GunaButton();
            this.logoutbutton = new Guna.UI.WinForms.GunaButton();
            this.passwordbutton = new Guna.UI.WinForms.GunaButton();
            this.emailbutton = new Guna.UI.WinForms.GunaButton();
            this.bookeddatabutton = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Lavender;
            this.gunaShadowPanel1.Controls.Add(this.modifydetailbutton);
            this.gunaShadowPanel1.Controls.Add(this.addadmin);
            this.gunaShadowPanel1.Controls.Add(this.adminlabel);
            this.gunaShadowPanel1.Controls.Add(this.logoutbutton);
            this.gunaShadowPanel1.Controls.Add(this.passwordbutton);
            this.gunaShadowPanel1.Controls.Add(this.emailbutton);
            this.gunaShadowPanel1.Controls.Add(this.bookeddatabutton);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(291, 333);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // adminlabel
            // 
            this.adminlabel.AutoSize = true;
            this.adminlabel.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlabel.Location = new System.Drawing.Point(84, 16);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(98, 32);
            this.adminlabel.TabIndex = 10;
            this.adminlabel.Text = "ADMIN";
            // 
            // refreshtimer
            // 
            this.refreshtimer.Tick += new System.EventHandler(this.refreshtimer_Tick);
            // 
            // modifydetailbutton
            // 
            this.modifydetailbutton.AnimationHoverSpeed = 0.07F;
            this.modifydetailbutton.AnimationSpeed = 0.03F;
            this.modifydetailbutton.BackColor = System.Drawing.Color.Transparent;
            this.modifydetailbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.modifydetailbutton.BorderColor = System.Drawing.Color.Transparent;
            this.modifydetailbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modifydetailbutton.FocusedColor = System.Drawing.Color.Empty;
            this.modifydetailbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifydetailbutton.ForeColor = System.Drawing.Color.White;
            this.modifydetailbutton.Image = global::TravelManagement.Properties.Resources.edit_property_60px;
            this.modifydetailbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.modifydetailbutton.Location = new System.Drawing.Point(30, 56);
            this.modifydetailbutton.Name = "modifydetailbutton";
            this.modifydetailbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.modifydetailbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.modifydetailbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.modifydetailbutton.OnHoverImage = null;
            this.modifydetailbutton.OnPressedColor = System.Drawing.Color.Black;
            this.modifydetailbutton.Radius = 2;
            this.modifydetailbutton.Size = new System.Drawing.Size(230, 33);
            this.modifydetailbutton.TabIndex = 12;
            this.modifydetailbutton.Text = "Modify Detail";
            this.modifydetailbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifydetailbutton.Click += new System.EventHandler(this.modifydetailbutton_Click);
            // 
            // addadmin
            // 
            this.addadmin.AnimationHoverSpeed = 0.07F;
            this.addadmin.AnimationSpeed = 0.03F;
            this.addadmin.BackColor = System.Drawing.Color.Transparent;
            this.addadmin.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.addadmin.BorderColor = System.Drawing.Color.Transparent;
            this.addadmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addadmin.FocusedColor = System.Drawing.Color.Empty;
            this.addadmin.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addadmin.ForeColor = System.Drawing.Color.White;
            this.addadmin.Image = global::TravelManagement.Properties.Resources.addadmin;
            this.addadmin.ImageSize = new System.Drawing.Size(20, 20);
            this.addadmin.Location = new System.Drawing.Point(30, 101);
            this.addadmin.Name = "addadmin";
            this.addadmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addadmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addadmin.OnHoverForeColor = System.Drawing.Color.White;
            this.addadmin.OnHoverImage = null;
            this.addadmin.OnPressedColor = System.Drawing.Color.Black;
            this.addadmin.Radius = 2;
            this.addadmin.Size = new System.Drawing.Size(230, 33);
            this.addadmin.TabIndex = 11;
            this.addadmin.Text = "ADD ADMIN";
            this.addadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addadmin.Click += new System.EventHandler(this.addadmin_Click);
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
            this.logoutbutton.Image = global::TravelManagement.Properties.Resources.logout1;
            this.logoutbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutbutton.Location = new System.Drawing.Point(30, 275);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.logoutbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.logoutbutton.OnHoverImage = null;
            this.logoutbutton.OnPressedColor = System.Drawing.Color.Black;
            this.logoutbutton.Radius = 2;
            this.logoutbutton.Size = new System.Drawing.Size(230, 33);
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
            this.passwordbutton.Image = global::TravelManagement.Properties.Resources.key1;
            this.passwordbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.passwordbutton.Location = new System.Drawing.Point(30, 230);
            this.passwordbutton.Name = "passwordbutton";
            this.passwordbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.passwordbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.passwordbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.passwordbutton.OnHoverImage = null;
            this.passwordbutton.OnPressedColor = System.Drawing.Color.Black;
            this.passwordbutton.Radius = 2;
            this.passwordbutton.Size = new System.Drawing.Size(230, 33);
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
            this.emailbutton.Image = global::TravelManagement.Properties.Resources.send_email_100px1;
            this.emailbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.emailbutton.Location = new System.Drawing.Point(30, 185);
            this.emailbutton.Name = "emailbutton";
            this.emailbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.emailbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.emailbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.emailbutton.OnHoverImage = null;
            this.emailbutton.OnPressedColor = System.Drawing.Color.Black;
            this.emailbutton.Radius = 2;
            this.emailbutton.Size = new System.Drawing.Size(230, 33);
            this.emailbutton.TabIndex = 7;
            this.emailbutton.Text = "EMAIL";
            this.emailbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailbutton.Click += new System.EventHandler(this.emailbutton_Click);
            // 
            // bookeddatabutton
            // 
            this.bookeddatabutton.AnimationHoverSpeed = 0.07F;
            this.bookeddatabutton.AnimationSpeed = 0.03F;
            this.bookeddatabutton.BackColor = System.Drawing.Color.Transparent;
            this.bookeddatabutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.bookeddatabutton.BorderColor = System.Drawing.Color.Transparent;
            this.bookeddatabutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bookeddatabutton.FocusedColor = System.Drawing.Color.Empty;
            this.bookeddatabutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookeddatabutton.ForeColor = System.Drawing.Color.White;
            this.bookeddatabutton.Image = global::TravelManagement.Properties.Resources.booked;
            this.bookeddatabutton.ImageSize = new System.Drawing.Size(20, 20);
            this.bookeddatabutton.Location = new System.Drawing.Point(30, 143);
            this.bookeddatabutton.Name = "bookeddatabutton";
            this.bookeddatabutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bookeddatabutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bookeddatabutton.OnHoverForeColor = System.Drawing.Color.White;
            this.bookeddatabutton.OnHoverImage = null;
            this.bookeddatabutton.OnPressedColor = System.Drawing.Color.Black;
            this.bookeddatabutton.Radius = 2;
            this.bookeddatabutton.Size = new System.Drawing.Size(230, 33);
            this.bookeddatabutton.TabIndex = 6;
            this.bookeddatabutton.Text = "BOOKED DATA";
            this.bookeddatabutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookeddatabutton.Click += new System.EventHandler(this.bookeddatabutton_Click);
            // 
            // afterloggedadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "afterloggedadmin";
            this.Size = new System.Drawing.Size(291, 333);
            this.Load += new System.EventHandler(this.afterloggedadmin_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton addadmin;
        private System.Windows.Forms.Label adminlabel;
        private Guna.UI.WinForms.GunaButton logoutbutton;
        private Guna.UI.WinForms.GunaButton passwordbutton;
        private Guna.UI.WinForms.GunaButton emailbutton;
        private Guna.UI.WinForms.GunaButton bookeddatabutton;
        private System.Windows.Forms.Timer refreshtimer;
        private Guna.UI.WinForms.GunaButton modifydetailbutton;
    }
}
