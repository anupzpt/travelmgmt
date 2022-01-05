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
    public partial class hiking : UserControl
    {
        public hiking()
        {
            InitializeComponent();
        }
        int SN = 4;

        string button1value;
        string button2value;
        string button3value;
        string button4value;
        private void hiking_Load(object sender, EventArgs e)
        {
            hike.Location = new Point(590, 15);
            nepaltour.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            Refreshtimer.Start();
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
                string image = "Select * from trekchangepanel";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string destination = dt.Rows[0]["treklocation"].ToString();
                string destination1 = dt.Rows[1]["treklocation"].ToString();
                string destination2 = dt.Rows[2]["treklocation"].ToString();
                string destination3 = dt.Rows[3]["treklocation"].ToString();
                string label = dt.Rows[0]["trekpricelabel"].ToString();
                string label1 = dt.Rows[1]["trekpricelabel"].ToString();
                string label2 = dt.Rows[2]["trekpricelabel"].ToString();
                string label3 = dt.Rows[3]["trekpricelabel"].ToString();
                /////////////////////////////////////////////////
                string bestpanel = dt.Rows[0]["trekpicture"].ToString();
                string bestpanel1 = dt.Rows[1]["trekpicture"].ToString();
                string bestpanel2 = dt.Rows[2]["trekpicture"].ToString();
                string bestpanel3 = dt.Rows[3]["trekpicture"].ToString();
                //////////////////////////////////////////////////////
                button1value = dt.Rows[0]["SN"].ToString();
                button2value = dt.Rows[1]["SN"].ToString();
                button3value = dt.Rows[2]["SN"].ToString();
                button4value = dt.Rows[3]["SN"].ToString();

                pictureBox1.Image = Image.FromFile(bestpanel);
                pictureBox2.Image = Image.FromFile(bestpanel1);
                pictureBox3.Image = Image.FromFile(bestpanel2);
                pictureBox4.Image = Image.FromFile(bestpanel3);
                hikebutton1.Text = destination;
                hikebutton2.Text = destination1;
                hikebutton3.Text = destination2;
                hikebutton4.Text = destination3;
                hikelabel1.Text = label;
                hikelabel2.Text = label1;
                hikelabel3.Text = label2;
                hikelabel4.Text = label3;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();

            }
        }
        int countrightclick = 1;
        int countleftclick = 0;
     

        private void right_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
            int temp = 0;
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    string image = "Select * from trekchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[SN]["treklocation"].ToString();
                    string label = dt.Rows[SN]["trekpricelabel"].ToString();
                    string bestpanel = dt.Rows[SN]["trekpicture"].ToString();
                    button1value = dt.Rows[SN]["SN"].ToString();
                    if (count == 1)                    {                        SN = SN + 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        hikebutton1.Text = destination;
                        hikelabel1.Text = label;
                    }                    if (count == 2)                    {                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        hikebutton2.Text = destination;
                        hikelabel2.Text = label;
                    }                    if (count == 3)                    {                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        hikebutton3.Text = destination;
                        hikelabel3.Text = label;
                    }                    if (count == 4)                    {                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        hikebutton4.Text = destination;
                        hikelabel4.Text = label;
                        count = 1;                    }                    count++;

                }
                catch (Exception ex)
                {
                    int j = 0;
                    if (count == 2)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (j == 0)
                            {
                                pictureBox2.Visible = false;
                                hikebutton2.Visible = false;
                                hikelabel2.Visible = false;
                            }
                            if (j == 1)
                            {
                                pictureBox3.Visible = false;
                                hikebutton3.Visible = false;
                                hikelabel3.Visible = false;
                            }
                            if (j == 2)
                            {
                                pictureBox4.Visible = false;
                                hikebutton4.Visible = false;
                                hikelabel4.Visible = false;
                            }
                        }
                    }
                    if (count == 3)
                    {

                        for (j = 0; j < 2; j++)
                        {
                            if (j == 0)
                            {
                                pictureBox3.Visible = false;
                                hikebutton3.Visible = false;
                                hikelabel3.Visible = false;
                            }
                            if (j == 1)
                            {
                                pictureBox4.Visible = false;
                                hikebutton4.Visible = false;
                                hikelabel4.Visible = false;
                            }
                        }
                    }
                    if (count == 4)
                    {
                        for (j = 0; j < 1; j++)
                        {
                            if (j == 0)
                            {
                                pictureBox4.Visible = false;
                                hikebutton4.Visible = false;
                                hikelabel4.Visible = false;
                            }
                        }
                    }


                }
                finally
                {
                    con.Close();
                }
            }

        }
        private void left_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            hikebutton2.Visible = true;
            hikelabel2.Visible = true;
            pictureBox3.Visible = true;
            hikebutton3.Visible = true;
            hikelabel3.Visible = true;
            pictureBox4.Visible = true;
            hikebutton4.Visible = true;
            hikelabel4.Visible = true;

            countrightclick = 0;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    string image = "Select * from trekchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[i]["treklocation"].ToString();
                    string label = dt.Rows[i]["trekpricelabel"].ToString();
                    string bestpanel = dt.Rows[i]["trekpicture"].ToString();
                    button1value = dt.Rows[i]["SN"].ToString();
                    if (count == 1)                    {                        //SN = SN - 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        hikebutton1.Text = destination;
                        hikelabel1.Text = label;
                    }                    if (count == 2)                    {                        //SN = SN - 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        hikebutton2.Text = destination;
                        hikelabel2.Text = label;
                    }                    if (count == 3)                    {                        //SN = SN -1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        hikebutton3.Text = destination;
                        hikelabel3.Text = label;
                    }                    if (count == 4)                    {                        //SN = SN - 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        hikebutton4.Text = destination;
                        hikelabel4.Text = label;

                    }                    count++;

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    SN = i;
                    SN++;
                    con.Close();
                }
            }
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            //if (MyGlobal.closedetail == 1)
            //{
            //    detail.Visible = false;
            //    MyGlobal.closedetail = 0;
            //}
            if (MyGlobal.crossbuttonclick == 1)
            {
                MyGlobal.crossbuttonclick = 0;
                detail.Visible = false;
            }
        }

        private void hikebutton1_Click(object sender, EventArgs e)
        {

            int temp = Convert.ToInt32(button1value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
        }

        private void hikebutton2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button2value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
        }

        private void hikebutton3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button3value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
        }

        private void hikebutton4_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button4value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            detail.Visible = false;
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Crossbutton.Visible = false;
        }
    }
    
}


