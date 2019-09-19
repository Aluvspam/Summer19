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
        public int CurrentPower;
        public void Start()
        {
            Console.WriteLine("The engine started!");
        }

        public void Stop()
        {
            Console.WriteLine("The engine stopped");
        }

        public void NewPower(int newPower)
        {
            CurrentPower = newPower;
            Console.WriteLine("The new power of the engine is...");
        }
    }
}
