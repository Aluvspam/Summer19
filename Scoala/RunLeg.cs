using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class RunLeg
    {
        public class RunLegs : IMoveStrategy
        {
            public void Execute()
            {
                Console.WriteLine("Running with my 4 legs");
            }
        }
    }
}
