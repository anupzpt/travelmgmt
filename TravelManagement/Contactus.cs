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
    public partial class Contactus : UserControl
    {
        public Contactus()
        {
            InitializeComponent();
        }

        private void Contactus_Load(object sender, EventArgs e)
        {
            contactustext.Location = new Point(575, 200);
        }
    }
}
