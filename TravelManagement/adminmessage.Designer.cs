namespace TravelManagement
{
    partial class adminmessage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messagetextbox = new Guna.UI.WinForms.GunaShadowPanel();
            this.messagetext = new Guna.UI.WinForms.GunaLineTextBox();
            this.selectComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.savebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.titletextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.messagetextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.messagetextbox);
            this.panel2.Controls.Add(this.selectComboBox);
            this.panel2.Controls.Add(this.savebutton);
            this.panel2.Controls.Add(this.titletextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 506);
            this.panel2.TabIndex = 1;
            // 
            // messagetextbox
            // 
            this.messagetextbox.BackColor = System.Drawing.Color.Transparent;
            this.messagetextbox.BaseColor = System.Drawing.Color.Lavender;
            this.messagetextbox.Controls.Add(this.messagetext);
            this.messagetextbox.Location = new System.Drawing.Point(12, 196);
            this.messagetextbox.Name = "messagetextbox";
            this.messagetextbox.ShadowColor = System.Drawing.Color.SeaGreen;
            this.messagetextbox.ShadowDepth = 200;
            this.messagetextbox.Size = new System.Drawing.Size(414, 234);
            this.messagetextbox.TabIndex = 11;
            // 
            // messagetext
            // 
            this.messagetext.BackColor = System.Drawing.Color.White;
            this.messagetext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messagetext.FocusedLineColor = System.Drawing.Color.Transparent;
            this.messagetext.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagetext.LineColor = System.Drawing.Color.Transparent;
            this.messagetext.Location = new System.Drawing.Point(16, 16);
            this.messagetext.Name = "messagetext";
            this.messagetext.PasswordChar = '\0';
            this.messagetext.SelectedText = "";
            this.messagetext.Size = new System.Drawing.Size(380, 201);
            this.messagetext.TabIndex = 0;
            this.messagetext.Text = "Type Message Here";
            this.messagetext.TextChanged += new System.EventHandler(this.messagetext_TextChanged);
            this.messagetext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.messagetext_MouseDown);
            // 
            // selectComboBox
            // 
            this.selectComboBox.BackColor = System.Drawing.Color.Transparent;
            this.selectComboBox.BaseColor = System.Drawing.Color.White;
            this.selectComboBox.BorderColor = System.Drawing.Color.Silver;
            this.selectComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.selectComboBox.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectComboBox.ForeColor = System.Drawing.Color.Black;
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(114, 94);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.selectComboBox.Size = new System.Drawing.Size(308, 34);
            this.selectComboBox.TabIndex = 0;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.selectComboBox_SelectedIndexChanged);
            this.selectComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectComboBox_MouseClick);
            this.selectComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectComboBox_MouseDown);
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
            this.savebutton.Location = new System.Drawing.Point(165, 442);
            this.savebutton.Name = "savebutton";
            this.savebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.savebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.savebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.savebutton.OnHoverImage = null;
            this.savebutton.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.savebutton.Radius = 3;
            this.savebutton.Size = new System.Drawing.Size(113, 42);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "SEND";
            this.savebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // titletextbox
            // 
            this.titletextbox.BackColor = System.Drawing.Color.White;
            this.titletextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titletextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.titletextbox.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.titletextbox.Location = new System.Drawing.Point(115, 140);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.PasswordChar = '\0';
            this.titletextbox.SelectedText = "";
            this.titletextbox.Size = new System.Drawing.Size(307, 36);
            this.titletextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEND TO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compose Message";
            // 
            // adminmessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "adminmessage";
            this.Size = new System.Drawing.Size(448, 506);
            this.Load += new System.EventHandler(this.adminmessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.messagetextbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaShadowPanel messagetextbox;
        private Guna.UI.WinForms.GunaComboBox selectComboBox;
        private Guna.UI.WinForms.GunaGradientButton savebutton;
        private Guna.UI.WinForms.GunaLineTextBox titletextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox messagetext;
    }
}
