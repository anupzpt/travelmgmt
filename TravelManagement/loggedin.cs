using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelManagement
{
    public partial class loggedin : UserControl
    {
        public loggedin()
        {
            InitializeComponent();
        }
        private void donthaveaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerpanel.Visible = true;

        }

        private void loggedin_Load(object sender, EventArgs e)
        {
            
            registerpanel.Visible = false;
           // passwordtextbox.UseSystemPasswordChar = true;

        }



        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            try
            {
                con.Open();
                string query = "select *from login where Username='" + usertextbox.Text + "'";
                SqlDataAdapter sta = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sta.Fill(dt);
                string userpassword = dt.Rows[0]["Password"].ToString();
                if (string.Equals(userpassword, passwordtextbox.Text))
                {
                    MyGlobal.username = dt.Rows[0]["Username"].ToString();
                    string verify = dt.Rows[0]["verify"].ToString();
                    MyGlobal.loginsucess = 1;
                    if (string.Equals(verify, "admin"))
                    {
                        MyGlobal.admin = 1;
                        MyGlobal.user = 0;

                    }
                    if (string.Equals(verify, "user"))
                    {
                        MyGlobal.user = 1;
                        MyGlobal.admin = 0;
                    }
                }
                else
                {
                    MessageBox.Show(" LOGIN UNSUCCESSFUL ");

                }
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
           
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void loginhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            registerpanel.Visible = false;
        }
        

        

        private void usertextbox_MouseDown(object sender, MouseEventArgs e)
        {
            usertextbox = null;
        }

        private void passwordtextbox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtextbox = null;
        }
    }
}
