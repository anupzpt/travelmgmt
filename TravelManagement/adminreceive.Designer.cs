namespace TravelManagement
{
    partial class adminreceive
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
            this.emailpanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.add = new Guna.UI.WinForms.GunaCircleButton();
            this.add2 = new Guna.UI.WinForms.GunaCircleButton();
            this.MessageDisplaypanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtimer = new System.Windows.Forms.Timer(this.components);
            this.adminmessage = new TravelManagement.adminmessage();
            this.emailpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailpanel
            // 
            this.emailpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailpanel.BackColor = System.Drawing.Color.Transparent;
            this.emailpanel.BaseColor = System.Drawing.Color.Lavender;
            this.emailpanel.Controls.Add(this.add);
            this.emailpanel.Controls.Add(this.add2);
            this.emailpanel.Controls.Add(this.MessageDisplaypanel);
            this.emailpanel.Controls.Add(this.label1);
            this.emailpanel.Location = new System.Drawing.Point(10, 10);
            this.emailpanel.Name = "emailpanel";
            this.emailpanel.ShadowColor = System.Drawing.Color.SeaGreen;
            this.emailpanel.ShadowDepth = 200;
            this.emailpanel.Size = new System.Drawing.Size(820, 492);
            this.emailpanel.TabIndex = 13;
            // 
            // add
            // 
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = global::TravelManagement.Properties.Resources.add;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.BaseColor = System.Drawing.Color.Transparent;
            this.add.BorderColor = System.Drawing.Color.Black;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.FocusedColor = System.Drawing.Color.Empty;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = null;
            this.add.ImageSize = new System.Drawing.Size(52, 52);
            this.add.Location = new System.Drawing.Point(14, 4);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add.OnHoverForeColor = System.Drawing.Color.White;
            this.add.OnHoverImage = null;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Size = new System.Drawing.Size(60, 53);
            this.add.TabIndex = 15;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // add2
            // 
            this.add2.AnimationHoverSpeed = 0.07F;
            this.add2.AnimationSpeed = 0.03F;
            this.add2.BackColor = System.Drawing.Color.Transparent;
            this.add2.BackgroundImage = global::TravelManagement.Properties.Resources.add;
            this.add2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add2.BaseColor = System.Drawing.Color.Transparent;
            this.add2.BorderColor = System.Drawing.Color.Black;
            this.add2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add2.FocusedColor = System.Drawing.Color.Empty;
            this.add2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add2.ForeColor = System.Drawing.Color.White;
            this.add2.Image = null;
            this.add2.ImageSize = new System.Drawing.Size(52, 52);
            this.add2.Location = new System.Drawing.Point(14, 4);
            this.add2.Name = "add2";
            this.add2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add2.OnHoverForeColor = System.Drawing.Color.White;
            this.add2.OnHoverImage = null;
            this.add2.OnPressedColor = System.Drawing.Color.Black;
            this.add2.Size = new System.Drawing.Size(60, 53);
            this.add2.TabIndex = 16;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // MessageDisplaypanel
            // 
            this.MessageDisplaypanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageDisplaypanel.AutoScroll = true;
            this.MessageDisplaypanel.BackColor = System.Drawing.Color.Transparent;
            this.MessageDisplaypanel.BaseColor = System.Drawing.Color.Silver;
            this.MessageDisplaypanel.Location = new System.Drawing.Point(14, 59);
            this.MessageDisplaypanel.Name = "MessageDisplaypanel";
            this.MessageDisplaypanel.ShadowColor = System.Drawing.Color.Tan;
            this.MessageDisplaypanel.ShadowDepth = 200;
            this.MessageDisplaypanel.Size = new System.Drawing.Size(793, 236);
            this.MessageDisplaypanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMAIL";
            // 
            // emailtimer
            // 
            this.emailtimer.Tick += new System.EventHandler(this.emailtimer_Tick);
            // 
            // adminmessage
            // 
            this.adminmessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminmessage.BackColor = System.Drawing.Color.White;
            this.adminmessage.Location = new System.Drawing.Point(360, 10);
            this.adminmessage.Name = "adminmessage";
            this.adminmessage.Size = new System.Drawing.Size(448, 489);
            this.adminmessage.TabIndex = 0;
            this.adminmessage.Visible = false;
            // 
            // adminreceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.emailpanel);
            this.Controls.Add(this.adminmessage);
            this.Name = "adminreceive";
            this.Size = new System.Drawing.Size(840, 505);
            this.Load += new System.EventHandler(this.adminreceive_Load);
            this.emailpanel.ResumeLayout(false);
            this.emailpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel emailpanel;
        private Guna.UI.WinForms.GunaShadowPanel MessageDisplaypanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleButton add;
        private System.Windows.Forms.Timer emailtimer;
        private adminmessage adminmessage;
        private Guna.UI.WinForms.GunaCircleButton add2;
    }
}
