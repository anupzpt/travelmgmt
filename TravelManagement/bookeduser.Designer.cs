namespace TravelManagement
{
    partial class bookeduser
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
            this.booking = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketno = new System.Windows.Forms.Label();
            this.ticket = new System.Windows.Forms.Label();
            this.datetextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.totalpricetextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.days = new Guna.UI.WinForms.GunaLabel();
            this.transporttextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.destinationtextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.trippricetextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.Durationtextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.accomodationtextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.quantitytextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addpackagetext = new System.Windows.Forms.Label();
            this.timerbook = new System.Windows.Forms.Timer(this.components);
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.imagepicturebox = new Guna.UI.WinForms.GunaPictureBox();
            this.booking.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagepicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // booking
            // 
            this.booking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booking.BackColor = System.Drawing.Color.Transparent;
            this.booking.BaseColor = System.Drawing.Color.Lavender;
            this.booking.Controls.Add(this.right);
            this.booking.Controls.Add(this.left);
            this.booking.Controls.Add(this.panel1);
            this.booking.Controls.Add(this.addpackagetext);
            this.booking.Location = new System.Drawing.Point(0, 0);
            this.booking.Name = "booking";
            this.booking.ShadowColor = System.Drawing.Color.Black;
            this.booking.Size = new System.Drawing.Size(852, 402);
            this.booking.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ticketno);
            this.panel1.Controls.Add(this.ticket);
            this.panel1.Controls.Add(this.datetextbox);
            this.panel1.Controls.Add(this.totalpricetextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.days);
            this.panel1.Controls.Add(this.imagepicturebox);
            this.panel1.Controls.Add(this.transporttextbox);
            this.panel1.Controls.Add(this.destinationtextbox);
            this.panel1.Controls.Add(this.trippricetextbox);
            this.panel1.Controls.Add(this.Durationtextbox);
            this.panel1.Controls.Add(this.accomodationtextbox);
            this.panel1.Controls.Add(this.quantitytextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(28, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 354);
            this.panel1.TabIndex = 10;
            // 
            // ticketno
            // 
            this.ticketno.AutoSize = true;
            this.ticketno.Enabled = false;
            this.ticketno.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold);
            this.ticketno.Location = new System.Drawing.Point(643, 10);
            this.ticketno.Name = "ticketno";
            this.ticketno.Size = new System.Drawing.Size(59, 21);
            this.ticketno.TabIndex = 29;
            this.ticketno.Text = "label2";
            // 
            // ticket
            // 
            this.ticket.AutoSize = true;
            this.ticket.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket.Location = new System.Drawing.Point(525, 10);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(112, 21);
            this.ticket.TabIndex = 28;
            this.ticket.Text = "TICKET NO :";
            // 
            // datetextbox
            // 
            this.datetextbox.BackColor = System.Drawing.Color.White;
            this.datetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datetextbox.Enabled = false;
            this.datetextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.datetextbox.Location = new System.Drawing.Point(181, 212);
            this.datetextbox.Name = "datetextbox";
            this.datetextbox.PasswordChar = '\0';
            this.datetextbox.SelectedText = "";
            this.datetextbox.Size = new System.Drawing.Size(308, 32);
            this.datetextbox.TabIndex = 27;
            // 
            // totalpricetextbox
            // 
            this.totalpricetextbox.BackColor = System.Drawing.Color.White;
            this.totalpricetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalpricetextbox.Enabled = false;
            this.totalpricetextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalpricetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalpricetextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.totalpricetextbox.Location = new System.Drawing.Point(181, 297);
            this.totalpricetextbox.Name = "totalpricetextbox";
            this.totalpricetextbox.PasswordChar = '\0';
            this.totalpricetextbox.SelectedText = "";
            this.totalpricetextbox.Size = new System.Drawing.Size(308, 32);
            this.totalpricetextbox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "TOTAL PRICE";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.Location = new System.Drawing.Point(422, 133);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(62, 26);
            this.days.TabIndex = 24;
            this.days.Text = "DAYS";
            // 
            // transporttextbox
            // 
            this.transporttextbox.BackColor = System.Drawing.Color.White;
            this.transporttextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transporttextbox.Enabled = false;
            this.transporttextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.transporttextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transporttextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.transporttextbox.Location = new System.Drawing.Point(181, 91);
            this.transporttextbox.Name = "transporttextbox";
            this.transporttextbox.PasswordChar = '\0';
            this.transporttextbox.SelectedText = "";
            this.transporttextbox.Size = new System.Drawing.Size(308, 32);
            this.transporttextbox.TabIndex = 4;
            // 
            // destinationtextbox
            // 
            this.destinationtextbox.BackColor = System.Drawing.Color.White;
            this.destinationtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationtextbox.Enabled = false;
            this.destinationtextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.destinationtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationtextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.destinationtextbox.Location = new System.Drawing.Point(181, 10);
            this.destinationtextbox.Name = "destinationtextbox";
            this.destinationtextbox.PasswordChar = '\0';
            this.destinationtextbox.SelectedText = "";
            this.destinationtextbox.Size = new System.Drawing.Size(308, 32);
            this.destinationtextbox.TabIndex = 0;
            // 
            // trippricetextbox
            // 
            this.trippricetextbox.BackColor = System.Drawing.Color.White;
            this.trippricetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trippricetextbox.Enabled = false;
            this.trippricetextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.trippricetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trippricetextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.trippricetextbox.Location = new System.Drawing.Point(181, 51);
            this.trippricetextbox.Name = "trippricetextbox";
            this.trippricetextbox.PasswordChar = '\0';
            this.trippricetextbox.SelectedText = "";
            this.trippricetextbox.Size = new System.Drawing.Size(308, 32);
            this.trippricetextbox.TabIndex = 1;
            // 
            // Durationtextbox
            // 
            this.Durationtextbox.BackColor = System.Drawing.Color.White;
            this.Durationtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Durationtextbox.Enabled = false;
            this.Durationtextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Durationtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Durationtextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.Durationtextbox.Location = new System.Drawing.Point(181, 132);
            this.Durationtextbox.Name = "Durationtextbox";
            this.Durationtextbox.PasswordChar = '\0';
            this.Durationtextbox.SelectedText = "";
            this.Durationtextbox.Size = new System.Drawing.Size(235, 32);
            this.Durationtextbox.TabIndex = 3;
            // 
            // accomodationtextbox
            // 
            this.accomodationtextbox.BackColor = System.Drawing.Color.White;
            this.accomodationtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accomodationtextbox.Enabled = false;
            this.accomodationtextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.accomodationtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.accomodationtextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.accomodationtextbox.Location = new System.Drawing.Point(181, 171);
            this.accomodationtextbox.Name = "accomodationtextbox";
            this.accomodationtextbox.PasswordChar = '\0';
            this.accomodationtextbox.SelectedText = "";
            this.accomodationtextbox.Size = new System.Drawing.Size(308, 32);
            this.accomodationtextbox.TabIndex = 5;
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.BackColor = System.Drawing.Color.White;
            this.quantitytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantitytextbox.Enabled = false;
            this.quantitytextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.quantitytextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantitytextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.quantitytextbox.Location = new System.Drawing.Point(181, 257);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.PasswordChar = '\0';
            this.quantitytextbox.SelectedText = "";
            this.quantitytextbox.Size = new System.Drawing.Size(308, 32);
            this.quantitytextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "DESTINATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "DURATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "ACCOMODATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "DATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "TRANSPORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "TRIP PRICE";
            // 
            // addpackagetext
            // 
            this.addpackagetext.AutoSize = true;
            this.addpackagetext.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpackagetext.Location = new System.Drawing.Point(267, 4);
            this.addpackagetext.Name = "addpackagetext";
            this.addpackagetext.Size = new System.Drawing.Size(200, 34);
            this.addpackagetext.TabIndex = 9;
            this.addpackagetext.Text = "YOUR BOOKING";
            // 
            // timerbook
            // 
            this.timerbook.Tick += new System.EventHandler(this.timerbook_Tick);
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.BackgroundImage = global::TravelManagement.Properties.Resources.right_52px;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.ForeColor = System.Drawing.Color.Firebrick;
            this.right.Location = new System.Drawing.Point(799, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(53, 44);
            this.right.TabIndex = 21;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.BackgroundImage = global::TravelManagement.Properties.Resources.left_52px;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left.FlatAppearance.BorderSize = 0;
            this.left.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.Color.Firebrick;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(53, 44);
            this.left.TabIndex = 20;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // imagepicturebox
            // 
            this.imagepicturebox.BackColor = System.Drawing.Color.Transparent;
            this.imagepicturebox.BaseColor = System.Drawing.Color.Transparent;
            this.imagepicturebox.Enabled = false;
            this.imagepicturebox.ErrorImage = null;
            this.imagepicturebox.Location = new System.Drawing.Point(550, 41);
            this.imagepicturebox.Name = "imagepicturebox";
            this.imagepicturebox.Size = new System.Drawing.Size(232, 188);
            this.imagepicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagepicturebox.TabIndex = 22;
            this.imagepicturebox.TabStop = false;
            // 
            // bookeduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.booking);
            this.Name = "bookeduser";
            this.Size = new System.Drawing.Size(852, 402);
            this.Load += new System.EventHandler(this.bookeduser_Load);
            this.booking.ResumeLayout(false);
            this.booking.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagepicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel booking;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLineTextBox datetextbox;
        private Guna.UI.WinForms.GunaLineTextBox totalpricetextbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel days;
        private Guna.UI.WinForms.GunaPictureBox imagepicturebox;
        private Guna.UI.WinForms.GunaLineTextBox transporttextbox;
        private Guna.UI.WinForms.GunaLineTextBox destinationtextbox;
        private Guna.UI.WinForms.GunaLineTextBox trippricetextbox;
        private Guna.UI.WinForms.GunaLineTextBox Durationtextbox;
        private Guna.UI.WinForms.GunaLineTextBox accomodationtextbox;
        private Guna.UI.WinForms.GunaLineTextBox quantitytextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addpackagetext;
        private System.Windows.Forms.Label ticketno;
        private System.Windows.Forms.Label ticket;
        private System.Windows.Forms.Timer timerbook;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
    }
}
