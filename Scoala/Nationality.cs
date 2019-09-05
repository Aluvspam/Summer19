using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Nationality
    {
        public string Country;

        public Nationality(string country)
        {
            Country = country;
        }

        public override string ToString()
        {
            return "Nationality for this person is " + Country;
        }
    }
}
