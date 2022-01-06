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
    public partial class aboutususercontrol : UserControl
    {
        public aboutususercontrol()
        {
            InitializeComponent();
        }

        private void aboutususercontrol_Load(object sender, EventArgs e)
        {
            aboutus.Size = new Size(1360, 489);
           aboutusdetail.Location = new Point(0, 492);
           aboutusdetail.Size = new Size(1360, 465);
           lastpanel.Location = new Point(0, 900);
            lastpanel.Size = new Size(1360, 300);

        }
    }
}
