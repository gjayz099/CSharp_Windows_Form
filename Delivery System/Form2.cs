using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_System
{
    public partial class Form2 : Form
    {
        ////Virable
        public static string FullnametextO;
        public static string GendertextO;
        public static string PhoneNumbertextO;
        public static string DestinationProvicetextO;
        public static string DestinationCitytextO;
        public static string datetimeO;
        public static string data;
        ////Form2
        public Form2()
        {
            InitializeComponent();
        }
        ////Submit Method .... If Statements
        public void Submit()
        {
            ////If Statements
            string gender;
            if (RDBfemale.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            ////Try Catch
            try
            {
                PersonO owner = new PersonO(TBfirstname.Text, TBlastname.Text, Convert.ToChar(TBmiddlename.Text), TBphonenum.Text, gender, CBBdestinationProv.Text, TBDestinationCity.Text);
                FullnametextO = owner.Fname + " " + owner.Lname + " " + owner.Mname;
                GendertextO = owner.Gender;
                PhoneNumbertextO = owner.PhoneN;
                DestinationProvicetextO = owner.DesTNTProv;
                DestinationCitytextO = owner.DesTNTCity;
                DateTime data0 = DateTime.Now;
                datetimeO = data0.ToString("dddd, dd MMMM yyyy");
                Form3 fm3 = new Form3(this);
                fm3.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Datails", "Windows");
            }
        }
        //////Event Submit Buttom
        private void BTNsubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }
        //////Event Log out Buttom
        private void BTNlogout_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are You Sure To Log Out?", "Windows", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                this.Hide();
                Form1 fm1 = new Form1();
                fm1.Show();
            }
            else
            {
                ///CANCEL
            }   
        }
    }
}
