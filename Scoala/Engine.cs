using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public abstract class Engine
    {
        public string energyInput;
        public int Power;
        public double Consumption;
        public int CurrentPower;
        public abstract void Start();

        public abstract void Stop();

        public virtual void NewPower(int newPower)
        {
            CurrentPower = newPower;
            Console.WriteLine("The new power of the engine is...");
        }
        public void ResourceType()
        {
            Console.WriteLine("This engine's used resource is " + energyInput);
        }
    }
}
