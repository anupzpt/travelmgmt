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
    public partial class Contactusdetail : UserControl
    {
        public Contactusdetail()
        {
            InitializeComponent();
        }

        private void Contactusdetail_Load(object sender, EventArgs e)
        {
            contactuslabel.Location = new Point(73, 42);
            contactimagepanel.Location = new Point(62, 89);
            contactimagepanel.Size = new Size(500, 300);
            havequestionpanel.Location = new Point(700, 20);
            havequestionpanel.Size = new Size(600, 400);
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
           
                try
                {
                string date = DateTime.Now.ToString();
                string reciver = "anu";
                    con.Open();
                    string query = "insert into message (title,message,sender,reciver,email,date) Values ('" + titletext.Text + "','" + messagetext.Text + "','" + nametext.Text + "','"+reciver +"','" + emailtext.Text + "','"+date+"')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SEND");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SEND FAIL");
                }
                finally
                {
                    con.Close();
                }
        }
    }
}
