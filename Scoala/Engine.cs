using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Engine
    {
        public static void Power(int a)
        {
            Console.WriteLine($"Power is {a}");
        }

        public static void Consumption(double b)
        {
            Console.WriteLine($"Consumption is {b}");
        }

        public static void Start()
        {
            Console.WriteLine("The engine started!");
        }

        public static void Stop()
        {
            Console.WriteLine("The engine stopped");
        }

        public static void NewPower()
        {
            Console.WriteLine("The new power of the engine is...");
        }


    }
}
