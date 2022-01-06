namespace TravelManagement
{
    partial class changepassword
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
            this.eye = new Guna.UI.WinForms.GunaCircleButton();
            this.savebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.newpassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.password = new Guna.UI.WinForms.GunaLineTextBox();
            this.usernametext = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaCircleButton3 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eye2 = new Guna.UI.WinForms.GunaCircleButton();
            this.Eyetimer = new System.Windows.Forms.Timer(this.components);
            this.designpanel = new System.Windows.Forms.Panel();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.designpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.eye);
            this.gunaShadowPanel1.Controls.Add(this.savebutton);
            this.gunaShadowPanel1.Controls.Add(this.newpassword);
            this.gunaShadowPanel1.Controls.Add(this.password);
            this.gunaShadowPanel1.Controls.Add(this.usernametext);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton3);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton2);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaShadowPanel1.Controls.Add(this.pictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.eye2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(475, 43);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.SystemColors.Desktop;
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(390, 400);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // eye
            // 
            this.eye.AnimationHoverSpeed = 0.07F;
            this.eye.AnimationSpeed = 0.03F;
            this.eye.BaseColor = System.Drawing.Color.Transparent;
            this.eye.BorderColor = System.Drawing.Color.Black;
            this.eye.DialogResult = System.Windows.Forms.DialogResult.None;
            this.eye.FocusedColor = System.Drawing.Color.Empty;
            this.eye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eye.ForeColor = System.Drawing.Color.White;
            this.eye.Image = global::TravelManagement.Properties.Resources.eye_24px;
            this.eye.ImageSize = new System.Drawing.Size(30, 30);
            this.eye.Location = new System.Drawing.Point(297, 209);
            this.eye.Name = "eye";
            this.eye.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.eye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.eye.OnHoverForeColor = System.Drawing.Color.White;
            this.eye.OnHoverImage = null;
            this.eye.OnPressedColor = System.Drawing.Color.Black;
            this.eye.Size = new System.Drawing.Size(35, 37);
            this.eye.TabIndex = 16;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // savebutton
            // 
            this.savebutton.AnimationHoverSpeed = 0.07F;
            this.savebutton.AnimationSpeed = 0.03F;
            this.savebutton.BackColor = System.Drawing.Color.Transparent;
            this.savebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.savebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.savebutton.BorderColor = System.Drawing.Color.Navy;
            this.savebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.savebutton.FocusedColor = System.Drawing.Color.Empty;
            this.savebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Image = null;
            this.savebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.savebutton.Location = new System.Drawing.Point(137, 335);
            this.savebutton.Name = "savebutton";
            this.savebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.savebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.savebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.savebutton.OnHoverImage = null;
            this.savebutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.savebutton.Radius = 3;
            this.savebutton.Size = new System.Drawing.Size(102, 36);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "DONE";
            this.savebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // newpassword
            // 
            this.newpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.newpassword.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.ForeColor = System.Drawing.Color.Black;
            this.newpassword.LineColor = System.Drawing.Color.Gainsboro;
            this.newpassword.Location = new System.Drawing.Point(95, 278);
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '\0';
            this.newpassword.SelectedText = "";
            this.newpassword.Size = new System.Drawing.Size(237, 31);
            this.newpassword.TabIndex = 2;
            this.newpassword.Text = "NEW PASSWORD";
            this.newpassword.Click += new System.EventHandler(this.newpassword_Click);
            this.newpassword.Enter += new System.EventHandler(this.newpassword_Enter);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.LineColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(95, 215);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(237, 31);
            this.password.TabIndex = 1;
            this.password.Text = "PASSWORD";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametext.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernametext.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.ForeColor = System.Drawing.Color.Black;
            this.usernametext.LineColor = System.Drawing.Color.Gainsboro;
            this.usernametext.Location = new System.Drawing.Point(95, 155);
            this.usernametext.Name = "usernametext";
            this.usernametext.PasswordChar = '\0';
            this.usernametext.SelectedText = "";
            this.usernametext.Size = new System.Drawing.Size(237, 31);
            this.usernametext.TabIndex = 0;
            this.usernametext.Text = "USERNAME";
            this.usernametext.Click += new System.EventHandler(this.usernametext_Click);
            this.usernametext.Enter += new System.EventHandler(this.usernametext_Enter);
            // 
            // gunaCircleButton3
            // 
            this.gunaCircleButton3.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton3.AnimationSpeed = 0.03F;
            this.gunaCircleButton3.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton3.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton3.Image = global::TravelManagement.Properties.Resources.locked;
            this.gunaCircleButton3.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton3.Location = new System.Drawing.Point(25, 262);
            this.gunaCircleButton3.Name = "gunaCircleButton3";
            this.gunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton3.OnHoverImage = null;
            this.gunaCircleButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton3.TabIndex = 15;
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
            this.gunaCircleButton2.Location = new System.Drawing.Point(25, 204);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.TabIndex = 14;
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
            this.gunaCircleButton1.Location = new System.Drawing.Point(25, 146);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(51, 52);
            this.gunaCircleButton1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelManagement.Properties.Resources.sacho;
            this.pictureBox1.Location = new System.Drawing.Point(114, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // eye2
            // 
            this.eye2.AnimationHoverSpeed = 0.07F;
            this.eye2.AnimationSpeed = 0.03F;
            this.eye2.BaseColor = System.Drawing.Color.Transparent;
            this.eye2.BorderColor = System.Drawing.Color.Black;
            this.eye2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.eye2.FocusedColor = System.Drawing.Color.Empty;
            this.eye2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eye2.ForeColor = System.Drawing.Color.White;
            this.eye2.Image = global::TravelManagement.Properties.Resources.eye_24px;
            this.eye2.ImageSize = new System.Drawing.Size(30, 30);
            this.eye2.Location = new System.Drawing.Point(297, 209);
            this.eye2.Name = "eye2";
            this.eye2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.eye2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.eye2.OnHoverForeColor = System.Drawing.Color.White;
            this.eye2.OnHoverImage = null;
            this.eye2.OnPressedColor = System.Drawing.Color.Black;
            this.eye2.Size = new System.Drawing.Size(35, 37);
            this.eye2.TabIndex = 17;
            this.eye2.Click += new System.EventHandler(this.eye2_Click);
            // 
            // Eyetimer
            // 
            this.Eyetimer.Interval = 1000;
            this.Eyetimer.Tick += new System.EventHandler(this.Eyetimer_Tick);
            // 
            // designpanel
            // 
            this.designpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.designpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.designpanel.Controls.Add(this.gunaShadowPanel1);
            this.designpanel.Location = new System.Drawing.Point(0, 0);
            this.designpanel.Name = "designpanel";
            this.designpanel.Size = new System.Drawing.Size(900, 471);
            this.designpanel.TabIndex = 3;
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.designpanel);
            this.Name = "changepassword";
            this.Size = new System.Drawing.Size(900, 471);
            this.Load += new System.EventHandler(this.changepassword_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.designpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGradientButton savebutton;
        private Guna.UI.WinForms.GunaLineTextBox newpassword;
        private Guna.UI.WinForms.GunaLineTextBox password;
        private Guna.UI.WinForms.GunaLineTextBox usernametext;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton3;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCircleButton eye;
        private Guna.UI.WinForms.GunaCircleButton eye2;
        private System.Windows.Forms.Timer Eyetimer;
        private System.Windows.Forms.Panel designpanel;
    }
}
