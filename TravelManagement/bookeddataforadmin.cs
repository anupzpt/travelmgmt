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

        private void bookeddataforadmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}
