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
    public partial class bookeddataforadmin : UserControl
    {
        public bookeddataforadmin()
        {
            InitializeComponent();
        }
        int refreshvalue = 0;
        private void bookeddataforadmin_Load(object sender, EventArgs e)
        {
            bookedtimer.Start();
            refreshvalue = 1;
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            refreshvalue = 1;
        }

        private void bookedtimer_Tick(object sender, EventArgs e)
        {
            if(refreshvalue==1)
            {
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                try
                {
                    con.Open();
                    string query = "Select * from booking";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    booking.Rows.Clear();
                    int sn = 0;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        sn++;
                        booking.Rows.Add(sn, dataRow["name"], dataRow["number"], dataRow["username"], dataRow["location"], dataRow["quantity"], dataRow["date"], dataRow["duration"], dataRow["ticketno"], dataRow["totalprice"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                refreshvalue = 0; 
            }
        }
    }
}
