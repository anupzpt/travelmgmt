namespace TravelManagement
{
    partial class user
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
            this.usermainpanel = new System.Windows.Forms.Panel();
            this.bookeduser = new TravelManagement.bookeduser();
            this.updateuser = new TravelManagement.updateuser();
            this.panelforbutton = new System.Windows.Forms.Panel();
            this.Printbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Booked = new Guna.UI.WinForms.GunaGradientButton();
            this.Updatebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.usermainpanel.SuspendLayout();
            this.panelforbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // usermainpanel
            // 
            this.usermainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usermainpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.usermainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usermainpanel.Controls.Add(this.bookeduser);
            this.usermainpanel.Controls.Add(this.updateuser);
            this.usermainpanel.Controls.Add(this.panelforbutton);
            this.usermainpanel.Location = new System.Drawing.Point(0, 0);
            this.usermainpanel.Name = "usermainpanel";
            this.usermainpanel.Size = new System.Drawing.Size(857, 450);
            this.usermainpanel.TabIndex = 2;
            // 
            // bookeduser
            // 
            this.bookeduser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookeduser.Location = new System.Drawing.Point(2, 54);
            this.bookeduser.Name = "bookeduser";
            this.bookeduser.Size = new System.Drawing.Size(855, 392);
            this.bookeduser.TabIndex = 13;
            // 
            // updateuser
            // 
            this.updateuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateuser.Location = new System.Drawing.Point(2, 54);
            this.updateuser.Name = "updateuser";
            this.updateuser.Size = new System.Drawing.Size(855, 392);
            this.updateuser.TabIndex = 11;
            // 
            // panelforbutton
            // 
            this.panelforbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelforbutton.BackColor = System.Drawing.Color.Transparent;
            this.panelforbutton.Controls.Add(this.Printbutton);
            this.panelforbutton.Controls.Add(this.Booked);
            this.panelforbutton.Controls.Add(this.Updatebutton);
            this.panelforbutton.Location = new System.Drawing.Point(0, 0);
            this.panelforbutton.Name = "panelforbutton";
            this.panelforbutton.Size = new System.Drawing.Size(854, 54);
            this.panelforbutton.TabIndex = 1;
            // 
            // Printbutton
            // 
            this.Printbutton.AnimationHoverSpeed = 0.07F;
            this.Printbutton.AnimationSpeed = 0.03F;
            this.Printbutton.BackColor = System.Drawing.Color.Transparent;
            this.Printbutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Printbutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Printbutton.BorderColor = System.Drawing.Color.Navy;
            this.Printbutton.BorderSize = 1;
            this.Printbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Printbutton.FocusedColor = System.Drawing.Color.Empty;
            this.Printbutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbutton.ForeColor = System.Drawing.Color.White;
            this.Printbutton.Image = null;
            this.Printbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Printbutton.Location = new System.Drawing.Point(295, 6);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Printbutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Printbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Printbutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Printbutton.OnHoverImage = null;
            this.Printbutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Printbutton.Radius = 3;
            this.Printbutton.Size = new System.Drawing.Size(103, 42);
            this.Printbutton.TabIndex = 14;
            this.Printbutton.Text = "PRINT";
            this.Printbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // Booked
            // 
            this.Booked.AnimationHoverSpeed = 0.07F;
            this.Booked.AnimationSpeed = 0.03F;
            this.Booked.BackColor = System.Drawing.Color.Transparent;
            this.Booked.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Booked.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Booked.BorderColor = System.Drawing.Color.Navy;
            this.Booked.BorderSize = 1;
            this.Booked.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Booked.FocusedColor = System.Drawing.Color.Empty;
            this.Booked.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked.ForeColor = System.Drawing.Color.White;
            this.Booked.Image = null;
            this.Booked.ImageSize = new System.Drawing.Size(20, 20);
            this.Booked.Location = new System.Drawing.Point(15, 6);
            this.Booked.Name = "Booked";
            this.Booked.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Booked.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Booked.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Booked.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Booked.OnHoverImage = null;
            this.Booked.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Booked.Radius = 3;
            this.Booked.Size = new System.Drawing.Size(121, 42);
            this.Booked.TabIndex = 12;
            this.Booked.Text = "BOOKED";
            this.Booked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Booked.Click += new System.EventHandler(this.Booked_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.AnimationHoverSpeed = 0.07F;
            this.Updatebutton.AnimationSpeed = 0.03F;
            this.Updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.Updatebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Updatebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Updatebutton.BorderColor = System.Drawing.Color.Navy;
            this.Updatebutton.BorderSize = 1;
            this.Updatebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Updatebutton.FocusedColor = System.Drawing.Color.Empty;
            this.Updatebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Image = null;
            this.Updatebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Updatebutton.Location = new System.Drawing.Point(158, 6);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Updatebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Updatebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Updatebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Updatebutton.OnHoverImage = null;
            this.Updatebutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Radius = 3;
            this.Updatebutton.Size = new System.Drawing.Size(113, 42);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usermainpanel);
            this.Name = "user";
            this.Size = new System.Drawing.Size(857, 450);
            this.Load += new System.EventHandler(this.user_Load);
            this.usermainpanel.ResumeLayout(false);
            this.panelforbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usermainpanel;
        private Guna.UI.WinForms.GunaGradientButton Updatebutton;
        private updateuser updateuser;
        private bookeduser bookeduser;
        private Guna.UI.WinForms.GunaGradientButton Printbutton;
        private System.Windows.Forms.Panel panelforbutton;
        private Guna.UI.WinForms.GunaGradientButton Booked;
    }
}
