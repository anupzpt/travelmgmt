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
    public partial class afterloggeduser : UserControl
    {
        public afterloggeduser()
        {
            InitializeComponent();
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            MyGlobal.userprofile = 1;
        }

        private void userlabel_Click(object sender, EventArgs e)
        {

        }

        private void afterloggeduser_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.userlogout = 1;
            
        }

        private void emailbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.message = 1;
            MyGlobal.inboxuser = 1;
        }

        private void passwordbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.changepassword = 1;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.userlogout==2)
            {
                userlabel.Text = MyGlobal.username;
                MyGlobal.userlogout = 0;//fari naya variable create garna naparos vanera 
            }
        }
    }
}
