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
    public partial class addnewadmin : UserControl
    {
        public addnewadmin()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string verify = "admin";
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                con.Open();
                string query = "insert into login (Username,Password,verify) Values ('" + usernametext.Text + "','" + password.Text + "','" + verify + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MyGlobal.logintimer = 1;
                MessageBox.Show("ADDED SUCCESSFULLY");
                usernametext.Text = "USERNAME";
                password.Text = null;

            }
            catch (Exception)
            {
                MessageBox.Show("not");
            }
        }
        int viewbutton = 0;

        private void eye_Click(object sender, EventArgs e)
        {
            viewbutton = 1;
            eye2.BringToFront();
            eye.SendToBack();
        }

        private void timereye_Tick(object sender, EventArgs e)
        {
            if (viewbutton == 1)
            {
                password.UseSystemPasswordChar = false;
                viewbutton = 0;
            }
            if (viewbutton == 2)
            {
                password.UseSystemPasswordChar = true;
                viewbutton = 0;
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            viewbutton = 2;
            eye.BringToFront();
            eye2.SendToBack();
        }

        private void addnewadmin_Load(object sender, EventArgs e)
        {
            timereye.Start();
            password.UseSystemPasswordChar = true;
            if(usernametext.Text==null ||password.Text==null)
            {
                savebutton.Enabled = false;
            }
        }
    }
}
