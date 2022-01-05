using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            bookeduser.Visible = false;
            updateuser.Visible = true;
            Printbutton.Visible = false;
            MyGlobal.updatebutton = 1;
            MyGlobal.updatetimer = 1;
            MyGlobal.Tripprice = 1;

            updateuser.setvalue();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            bookeduser.Visible = false;
            updateuser.Visible = false;
            MyGlobal.deletebutton = 1;

        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.crosstimer = 1;
        }

        private void Booked_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("clicked");
            bookeduser.Visible = true;
            Printbutton.Visible = true;
            updateuser.Visible = false;
            MyGlobal.bookedbutton = 1;
            MyGlobal.Tripprice = 1;
            bookeduser.setvalue();
        }
        int xheight, xwidth;

        private void user_Load(object sender, EventArgs e)
        {
            Printbutton.Visible = false;
            panelforbutton.Location = new Point(200, 20);
            bookeduser.Location = new Point(200, 90);
            bookeduser.Size = new Size(900, 400);
            updateuser.Location = new Point(200, 90);
            updateuser.Size = new Size(900, 400);
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            xheight = 900;
            xwidth = 360;
            Bitmap captureBitmap = new Bitmap(xheight, xwidth, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, -200, -295, captureRectangle.Size);
            captureBitmap.Save(@"D:\Capture.jpg", ImageFormat.Jpeg);
            MessageBox.Show("Printed Successfully");




        }

    }
}
