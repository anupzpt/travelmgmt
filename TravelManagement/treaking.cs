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
    public partial class treaking : UserControl
    {
        public treaking()
        {
            InitializeComponent();
        }

        private void treaking_Load(object sender, EventArgs e)
        {
            trektext.Location = new Point(520, 150);
            string SN = "1";
            try
            {

                
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
            }
            catch(Exception)
            {

            }
      
        }
        int SN = 1;

        private void right_Click(object sender, EventArgs e)
        {
            try
            {
                SN = SN + 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
            }
            catch (Exception ex)
            {
                SN = 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
            }
            finally
            {

            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            try
            {
                SN = SN - 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
            }
            catch (Exception ex)
            {
                SN = 1;
            }
            finally
            {

            }
        }
    }
}
