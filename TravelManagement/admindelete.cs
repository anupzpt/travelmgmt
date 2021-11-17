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
    public partial class admindelete : UserControl
    {
        public admindelete()
        {
            InitializeComponent();
        }
        string location;

        private void admindelete_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from changepanel where CONVERT(VARCHAR, Location)='" + selectComboBox.Text + "'";
                cmd.ExecuteNonQuery();

                destinationtextbox.Text = null;
                trippricetextbox.Text = null;
                descriptiontextbox.Text = null;
                Durationtextbox.Text = null;
                transporttextbox.Text = null;
                accomodationtextbox.Text = null;
                imagetextbox.Text = null;
            }
            catch(Exception)
            {

            }
        }

        private void filebutton_Click(object sender, EventArgs e)
        {
            string imagelocation;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = dialog.FileName;
                imagetextbox.Text = imagelocation;
                imagepicturebox.Image = Image.FromFile(imagelocation);
            }
        }

        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = selectComboBox.Text;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
                string query = "Select *From changepanel Where CONVERT(VARCHAR,Location)='" + selectComboBox.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                descriptiontextbox.Text = dt.Rows[0]["Descripition"].ToString();
                Durationtextbox.Text = dt.Rows[0]["Duration"].ToString();
                transporttextbox.Text = dt.Rows[0]["Transport"].ToString();
                accomodationtextbox.Text = dt.Rows[0]["Accomodation"].ToString();
                destinationtextbox.Text = dt.Rows[0]["Location"].ToString();
                trippricetextbox.Text = dt.Rows[0]["Pricelabel"].ToString();
                imagetextbox.Text = dt.Rows[0]["Picture"].ToString();
                imagepicturebox.Image = Image.FromFile(imagetextbox.Text);
            }
            catch(Exception)
            {

            }
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            if (MyGlobal.deletebutton == 1)
            {
                selectComboBox.Items.Clear();
                if (MyGlobal.admininfo == 1)
                {

                    try
                    {
                        con.Open();

                        string image = "Select *from changepanel";
                        SqlDataAdapter sda = new SqlDataAdapter(image, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; ;)
                        {
                            string destionation = dt.Rows[i]["Location"].ToString();
                            selectComboBox.Items.Add(destionation);

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
                if (MyGlobal.admininfo == 2)
                {
                    try
                    {
                        con.Open();

                        string image = "Select *from trekchangepanel";
                        SqlDataAdapter sda = new SqlDataAdapter(image, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; ;)
                        {
                            string destionation = dt.Rows[i]["treklocation"].ToString();
                            selectComboBox.Items.Add(destionation);

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
                if (MyGlobal.admininfo == 3)
                {
                    try
                    {
                        con.Open();

                        string image = "Select *from specialchangepanel";
                        SqlDataAdapter sda = new SqlDataAdapter(image, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; ;)
                        {
                            string destionation = dt.Rows[i]["speciallocation"].ToString();
                            selectComboBox.Items.Add(destionation);
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
                if (MyGlobal.admininfo == 4)
                {
                    try
                    {
                        string image = "Select *from hompagechangepanel";
                        SqlDataAdapter sda = new SqlDataAdapter(image, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; ;)
                        {
                            string destionation = dt.Rows[i]["hompagelocation"].ToString();
                            selectComboBox.Items.Add(destionation);
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
                MyGlobal.deletebutton = 0;
            }

        }

        private void deletetimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.deletetimer==1)
            {
                
                destinationtextbox.Text = null;
                trippricetextbox.Text = null;
                descriptiontextbox.Text = null;
                Durationtextbox.Text = null;
                transporttextbox.Text = null;
                accomodationtextbox.Text = null;
                imagetextbox.Text = null;
                MyGlobal.deletetimer = 0;
            }
        }
    }
}
