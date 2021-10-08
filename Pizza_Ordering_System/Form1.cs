using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Ordering_System
{

    ///BY GJAY///

    //MAIN PROGRAM
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hawian Pizza
            HStextBox.Text = "0";
            HMtextBox.Text = "0";
            HLtextBox.Text = "0";
            //Chees Chessy
            CCStextBox.Text = "0";
            CCMtextBox.Text = "0";
            CCLtextBox.Text = "0";
            //Pepperoni
            PStextBox.Text = "0";
            PMtextBox.Text = "0";
            PLtextBox.Text = "0";
            //Ham & Chesse
            HCStextBox.Text = "0";
            HCMtextBox.Text = "0";
            HCLtextBox.Text = "0";
            //Drinks
            COKEtextBox.Text = "0";
            SPRITEtextBox.Text = "0";
            ROYALtextBox.Text = "0";

            //Hawian Pizza //Boolean
            HStextBox.Enabled = false;
            HMtextBox.Enabled = false;
            HLtextBox.Enabled = false;
            //Chesse Chessy //Boolean
            CCStextBox.Enabled = false;
            CCMtextBox.Enabled = false;
            CCLtextBox.Enabled = false;
            //Pepperoni //Boolean
            PStextBox.Enabled = false;
            PMtextBox.Enabled = false;
            PLtextBox.Enabled = false;
            //Ham & Cheesse //Boolean
            HCStextBox.Enabled = false;
            HCMtextBox.Enabled = false;
            HCLtextBox.Enabled = false;
            //Drinks /Coke/SPRITE/ROYAL //Boolean
            COKEtextBox.Enabled = false;
            SPRITEtextBox.Enabled = false;
            ROYALtextBox.Enabled = false;
        }

        private void HcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(HcheckBox.Checked == true)
            {
                HStextBox.Enabled = true;
                HMtextBox.Enabled = true;
                HLtextBox.Enabled = true;
            }
            if (HcheckBox.Checked == false)
            {
                HStextBox.Enabled = false;
                HMtextBox.Enabled = false;
                HLtextBox.Enabled = false;
                HStextBox.Text = "0";
                HMtextBox.Text = "0";
                HLtextBox.Text = "0";
            }
        }

        private void CCcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CCcheckBox.Checked == true)
            {
                CCStextBox.Enabled = true;
                CCMtextBox.Enabled = true;
                CCLtextBox.Enabled = true;
            }
            if (CCcheckBox.Checked == false)
            {
                CCStextBox.Enabled = false;
                CCMtextBox.Enabled = false;
                CCLtextBox.Enabled = false;
                CCStextBox.Text = "0";
                CCMtextBox.Text = "0";
                CCLtextBox.Text = "0";
            }
        }

        private void PcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(PcheckBox.Checked == true)
            {
                PStextBox.Enabled = true;
                PMtextBox.Enabled = true;
                PLtextBox.Enabled = true;
            }
            if(PcheckBox.Checked == false)
            {
                PStextBox.Enabled = false;
                PMtextBox.Enabled = false;
                PLtextBox.Enabled = false;
                PStextBox.Text = "0";
                PMtextBox.Text = "0";
                PLtextBox.Text = "0";
            }
        }

        private void HCcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(HCcheckBox.Checked == true)
            {
                HCStextBox.Enabled = true;
                HCMtextBox.Enabled = true;
                HCLtextBox.Enabled = true;
            }
            if (HCcheckBox.Checked == false)
            {
                HCStextBox.Enabled = false;
                HCMtextBox.Enabled = false;
                HCLtextBox.Enabled = false;
                HCStextBox.Text = "0";
                HCMtextBox.Text = "0";
                HCLtextBox.Text = "0";
            }
        }

        private void COKEcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(COKEcheckBox.Checked == true)
            {
                COKEtextBox.Enabled = true;
            }
            if (COKEcheckBox.Checked == false)
            {
                COKEtextBox.Enabled = false;
                COKEtextBox.Text = "0";
            }
        }

        private void SPRITEcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SPRITEcheckBox.Checked == true)
            {
                SPRITEtextBox.Enabled = true;
            }
            if (SPRITEcheckBox.Checked == false)
            {
                SPRITEtextBox.Enabled = false;
                SPRITEtextBox.Text = "0";
            }
        }

        private void ROYALcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ROYALcheckBox.Checked == true)
            {
                ROYALtextBox.Enabled = true;
            }
            if(ROYALcheckBox.Checked == false)
            {
                ROYALtextBox.Enabled = false;
                ROYALtextBox.Text = "0";
            }
        }

        private void HStextBox_Click(object sender, EventArgs e)
        {
            HStextBox.Text = "";
            HStextBox.Focus();
        }

        private void HMtextBox_Click(object sender, EventArgs e)
        {
            HMtextBox.Text = "";
            HMtextBox.Focus();
        }

        private void HLtextBox_Click(object sender, EventArgs e)
        {
            HLtextBox.Text = "";
            HLtextBox.Focus();
        }

        private void CCStextBox_Click(object sender, EventArgs e)
        {
            CCStextBox.Text = "";
            CCStextBox.Focus();
        }

        private void CCMtextBox_Click(object sender, EventArgs e)
        {
            CCMtextBox.Text = "";
            CCMtextBox.Focus();
        }

        private void CCLtextBox_Click(object sender, EventArgs e)
        {
            CCLtextBox.Text = "";
            CCLtextBox.Focus();
        }

        private void PStextBox_Click(object sender, EventArgs e)
        {
            PStextBox.Text = "";
            PStextBox.Focus();
        }

        private void PMtextBox_Click(object sender, EventArgs e)
        {
            PMtextBox.Text = "";
            PMtextBox.Focus();
        }

        private void PLtextBox_Click(object sender, EventArgs e)
        {
            PLtextBox.Text = "";
            PLtextBox.Focus();
        }

        private void HCStextBox_Click(object sender, EventArgs e)
        {
            HCStextBox.Text = "";
            HCStextBox.Focus();
        }

        private void HCMtextBox_Click(object sender, EventArgs e)
        {
            HCMtextBox.Text = "";
            HCMtextBox.Focus();
        }

        private void HCLtextBox_Click(object sender, EventArgs e)
        {
            HCLtextBox.Text = "";
            HCLtextBox.Focus();
        }

        private void COKEtextBox_Click(object sender, EventArgs e)
        {
            COKEtextBox.Text = "";
            COKEtextBox.Focus();
        }

        private void SPRITEtextBox_Click(object sender, EventArgs e)
        {
            SPRITEtextBox.Text = "";
            SPRITEtextBox.Focus();
        }

        private void ROYALtextBox_Click(object sender, EventArgs e)
        {
            ROYALtextBox.Text = "";
            ROYALtextBox.Focus();
        }

        private void SUBMITbtn_Click(object sender, EventArgs e)
        {

            //Virables Total
            decimal SUBTOTAL;
            decimal TAX;
            decimal TOTAL;
            
            //Viarables
            decimal SHawiian, SCheese_Chessy, SPepperoni, SHam_Cheese, SCoke, SSprite, SRoyal;
            decimal MHawiian, MCheese_Chessy, MPepperoni, MHam_Cheese;
            decimal LHawiian, LCheese_Chessy, LPepperoni, LHam_Cheese;

            decimal PHawiian, PChesse_Chessy, PPepperoni, PHam_Cheese, PDrinks;

            //Price Pizza Classs
            Pizza Hawiian = new Pizza("Hawiian", 40, 60, 95);
            Pizza Cheese_Chessy = new Pizza("Cheese Chessy", 80, 105, 150);
            Pizza Pepperoni = new Pizza("Pepperoni", 30, 45, 65);
            Pizza Ham_Chesse = new Pizza("Ham Chesse", 100, 150, 200);

            //Price Softdrinks Class 
            Softdrinks Coke = new Softdrinks("Coke", 18);
            Softdrinks Sprite = new Softdrinks("Sprite", 15);
            Softdrinks Royal = new Softdrinks("Royal", 16);
           

            SHawiian = Decimal.Parse(HStextBox.Text) * Hawiian.small;
            MHawiian = Decimal.Parse(HMtextBox.Text) * Hawiian.medium;
            LHawiian = Decimal.Parse(HLtextBox.Text) * Hawiian.large;
            SCheese_Chessy = Decimal.Parse(CCStextBox.Text) * Cheese_Chessy.small;
            MCheese_Chessy = Decimal.Parse(CCMtextBox.Text) * Cheese_Chessy.medium;
            LCheese_Chessy = Decimal.Parse(CCLtextBox.Text) * Cheese_Chessy.large;
            SPepperoni = Decimal.Parse(PStextBox.Text) * Pepperoni.small;
            MPepperoni = Decimal.Parse(PMtextBox.Text) * Pepperoni.medium;
            LPepperoni = Decimal.Parse(PLtextBox.Text) * Pepperoni.large;
            SHam_Cheese = Decimal.Parse(HCStextBox.Text) * Ham_Chesse.small;
            MHam_Cheese = Decimal.Parse(HCMtextBox.Text) * Ham_Chesse.medium;
            LHam_Cheese = Decimal.Parse(HCLtextBox.Text) * Ham_Chesse.large;


            SCoke = Decimal.Parse(COKEtextBox.Text) * Coke.price;
            SSprite = Decimal.Parse(SPRITEtextBox.Text) * Sprite.price;
            SRoyal = Decimal.Parse(ROYALtextBox.Text) * Royal.price;

            PHawiian = SHawiian + MHawiian + LHawiian;
            PChesse_Chessy = SCheese_Chessy + MCheese_Chessy + LCheese_Chessy;
            PPepperoni = SPepperoni + MPepperoni + LPepperoni;
            PHam_Cheese = SHam_Cheese + MHam_Cheese + LHam_Cheese;

            PDrinks = SCoke + SSprite + SRoyal;

            SUBTOTAL = PHawiian + PChesse_Chessy + PPepperoni + PHam_Cheese + PDrinks;


            TAX =  0.12M * SUBTOTAL;

            TOTAL = SUBTOTAL + TAX;

            Subtotal.Text = Convert.ToString(SUBTOTAL);
            Tax.Text = Convert.ToString(TAX);
            Total.Text = Convert.ToString(TOTAL);

            DialogResult ask = MessageBox.Show("ARE YOU SURE TO IMPORT THE TEXT?", "IMPORT TEXT FILE", MessageBoxButtons.YesNo);
            //Conditions and If Statements
            if (ask == DialogResult.Yes)
            {

                //Import data in Txt FILE
                StreamWriter write = new StreamWriter(Path.Combine(@"C:\Users\Gjayz\Desktop\Print.txt"), true);
                write.WriteLine("\t\t-------------------------------------------------------");
                write.WriteLine("\t\t---------------------YOUR BILLING----------------------");
                write.WriteLine("\t\t-- " + Hawiian.name + "       Small " + HStextBox.Text + " Medium " + HMtextBox.Text + " Large " + HMtextBox.Text + "  |P" + PHawiian + " --");
                write.WriteLine("\t\t-- " + Cheese_Chessy.name+ " Small "+ CCStextBox.Text+ " Medium " + CCMtextBox.Text+ " Large " + CCLtextBox.Text +"  |P"+PChesse_Chessy+" --");
                write.WriteLine("\t\t-- " + Pepperoni.name + "     Small " + PStextBox.Text + " Medium " + PMtextBox.Text + " Large " + PLtextBox.Text +"  |P"+ PPepperoni + " --");
                write.WriteLine("\t\t-- " + Ham_Chesse.name + "    Small " + HCStextBox.Text + " Medium " + HCMtextBox.Text + " Large " + HCLtextBox.Text + "  |P" + PHam_Cheese + " --");
                write.WriteLine("\t\t-- "+"DRINKS"+"                                  |P"+PDrinks+" --");
                write.WriteLine("\t\t-- " + "TAX" + "                                     |P" + TAX + " --");
                write.WriteLine("\t\t----------------PAYMENT METHOD: "+ PAYMENTcbb.SelectedItem+"----------");
                write.WriteLine("\t\t-------------------------------------------|P" + TOTAL);
                write.Close();
            }
        }

        private void EXITbtn_Click(object sender, EventArgs e)
        {
            string T = "EXIT";
            string M = "ARE YOU SURE CLOSE";
            MessageBoxButtons BTN = MessageBoxButtons.YesNo;
            DialogResult ask = MessageBox.Show(M, T, BTN);
            if(ask == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                ///CANCEL
            }
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            //Hawian Pizza
            HStextBox.Text = "0";
            HMtextBox.Text = "0";
            HLtextBox.Text = "0";
            //Chees Chessy
            CCStextBox.Text = "0";
            CCMtextBox.Text = "0";
            CCLtextBox.Text = "0";
            //Pepperoni
            PStextBox.Text = "0";
            PMtextBox.Text = "0";
            PLtextBox.Text = "0";
            //Ham & Chesse
            HCStextBox.Text = "0";
            HCMtextBox.Text = "0";
            HCLtextBox.Text = "0";
            //Drinks
            COKEtextBox.Text = "0";
            SPRITEtextBox.Text = "0";
            ROYALtextBox.Text = "0";

            //Hawian Pizza //Boolean
            HStextBox.Enabled = false;
            HMtextBox.Enabled = false;
            HLtextBox.Enabled = false;
            //Chesse Chessy //Boolean
            CCStextBox.Enabled = false;
            CCMtextBox.Enabled = false;
            CCLtextBox.Enabled = false;
            //Pepperoni //Boolean
            PStextBox.Enabled = false;
            PMtextBox.Enabled = false;
            PLtextBox.Enabled = false;
            //Ham & Cheesse //Boolean
            HCStextBox.Enabled = false;
            HCMtextBox.Enabled = false;
            HCLtextBox.Enabled = false;
            //Drinks /Coke/SPRITE/ROYAL
            COKEtextBox.Enabled = false;
            SPRITEtextBox.Enabled = false;
            ROYALtextBox.Enabled = false;
            //Product Checkbox //Boolean
            HcheckBox.Checked = false;
            CCcheckBox.Checked = false;
            PcheckBox.Checked = false;
            HCcheckBox.Checked = false;
            //Drinks Checkbox //Boolean
            COKEcheckBox.Checked = false;
            SPRITEcheckBox.Checked = false;
            ROYALcheckBox.Checked = false;

            //TEXT PAYMENT
            Subtotal.Text = "";
            Total.Text = "";
            Tax.Text = "";
        }
    }
}
