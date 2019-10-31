using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Creating instance. Returning:");
                    instance = new Singleton();

                }
                Console.WriteLine("Instance exists. Returning:");
                return instance;
            }
        }

    }

    abstract class Strategy

    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyAdd : Strategy

    {
        public override void AlgorithmInterface()
        {
            var x = 5 + 5;
            Console.WriteLine(x);
        }
    }

    class ConcreteStrategyMultiplication : Strategy

    {
        public override void AlgorithmInterface()
        {
            var x = 5 * 2;

            Console.WriteLine(
              x);
        }
    }

}
