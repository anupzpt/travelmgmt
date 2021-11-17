namespace TravelManagement
{
    partial class bookeddataforadmin
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
            this.bookedtimer = new System.Windows.Forms.Timer(this.components);
            this.designpanel = new System.Windows.Forms.Panel();
            this.refreshbutton = new Guna.UI.WinForms.GunaCircleButton();
            this.title = new System.Windows.Forms.Label();
            this.booking = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking)).BeginInit();
            this.SuspendLayout();
            // 
            // bookedtimer
            // 
            this.bookedtimer.Tick += new System.EventHandler(this.bookedtimer_Tick);
            // 
            // designpanel
            // 
            this.designpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.designpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.designpanel.Controls.Add(this.refreshbutton);
            this.designpanel.Controls.Add(this.title);
            this.designpanel.Controls.Add(this.booking);
            this.designpanel.Location = new System.Drawing.Point(0, 0);
            this.designpanel.Name = "designpanel";
            this.designpanel.Size = new System.Drawing.Size(900, 471);
            this.designpanel.TabIndex = 3;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbutton.AnimationHoverSpeed = 0.07F;
            this.refreshbutton.AnimationSpeed = 0.03F;
            this.refreshbutton.BackColor = System.Drawing.Color.LightGray;
            this.refreshbutton.BackgroundImage = global::TravelManagement.Properties.Resources.icons8_reset_48px;
            this.refreshbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshbutton.BaseColor = System.Drawing.Color.Transparent;
            this.refreshbutton.BorderColor = System.Drawing.Color.Black;
            this.refreshbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshbutton.FocusedColor = System.Drawing.Color.Empty;
            this.refreshbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshbutton.ForeColor = System.Drawing.Color.White;
            this.refreshbutton.Image = null;
            this.refreshbutton.ImageSize = new System.Drawing.Size(52, 52);
            this.refreshbutton.Location = new System.Drawing.Point(833, 5);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.refreshbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshbutton.OnHoverImage = null;
            this.refreshbutton.OnPressedColor = System.Drawing.Color.Black;
            this.refreshbutton.Size = new System.Drawing.Size(60, 57);
            this.refreshbutton.TabIndex = 3;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LightGray;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Font = new System.Drawing.Font("Playfair Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(453, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(370, 66);
            this.title.TabIndex = 2;
            this.title.Text = "BOOKED DATA";
            // 
            // booking
            // 
            this.booking.AllowUserToAddRows = false;
            this.booking.AllowUserToDeleteRows = false;
            this.booking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booking.BackgroundColor = System.Drawing.Color.White;
            this.booking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Name,
            this.Number,
            this.Username,
            this.Destination,
            this.Quantity,
            this.Date,
            this.Duration,
            this.TicketNo,
            this.TotalAmount});
            this.booking.Location = new System.Drawing.Point(158, 97);
            this.booking.Name = "booking";
            this.booking.ReadOnly = true;
            this.booking.Size = new System.Drawing.Size(605, 354);
            this.booking.TabIndex = 1;
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 45;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 140;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 90;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 53;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 190;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 70;
            // 
            // TicketNo
            // 
            this.TicketNo.HeaderText = "TicketNo";
            this.TicketNo.Name = "TicketNo";
            this.TicketNo.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // bookeddataforadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.designpanel);
            //this.Name = "bookeddataforadmin";
            this.Size = new System.Drawing.Size(900, 471);
            this.Load += new System.EventHandler(this.bookeddataforadmin_Load);
            this.designpanel.ResumeLayout(false);
            this.designpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designpanel;
        private System.Windows.Forms.DataGridView booking;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Timer bookedtimer;
        private Guna.UI.WinForms.GunaCircleButton refreshbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}
