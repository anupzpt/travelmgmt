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
    public partial class logout : UserControl
    {
        public logout()
        {
            InitializeComponent();
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.loginsucess = 0;
            MyGlobal.nobutton = 1;

            // MyGlobal.displayadminfrontpage = 0;
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            MyGlobal.nobutton = 1;

        }
    }
}
