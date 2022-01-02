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
            passwordtextbox.UseSystemPasswordChar = true;
            Eyetimer.Start();
            eye2.SendToBack();
           
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
                    MyGlobal.userlogout = 2;
                }
                else
                {
                    MessageBox.Show(" LOGIN UNSUCCESSFUL ");
                    usertextbox.Text = null;
                    passwordtextbox.Text = null;
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
        

        

              
        int viewbutton = 0;
        private void eye_Click(object sender, EventArgs e)
        {
            viewbutton = 1;
            eye2.BringToFront();
            eye.SendToBack();
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            viewbutton = 2;
            eye.BringToFront();
            eye2.SendToBack();
        }

        private void Eyetimer_Tick(object sender, EventArgs e)
        {
            if (viewbutton == 1)
            {
                passwordtextbox.UseSystemPasswordChar = false;

                viewbutton = 0;
            }
            if (viewbutton == 2)
            {
                passwordtextbox.UseSystemPasswordChar = true;
                viewbutton = 0;
            }
        }

        private void usertextbox_MouseDown(object sender, MouseEventArgs e)
        {
            usertextbox.Text = null;
        }

        private void passwordtextbox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtextbox.Text = null;
        }

        private void usertextbox_Enter(object sender, EventArgs e)
        {
            usertextbox.Text = null;
        }

        private void passwordtextbox_Enter(object sender, EventArgs e)
        {
            passwordtextbox.Text = null;
        }
    }
}
