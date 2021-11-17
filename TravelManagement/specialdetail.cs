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
    public partial class specialdetail : UserControl
    {
        public specialdetail()
        {
            InitializeComponent();
        }
        int SN = 4;
        string button1value;
        string button2value;
        string button3value;
        string button4value;
        private void specialdetail_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();

            try
            {
                specialtourlabel.Location = new Point(635, 45);
                bestpanel1.Location = new Point(100, 100);
                bestpanel2.Location = new Point(400, 100);
                bestpanel3.Location = new Point(700, 100);
                bestpanel4.Location = new Point(1000, 100);
               // detail.Visible = false;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                try
                {
                    con.Open();
                    string image = "Select * from specialchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[0]["speciallocation"].ToString();
                    string destination1 = dt.Rows[1]["speciallocation"].ToString();
                    string destination2 = dt.Rows[2]["speciallocation"].ToString();
                    string destination3 = dt.Rows[3]["speciallocation"].ToString();
                    string label = dt.Rows[0]["specialpricelabel"].ToString();
                    string label1 = dt.Rows[1]["specialpricelabel"].ToString();
                    string label2 = dt.Rows[2]["specialpricelabel"].ToString();
                    string label3 = dt.Rows[3]["specialpricelabel"].ToString();
                    string bestpanel = dt.Rows[0]["specialpicture"].ToString();
                    string bestpanel1 = dt.Rows[1]["specialpicture"].ToString();
                    string bestpanel2 = dt.Rows[2]["specialpicture"].ToString();
                    string bestpanel3 = dt.Rows[3]["specialpicture"].ToString();

                    button1value = dt.Rows[0]["SN"].ToString();
                    button2value = dt.Rows[1]["SN"].ToString();
                    button3value = dt.Rows[2]["SN"].ToString();
                    button4value = dt.Rows[3]["SN"].ToString();

                    pictureBox1.Image = Image.FromFile(bestpanel);
                    pictureBox2.Image = Image.FromFile(bestpanel1);
                    pictureBox3.Image = Image.FromFile(bestpanel2);
                    pictureBox4.Image = Image.FromFile(bestpanel3);
                    specialbutton1.Text = destination;
                    specialbutton2.Text = destination1;
                    specialbutton3.Text = destination2;
                    specialbutton4.Text = destination3;
                    speciallabel1.Text = label;
                    speciallabel2.Text = label1;
                    speciallabel3.Text = label2;
                    speciallabel4.Text = label3;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            catch(Exception)
            {

            }
        }
        private void speciallabel4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 



        private void specialbutton1_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button1value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 1;
            MyGlobal.treakingbuttonpressed = 0;
        }

        private void specialbutton2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button2value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 1;
            MyGlobal.treakingbuttonpressed = 0;
        }

        private void specialbutton3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button3value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 1;
            MyGlobal.treakingbuttonpressed = 0;
        }

      

        private void specialbutton4_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button4value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 1;
            MyGlobal.treakingbuttonpressed = 0;
        }

        private void detail_Load(object sender, EventArgs e)
        {

        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            if (MyGlobal.closedetail == 1)
            {
                detail.Visible = false;
                MyGlobal.closedetail = 0;
            }
        }
    }
}
