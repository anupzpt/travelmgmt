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
    public partial class Usermainpanel : UserControl
    {
        public Usermainpanel()
        {
            InitializeComponent();
        }

        private void Usermainpanel_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.userprofile==1)
            {
                profile.Visible = true;
                sendmessage.Visible = false;
                logout.Visible=false;
                changepassword.Visible = false;
                MyGlobal.userprofile = 0;
            }
            if (MyGlobal.userlogout==1)
            {
                profile.Visible = false;
                sendmessage.Visible = false;
                logout.Visible = true;
                changepassword.Visible = false;
                MyGlobal.userlogout = 0;
            }
            if(MyGlobal.nobutton==1)
            {
                logout.Visible = false;
                MyGlobal.nobutton = 0;
            }
            if(MyGlobal.message==1)
            {
                profile.Visible = false;
                sendmessage.Visible = true;
                logout.Visible = false;
                changepassword.Visible = false;
                MyGlobal.message = 2;
            }
        }
    }
}
