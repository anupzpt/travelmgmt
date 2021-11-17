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
    public partial class adminimage : UserControl
    {
        public adminimage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addimage.Visible = true;
            deleteimage.Visible = false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            addimage.Visible = false;
            deleteimage.Visible = true;
        }

        private void adminimage_Load(object sender, EventArgs e)
        {
            panelforbutton.Location = new Point(240, 0);
            addimage.Location = new Point(240, 50);
            addimage.Size = new Size(900, 400);
            deleteimage.Location = new Point(240, 50);
            deleteimage.Size = new Size(900, 400);
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.crosstimer = 1;
        }
    }
}
