namespace TravelManagement
{
    partial class bookedconform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookedconform));
            this.bookpanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.destinationlabel = new System.Windows.Forms.Label();
            this.ticketlabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.trippricelabel = new System.Windows.Forms.Label();
            this.transportlabel = new System.Windows.Forms.Label();
            this.durationlabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.phonenolabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tripprice = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.ticket = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.confirmbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Booktimer = new System.Windows.Forms.Timer(this.components);
            this.bookpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookpanel
            // 
            this.bookpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookpanel.BackgroundImage")));
            this.bookpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookpanel.Controls.Add(this.destinationlabel);
            this.bookpanel.Controls.Add(this.ticketlabel);
            this.bookpanel.Controls.Add(this.datelabel);
            this.bookpanel.Controls.Add(this.totallabel);
            this.bookpanel.Controls.Add(this.quantitylabel);
            this.bookpanel.Controls.Add(this.trippricelabel);
            this.bookpanel.Controls.Add(this.transportlabel);
            this.bookpanel.Controls.Add(this.durationlabel);
            this.bookpanel.Controls.Add(this.emaillabel);
            this.bookpanel.Controls.Add(this.phonenolabel);
            this.bookpanel.Controls.Add(this.namelabel);
            this.bookpanel.Controls.Add(this.Total);
            this.bookpanel.Controls.Add(this.quantity);
            this.bookpanel.Controls.Add(this.label1);
            this.bookpanel.Controls.Add(this.Tripprice);
            this.bookpanel.Controls.Add(this.duration);
            this.bookpanel.Controls.Add(this.ticket);
            this.bookpanel.Controls.Add(this.destination);
            this.bookpanel.Controls.Add(this.date);
            this.bookpanel.Controls.Add(this.phone);
            this.bookpanel.Controls.Add(this.email);
            this.bookpanel.Controls.Add(this.name);
            this.bookpanel.Controls.Add(this.confirmbutton);
            this.bookpanel.GradientBottomLeft = System.Drawing.Color.LightSteelBlue;
            this.bookpanel.GradientBottomRight = System.Drawing.Color.LightSlateGray;
            this.bookpanel.GradientTopLeft = System.Drawing.Color.CadetBlue;
            this.bookpanel.GradientTopRight = System.Drawing.Color.Silver;
            this.bookpanel.Location = new System.Drawing.Point(0, 0);
            this.bookpanel.Name = "bookpanel";
            this.bookpanel.Quality = 10;
            this.bookpanel.Size = new System.Drawing.Size(715, 435);
            this.bookpanel.TabIndex = 13;
            this.bookpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookpanel_Paint);
            // 
            // destinationlabel
            // 
            this.destinationlabel.AutoSize = true;
            this.destinationlabel.BackColor = System.Drawing.Color.Transparent;
            this.destinationlabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationlabel.Location = new System.Drawing.Point(286, 58);
            this.destinationlabel.Name = "destinationlabel";
            this.destinationlabel.Size = new System.Drawing.Size(73, 26);
            this.destinationlabel.TabIndex = 29;
            this.destinationlabel.Text = "label11";
            // 
            // ticketlabel
            // 
            this.ticketlabel.AutoSize = true;
            this.ticketlabel.BackColor = System.Drawing.Color.Transparent;
            this.ticketlabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketlabel.Location = new System.Drawing.Point(434, 29);
            this.ticketlabel.Name = "ticketlabel";
            this.ticketlabel.Size = new System.Drawing.Size(77, 26);
            this.ticketlabel.TabIndex = 28;
            this.ticketlabel.Text = "label10";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(434, 3);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(68, 26);
            this.datelabel.TabIndex = 27;
            this.datelabel.Text = "label9";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.BackColor = System.Drawing.Color.Transparent;
            this.totallabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(153, 329);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(68, 26);
            this.totallabel.TabIndex = 26;
            this.totallabel.Text = "label8";
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.BackColor = System.Drawing.Color.Transparent;
            this.quantitylabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylabel.Location = new System.Drawing.Point(155, 292);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(66, 26);
            this.quantitylabel.TabIndex = 25;
            this.quantitylabel.Text = "label7";
            // 
            // trippricelabel
            // 
            this.trippricelabel.AutoSize = true;
            this.trippricelabel.BackColor = System.Drawing.Color.Transparent;
            this.trippricelabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trippricelabel.Location = new System.Drawing.Point(153, 256);
            this.trippricelabel.Name = "trippricelabel";
            this.trippricelabel.Size = new System.Drawing.Size(68, 26);
            this.trippricelabel.TabIndex = 24;
            this.trippricelabel.Text = "label6";
            // 
            // transportlabel
            // 
            this.transportlabel.AutoSize = true;
            this.transportlabel.BackColor = System.Drawing.Color.Transparent;
            this.transportlabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportlabel.Location = new System.Drawing.Point(153, 222);
            this.transportlabel.Name = "transportlabel";
            this.transportlabel.Size = new System.Drawing.Size(66, 26);
            this.transportlabel.TabIndex = 23;
            this.transportlabel.Text = "label5";
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.BackColor = System.Drawing.Color.Transparent;
            this.durationlabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationlabel.Location = new System.Drawing.Point(153, 191);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(67, 26);
            this.durationlabel.TabIndex = 22;
            this.durationlabel.Text = "label4";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(153, 160);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(67, 26);
            this.emaillabel.TabIndex = 21;
            this.emaillabel.Text = "label3";
            // 
            // phonenolabel
            // 
            this.phonenolabel.AutoSize = true;
            this.phonenolabel.BackColor = System.Drawing.Color.Transparent;
            this.phonenolabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenolabel.Location = new System.Drawing.Point(153, 129);
            this.phonenolabel.Name = "phonenolabel";
            this.phonenolabel.Size = new System.Drawing.Size(67, 26);
            this.phonenolabel.TabIndex = 20;
            this.phonenolabel.Text = "label2";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(153, 103);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(50, 26);
            this.namelabel.TabIndex = 19;
            this.namelabel.Text = "text";
            this.namelabel.Click += new System.EventHandler(this.text_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(56, 329);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(95, 26);
            this.Total.TabIndex = 18;
            this.Total.Text = "TOTAL  :";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(22, 292);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(129, 26);
            this.quantity.TabIndex = 17;
            this.quantity.Text = "QUANTITY  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "TRANSPORT  :";
            // 
            // Tripprice
            // 
            this.Tripprice.AutoSize = true;
            this.Tripprice.BackColor = System.Drawing.Color.Transparent;
            this.Tripprice.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tripprice.Location = new System.Drawing.Point(10, 256);
            this.Tripprice.Name = "Tripprice";
            this.Tripprice.Size = new System.Drawing.Size(140, 26);
            this.Tripprice.TabIndex = 15;
            this.Tripprice.Text = "TRIP PRICE  :";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.BackColor = System.Drawing.Color.Transparent;
            this.duration.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(16, 191);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(133, 26);
            this.duration.TabIndex = 14;
            this.duration.Text = "DURATION  :";
            // 
            // ticket
            // 
            this.ticket.AutoSize = true;
            this.ticket.BackColor = System.Drawing.Color.Transparent;
            this.ticket.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket.Location = new System.Drawing.Point(303, 29);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(132, 26);
            this.ticket.TabIndex = 13;
            this.ticket.Text = "TICKET NO :";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.BackColor = System.Drawing.Color.Transparent;
            this.destination.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(122, 58);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(158, 26);
            this.destination.TabIndex = 12;
            this.destination.Text = "DESTINATION :";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(333, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(83, 26);
            this.date.TabIndex = 11;
            this.date.Text = "DATE  :";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(12, 129);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(134, 26);
            this.phone.TabIndex = 10;
            this.phone.Text = "PHONE NO  :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(60, 160);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(87, 26);
            this.email.TabIndex = 9;
            this.email.Text = "EMAIL :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(57, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 26);
            this.name.TabIndex = 8;
            this.name.Text = "NAME  :";
            // 
            // confirmbutton
            // 
            this.confirmbutton.AnimationHoverSpeed = 0.07F;
            this.confirmbutton.AnimationSpeed = 0.03F;
            this.confirmbutton.BackColor = System.Drawing.Color.Transparent;
            this.confirmbutton.BaseColor1 = System.Drawing.Color.LightSeaGreen;
            this.confirmbutton.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.confirmbutton.BorderColor = System.Drawing.Color.Black;
            this.confirmbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirmbutton.FocusedColor = System.Drawing.Color.Empty;
            this.confirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.ForeColor = System.Drawing.Color.White;
            this.confirmbutton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.confirmbutton.Image = null;
            this.confirmbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmbutton.Location = new System.Drawing.Point(308, 366);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.OnHoverBaseColor1 = System.Drawing.Color.Peru;
            this.confirmbutton.OnHoverBaseColor2 = System.Drawing.Color.BurlyWood;
            this.confirmbutton.OnHoverBorderColor = System.Drawing.Color.PeachPuff;
            this.confirmbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutton.OnHoverImage = null;
            this.confirmbutton.OnPressedColor = System.Drawing.Color.MistyRose;
            this.confirmbutton.Radius = 8;
            this.confirmbutton.Size = new System.Drawing.Size(122, 43);
            this.confirmbutton.TabIndex = 6;
            this.confirmbutton.Text = "CONFIRM";
            this.confirmbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // Booktimer
            // 
            this.Booktimer.Tick += new System.EventHandler(this.Booktimer_Tick);
            // 
            // bookedconform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookpanel);
            this.Name = "bookedconform";
            this.Size = new System.Drawing.Size(715, 435);
            this.Load += new System.EventHandler(this.bookedconform_Load);
            this.bookpanel.ResumeLayout(false);
            this.bookpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bookpanel;
        private Guna.UI.WinForms.GunaGradientButton confirmbutton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label ticketlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label trippricelabel;
        private System.Windows.Forms.Label transportlabel;
        private System.Windows.Forms.Label durationlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label phonenolabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tripprice;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label ticket;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label destinationlabel;
        private System.Windows.Forms.Timer Booktimer;
    }
}
