using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Address
    {
        public string Town;
        public string StreetAddress1;
        public string StreetAddress2;
        //TO DO create overide for ToString() method here - George
        public override string ToString()
        {
            return "adresa: " + Town + " " + StreetAddress1 + " " + StreetAddress2;
        }
    }
}
