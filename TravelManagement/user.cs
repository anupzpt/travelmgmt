using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            bookeduser.Visible = false;
            deleteusers.Visible = false;
            updateuser.Visible = true;
            MyGlobal.updatebutton = 1;

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            bookeduser.Visible = false;
            deleteusers.Visible = true;
            updateuser.Visible = false;
            MyGlobal.deletebutton = 1;

        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.crosstimer = 1;
        }

        private void Booked_Click(object sender, EventArgs e)
        {
            
            bookeduser.Visible = true;
            deleteusers.Visible = false;
            updateuser.Visible = false;
            MyGlobal.bookedbutton = 1;
            MyGlobal.ticketbook = 1;
        }
    }
}
