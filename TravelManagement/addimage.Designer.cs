namespace TravelManagement
{
    partial class addimage
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
            this.picturepanel = new System.Windows.Forms.Panel();
            this.imagepanel = new System.Windows.Forms.Panel();
            this.savebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.filebutton = new Guna.UI.WinForms.GunaButton();
            this.imagetextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addpackagetext = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gunaShadowPanel1.SuspendLayout();
            this.picturepanel.SuspendLayout();
            this.imagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Lavender;
            this.gunaShadowPanel1.Controls.Add(this.picturepanel);
            this.gunaShadowPanel1.Controls.Add(this.imagepanel);
            this.gunaShadowPanel1.Controls.Add(this.addpackagetext);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(857, 544);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // picturepanel
            // 
            this.picturepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturepanel.Controls.Add(this.pictureBox);
            this.picturepanel.Location = new System.Drawing.Point(1, 83);
            this.picturepanel.Name = "picturepanel";
            this.picturepanel.Size = new System.Drawing.Size(854, 448);
            this.picturepanel.TabIndex = 5;
            // 
            // imagepanel
            // 
            this.imagepanel.Controls.Add(this.savebutton);
            this.imagepanel.Controls.Add(this.filebutton);
            this.imagepanel.Controls.Add(this.imagetextbox);
            this.imagepanel.Controls.Add(this.label9);
            this.imagepanel.Location = new System.Drawing.Point(67, 38);
            this.imagepanel.Name = "imagepanel";
            this.imagepanel.Size = new System.Drawing.Size(627, 37);
            this.imagepanel.TabIndex = 4;
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
            this.savebutton.Location = new System.Drawing.Point(489, -3);
            this.savebutton.Name = "savebutton";
            this.savebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.savebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.savebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.savebutton.OnHoverImage = null;
            this.savebutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.savebutton.Radius = 3;
            this.savebutton.Size = new System.Drawing.Size(113, 42);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "SAVE";
            this.savebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // filebutton
            // 
            this.filebutton.AnimationHoverSpeed = 0.07F;
            this.filebutton.AnimationSpeed = 0.03F;
            this.filebutton.BaseColor = System.Drawing.Color.DimGray;
            this.filebutton.BorderColor = System.Drawing.Color.Black;
            this.filebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.filebutton.FocusedColor = System.Drawing.Color.Empty;
            this.filebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filebutton.ForeColor = System.Drawing.Color.White;
            this.filebutton.Image = global::TravelManagement.Properties.Resources.file_16px;
            this.filebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.filebutton.Location = new System.Drawing.Point(394, 2);
            this.filebutton.Name = "filebutton";
            this.filebutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.filebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.filebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.filebutton.OnHoverImage = null;
            this.filebutton.OnPressedColor = System.Drawing.Color.Black;
            this.filebutton.Size = new System.Drawing.Size(40, 30);
            this.filebutton.TabIndex = 10;
            this.filebutton.Text = "gunaButton1";
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // imagetextbox
            // 
            this.imagetextbox.BackColor = System.Drawing.Color.White;
            this.imagetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imagetextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.imagetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imagetextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.imagetextbox.Location = new System.Drawing.Point(91, 2);
            this.imagetextbox.Name = "imagetextbox";
            this.imagetextbox.PasswordChar = '\0';
            this.imagetextbox.SelectedText = "";
            this.imagetextbox.Size = new System.Drawing.Size(297, 32);
            this.imagetextbox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "IMAGE";
            // 
            // addpackagetext
            // 
            this.addpackagetext.AutoSize = true;
            this.addpackagetext.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpackagetext.Location = new System.Drawing.Point(294, 1);
            this.addpackagetext.Name = "addpackagetext";
            this.addpackagetext.Size = new System.Drawing.Size(153, 34);
            this.addpackagetext.TabIndex = 3;
            this.addpackagetext.Text = "ADD IMAGE";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(854, 448);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // addimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "addimage";
            this.Size = new System.Drawing.Size(857, 547);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.picturepanel.ResumeLayout(false);
            this.imagepanel.ResumeLayout(false);
            this.imagepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel picturepanel;
        private System.Windows.Forms.Panel imagepanel;
        private Guna.UI.WinForms.GunaGradientButton savebutton;
        private Guna.UI.WinForms.GunaButton filebutton;
        private Guna.UI.WinForms.GunaLineTextBox imagetextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label addpackagetext;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
