namespace TravelManagement
{
    partial class Admin
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
            this.adminmainpanel = new System.Windows.Forms.Panel();
            this.Crossbutton = new System.Windows.Forms.Button();
            this.panelforbutton = new System.Windows.Forms.Panel();
            this.Deletebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Updatebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Add = new Guna.UI.WinForms.GunaGradientButton();
            this.adminadd = new TravelManagement.adminadd();
            this.adminupdate = new TravelManagement.adminupdate();
            this.admindelete = new TravelManagement.admindelete();
            this.adminmainpanel.SuspendLayout();
            this.panelforbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminmainpanel
            // 
            this.adminmainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminmainpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.adminmainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminmainpanel.Controls.Add(this.adminadd);
            this.adminmainpanel.Controls.Add(this.adminupdate);
            this.adminmainpanel.Controls.Add(this.admindelete);
            this.adminmainpanel.Controls.Add(this.Crossbutton);
            this.adminmainpanel.Controls.Add(this.panelforbutton);
            this.adminmainpanel.Location = new System.Drawing.Point(0, 0);
            this.adminmainpanel.Name = "adminmainpanel";
            this.adminmainpanel.Size = new System.Drawing.Size(857, 450);
            this.adminmainpanel.TabIndex = 1;
            // 
            // Crossbutton
            // 
            this.Crossbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Crossbutton.BackColor = System.Drawing.Color.Transparent;
            this.Crossbutton.FlatAppearance.BorderSize = 0;
            this.Crossbutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crossbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.Crossbutton.Location = new System.Drawing.Point(708, 5);
            this.Crossbutton.Name = "Crossbutton";
            this.Crossbutton.Size = new System.Drawing.Size(55, 39);
            this.Crossbutton.TabIndex = 10;
            this.Crossbutton.Text = "X";
            this.Crossbutton.UseVisualStyleBackColor = false;
            this.Crossbutton.Click += new System.EventHandler(this.Crossbutton_Click);
            // 
            // panelforbutton
            // 
            this.panelforbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelforbutton.BackColor = System.Drawing.Color.Transparent;
            this.panelforbutton.Controls.Add(this.Deletebutton);
            this.panelforbutton.Controls.Add(this.Updatebutton);
            this.panelforbutton.Controls.Add(this.Add);
            this.panelforbutton.Location = new System.Drawing.Point(0, 0);
            this.panelforbutton.Name = "panelforbutton";
            this.panelforbutton.Size = new System.Drawing.Size(671, 54);
            this.panelforbutton.TabIndex = 1;
            // 
            // Deletebutton
            // 
            this.Deletebutton.AnimationHoverSpeed = 0.07F;
            this.Deletebutton.AnimationSpeed = 0.03F;
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Deletebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Deletebutton.BorderColor = System.Drawing.Color.Navy;
            this.Deletebutton.BorderSize = 1;
            this.Deletebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Deletebutton.FocusedColor = System.Drawing.Color.Empty;
            this.Deletebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Image = null;
            this.Deletebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Deletebutton.Location = new System.Drawing.Point(347, 3);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Deletebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Deletebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Deletebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Deletebutton.OnHoverImage = null;
            this.Deletebutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebutton.Radius = 3;
            this.Deletebutton.Size = new System.Drawing.Size(121, 42);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
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
            this.Updatebutton.Location = new System.Drawing.Point(178, 4);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Updatebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Updatebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Updatebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Updatebutton.OnHoverImage = null;
            this.Updatebutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Radius = 3;
            this.Updatebutton.Size = new System.Drawing.Size(121, 42);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Add
            // 
            this.Add.AnimationHoverSpeed = 0.07F;
            this.Add.AnimationSpeed = 0.03F;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Add.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Add.BorderColor = System.Drawing.Color.Navy;
            this.Add.BorderSize = 1;
            this.Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Add.FocusedColor = System.Drawing.Color.Empty;
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = null;
            this.Add.ImageSize = new System.Drawing.Size(20, 20);
            this.Add.Location = new System.Drawing.Point(10, 5);
            this.Add.Name = "Add";
            this.Add.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Add.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Add.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Add.OnHoverImage = null;
            this.Add.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.Add.Radius = 3;
            this.Add.Size = new System.Drawing.Size(119, 42);
            this.Add.TabIndex = 7;
            this.Add.Text = "ADD";
            this.Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // adminadd
            // 
            this.adminadd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminadd.Location = new System.Drawing.Point(2, 54);
            this.adminadd.Name = "adminadd";
            this.adminadd.Size = new System.Drawing.Size(855, 392);
            this.adminadd.TabIndex = 2;
            // 
            // adminupdate
            // 
            this.adminupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminupdate.Location = new System.Drawing.Point(2, 52);
            this.adminupdate.Name = "adminupdate";
            this.adminupdate.Size = new System.Drawing.Size(852, 392);
            this.adminupdate.TabIndex = 12;
            this.adminupdate.Visible = false;
            // 
            // admindelete
            // 
            this.admindelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admindelete.Location = new System.Drawing.Point(2, 54);
            this.admindelete.Name = "admindelete";
            this.admindelete.Size = new System.Drawing.Size(852, 392);
            this.admindelete.TabIndex = 11;
            this.admindelete.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminmainpanel);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(857, 450);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.adminmainpanel.ResumeLayout(false);
            this.panelforbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminmainpanel;
        private System.Windows.Forms.Button Crossbutton;
        private System.Windows.Forms.Panel panelforbutton;
        private Guna.UI.WinForms.GunaGradientButton Deletebutton;
        private Guna.UI.WinForms.GunaGradientButton Updatebutton;
        private Guna.UI.WinForms.GunaGradientButton Add;
        private adminupdate adminupdate;
        private admindelete admindelete;
        private adminadd adminadd;
    }
}
