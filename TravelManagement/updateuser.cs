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
    public partial class updateuser : UserControl
    {
        public updateuser()
        {
            InitializeComponent();
        }
        private void updateuser_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();
        }
        int i = 0;
        private void timerbook_Tick(object sender, EventArgs e)
        {

            
        }

        private void updatebutton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tickettextbox_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(MyGlobal.constring);
            //    con.Open();
            //    string query = "Select *From booking Where CONVERT(VARCHAR,ticketno)='" + tickettextbox.Text + "';";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            // //   destinationtextbox.Text = dt.Rows[0][""].ToString();
            //    durationtextbox.Text = dt.Rows[0]["duration"].ToString();
            //    transporttextbox.Text = dt.Rows[0]["transport"].ToString();
            //    accomodationtextbox.Text = dt.Rows[0]["accomodation"].ToString();
            //    destinationtextbox.Text = dt.Rows[0]["location"].ToString();
            //    trippricetextbox.Text = dt.Rows[0]["totalprice"].ToString();
            //    datetextbox.Text = dt.Rows[0]["date"].ToString();
            //    quantitytextbox.Text = dt.Rows[0]["quantity"].ToString();
            //    totalpricetextbox.Text = dt.Rows[0]["totalprice"].ToString();
            //    imagepicturebox.Text = dt.Rows[0]["picture"].ToString();
            //    imagepicturebox.Image = Image.FromFile(imagepicturebox.Text);
            //}
            //catch (Exception)
            //{

            //}
        }

        private void timerbook_Tick_1(object sender, EventArgs e)
        {
            
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
                            MyGlobal.Tripprice = 0;
                            //   MessageBox.Show(i.ToString());
                        }
                    }
                    catch (Exception)
                    {

                    }
                    //   imagepicturebox.Image = Image.FromFile(imagetextbox.Text);
                    i++;

                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
        }
        
        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            int calculate;
            int price = Convert.ToInt32(trippricetextbox.Text);
            int quantity = Convert.ToInt32(quantitytextbox.Text);
            calculate = price * quantity;
            try
            {
                con.Open();
              string query ="Update booking set date='"+ datetextbox.Text +"',quantity='" +quantitytextbox.Text + "',totalprice='" + calculate.ToString() + "' Where CONVERT (VARCHAR , ticketno)='" + ticketno.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                totalpricetextbox.Text = calculate.ToString();


            }
            catch (Exception)
            {

            }
        }
    }
}
