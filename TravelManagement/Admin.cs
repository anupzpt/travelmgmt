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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            adminadd.Visible = true;
            admindelete.Visible = false;
            adminupdate.Visible = false;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            adminadd.Visible = false;
            admindelete.Visible = false;
            adminupdate.Visible = true;
            

            MyGlobal.updatebutton = 1;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            adminadd.Visible = false;
            admindelete.Visible = true;
            adminupdate.Visible = false;
            MyGlobal.deletebutton = 1;
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.crosstimer = 1;
            MyGlobal.admincrossbutton = 1;
            MyGlobal.deletetimer = 1;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panelforbutton.Location = new Point(200, 20);
            adminadd.Location = new Point(200, 100);
            adminadd.Size = new Size(900, 400);
            adminupdate.Location = new Point(200, 100);
            adminupdate.Size = new Size(900, 400);
            admindelete.Location = new Point(200, 100);
            admindelete.Size = new Size(900, 400);
        }

       
    }
}
