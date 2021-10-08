using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering_System
{
    ///BY GJAY///
    class Softdrinks
    {
        //Class Softdrinks
        public string name { get; set; }
        public decimal price { get; set; }

        public Softdrinks(string name,decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
