using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme
{
   public class SirNr
    {
        public int Sirnr(int n)
        {
            
            int sum = n + Sirnr(n - 1);
            return sum;

        }
    }
}
