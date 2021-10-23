using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Ordering_System
{
    class Fries : Drinks
    {   
        public Fries(string SName, int Qty, double Price) :base(SName, Qty,Price)
        {
            this.Name = SName;
            this.Qty = Qty;
            this.Price = Price;
        }
    }
}