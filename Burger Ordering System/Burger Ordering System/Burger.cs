using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Ordering_System
{
    class Burger : Product
    {
        public Burger(string Name, int Qty, double Price) : base(Name, Qty, Price)
        {
            this.Name = Name;
            this.Qty = Qty;
            this.Price = Price;
        }    
    }
}