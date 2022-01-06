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
    public partial class tourinnepal : UserControl
    {
        public tourinnepal()
        {
            InitializeComponent();
        }
        int SN = 4;
        string button1value;
        string button2value;
        string button3value;
        string button4value;
        private void tourinnepal_Load(object sender, EventArgs e)
        {
            //lost.Visible = false;
          //  detail.Visible = false;
            tournepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            Refreshtimer.Start();

            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {

                con.Open();
                string image = "Select * from changepanel";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string destination = dt.Rows[0]["Location"].ToString();
                string destination1 = dt.Rows[1]["Location"].ToString();
                string destination2 = dt.Rows[2]["Location"].ToString();
                string destination3 = dt.Rows[3]["Location"].ToString();
                string label = dt.Rows[0]["Pricelabel"].ToString();
                string label1 = dt.Rows[1]["Pricelabel"].ToString();
                string label2 = dt.Rows[2]["Pricelabel"].ToString();
                string label3 = dt.Rows[3]["Pricelabel"].ToString();
                string bestpanel = dt.Rows[0]["Picture"].ToString();
                string bestpanel1 = dt.Rows[1]["Picture"].ToString();
                string bestpanel2 = dt.Rows[2]["Picture"].ToString();
                string bestpanel3 = dt.Rows[3]["Picture"].ToString();
                button1value = dt.Rows[0]["SN"].ToString();
                button2value = dt.Rows[1]["SN"].ToString();
                button3value = dt.Rows[2]["SN"].ToString();
                button4value = dt.Rows[3]["SN"].ToString();
                pictureBox1.Image = Image.FromFile(bestpanel);
                pictureBox2.Image = Image.FromFile(bestpanel1);
                pictureBox3.Image = Image.FromFile(bestpanel2);
                pictureBox4.Image = Image.FromFile(bestpanel3);
                tourbutton1.Text = destination;
                tourbutton2.Text = destination1;
                tourbutton3.Text = destination2;
                tourbutton4.Text = destination3;
                tourlabel1.Text = label;
                tourlabel2.Text = label1;
                tourlabel3.Text = label2;
                tourlabel4.Text = label3;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void tourbutton1_Click(object sender, EventArgs e)
        {

            int temp = Convert.ToInt32(button1value);
            MyGlobal.SN = temp;
            MyGlobal.tourbuttonpressed = 1;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 0;
            MyGlobal.homebuttonpressed = 0;
            detail.Visible = true;
        }

        private void tourbutton2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button2value);
            MyGlobal.SN = temp;
            MyGlobal.tourbuttonpressed = 1;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 0;
            MyGlobal.homebuttonpressed = 0;

            detail.Visible = true;
        }

        private void tourbutton3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button3value);
            MyGlobal.SN = temp;
            MyGlobal.tourbuttonpressed = 1;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 0;
            MyGlobal.homebuttonpressed = 0;
            detail.Visible = true;
        }

        private void tourbutton4_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button4value);
            MyGlobal.SN = temp;
            MyGlobal.tourbuttonpressed = 1;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 0;
            MyGlobal.homebuttonpressed = 0;
            detail.Visible = true;
        }
        public void Sample()
        {
            this.detail.Visible = false;
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {

            //if (MyGlobal.closedetail == 1)
            //{
            //    detail.Visible = false;
            //    MessageBox.Show("gsgs");
            //    MyGlobal.closedetail = 0;
            //}
            if(MyGlobal.globalcross == 1)
            {
                MyGlobal.globalcross = 0;
                detail.Visible = false;
            }
            if (MyGlobal.crossbuttonclick == 1)
            {
                MyGlobal.crossbuttonclick = 0;
                detail.Visible = false;
            }
        }
        int countrightclick = 1;
        int countleftclick = 0;
        private void left_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            tourbutton2.Visible = true;
            tourlabel2.Visible = true;
            pictureBox3.Visible = true;
            tourbutton3.Visible = true;
            tourlabel3.Visible = true;
            pictureBox4.Visible = true;
            tourbutton4.Visible = true;
            tourlabel4.Visible = true;

            countrightclick = 0;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    string image = "Select * from changepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    button1value = dt.Rows[i]["SN"].ToString();
                    if (count == 1)                    {                        //SN = SN - 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        tourbutton1.Text = destination;
                        tourlabel1.Text = label;
                    }                    if (count == 2)                    {                        //SN = SN - 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        tourbutton2.Text = destination;
                        tourlabel2.Text = label;
                    }                    if (count == 3)                    {                        //SN = SN -1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        tourbutton3.Text = destination;
                        tourlabel3.Text = label;
                    }                    if (count == 4)                    {                        //SN = SN - 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        tourbutton4.Text = destination;
                        tourlabel4.Text = label;

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
                    string image = "Select * from changepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    button1value = dt.Rows[SN]["SN"].ToString();
                    if (count == 1)                    {                        SN = SN + 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        tourbutton1.Text = destination;
                        tourlabel1.Text = label;
                    }                    if (count == 2)                    {                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        tourbutton2.Text = destination;
                        tourlabel2.Text = label;
                    }                    if (count == 3)                    {                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        tourbutton3.Text = destination;
                        tourlabel3.Text = label;
                    }                    if (count == 4)                    {                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        tourbutton4.Text = destination;
                        tourlabel4.Text = label;
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
                                tourbutton2.Visible = false;
                                tourlabel2.Visible = false;
                            }
                            if (j == 1)
                            {
                                pictureBox3.Visible = false;
                                tourbutton3.Visible = false;
                                tourlabel3.Visible = false;
                            }
                            if (j == 2)
                            {
                                pictureBox4.Visible = false;
                                tourbutton4.Visible = false;
                                tourlabel4.Visible = false;
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
                                    tourbutton3.Visible = false;
                                    tourlabel3.Visible = false;
                                }
                                if (j == 1)
                                {
                                    pictureBox4.Visible = false;
                                    tourbutton4.Visible = false;
                                    tourlabel4.Visible = false;
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
                                    tourbutton4.Visible = false;
                                    tourlabel4.Visible = false;
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
    }
}
