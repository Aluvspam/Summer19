using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class ExampleEx
    {
        const int c = 0;
        int s;

        public void Run()
        {
            s = 0;
            while (true)
            {
                double a = 0;
                try
                {
                    for (s = 2; s > -3; s--)
                    {
                        a = division(36, s);
                        Console.WriteLine(a);
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("B_outule nu poti sa imparti la zero!!!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("exception !!! " + e.Message);
                    throw;
                }
                finally
                {
                    var b = division(4.0, s);
                    var z = division(b, b);
                    var sz = division(0.0, s);
                    Console.WriteLine(b - double.PositiveInfinity);
                }
                Console.WriteLine("Bored? Y/N");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    break;
                }
            }
        }
        int division(int d, int i)
        {
            //throw new NotImplementedException();
            return d / i;
        }
        double division(double d, double i)
        {
            return d / i;
        }
    }
}
