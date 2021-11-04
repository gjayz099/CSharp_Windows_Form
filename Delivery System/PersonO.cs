using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_System
{
    ////Person onwer Class
    class PersonO
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public char Mname { get; set; }
        public string PhoneN { get; set; }
        public string Gender { get; set; }
        public string DesTNTProv { get; set; }
        public string DesTNTCity { get; set; }

        public PersonO(string Fname, string Lname, char Mname, string PhoneN, string Gender, string DesTNTProv, string DesTNTCity)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Mname = Mname;
            this.PhoneN = PhoneN;
            this.Gender = Gender;
            this.DesTNTProv= DesTNTProv;
            this.DesTNTCity = DesTNTCity;
        }
    }
}
