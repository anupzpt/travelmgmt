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
    public partial class Aboutus : UserControl
    {
        public Aboutus()
        {
            InitializeComponent();
        }

        private void Aboutus_Load(object sender, EventArgs e)
        {
            aboutustext.Location = new Point(575, 100);
        }
    }
}
