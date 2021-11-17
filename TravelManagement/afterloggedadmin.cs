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
    public partial class afterloggedadmin : UserControl
    {
        public afterloggedadmin()
        {
            InitializeComponent();
        }

        private void afterloggedadmin_Load(object sender, EventArgs e)
        {
            
            refreshtimer.Start();
        }

        private void refreshtimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.loginsucess==1||MyGlobal.loginsucess==2)
            {
                adminlabel.Text = MyGlobal.username;
            }
            //if(MyGlobal.user==1)
            //{
                
            //    modifydetailbutton.Visible = false;
            //    addadmin.Visible = false;
            //    bookeddatabutton.Visible = false;
            //}
            //if (MyGlobal.admin == 1)
            //{
            //    modifydetailbutton.Visible = true;
            //    addadmin.Visible = true;
            //    bookeddatabutton.Visible = true;
            //}
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.userlogout = 1;
            //MyGlobal.loginsucess = 0;
            //MyGlobal.displayadminfrontpage = 0;
        }

        private void addadmin_Click(object sender, EventArgs e)
        {
            MyGlobal.addadmin = 1;
        }

        private void bookeddatabutton_Click(object sender, EventArgs e)
        {

        }

        private void emailbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.adminreceive = 1;
            MyGlobal.inbox = 1;
        }

        private void passwordbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void modifydetailbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.displayadminfrontpage = 1;
        }
    }
}
