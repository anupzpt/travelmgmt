namespace TravelManagement
{
    partial class loggedin
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
            this.usertextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerpanel = new System.Windows.Forms.Panel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.loginhere = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.donthaveaccount = new Guna.UI.WinForms.GunaLinkLabel();
            this.passwordtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.loginbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.Refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.register = new TravelManagement.register();
            this.panel1.SuspendLayout();
            this.registerpanel.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usertextbox
            // 
            this.usertextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usertextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertextbox.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usertextbox.HintForeColor = System.Drawing.Color.Empty;
            this.usertextbox.HintText = "";
            this.usertextbox.isPassword = false;
            this.usertextbox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.usertextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.usertextbox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.usertextbox.LineThickness = 2;
            this.usertextbox.Location = new System.Drawing.Point(102, 70);
            this.usertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(223, 42);
            this.usertextbox.TabIndex = 0;
            this.usertextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usertextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usertextbox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.registerpanel);
            this.panel1.Controls.Add(this.gunaPanel1);
            this.panel1.Controls.Add(this.passwordtextbox);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.usertextbox);
            this.panel1.Controls.Add(this.gunaShadowPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 369);
            this.panel1.TabIndex = 1;
            // 
            // registerpanel
            // 
            this.registerpanel.Controls.Add(this.gunaPanel2);
            this.registerpanel.Controls.Add(this.register);
            this.registerpanel.Location = new System.Drawing.Point(0, 0);
            this.registerpanel.Name = "registerpanel";
            this.registerpanel.Size = new System.Drawing.Size(383, 370);
            this.registerpanel.TabIndex = 8;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.Controls.Add(this.loginhere);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 330);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(383, 36);
            this.gunaPanel2.TabIndex = 8;
            // 
            // loginhere
            // 
            this.loginhere.AutoSize = true;
            this.loginhere.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginhere.Location = new System.Drawing.Point(105, 10);
            this.loginhere.Name = "loginhere";
            this.loginhere.Size = new System.Drawing.Size(165, 15);
            this.loginhere.TabIndex = 0;
            this.loginhere.TabStop = true;
            this.loginhere.Text = "I Have A Account? Login Here";
            this.loginhere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginhere_LinkClicked);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.donthaveaccount);
            this.gunaPanel1.Location = new System.Drawing.Point(4, 331);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(367, 32);
            this.gunaPanel1.TabIndex = 7;
            // 
            // donthaveaccount
            // 
            this.donthaveaccount.AutoSize = true;
            this.donthaveaccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.donthaveaccount.Location = new System.Drawing.Point(88, 10);
            this.donthaveaccount.Name = "donthaveaccount";
            this.donthaveaccount.Size = new System.Drawing.Size(189, 15);
            this.donthaveaccount.TabIndex = 0;
            this.donthaveaccount.TabStop = true;
            this.donthaveaccount.Text = "Dont Have Account? Register Here";
            this.donthaveaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donthaveaccount_LinkClicked);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtextbox.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtextbox.HintText = "";
            this.passwordtextbox.isPassword = true;
            this.passwordtextbox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.passwordtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.passwordtextbox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.passwordtextbox.LineThickness = 2;
            this.passwordtextbox.Location = new System.Drawing.Point(100, 139);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(225, 44);
            this.passwordtextbox.TabIndex = 1;
            this.passwordtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordtextbox_MouseDown);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(148, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "LOGIN";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.loginbutton);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton2);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(18, 42);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.SeaGreen;
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(338, 283);
            this.gunaShadowPanel1.TabIndex = 6;
            // 
            // loginbutton
            // 
            this.loginbutton.AnimationHoverSpeed = 0.07F;
            this.loginbutton.AnimationSpeed = 0.03F;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.loginbutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.loginbutton.BorderColor = System.Drawing.Color.Navy;
            this.loginbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginbutton.FocusedColor = System.Drawing.Color.Empty;
            this.loginbutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Image = null;
            this.loginbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginbutton.Location = new System.Drawing.Point(120, 204);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.loginbutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.loginbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginbutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.loginbutton.OnHoverImage = null;
            this.loginbutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.loginbutton.Radius = 3;
            this.loginbutton.Size = new System.Drawing.Size(102, 36);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "LOG IN";
            this.loginbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click_1);
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = global::TravelManagement.Properties.Resources.locked;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.Location = new System.Drawing.Point(13, 90);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.TabIndex = 3;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::TravelManagement.Properties.Resources.icons8_user_96;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(13, 14);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.TabIndex = 2;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(-1, 2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(383, 370);
            this.register.TabIndex = 0;
            this.register.Load += new System.EventHandler(this.register_Load);
            // 
            // loggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "loggedin";
            this.Size = new System.Drawing.Size(383, 370);
            this.Load += new System.EventHandler(this.loggedin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.registerpanel.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox usertextbox;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLinkLabel donthaveaccount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtextbox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.Timer Refreshtimer;
        private System.Windows.Forms.Panel registerpanel;
        private register register;
        private Guna.UI.WinForms.GunaGradientButton loginbutton;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLinkLabel loginhere;
    }
}
