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
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string verify = "user";
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                con.Open();
                string query = "insert into login (Username,Password,email,verify) Values ('" + usernametext.Text + "','" + password.Text + "','" + emailtextbox.Text + "','" + verify + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MyGlobal.logintimer = 1;
                MessageBox.Show("REGISTERED SUCCESSFULLY");

            }
            catch (Exception)
            {
                MessageBox.Show("not");
            }
        }

        private void usernametext_MouseClick(object sender, MouseEventArgs e)
        {
            //usernametext.Text = " ";
            //emailtextbox.Text = " ";
            //password.Text = " ";
            //rewrite.Text = " ";
        }
        int viewbutton = 0;
        private void eye_Click(object sender, EventArgs e)
        {
            viewbutton = 1;
            eye2.BringToFront();
            eye.SendToBack();
        }

        private void Eyetimer_Tick(object sender, EventArgs e)
        {
            if(viewbutton==1)
            {
                password.UseSystemPasswordChar = false;
                viewbutton = 0;
            }
            if(viewbutton==2)
            {
                password.UseSystemPasswordChar = true;
                viewbutton = 0;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
            Eyetimer.Start();
            password.UseSystemPasswordChar = true;
            donebutton.Enabled = false;

        }

        private void eye2_Click(object sender, EventArgs e)
        {
            viewbutton = 2;
            eye.BringToFront();
            eye2.SendToBack();
        }

        private void rewrite_TextChanged(object sender, EventArgs e)
        {
            if(password.Text.Trim()==rewrite.Text.Trim())
            {
                rewrite.ForeColor = Color.Green;
               donebutton.Enabled = true;
            }
            else
            {
                rewrite.ForeColor = Color.Red;
                donebutton.Enabled = false;
            }
        }

        private void usernametext_MouseDown(object sender, MouseEventArgs e)
        {
            usernametext.Text = null;

        }

        private void usernametext_MouseDown_1(object sender, MouseEventArgs e)
        {
            usernametext.Text = null;
        }
    }
}
