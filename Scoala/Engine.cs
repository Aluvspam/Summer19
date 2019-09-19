using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Engine
    {
        public int Power;
        public double Consumption;
       
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
