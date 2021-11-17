using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class bookedconform : UserControl
    {
        public bookedconform()
        {
            InitializeComponent();
        }
        int ran;
        private void bookpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
                string query = "insert into booking (name,number,email,date,quantity,location,duration,transport,accomodation,tripprice,totalprice,username,ticketno) Values" +
                    " ('" + MyGlobal.name+ "','" + MyGlobal.number + "','" + MyGlobal.email + "','" + MyGlobal.date + "'," +
                    "'" + MyGlobal.quantity + "','" + MyGlobal.location + "','" + MyGlobal.duration + "','" + MyGlobal.transport + "','" + MyGlobal.accomodation + "'," +
                    "'" + MyGlobal.tripprice + "','" + 000 + "','" + MyGlobal.username + "','" + ran + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("YOUR BOOKING IS CONFIRMED");
                datelabel.Text = null;
                ticketlabel.Text = null;
                destinationlabel.Text = null;
                namelabel.Text = null;
                phonenolabel.Text = null;
                emaillabel.Text = null;
                quantitylabel.Text = null;
                durationlabel.Text = null;
                transportlabel.Text = null;
                trippricelabel.Text = null;
            }
            catch (Exception)
            {

            }
        }

        private void bookedconform_Load(object sender, EventArgs e)
        {
            Booktimer.Start();
            
            
        }
        
        private void Booktimer_Tick(object sender, EventArgs e)
        {
           if(MyGlobal.displaybooked==1)
            {
                datelabel.Text = MyGlobal.date;
                ticketlabel.Text = "1000";
                destinationlabel.Text = MyGlobal.location;
                namelabel.Text = MyGlobal.name;
                phonenolabel.Text = MyGlobal.number;
                emaillabel.Text = MyGlobal.email;
                quantitylabel.Text = MyGlobal.quantity;
                durationlabel.Text = MyGlobal.duration;
                transportlabel.Text = MyGlobal.transport;
                trippricelabel.Text = MyGlobal.tripprice;
                Random r = new Random();
                ran = r.Next(3000, 9000);
                ticketlabel.Text = ran.ToString();
                MyGlobal.displaybooked = 0;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        //private void cancel_Click_1(object sender, EventArgs e)
        //{
        //    datelabel.Text = null;
        //    ticketlabel.Text = null;
        //    destinationlabel.Text = null;
        //    namelabel.Text = null;
        //    phonenolabel.Text = null;
        //    emaillabel.Text = null;
        //    quantitylabel.Text = null;
        //    durationlabel.Text = null;
        //    transportlabel.Text = null;
        //    trippricelabel.Text = null;
        //}
    }
}
