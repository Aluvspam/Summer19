using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class MakeItWalkOnTwoLegs : IMoveStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Now I'm walking on two legs !");
        }
    }
}
