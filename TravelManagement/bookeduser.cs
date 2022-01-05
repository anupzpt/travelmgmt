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
    public partial class bookeduser : UserControl
    {
        public bookeduser()
        {
            InitializeComponent();
        }

        private void bookeduser_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();
        }
        int i = 0;

        private void timerbook_Tick(object sender, EventArgs e)
        {
            //i = 0;

            //if (MyGlobal.ticketbook == 2)
            //{
            //    SqlConnection con = new SqlConnection(MyGlobal.constring);
            //    try
            //    {
            //        con.Open();
            //        string query = "Select *from booking ";
            //        SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        string username = dt.Rows[i]["username"].ToString();
            //        try
            //        {
            //            if (string.Equals(username, MyGlobal.username))
            //            {
            //                Durationtextbox.Text = dt.Rows[i]["duration"].ToString();
            //                transporttextbox.Text = dt.Rows[i]["transport"].ToString();
            //                accomodationtextbox.Text = dt.Rows[i]["accomodation"].ToString();
            //                destinationtextbox.Text = dt.Rows[i]["location"].ToString();
            //                trippricetextbox.Text = dt.Rows[i]["tripprice"].ToString();
            //                datetextbox.Text = dt.Rows[i]["date"].ToString();
            //                quantitytextbox.Text = dt.Rows[i]["quantity"].ToString();
            //                totalpricetextbox.Text = dt.Rows[i]["totalprice"].ToString();
            //                ticketno.Text = dt.Rows[i]["ticketno"].ToString();
            //                imagepicturebox.Text = dt.Rows[i]["picture"].ToString();
            //                imagepicturebox.Image = Image.FromFile(imagepicturebox.Text);
            //                MyGlobal.ticketbook = 0;
            //                MessageBox.Show("feri clicked");
            //            }
            //        }
            //        catch (Exception)
            //        {
            //        }
            //        imagepicturebox.Image = Image.FromFile(imagetextbox.Text);
            //        i++;

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    finally
            //    {

            //    }

            //}
        }
       
        private void right_Click(object sender, EventArgs e)
        {
            MyGlobal.Tripprice = 1;
        }

        private void left_Click(object sender, EventArgs e)
        {
            i = 0;
            MyGlobal.Tripprice = 1;
        }
        public void setvalue()
        {
            i = 0;
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            if (MyGlobal.Tripprice == 1)
            {
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                try
                {
                    con.Open();
                    string query = "Select *from booking ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string username = dt.Rows[i]["username"].ToString();
                    try
                   {
                        if (string.Equals(username, MyGlobal.username))
                        {
                            MyGlobal.Tripprice = 0;
                            Durationtextbox.Text = dt.Rows[i]["duration"].ToString();
                            transporttextbox.Text = dt.Rows[i]["transport"].ToString();
                            accomodationtextbox.Text = dt.Rows[i]["accomodation"].ToString();
                            destinationtextbox.Text = dt.Rows[i]["location"].ToString();
                            trippricetextbox.Text = dt.Rows[i]["tripprice"].ToString();
                            datetextbox.Text = dt.Rows[i]["date"].ToString();
                            quantitytextbox.Text = dt.Rows[i]["quantity"].ToString();
                            totalpricetextbox.Text = dt.Rows[i]["totalprice"].ToString();
                            ticketno.Text = dt.Rows[i]["ticketno"].ToString();
                            imagepicturebox.Text = dt.Rows[i]["picture"].ToString();
                            imagepicturebox.Image = Image.FromFile(imagepicturebox.Text);
                           // MessageBox.Show("feri clicked");
                        }
                    }
                    catch (Exception)
                    {
                    }
                    i++;

                }
                catch (Exception ex)
                { }
                finally
                { }

            }
        }
    }
}
