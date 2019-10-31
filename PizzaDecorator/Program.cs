using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            ITopping mozza = new Mozzarella();
            mozza.Component = pizza;
            ITopping pepe = new Peperoni() { Component = mozza };
            ITopping mozza2 = new Mozzarella();
            mozza2.Component = pepe;
            Console.WriteLine("cu de toate costa " + mozza2.GetCost());
            Console.ReadLine();
        }
    }
}
