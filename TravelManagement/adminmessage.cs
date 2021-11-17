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
    public partial class adminmessage : UserControl
    {
        public adminmessage()
        {
            InitializeComponent();
        }

        private void adminmessage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            try
            {
                con.Open();

                string query = "Select *from login";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; ;)
                {
                    string verify = dt.Rows[i]["verify"].ToString();
                    if(string.Equals(verify,"user"))
                    {
                        string user = dt.Rows[i]["Username"].ToString();
                        selectComboBox.Items.Add(user);

                    }

                    i++;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

        }
      

        private void savebutton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            string query = "insert into message (title,message,date,sender,reciver) Values ('" + titletextbox.Text + "','" + messagetext.Text + "','" + date+ "','" + MyGlobal.username + "','" + selectComboBox.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Message Delivered");
            titletextbox.Text = null;
            messagetext.Text = null;

        }
        

        private void selectComboBox_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void selectComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            try
            {
                con.Open();
               // string image = "Select *from message Where CONVERT(VARCHAR,sender)='" + selectComboBox.Text + "';";

                 string image = "Select *from login Where CONVERT(VARCHAR,Username)='" + selectComboBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void messagetext_TextChanged(object sender, EventArgs e)
        {
          //  messagetext.Text = null;
        }

        private void messagetext_MouseDown(object sender, MouseEventArgs e)
        {
            messagetext.Text = null;

        }
    }
}
