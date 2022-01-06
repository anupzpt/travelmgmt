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
    public partial class changepassword : UserControl
    {
        public changepassword()
        {
            InitializeComponent();
        }

        private void usernametext_Click(object sender, EventArgs e)
        {
            usernametext.Clear();
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
          
        }

        private void newpassword_Click(object sender, EventArgs e)
        {
            newpassword.Clear();
        }
        int button = 0;
        private void eye_Click(object sender, EventArgs e)
        {
            button = 1;
            eye2.BringToFront();
            eye.SendToBack();
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            button = 2;
            eye.BringToFront();
            eye2.SendToBack();
        }

        private void changepassword_Load(object sender, EventArgs e)
        {
            Eyetimer.Start();
            password.UseSystemPasswordChar = true;
            newpassword.UseSystemPasswordChar = true;
            savebutton.Enabled = false;
        }

        private void Eyetimer_Tick(object sender, EventArgs e)
        {
            if (button == 1)
            {
                password.UseSystemPasswordChar = false;
                newpassword.UseSystemPasswordChar = false;
                button = 0;
            }
            if (button == 2)
            {
                password.UseSystemPasswordChar = true;
                newpassword.UseSystemPasswordChar = true;
                button = 0;
            }
        }

      

        private void savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            if(usernametext.Text=="" |password.Text=="")
            {
                savebutton.Enabled = false;
                MessageBox.Show("Enter Username and Password.");
            }
            else
            {
                savebutton.Enabled = true;
            }
            
                con.Open();
                string query = "Update login set Password ='" + newpassword.Text + "'where Password= '" + password.Text + " '" ;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("YOUR PASSWORD IS SUCCESSFULLY CHANGED...");
                usernametext.Text = "USERNAME";
                password.Text = null;
                newpassword.Text = "NEW PASSWORD";
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            string query = "select *from login where Username='" + usernametext.Text + "'";
            SqlDataAdapter sta = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sta.Fill(dt);
            string userpassword = dt.Rows[0]["Password"].ToString();
            if (string.Equals(userpassword, password.Text))
            {
                password.ForeColor = Color.Green;
                newpassword.Enabled = true;
                savebutton.Enabled = true;
            }
            else
            {
                password.ForeColor = Color.Red;
                newpassword.Enabled = false;
                savebutton.Enabled = false;
            }
        }

        private void usernametext_Enter(object sender, EventArgs e)
        {
            usernametext.Text = null;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = null;
        }

        private void newpassword_Enter(object sender, EventArgs e)
        {
            newpassword.Text = null;
        }
    }
}
