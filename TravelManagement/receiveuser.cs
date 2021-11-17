using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class receiveuser : UserControl
    {
        public receiveuser()
        {
            InitializeComponent();
        }
        int end = 100;

        private void sendmessage_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
        }

        

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (MyGlobal.inboxuser == 1)
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
                MyGlobal.inboxuser = 0;

            }
        }
        //if(MyGlobal.message==2)
        //{
        //    SqlConnection con = new SqlConnection(MyGlobal.constring);
        //    try
        //    {
        //        con.Open();

        //        string image = "Select *from message";
        //        SqlDataAdapter sda = new SqlDataAdapter(image, con);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        for (int i = 0; ;)
        //        {
        //            string user = dt.Rows[i]["reciver"].ToString();
        //            if (string.Equals(user, MyGlobal.username))
        //            {
        //                string admin = dt.Rows[i]["sender"].ToString();
        //                if (!selectComboBox.Items.Contains(admin))
        //                {
        //                    selectComboBox.Items.Add(admin);
        //                }
        //            }
        //            i++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        con.Close();
        //        // RefreshTimer.Stop();
        //    }
        //}

    
        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    SqlConnection con = new SqlConnection(MyGlobal.constring);
        //    try
        //    {

        //        con.Open();
        //        string image = "Select *from message Where CONVERT(VARCHAR,Sender)='" + MyGlobal.username + "';";
        //        SqlDataAdapter sda = new SqlDataAdapter(image, con);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        for (int i = 0; ; i++)
        //        {
        //            string title = dt.Rows[i]["title"].ToString();
        //            string message = dt.Rows[i]["message"].ToString();
        //            string date = dt.Rows[i]["date"].ToString();
        //            ////////////////
        //            Label Date = new Label();
        //            Date.Name = "Datedisplay" + i.ToString();
        //            Date.Text = date;
        //            Date.Location = new Point(650, end - 30);
        //            Date.Font = new Font("Playfair Display", 14, FontStyle.Underline);
        //            /////////////
        //            Label l = new Label();
        //            l.Name = "Titlelabel" + i.ToString();
        //            l.Text = "Message Title : ";
        //            l.Location = new Point(100, end);
        //            l.Size = new Size(160, 60);
        //            l.Font = new Font("Playfair Display", 14, FontStyle.Bold);
        //            l.BackColor = Color.Beige;

        //            ////////////////////
        //            Label Titlelabel = new Label();
        //            Titlelabel.Name = "title" + i.ToString();
        //            Titlelabel.Text = title;
        //            Titlelabel.Location = new Point(250, end);
        //            Titlelabel.Size = new Size(568, 60);
        //            Titlelabel.Font = new Font("Playfair Display", 14, FontStyle.Bold);
        //            Titlelabel.BackColor = Color.Aqua;




        //            //////////////////////////////////
        //            end = end + 70;
        //            Label Message = new Label();
        //            Message.Name = "Message" + i.ToString();
        //            Message.Text = message;
        //            Message.Location = new Point(170, end);
        //            Message.Size = new Size(568, 150);
        //            Message.Font = new Font("Playfair Display", 12, FontStyle.Bold);
        //            Message.BorderStyle = BorderStyle.FixedSingle;
        //            ////////////////////////
        //            Panel back = new Panel();
        //            back.Name = "backpanel" + i.ToString();
        //            back.Location = new Point(21, 23);
        //            back.Size = new Size(747, 92);
        //            back.Controls.Add(l);
        //            MessageDisplaypanel.Controls.Add(l);
        //            MessageDisplaypanel.Controls.Add(Titlelabel);
        //            MessageDisplaypanel.Controls.Add(Message);
        //            MessageDisplaypanel.Controls.Add(Date);


        //            end = end + 200;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    Label l2 = new Label();
        //    l2.Name = "titlel2";
        //    l2.Text = null;
        //    l2.Location = new Point(170, end);
        //    l2.Size = new Size(568, 26);
        //    l2.Font = new Font("Arial", 15, FontStyle.Bold);
        //    MessageDisplaypanel.Controls.Add(l2);
        }
    }
}
