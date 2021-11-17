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
    public partial class Homepageusercontrol : UserControl
    {
        public Homepageusercontrol()
        {
            InitializeComponent();
        }

        private void Homepageusercontrol_Load(object sender, EventArgs e)
        {
            homepage.Size = new Size(840, 489);
            search.Location = new Point(0, 492);
            search.Size = new Size(840, 205);
            explorenepal.Location = new Point(0, 700);
            explorenepal.Size = new Size(900, 1100);
            hiking.Location = new Point(0, 1150);
            hiking.Size = new Size(900, 400);
            //  rara.Location = new Point(0, 1510);
            // rara.Size = new Size(840, 261);
            lastpanel.Location = new Point(0, 1600);
            lastpanel.Size = new Size(840, 400);
        }
    }
}
