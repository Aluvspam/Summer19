using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme
{
   public class Fibon
    {
        public double Fib(int n)
        {
            if (n == 0)
                return 0;
            double rez = n + Fib(n - 1);
            return rez;

        }
    }
}
