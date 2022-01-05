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
    public partial class tourusercontrolform : UserControl
    {
        public tourusercontrolform()
        {
            InitializeComponent();
        }

        private void tourusercontrolform_Load(object sender, EventArgs e)
        {
            tour.Size = new Size(1360, 550);
            tourinnepal.Location = new Point(0, 492);
            tourinnepal.Size = new Size(1360, 457);
            tourlastpanel.Location = new Point(0, 1000);
            tourlastpanel.Size = new Size(1360, 207);
            lastpanel.Location = new Point(0, 800);
            lastpanel.Size = new Size(1360, 200);
        }
    }
}
