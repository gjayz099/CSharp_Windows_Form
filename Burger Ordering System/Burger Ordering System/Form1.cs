using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_Ordering_System
{

    /////// Gjayz....
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ////Burger Qty
            DUPBpbQty.Text = "0";
            DUPBcbQty.Text = "0";
            DUPCbQty.Text = "0";
            DUPCcbQty.Text = "0";
            DUPDmbQty.Text = "0";
            DUPMbQty.Text = "0";

            ////Burger boolean
            DUPBpbQty.Enabled = false;
            DUPBcbQty.Enabled = false;
            DUPCbQty.Enabled = false;
            DUPCcbQty.Enabled = false;
            DUPDmbQty.Enabled = false;
            DUPMbQty.Enabled = false;

            ////Softdrings Qty
            TBcoke.Text = "0";
            TBpepsicola.Text = "0";
            TBsprite.Text = "0";
            TBgatorade.Text = "0";
            TBrealsoda.Text = "0";
            TBmango.Text = "0";
            TBorange.Text = "0";
            TBcalamansi.Text = "0";
            TBpineapple.Text = "0";
            TBmellon.Text = "0";

            ////Softdrings Boolean
            TBcoke.Enabled = false;
            TBpepsicola.Enabled = false;
            TBsprite.Enabled = false;
            TBgatorade.Enabled = false;
            TBrealsoda.Enabled = false;
            TBmango.Enabled = false;
            TBorange.Enabled = false;
            TBcalamansi.Enabled = false;
            TBpineapple.Enabled = false;
            TBmellon.Enabled = false;

            ////Fries Qty
            DUPsmallfriesQty.Text = "0";
            DUPmeduimfriesQty.Text = "0";
            DUPlargefriesQty.Text = "0";

            ////Fries Boolean
            DUPsmallfriesQty.Enabled = false;
            DUPmeduimfriesQty.Enabled = false;
            DUPlargefriesQty.Enabled = false;

            TBcost.Text = "0";
            TBtax.Text = "0.07";
            TByourmoney.Text = "0";
            TBtotalcost.Text = "0";
            TByourchange.Text = "0";


            
        }
        //// Burger Variable
        private void CBbpb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBbpb.Checked == true)
            {
                DUPBpbQty.Enabled = true;
            }
            if (CBbpb.Checked == false)
            {
                DUPBpbQty.Enabled = false;
                DUPBpbQty.Text = "0";
            }
        }

        private void CBbcb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBbcb.Checked == true)
            {
                DUPBcbQty.Enabled = true;
            }
            if (CBbcb.Checked == false)
            {
                DUPBcbQty.Enabled = false;
                DUPBcbQty.Text = "0";
            }
        }

        private void CBcb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcb.Checked == true)
            {
                DUPCbQty.Enabled = true;
            }
            if (CBcb.Checked == false)
            {
                DUPCbQty.Enabled = false;
                DUPCbQty.Text = "0";
            }
        }

        private void CBccb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBccb.Checked == true)
            {
                DUPCcbQty.Enabled = true;
            }
            if (CBccb.Checked == false)
            {
                DUPCcbQty.Enabled = false;
                DUPCcbQty.Text = "0";
            }
        }

        private void CBdmb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBdmb.Checked == true)
            {
                DUPDmbQty.Enabled = true;
            }
            if (CBdmb.Checked == false)
            {
                DUPDmbQty.Enabled = false;
                DUPDmbQty.Text = "0";
            }
        }

        private void CBmb_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmb.Checked == true)
            {
                DUPMbQty.Enabled = true;
            }
            if (CBmb.Checked == false)
            {
                DUPMbQty.Enabled = false;
                DUPMbQty.Text = "0";
            }
        }
        //// S0ftdirks Variable
        private void CBcoke_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcoke.Checked == true)
            {
                TBcoke.Enabled = true;
            }
            if (CBcoke.Checked == false)
            {
                TBcoke.Enabled = false;
                TBcoke.Text = "0";
            }
        }

        private void CBpepsicola_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpepsicola.Checked == true)
            {
                TBpepsicola.Enabled = true;
            }
            if (CBpepsicola.Checked == false)
            {
                TBpepsicola.Enabled = false;
                TBpepsicola.Text = "0";
            }
        }

        private void CBsprite_CheckedChanged(object sender, EventArgs e)
        {
            if (CBsprite.Checked == true)
            {
                TBsprite.Enabled = true;
            }
            if (CBsprite.Checked == false)
            {
                TBsprite.Enabled = false;
                TBsprite.Text = "0";
            }
        }

        private void CBgatorade_CheckedChanged(object sender, EventArgs e)
        {
            if (CBgatorade.Checked == true)
            {
                TBgatorade.Enabled = true;
            }
            if (CBgatorade.Checked == false)
            {
                TBgatorade.Enabled = false;
                TBgatorade.Text = "0";
            }
        }

        private void CBrealsoda_CheckedChanged(object sender, EventArgs e)
        {
            if (CBrealsoda.Checked == true)
            {
                TBrealsoda.Enabled = true;
            }
            if (CBrealsoda.Checked == false)
            {
                TBrealsoda.Enabled = false;
                TBrealsoda.Text = "0";
            }
        }

        private void CBmango_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmango.Checked == true)
            {
                TBmango.Enabled = true;
            }
            if (CBmango.Checked == false)
            {
                TBmango.Enabled = false;
                TBmango.Text = "0";
            }
        }

        private void CBorange_CheckedChanged(object sender, EventArgs e)
        {
            if (CBorange.Checked == true)
            {
                TBorange.Enabled = true;
            }
            if (CBorange.Checked == false)
            {
                TBorange.Enabled = false;
                TBorange.Text = "0";
            }
        }

        private void CBcalamansi_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcalamansi.Checked == true)
            {
                TBcalamansi.Enabled = true;
            }
            if (CBcalamansi.Checked == false)
            {
                TBcalamansi.Enabled = false;
                TBcalamansi.Text = "0";
            }
        }

        private void CBpineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpineapple.Checked == true)
            {
                TBpineapple.Enabled = true;
            }
            if (CBpineapple.Checked == false)
            {
                TBpineapple.Enabled = false;
                TBpineapple.Text = "0";
            }
        }

        private void CBmellon_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmellon.Checked == true)
            {
                TBmellon.Enabled = true;
            }
            if (CBmellon.Checked == false)
            {
                TBmellon.Enabled = false;
                TBmellon.Text = "0";
            }
        }

        private void TBcoke_Click(object sender, EventArgs e)
        {
            TBcoke.Text = "";
            TBcoke.Focus();
        }

        private void TBpepsicola_Click(object sender, EventArgs e)
        {
            TBpepsicola.Text = "";
            TBpepsicola.Focus();
        }

        private void TBsprite_Click(object sender, EventArgs e)
        {
            TBsprite.Text = "";
            TBsprite.Focus();
        }

        private void TBgatorade_Click(object sender, EventArgs e)
        {
            TBgatorade.Text = "";
            TBgatorade.Focus();
        }

        private void TBrealsoda_Click(object sender, EventArgs e)
        {
            TBrealsoda.Text = "";
            TBrealsoda.Focus();
        }

        private void TBmango_Click(object sender, EventArgs e)
        {
            TBmango.Text = "";
            TBmango.Focus();
        }

        private void TBorange_Click(object sender, EventArgs e)
        {
            TBorange.Text = "";
            TBorange.Focus();
        }

        private void TBcalamansi_Click(object sender, EventArgs e)
        {
            TBcalamansi.Text = "";
            TBcalamansi.Focus();
        }

        private void TBpineapple_Click(object sender, EventArgs e)
        {
            TBpineapple.Text = "";
            TBpineapple.Focus();
        }

        private void TBmellon_Click(object sender, EventArgs e)
        {
            TBmellon.Text = "";
            TBmellon.Focus();
        }

        private void CBsmall_Click(object sender, EventArgs e)
        {
            if (CBsmall.Checked == true)
            {
                DUPsmallfriesQty.Enabled = true;
            }
            if (CBsmall.Checked == false)
            {
                DUPsmallfriesQty.Enabled = false;
                DUPsmallfriesQty.Text = "0";
            }
        }

        private void CBmedium_Click(object sender, EventArgs e)
        {
            if (CBmedium.Checked == true)
            {
                DUPmeduimfriesQty.Enabled = true;
            }
            if (CBmedium.Checked == false)
            {
                DUPmeduimfriesQty.Enabled = false;
                DUPmeduimfriesQty.Text = "0";
            }
        }

        private void CBlarge_Click(object sender, EventArgs e)
        {
            if (CBlarge.Checked == true)
            {
                DUPlargefriesQty.Enabled = true;
            }
            if (CBlarge.Checked == false)
            {
                DUPlargefriesQty.Enabled = false;
                DUPlargefriesQty.Text = "0";
            }
        }

        private void TByourmoney_Click(object sender, EventArgs e)
        {
            TByourmoney.Text = "";
            TByourmoney.Focus();
        }
        ////EXIT BUTTON
        private void BTNexit_Click(object sender, EventArgs e)
        {
            string S = "EXIT APPLACATION";
            string M = "ARE YOU SURE TO EXIT";
            MessageBoxButtons BTM = MessageBoxButtons.OKCancel;
            DialogResult ASK = MessageBox.Show(S, M, BTM);
            if (ASK == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                //CANCEL
            }
        }
        /////RESET BUTTON
        private void BTNreset_Click(object sender, EventArgs e)
        {
            ////Burger Qty
            DUPBpbQty.Text = "0";
            DUPBcbQty.Text = "0";
            DUPCbQty.Text = "0";
            DUPCcbQty.Text = "0";
            DUPDmbQty.Text = "0";
            DUPMbQty.Text = "0";

            ////Burger boolean
            DUPBpbQty.Enabled = false;
            DUPBcbQty.Enabled = false;
            DUPCbQty.Enabled = false;
            DUPCcbQty.Enabled = false;
            DUPDmbQty.Enabled = false;
            DUPMbQty.Enabled = false;

            ////Softdrings Qty
            TBcoke.Text = "0";
            TBpepsicola.Text = "0";
            TBsprite.Text = "0";
            TBgatorade.Text = "0";
            TBrealsoda.Text = "0";
            TBmango.Text = "0";
            TBorange.Text = "0";
            TBcalamansi.Text = "0";
            TBpineapple.Text = "0";
            TBmellon.Text = "0";

            ////Softdrings Boolean
            TBcoke.Enabled = false;
            TBpepsicola.Enabled = false;
            TBsprite.Enabled = false;
            TBgatorade.Enabled = false;
            TBrealsoda.Enabled = false;
            TBmango.Enabled = false;
            TBorange.Enabled = false;
            TBcalamansi.Enabled = false;
            TBpineapple.Enabled = false;
            TBmellon.Enabled = false;

            ////Fries Qty
            DUPsmallfriesQty.Text = "0";
            DUPmeduimfriesQty.Text = "0";
            DUPlargefriesQty.Text = "0";

            ////Fries Boolean
            DUPsmallfriesQty.Enabled = false;
            DUPmeduimfriesQty.Enabled = false;
            DUPlargefriesQty.Enabled = false;

            ////TOTAL
            TBcost.Text = "0";
            TBtax.Text = "0.07";
            TByourmoney.Text = "0";
            TBtotalcost.Text = "0";
            TByourchange.Text = "0";

            /////Burger CheckBox
            CBbpb.Checked = false;
            CBbcb.Checked = false;
            CBcb.Checked = false;
            CBccb.Checked = false;
            CBdmb.Checked = false;
            CBmb.Checked = false;
            /////Fries CheckBox
            CBsmall.Checked = false;
            CBmedium.Checked = false;
            CBlarge.Checked = false;
            ////drinks CheckBox
            CBcoke.Checked = false;
            CBpepsicola.Checked = false;
            CBsprite.Checked = false;
            CBgatorade.Checked = false;
            CBrealsoda.Checked = false;
            CBmango.Checked = false;
            CBorange.Checked = false;
            CBcalamansi.Checked = false;
            CBpineapple.Checked = false;
            CBmellon.Checked = false;
        }

        ////////////METHOD COST.........................
        public void CostAndTax()
        {
            ////Virables
            double cost;
            double totaltax;
            //////Price Burger virables
            double Pbpb, Pbcb, Pcb, Pccb, Pdmb, Pmb;
            /////Price Softdrinks virables
            double Pck, Ppc, Psp, Pgtr, Prsd, Pmg, Porg, Pcls, Ppp, Pml;
            ///Price Size Fries virables
            double Psm, Pmd, Plr;

            /////Burger Classs//
            Product BPB = new Burger(CBbpb.Text, Int32.Parse(DUPBpbQty.Text), 45.00);
            Product BCB = new Burger(CBbcb.Text, Int32.Parse(DUPBcbQty.Text), 40.00);
            Product CB = new Burger(CBcb.Text, Int32.Parse(DUPCbQty.Text), 30.00);
            Product CCB = new Burger(CBccb.Text, Int32.Parse(DUPCcbQty.Text), 50.00);
            Product DMB = new Burger(CBdmb.Text, Int32.Parse(DUPDmbQty.Text), 45.00);
            Product MB = new Burger(CBmb.Text, Int32.Parse(DUPMbQty.Text), 35.00);
            ////SOFT DRINKS
            Product CK = new Drinks(CBcoke.Text, Int32.Parse(TBcoke.Text), 30.00);
            Product PC = new Drinks(CBpepsicola.Text, Int32.Parse(TBpepsicola.Text), 20.00);
            Product SP = new Drinks(CBsprite.Text, Int32.Parse(TBsprite.Text), 25.00);
            Product GTR = new Drinks(CBgatorade.Text, Int32.Parse(TBgatorade.Text), 35.00);
            Product RSD = new Drinks(CBrealsoda.Text, Int32.Parse(TBrealsoda.Text), 25.00);
            ////JUICE DRINKS
            Product MG = new Drinks(CBmango.Text, Int32.Parse(TBmango.Text), 20.00);
            Product ORG = new Drinks(CBorange.Text, Int32.Parse(TBorange.Text), 20.00);
            Product CLS = new Drinks(CBcalamansi.Text, Int32.Parse(TBcalamansi.Text), 20.00);
            Product PP = new Drinks(CBpineapple.Text, Int32.Parse(TBpineapple.Text), 20.00);
            Product ML = new Drinks(CBmellon.Text, Int32.Parse(TBmellon.Text), 20.00);
            ////FRECH FRIES//
            Product SM = new Fries(CBsmall.Text, Int32.Parse(DUPsmallfriesQty.Text), 30.00);
            Product MD = new Fries(CBmedium.Text, Int32.Parse(DUPmeduimfriesQty.Text), 45.00);
            Product LR = new Fries(CBlarge.Text, Int32.Parse(DUPlargefriesQty.Text), 60.00);

            ////Burger virables to 	Multiplication
            Pbpb = BPB.Price * BPB.Qty;
            Pbcb = BCB.Price * BCB.Qty;
            Pcb = CB.Price * CB.Qty;
            Pccb = CCB.Price * CCB.Qty;
            Pdmb = DMB.Price * DMB.Qty;
            Pmb = MB.Price * MB.Qty;
            ////Softdrinks virables to 	Multiplication
            Pck = CK.Price * CK.Qty;
            Ppc = PC.Price * PC.Qty;
            Psp = SP.Price * SP.Qty;
            Pgtr = GTR.Price * GTR.Qty;
            Prsd = RSD.Price * RSD.Qty;
            ////Juice drinks virables to 	Multiplication
            Pmg = MG.Price * MG.Qty;
            Porg = ORG.Price * ORG.Qty;
            Pcls = CLS.Price * CLS.Qty;
            Ppp = PP.Price * PP.Qty;
            Pml = ML.Price * ML.Qty;
            ////fries size virables to 	Multiplication
            Psm = SM.Price * SM.Qty;
            Pmd = MD.Price * MD.Qty;
            Plr = LR.Price * LR.Qty;
            ///ADD COST
            cost = Pbcb + Pbpb + Pcb + Pccb + Pdmb + Pmb + Pck + Ppc + Psp + Pgtr + Prsd + Pmg + Porg + Pcls + Ppp + Pml + Psm + Pmd + Plr;
            ///TAX Total
            totaltax = cost * 0.07;
            TBcost.Text = Convert.ToString(cost);
            TBtax.Text = Convert.ToString(totaltax);

            /// ADD VIRABLE TAX and COST
            double tbcost = Convert.ToDouble(TBcost.Text);
            double tbtaxt = Convert.ToDouble(TBtax.Text);
            double tbtotalcost = tbcost + tbtaxt;

            TBtotalcost.Text = Convert.ToString(tbtotalcost);


        }

        ////METHOD Total/////
        public void Total()
        {
            //virable
            double cost;
            double totaltax;
            ///Price Burger virables
            double Pbpb, Pbcb, Pcb, Pccb, Pdmb, Pmb;
            ///Price Softdrinks virables
            double Pck, Ppc, Psp, Pgtr, Prsd, Pmg, Porg, Pcls, Ppp, Pml;
            ///Price Size Fries virables
            double Psm, Pmd, Plr;

            /////Burger Classs//
            Product BPB = new Burger(CBbpb.Text, Int32.Parse(DUPBpbQty.Text), 45.00);
            Product BCB = new Burger(CBbcb.Text, Int32.Parse(DUPBcbQty.Text), 40.00);
            Product CB = new Burger(CBcb.Text, Int32.Parse(DUPCbQty.Text), 30.00);
            Product CCB = new Burger(CBccb.Text, Int32.Parse(DUPCcbQty.Text), 50.00);
            Product DMB = new Burger(CBdmb.Text, Int32.Parse(DUPDmbQty.Text), 45.00);
            Product MB = new Burger(CBmb.Text, Int32.Parse(DUPMbQty.Text), 35.00);
            ////SOFT DRINKS
            Product CK = new Drinks(CBcoke.Text, Int32.Parse(TBcoke.Text), 30.00);
            Product PC = new Drinks(CBpepsicola.Text, Int32.Parse(TBpepsicola.Text), 20.00);
            Product SP = new Drinks(CBsprite.Text, Int32.Parse(TBsprite.Text), 25.00);
            Product GTR = new Drinks(CBgatorade.Text, Int32.Parse(TBgatorade.Text), 35.00);
            Product RSD = new Drinks(CBrealsoda.Text, Int32.Parse(TBrealsoda.Text), 25.00);
            ////JUICE DRINKS
            Product MG = new Drinks(CBmango.Text, Int32.Parse(TBmango.Text), 20.00);
            Product ORG = new Drinks(CBorange.Text, Int32.Parse(TBorange.Text), 20.00);
            Product CLS = new Drinks(CBcalamansi.Text, Int32.Parse(TBcalamansi.Text), 20.00);
            Product PP = new Drinks(CBpineapple.Text, Int32.Parse(TBpineapple.Text), 20.00);
            Product ML = new Drinks(CBmellon.Text, Int32.Parse(TBmellon.Text), 20.00);
            ////FRECH FRIES//
            Product SM = new Fries(CBsmall.Text, Int32.Parse(DUPsmallfriesQty.Text), 30.00);
            Product MD = new Fries(CBmedium.Text, Int32.Parse(DUPmeduimfriesQty.Text), 45.00);
            Product LR = new Fries(CBlarge.Text, Int32.Parse(DUPlargefriesQty.Text), 60.00);

            ////Burger virables to 	Multiplication
            Pbpb = BPB.Price * BPB.Qty;
            Pbcb = BCB.Price * BCB.Qty;
            Pcb = CB.Price * CB.Qty;
            Pccb = CCB.Price * CCB.Qty;
            Pdmb = DMB.Price * DMB.Qty;
            Pmb = MB.Price * MB.Qty;
            ////Softdrinks virables to 	Multiplication
            Pck = CK.Price * CK.Qty;
            Ppc = PC.Price * PC.Qty;
            Psp = SP.Price * SP.Qty;
            Pgtr = GTR.Price * GTR.Qty;
            Prsd = RSD.Price * RSD.Qty;
            ////Juice drinks virables to 	Multiplication
            Pmg = MG.Price * MG.Qty;
            Porg = ORG.Price * ORG.Qty;
            Pcls = CLS.Price * CLS.Qty;
            Ppp = PP.Price * PP.Qty;
            Pml = ML.Price * ML.Qty;
            ////fries size virables to 	Multiplication
            Psm = SM.Price * SM.Qty;
            Pmd = MD.Price * MD.Qty;
            Plr = LR.Price * LR.Qty;
            ///ADD COST
            cost = Pbcb + Pbpb + Pcb + Pccb + Pdmb + Pmb + Pck + Ppc + Psp + Pgtr + Prsd + Pmg + Porg + Pcls + Ppp + Pml + Psm + Pmd + Plr;

            ///TAX Total
            totaltax = cost * 0.07;
            TBcost.Text = Convert.ToString(cost);
            TBtax.Text = Convert.ToString(totaltax);

            /// ADD VIRABLE TAX and COST
            double tbcost = Convert.ToDouble(TBcost.Text);
            double tbtaxt = Convert.ToDouble(TBtax.Text);
            double tbtotalcost = tbcost + tbtaxt;

            TBtotalcost.Text = Convert.ToString(tbtotalcost);
            ////YOUR MONEY VIRABLE
            double tbyourmoney = Int32.Parse(TByourmoney.Text);
            ////Subtraction YOURMONEY And TOTALCOST
            double tbyourchange = Convert.ToDouble(tbyourmoney) - Convert.ToDouble(tbtotalcost);
            TByourchange.Text = Convert.ToString(tbyourchange);
        }
        ////Buttom Cost
        private void BTNcost_Click(object sender, EventArgs e)
        {
            CostAndTax();
        }
        //// Buttom Submit
        private void BTNsubmit_Click(object sender, EventArgs e)
        {
            Total();
        }
    }
}