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
    public partial class addimage : UserControl
    {
        public addimage()
        {
            InitializeComponent();
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
                pictureBox.Image = new Bitmap(Image.FromFile(imagelocation),new Size(pictureBox.Width, pictureBox.Height));
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            if (MyGlobal.admininfo == 5)
            {
                try
                {
                    con.Open();
                    string query = "insert into imagetable (Tour) Values ('" + imagetextbox.Text + "' )";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 6)
            {
                try
                {
                    con.Open();
                    string query = "insert into imagetable (Trekking) Values ('" + imagetextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 7)
            {
                try
                {
                    con.Open();
                    string query = "insert into imagetable (Special) Values ('" + imagetextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 8)
            {
                try
                {
                    con.Open();
                    string query = "insert into imagetable (Homepage) Values ('" + imagetextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }

        }

    }
}
