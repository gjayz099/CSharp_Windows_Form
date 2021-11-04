using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_System
{
    ////Person Resever Class
    class PersonR
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public char Mname { get; set; }
        public string PhoneN { get; set; }

        public PersonR(string Fname, string Lname, char Mname, string PhoneN)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Mname = Mname;
            this.PhoneN = PhoneN;
        }
    }
}
