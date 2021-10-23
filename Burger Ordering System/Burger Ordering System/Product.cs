using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Ordering_System
{
    class Product
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public Product(string Name, int Qty, double Price)
        {
            this.Name = Name;
            this.Qty = Qty;
            this.Price = Price;
        }    
    }
}
