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
            if (MyGlobal.globalcross == 1)
            {
                MyGlobal.globalcross = 0;
                detail.Visible = false;
            }
            if (MyGlobal.closedetail == 1)
            {
                detail.Visible = false;
                MyGlobal.closedetail = 0;
            }
        }
        int countrightclick = 1;
        int countleftclick = 0;
        private void left_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            specialbutton2.Visible = true;
            speciallabel2.Visible = true;
            pictureBox3.Visible = true;
            specialbutton3.Visible = true;
            speciallabel3.Visible = true;
            pictureBox4.Visible = true;
            specialbutton4.Visible = true;
            speciallabel4.Visible = true;

            countrightclick = 0;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    string image = "Select * from specialchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    button1value = dt.Rows[i]["SN"].ToString();
                    if (count == 1)                    {                        //SN = SN - 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        specialbutton1.Text = destination;
                        speciallabel1.Text = label;
                    }                    if (count == 2)                    {                        //SN = SN - 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        specialbutton2.Text = destination;
                        speciallabel2.Text = label;
                    }                    if (count == 3)                    {                        //SN = SN -1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        specialbutton3.Text = destination;
                        speciallabel3.Text = label;
                    }                    if (count == 4)                    {                        //SN = SN - 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        specialbutton4.Text = destination;
                        speciallabel4.Text = label;

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
                    string image = "Select * from specialchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    button1value = dt.Rows[SN]["SN"].ToString();
                    if (count == 1)                    {                        SN = SN + 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        specialbutton1.Text = destination;
                        speciallabel1.Text = label;
                    }                    if (count == 2)                    {                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        specialbutton2.Text = destination;
                        speciallabel2.Text = label;
                    }                    if (count == 3)                    {                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        specialbutton3.Text = destination;
                        speciallabel3.Text = label;
                    }                    if (count == 4)                    {                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        specialbutton4.Text = destination;
                        speciallabel4.Text = label;
                        count = 1;                    }                    count++;
                    MessageBox.Show("hi");

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
                                specialbutton2.Visible = false;
                                speciallabel2.Visible = false;
                            }
                            if (j == 1)
                            {
                                pictureBox3.Visible = false;
                                specialbutton3.Visible = false;
                                speciallabel3.Visible = false;
                            }
                            if (j == 2)
                            {
                                pictureBox4.Visible = false;
                                specialbutton4.Visible = false;
                                speciallabel4.Visible = false;
                            }
                        }
                        if (count == 3)
                        {
                            for (j = 0; j < 2; j++)
                            {
                                if (j == 0)
                                {
                                    pictureBox2.Visible = false;
                                    specialbutton2.Visible = false;
                                    speciallabel2.Visible = false;
                                }
                                if (j == 1)
                                {
                                    pictureBox3.Visible = false;
                                    specialbutton3.Visible = false;
                                    speciallabel3.Visible = false;
                                }
                            }
                        }
                        if (count == 4)
                        {
                            for (j = 0; j < 1; j++)
                            {
                                if (j == 0)
                                {
                                    pictureBox2.Visible = false;
                                    specialbutton2.Visible = false;
                                    speciallabel2.Visible = false;
                                }
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
