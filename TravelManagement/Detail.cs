using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelManagement
{
    public partial class Detail : UserControl
    {
        public Detail()
        {
            InitializeComponent();
        }
        string location;
        string duration1;
        string transport1;
        string accomodation1;
        string tripprice1;
        string image;
        private void Detail_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(45, 20);
            detaillabel.Location = new Point(62, 89);
            detaillabel.Size = new Size(900, 280);
            bookpanel.Location = new Point(800, 45);
            bookpanel.Size = new Size(400, 360);
            bookedconform.Visible = false;
            Refreshtimer.Start();
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            if (MyGlobal.treakingbuttonpressed==1){
                try
                {
                    con.Open();
                    string query = "Select *from trekchangepanel where SN='" + MyGlobal.SN + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string description = dt.Rows[0]["description"].ToString();
                    duration1 = dt.Rows[0]["duration"].ToString();
                    tripprice1 = dt.Rows[0]["trekpricelabel"].ToString();
                    accomodation1 = dt.Rows[0]["accomodation"].ToString();
                    transport1 = dt.Rows[0]["transport"].ToString();
                    location = dt.Rows[0]["treklocation"].ToString();
                    image = dt.Rows[0]["trekpicture"].ToString();
                    detailtext.Text = description;
                    durationlabel.Text = duration1;
                    trippricelabel.Text = tripprice1;
                    accomodationlabel.Text = accomodation1;
                    transportlabel.Text = transport1;
                    
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
            if (MyGlobal.tourbuttonpressed==1)
            {
                try
                {
                    con.Open();
                    string query = "Select *from changepanel where SN='" + MyGlobal.SN + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string description = dt.Rows[0]["Descripition"].ToString();
                    duration1 = dt.Rows[0]["Duration"].ToString();
                    tripprice1 = dt.Rows[0]["Tripprice"].ToString();
                    accomodation1 = dt.Rows[0]["Accomodation"].ToString();
                    transport1 = dt.Rows[0]["Transport"].ToString();
                    location = dt.Rows[0]["Location"].ToString();
                    image = dt.Rows[0]["Picture"].ToString();

                    detailtext.Text = description;
                    durationlabel.Text = duration1;
                    trippricelabel.Text = tripprice1;
                    accomodationlabel.Text = accomodation1;
                    transportlabel.Text = transport1;
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
            
            if (MyGlobal.specialbuttonpressed == 1)
            {
                try
                {
                    con.Open();
                    string query = "Select *from specialchangepanel where SN='" + MyGlobal.SN + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string description = dt.Rows[0]["descripition"].ToString();
                    duration1 = dt.Rows[0]["duration"].ToString();
                    tripprice1 = dt.Rows[0]["tripprice"].ToString();
                    accomodation1 = dt.Rows[0]["accomodation"].ToString();
                    transport1 = dt.Rows[0]["transport"].ToString();
                    location = dt.Rows[0]["speciallocation"].ToString();
                    image = dt.Rows[0]["specialpicture"].ToString();

                    detailtext.Text = description;
                    durationlabel.Text = duration1;
                    trippricelabel.Text = tripprice1;
                    accomodationlabel.Text = accomodation1;
                    transportlabel.Text = transport1;
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
            if (MyGlobal.homebuttonpressed == 1)
            {
                try
                {
                    con.Open();
                    string query = "Select *from hompagechangepanel where SN='" + MyGlobal.SN + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string description = dt.Rows[0]["descripition"].ToString();
                    duration1 = dt.Rows[0]["duration"].ToString();
                    tripprice1 = dt.Rows[0]["tripprice"].ToString();
                    accomodation1 = dt.Rows[0]["accomodation"].ToString();
                    transport1 = dt.Rows[0]["transport"].ToString();
                    location = dt.Rows[0]["hompagelocation"].ToString();
                    image = dt.Rows[0]["hompagepicture"].ToString();
                    detailtext.Text = description;
                    durationlabel.Text = duration1;
                    trippricelabel.Text = tripprice1;
                    accomodationlabel.Text = accomodation1;
                    transportlabel.Text = transport1;
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            quantityvalidity.Visible = false;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if ((char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                quantityvalidity.Visible = true;
            }
        }

        private void detailbutton_Click(object sender, EventArgs e)
        {
            detaillabel.Visible = true;
            includepanel.Visible = false;
            excludepanel.Visible = false;
        }

        private void includebutton_Click(object sender, EventArgs e)
        {
            detaillabel.Visible = false;
            includepanel.Visible = true;
            includepanel.BringToFront();
            excludepanel.Visible = false;
        }

        private void excludebutton_Click(object sender, EventArgs e)
        {
            excludepanel.Visible = true;
            excludepanel.BringToFront();
            includepanel.Visible = false;
            detaillabel.Visible = false;
        }

        private void photobutton_Click(object sender, EventArgs e)
        {

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            if (string.Equals(nametextbox.Text, "Name") || string.Equals(Phone.Text, "Mobile Number") || string.Equals(Email.Text, "Email") || string.Equals(Quantity.Text, "Quantity") || string.Equals(nametextbox.Text, null) || string.Equals(Phone.Text, null) || string.Equals(Email.Text, null) || string.Equals(Quantity.Text, null))
            {
                label2.Text = "Invalid data or null value not accepted ";
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;

                MyGlobal.displaybooked = 1;
                if (MyGlobal.loginsucess == 1 || MyGlobal.loginsucess == 2)
                {
                    Refreshtimer.Start();
                    bookedconform.Visible = true;
                    cancel.Visible = true;
                    MyGlobal.name = nametextbox.Text;
                    MyGlobal.number = Phone.Text;
                    MyGlobal.email = Email.Text;
                    MyGlobal.date = date.Text;
                    MyGlobal.quantity = Quantity.Text;
                    MyGlobal.location = location;
                    MyGlobal.duration = duration1;
                    MyGlobal.transport = transport1;
                    MyGlobal.accomodation = accomodation1;
                    MyGlobal.tripprice = tripprice1;
                    MyGlobal.image = image;
                    int calculate;
                    int price = Convert.ToInt32(MyGlobal.tripprice);
                    int quantity = Convert.ToInt32(MyGlobal.quantity);
                    calculate = price * quantity;
                    MyGlobal.totalprice = calculate.ToString();
                }
                else
                {
                    MyGlobal.displayloginpage = 1;
                }
            }
            //nametextbox.Text = "Name";
            //Phone.Text ="Mobile Number";
            //Email.Text = "Email";
            //Quantity.Text = "Quantity";
            //date.Text = "DATE";
        }

        private void nametextbox_MouseDown(object sender, MouseEventArgs e)
        {
            nametextbox.Text = null;

        }

        private void Phone_MouseDown(object sender, MouseEventArgs e)
        {
            Phone.Text = null;

        }

        private void Email_MouseDown(object sender, MouseEventArgs e)
        {
            Email.Text = null;
            string temp = Phone.Text;
            if(temp.Length<10)
            {
                validlabel.Visible = true;
            }
        }

        private void Quantity_MouseDown(object sender, MouseEventArgs e)
        {
            Quantity.Text = null;

        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validlabel.Visible = false;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if ((char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                validlabel.Visible = true;
            }
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            tourinnepal tourinnepal = new tourinnepal();
            tourinnepal.Sample();
            treakinginnepal treakinginnepal = new treakinginnepal();
            treakinginnepal.Sample();
            explorenepal explorenepal = new explorenepal();
            explorenepal.Sample();
            MyGlobal.globalcross = 1;
            MyGlobal.closedetail = 1;
            MyGlobal.crossbuttonclick = 1;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            bookedconform.Visible = false;
            cancel.Visible = false;
            nametextbox.Text = "Name";
            Phone.Text = "Mobile Number";
            Email.Text = "Email";
            Quantity.Text = "Quantity";
            date.Text = "DATE";
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {

             
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(Email.Text,pattern))
            {
                errorProvider1.Clear();
                emailvalidation.Visible = false;
            }
            else
            {
                errorProvider1.SetError(this.Email, " ");
                emailvalidation.Visible = true;
                return;
            }
        }

        private void Phone_Click(object sender, EventArgs e)
        {
           if (Phone.TextLength<10)
            {
                validlabel.Visible = true;
            }
            else
            {
                validlabel.Visible = false;
            }
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bookedconform_Load(object sender, EventArgs e)
        {

        }
    }
}
