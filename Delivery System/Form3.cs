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
    public partial class Form3 : Form
    {
        ////Virable Form2
        Form2 fm2;
        //////Form3 And Form2
        public Form3(Form2 ffm2)
        {
            InitializeComponent();
            this.fm2 = ffm2;

            LBFullname.Text = Form2.FullnametextO;
            LBGender.Text = Form2.GendertextO;
            LBPhoneN.Text = Form2.PhoneNumbertextO;
            LBDestinationP.Text = Form2.DestinationProvicetextO;
            LBDestinationC.Text = Form2.DestinationCitytextO;
            LBdatetime.Text = Form2.datetimeO;
        }
        //////Virable Resever
        public string FullnametextR;
        public string PhoneNumbertextR;
        //////Virable Owner
        public static string Fullnametext;
        public static string Gendertext;
        public static string PhoneNumbertext;
        public static string DestinationProvicetext;
        public static string DestinationCitytext;

        //////Save Method And Try Catch
        private void Save()
        {
            DialogResult ask = MessageBox.Show("Are You Sure To Put in Datagridview?", "Windows", MessageBoxButtons.YesNo);
            ///If Statements
            if (ask == DialogResult.Yes)
            {
                ////Try catch
                try
                {
                    PersonR Resever = new PersonR(TBfirstnameR.Text, TBlastnameR.Text, Convert.ToChar(TBmiddlenameR.Text), TBphonenumberR.Text);
                    FullnametextR = Resever.Fname + " " + Resever.Lname + " " + Resever.Mname;
                    PhoneNumbertextR = Resever.PhoneN;
                    Fullnametext = LBFullname.Text;
                    Gendertext = LBGender.Text;
                    PhoneNumbertext = LBPhoneN.Text;
                    DestinationProvicetext = LBDestinationP.Text;
                    DestinationCitytext = LBDestinationC.Text;

                    /////Form2 DataGridView  add/// 
                    string[] D = new string[] { Fullnametext, Gendertext, PhoneNumbertext, DestinationProvicetext, DestinationCitytext, FullnametextR, PhoneNumbertextR };
                    fm2.dataGridView1.Rows.Add(D);
                    /////Form2 Empty Text////
                    fm2.TBfirstname.Text = string.Empty;
                    fm2.TBlastname.Text = string.Empty;
                    fm2.TBmiddlename.Text = string.Empty;
                    fm2.TBphonenum.Text = string.Empty;
                    fm2.CBBdestinationProv.Text = string.Empty;
                    fm2.TBDestinationCity.Text = string.Empty;
                    fm2.RDBfemale.Checked = false;
                    fm2.RDBmale.Checked = false;
                    ///Hide Form 3
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Errrooorrr" + "Windows");
                }
            }
            else
            {
                ///CANCEL
            } 
        }
        //////Event Save Buttom
        private void BTNSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        //////Event Cancel Buttom
        private void BTNcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
