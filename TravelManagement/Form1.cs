using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loggedin.Visible = false;
            refreshtimer.Start();

        }

     

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (MyGlobal.loginsucess == 1 || MyGlobal.loginsucess == 2)
            {
                if (MyGlobal.admin == 1 )
                {
                    afterloggedadmin.Visible = true;
                    afterloggeduser.Visible = false;

                }
                if (MyGlobal.user==1)
                {
                    afterloggeduser.Visible = true;
                    afterloggedadmin.Visible = false;

                }
            }
            else
            {
                loggedin.Visible = true;

            }
            gunaCirclePictureBox2.BringToFront();
            gunaCirclePictureBox1.SendToBack();

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
             afterloggedadmin.Visible = false;
             loggedin.Visible = false;
            afterloggeduser.Visible = false;
            gunaCirclePictureBox1.BringToFront();
            gunaCirclePictureBox2.SendToBack();
        }

        private void refreshtimer_Tick(object sender, EventArgs e)
        {
            //Display admin panel if login suess
            if(MyGlobal.loginsucess==1)
            {
                if(MyGlobal.admin==1)
                {
                    afterloggedadmin.Visible = true;
                    afterloggeduser.Visible = false;

                    loggedin.Visible = false;
                    MyGlobal.loginsucess = 2;
                }
                if (MyGlobal.user == 1)
                {
                    loggedin.Visible = false;
                    afterloggeduser.Visible = true;
                    afterloggedadmin.Visible = false;
                    MyGlobal.loginsucess = 2;

                }

            }
          
            if(MyGlobal.loginsucess==0)
            {
                homepageusercontrol.Visible = true;
                //usermainpanel.Visible = false;
                user.Visible = false;
                logout.Visible = false;
                changepassword.Visible = false;
                afterloggeduser.Visible = false;
                afterloggedadmin.Visible = false;
                loggedin.Visible = true;
                MyGlobal.loginsucess = -1;
            }
            
            if (MyGlobal.displayadminfrontpage == 1)
            {
                adminforntpage.Visible = true;

                adminreceive.Visible = false;
                addnewadmin.Visible = false;
                bookeddataforadmin.Visible = false;
                changepassword.Visible = false;
                logout.Visible = false;
                
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;

                MyGlobal.displayadminfrontpage = 0;
            }
            //if (MyGlobal.displayadminfrontpage == 0)
            //{
            //    adminforntpage.Visible = false;

            //}
            if (MyGlobal.displayloginpage==1)
            {
                loggedin.Visible = true;
                gunaCirclePictureBox2.BringToFront();
                gunaCirclePictureBox1.SendToBack();
                MyGlobal.displayloginpage = 0;
            }
            if(MyGlobal.adminreceive==1)
            {
                adminreceive.Visible = true;
            
                adminforntpage.Visible = false;
                addnewadmin.Visible = false;
                bookeddataforadmin.Visible = false;
                changepassword.Visible = false;
                logout.Visible = false;
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.adminreceive = 0;
            }

            if(MyGlobal.addadmin==1)
            {
                addnewadmin.Visible = true;

                bookeddataforadmin.Visible = false;
                changepassword.Visible = false;
                logout.Visible = false;
                adminreceive.Visible = false;
                adminforntpage.Visible = false;
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.addadmin = 0;
            }
            if(MyGlobal.bookingadmin==1)
            {
                bookeddataforadmin.Visible = true;

                changepassword.Visible = false;
                logout.Visible = false;
                addnewadmin.Visible = false;
                adminreceive.Visible = false;
                adminforntpage.Visible = false;
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.bookingadmin = 0;
            }
            if (MyGlobal.changepassword==1)
            {
                changepassword.Visible = true;
                user.Visible = false;
                logout.Visible = false;
                addnewadmin.Visible = false;
                adminreceive.Visible = false;
                adminforntpage.Visible = false;
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.changepassword = 0;
            }
         
            if (MyGlobal.userprofile == 1 )
            {
                // usermainpanel.Visible = true;
                user.Visible = true;
                logout.Visible = false;
                changepassword.Visible = false;
                adminforntpage.Visible = false;
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.userprofile = 0;

              //  MessageBox.Show("kichkich");
            }
            if(MyGlobal.userlogout == 1)
            {
                logout.Visible = true;

                user.Visible = false;
                changepassword.Visible = false;

                addnewadmin.Visible = false;
                bookeddataforadmin.Visible = false;
                adminreceive.Visible = false;
                adminforntpage.Visible = false;
                
                homepageusercontrol.Visible = false;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.userlogout = 0;
            }
            if (MyGlobal.nobutton == 1)
            {
                logout.Visible = false;
                user.Visible = false;
                changepassword.Visible = false;
                addnewadmin.Visible = false;
                bookeddataforadmin.Visible = false;
                adminreceive.Visible = false;
                adminforntpage.Visible = false; 
                homepageusercontrol.Visible = true;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.nobutton = 0;
            }
            if (MyGlobal.message == 1)
            {
                receiveuser.Visible = true;
                logout.Visible = false;
                user.Visible = false;
                changepassword.Visible = false;
                adminforntpage.Visible = false;
                homepageusercontrol.Visible = false ;
                aboutususercontrol.Visible = false;
                tourusercontrolform.Visible = false;
                trekkingusercontrol.Visible = false;
                specialusercontrol.Visible = false;
                contactusercontrol.Visible = false;
                MyGlobal.message = 0;
            }

            }

        private void Home_Click_1(object sender, EventArgs e)
        {
           
            homepageusercontrol.Visible = true;
            aboutususercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Aboutus_Click_1(object sender, EventArgs e)
        {
            

            homepageusercontrol.Visible = false;
            aboutususercontrol.Visible = true;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Tours_Click_1(object sender, EventArgs e)
        {
          

            homepageusercontrol.Visible = false;
            aboutususercontrol.Visible = false;
            tourusercontrolform.Visible = true;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Trekking_Click_1(object sender, EventArgs e)
        {
           

            homepageusercontrol.Visible = false;
            aboutususercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = true;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Specialbutton_Click_1(object sender, EventArgs e)
        {
            

            homepageusercontrol.Visible = false;
            aboutususercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = true;
            contactusercontrol.Visible = false;
        }

        private void Contact_Click_1(object sender, EventArgs e)
        {
            

            homepageusercontrol.Visible = false;
            aboutususercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = true;
        }

        private void adminreceive_Load(object sender, EventArgs e)
        {

        }
    }
}
