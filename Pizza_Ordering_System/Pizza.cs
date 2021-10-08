using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering_System
{
    ///BY GJAY///
    class Pizza
    {
        //Class Pizza
        public string name { get; set; }
        public decimal small { get; set; }
        public decimal medium { get; set; }
        public decimal large { get; set; }

        public Pizza(string name, decimal small,decimal medium,decimal large)
        {
            this.name = name;
            this.small = small;
            this.medium = medium;
            this.large = large;
        }
    }
}
