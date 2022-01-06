namespace TravelManagement
{
    partial class register
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
            this.rewrite = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.eye = new Guna.UI.WinForms.GunaCircleButton();
            this.donebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaCircleButton4 = new Guna.UI.WinForms.GunaCircleButton();
            this.savebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.password = new Guna.UI.WinForms.GunaLineTextBox();
            this.emailtextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.usernametext = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.eye2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Eyetimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rewrite
            // 
            this.rewrite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rewrite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rewrite.Enabled = false;
            this.rewrite.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rewrite.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewrite.ForeColor = System.Drawing.Color.Black;
            this.rewrite.LineColor = System.Drawing.Color.Gainsboro;
            this.rewrite.Location = new System.Drawing.Point(70, 189);
            this.rewrite.Name = "rewrite";
            this.rewrite.PasswordChar = '\0';
            this.rewrite.SelectedText = "";
            this.rewrite.Size = new System.Drawing.Size(237, 31);
            this.rewrite.TabIndex = 3;
            this.rewrite.Text = "RE-ENTER";
            this.rewrite.TextChanged += new System.EventHandler(this.rewrite_TextChanged);
            this.rewrite.Enter += new System.EventHandler(this.rewrite_Enter);
            this.rewrite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernametext_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.gunaShadowPanel1);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 370);
            this.panel1.TabIndex = 2;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.eye);
            this.gunaShadowPanel1.Controls.Add(this.donebutton);
            this.gunaShadowPanel1.Controls.Add(this.rewrite);
            this.gunaShadowPanel1.Controls.Add(this.pictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton4);
            this.gunaShadowPanel1.Controls.Add(this.savebutton);
            this.gunaShadowPanel1.Controls.Add(this.password);
            this.gunaShadowPanel1.Controls.Add(this.emailtextbox);
            this.gunaShadowPanel1.Controls.Add(this.usernametext);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton2);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaShadowPanel1.Controls.Add(this.eye2);
            this.gunaShadowPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(27, 35);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.SeaGreen;
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(330, 288);
            this.gunaShadowPanel1.TabIndex = 8;
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
            this.eye.Location = new System.Drawing.Point(273, 126);
            this.eye.Name = "eye";
            this.eye.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.eye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.eye.OnHoverForeColor = System.Drawing.Color.White;
            this.eye.OnHoverImage = null;
            this.eye.OnPressedColor = System.Drawing.Color.Black;
            this.eye.Size = new System.Drawing.Size(35, 37);
            this.eye.TabIndex = 14;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // donebutton
            // 
            this.donebutton.AnimationHoverSpeed = 0.07F;
            this.donebutton.AnimationSpeed = 0.03F;
            this.donebutton.BackColor = System.Drawing.Color.Transparent;
            this.donebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.donebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.donebutton.BorderColor = System.Drawing.Color.Navy;
            this.donebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.donebutton.FocusedColor = System.Drawing.Color.Empty;
            this.donebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebutton.ForeColor = System.Drawing.Color.White;
            this.donebutton.Image = null;
            this.donebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.donebutton.Location = new System.Drawing.Point(105, 236);
            this.donebutton.Name = "donebutton";
            this.donebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.donebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.donebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.donebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.donebutton.OnHoverImage = null;
            this.donebutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.donebutton.Radius = 3;
            this.donebutton.Size = new System.Drawing.Size(102, 36);
            this.donebutton.TabIndex = 4;
            this.donebutton.Text = "DONE";
            this.donebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelManagement.Properties.Resources.envelop;
            this.pictureBox1.Location = new System.Drawing.Point(19, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // gunaCircleButton4
            // 
            this.gunaCircleButton4.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton4.AnimationSpeed = 0.03F;
            this.gunaCircleButton4.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton4.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.Image = global::TravelManagement.Properties.Resources.locked;
            this.gunaCircleButton4.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton4.Location = new System.Drawing.Point(14, 177);
            this.gunaCircleButton4.Name = "gunaCircleButton4";
            this.gunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton4.OnHoverImage = null;
            this.gunaCircleButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton4.TabIndex = 12;
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
            this.savebutton.Location = new System.Drawing.Point(126, 330);
            this.savebutton.Name = "savebutton";
            this.savebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.savebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.savebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.savebutton.OnHoverImage = null;
            this.savebutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.savebutton.Radius = 3;
            this.savebutton.Size = new System.Drawing.Size(102, 36);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "SAVE";
            this.savebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Enabled = false;
            this.password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.LineColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(72, 132);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(237, 31);
            this.password.TabIndex = 2;
            this.password.Text = "PASSWORD";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernametext_MouseClick);
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtextbox.Enabled = false;
            this.emailtextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.emailtextbox.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.ForeColor = System.Drawing.Color.Black;
            this.emailtextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.emailtextbox.Location = new System.Drawing.Point(73, 74);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.PasswordChar = '\0';
            this.emailtextbox.SelectedText = "";
            this.emailtextbox.Size = new System.Drawing.Size(237, 31);
            this.emailtextbox.TabIndex = 1;
            this.emailtextbox.Text = "EMAIL";
            this.emailtextbox.Enter += new System.EventHandler(this.emailtextbox_Enter);
            this.emailtextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.emailtextbox_MouseDown);
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametext.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernametext.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.ForeColor = System.Drawing.Color.Black;
            this.usernametext.LineColor = System.Drawing.Color.Gainsboro;
            this.usernametext.Location = new System.Drawing.Point(70, 19);
            this.usernametext.Name = "usernametext";
            this.usernametext.PasswordChar = '\0';
            this.usernametext.SelectedText = "";
            this.usernametext.Size = new System.Drawing.Size(237, 31);
            this.usernametext.TabIndex = 0;
            this.usernametext.Text = "USERNAME";
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            this.usernametext.Enter += new System.EventHandler(this.usernametext_Enter);
            this.usernametext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernametext_MouseClick);
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
            this.gunaCircleButton2.Location = new System.Drawing.Point(14, 119);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.TabIndex = 6;
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
            this.gunaCircleButton1.Location = new System.Drawing.Point(13, 7);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(51, 52);
            this.gunaCircleButton1.TabIndex = 5;
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
            this.eye2.Location = new System.Drawing.Point(275, 126);
            this.eye2.Name = "eye2";
            this.eye2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.eye2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.eye2.OnHoverForeColor = System.Drawing.Color.White;
            this.eye2.OnHoverImage = null;
            this.eye2.OnPressedColor = System.Drawing.Color.Black;
            this.eye2.Size = new System.Drawing.Size(35, 37);
            this.eye2.TabIndex = 15;
            this.eye2.Click += new System.EventHandler(this.eye2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(127, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 28);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "REGISTER";
            // 
            // Eyetimer
            // 
            this.Eyetimer.Interval = 1000;
            this.Eyetimer.Tick += new System.EventHandler(this.Eyetimer_Tick);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Size = new System.Drawing.Size(390, 370);
            this.Load += new System.EventHandler(this.register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox rewrite;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGradientButton donebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton4;
        private Guna.UI.WinForms.GunaGradientButton savebutton;
        private Guna.UI.WinForms.GunaLineTextBox password;
        private Guna.UI.WinForms.GunaLineTextBox emailtextbox;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCircleButton eye;
        private Guna.UI.WinForms.GunaLineTextBox usernametext;
        private System.Windows.Forms.Timer Eyetimer;
        private Guna.UI.WinForms.GunaCircleButton eye2;
    }
}
