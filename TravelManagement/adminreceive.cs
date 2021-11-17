using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class adminreceive : UserControl
    {
        public adminreceive()
        {
            InitializeComponent();
        }

       
        int end = 70;

        private void adminreceive_Load(object sender, EventArgs e)
        {
            emailtimer.Start();
          //  adminmessage.Visible = false;

        }

        private void emailtimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.inbox==1)
            {
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                try
                {
                    con.Open();
                    string image = "Select *from message Where CONVERT(VARCHAR,reciver)='" + MyGlobal.username + "';";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; ; i++)
                    {
                        string title = dt.Rows[i]["title"].ToString();
                        string message = dt.Rows[i]["message"].ToString();
                        string date = dt.Rows[i]["date"].ToString();
                        //////////////////
                        Label Date = new Label();
                        Date.Name = "Datedisplay" + i.ToString();
                        Date.Text = date;
                        Date.Location = new Point(900, end - 35);
                        Date.Size = new Size(250, 30);
                        Date.Font = new Font("Playfair Display", 14, FontStyle.Bold);
                        //Date.BorderStyle = BorderStyle.FixedSingle;
                        //Date.BackColor = Color.Pink;
                        ///////////////
                        Label l = new Label();
                        l.Name = "Titlelabel" + i.ToString();
                        l.Text = "Message Title : ";
                        l.Location = new Point(100, end);
                        l.Size = new Size(160, 60);
                        l.Font = new Font("Playfair Display", 14, FontStyle.Bold);
                        // l.BorderStyle = BorderStyle.FixedSingle;
                        //l.BackColor = Color.Purple;

                        //////////////////////
                        Label Titlelabel = new Label();
                        Titlelabel.Name = "title" + i.ToString();
                        Titlelabel.Text = title;
                        Titlelabel.Location = new Point(270, end);
                        Titlelabel.Size = new Size(860, 60);
                        Titlelabel.Font = new Font("Playfair Display", 14, FontStyle.Bold);
                        //Titlelabel.BorderStyle = BorderStyle.FixedSingle;
                        //Titlelabel.BackColor = Color.GreenYellow;

                        ////////////////////////////////////
                        end = end + 60;
                        Label Message = new Label();
                        Message.Name = "Message" + i.ToString();
                        Message.Text = message;
                        Message.Location = new Point(170, end);
                        Message.Size = new Size(900, 100);
                        Message.Font = new Font("Playfair Display", 12, FontStyle.Bold);
                        Message.BorderStyle = BorderStyle.FixedSingle;

                        MessageDisplaypanel.Controls.Add(l);
                        MessageDisplaypanel.Controls.Add(Titlelabel);
                        MessageDisplaypanel.Controls.Add(Message);
                        MessageDisplaypanel.Controls.Add(Date);
                        end = end + 150;
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
                MyGlobal.inbox = 0;

            }

        }

        private void add_Click(object sender, EventArgs e)
        {
           
        }

        private void add2_Click(object sender, EventArgs e)
        {
          //  adminmessage.Visible = false;
            adminmessage.SendToBack();
            add.BringToFront();
            add2.SendToBack();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            adminmessage.Visible = true;
            adminmessage.BringToFront();
            add2.BringToFront();
            add.SendToBack();
        }
    }
}
