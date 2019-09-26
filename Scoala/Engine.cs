using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public abstract class Engine : IEngine
    {
        protected string energyInput;
        public int Power;
        public double Consumption;
        int currentPower;

        public int CurrentPower { get; private set; }

        public virtual void NewPower(int newPower)
        {
            CurrentPower = newPower;
            Console.WriteLine("The new power of the engine is...");
        }
        public virtual void ResourceType()
        {
            Console.WriteLine("This engine's used resource is " + energyInput);
        }

        public abstract void Start();
        public abstract void Stop();

        public void MetodaNevirtuala()
        { }
    }
}
