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
    public partial class treakinginnepal : UserControl
    {
        public treakinginnepal()
        {
            InitializeComponent();
        }

        int SN = 4;
        string button1value;
        string button2value;
        string button3value;
        string button4value;
        private void treakinginnepal_Load(object sender, EventArgs e)
        {
            trekkingnepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            Refreshtimer.Start();
            // detail.Visible = false;
            // Crossbutton.Visible = false;
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
                trekbutton1.Text = destination;
                trekbutton2.Text = destination1;
                trekbutton3.Text = destination2;
                trekbutton4.Text = destination3;
                treklabel1.Text = label;
                treklabel2.Text = label1;
                treklabel3.Text = label2;
                treklabel4.Text = label3;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void trekbutton1_Click(object sender, EventArgs e)
        {
           
                int temp = Convert.ToInt32(button1value);
                MyGlobal.SN = temp;
                detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
            // detail.BringToFront();


        }

        private void trekbutton2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button2value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;
        }

        private void trekbutton3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button3value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;

        }

        private void trekbutton4_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(button4value);
            MyGlobal.SN = temp;
            detail.Visible = true;
            MyGlobal.tourbuttonpressed = 0;
            MyGlobal.specialbuttonpressed = 0;
            MyGlobal.treakingbuttonpressed = 1;

        }

        private void detail_Load(object sender, EventArgs e)
        {

        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.closedetail==1)
            {
                detail.Visible = false;
                MyGlobal.closedetail = 0;
            }
        }
        int countrightclick = 1;
        int countleftclick = 0;

        private void left_Click(object sender, EventArgs e)
        {
            if (countleftclick == 0)            {                SN = SN - 5;                countleftclick++;                countrightclick = 0;            }
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
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
                    if (count == 1)                    {                        SN = SN - 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        trekbutton4.Text = destination;
                        treklabel4.Text = label;
                    }                    if (count == 2)                    {                        SN = SN - 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        trekbutton3.Text = destination;
                        treklabel3.Text = label;
                    }                    if (count == 3)                    {                        SN = SN -1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        trekbutton2.Text = destination;
                        treklabel2.Text = label;
                    }                    if (count == 4)                    {                        SN = SN - 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        trekbutton1.Text = destination;
                        treklabel1.Text = label;
                        count = 1;                    }                    count++;

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void right_Click(object sender, EventArgs e)
        {
            if(countrightclick==0)
            {
                SN = SN + 5;
                countleftclick = 0;
                countrightclick++;
            }
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            int count = 1;
            for(int i=1;i<=4;i++)
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
                        trekbutton1.Text = destination;
                        treklabel1.Text = label;
                    }                    if (count == 2)                    {                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        trekbutton2.Text = destination;
                        treklabel2.Text = label;
                    }                    if (count == 3)                    {                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        trekbutton3.Text = destination;
                        treklabel3.Text = label;
                    }                    if (count == 4)                    {                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        trekbutton4.Text = destination;
                        treklabel4.Text = label;
                        count = 1;                    }                    count++;

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
}
