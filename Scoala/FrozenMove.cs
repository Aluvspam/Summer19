using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class FrozenMove : IMoveStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Can't move, I am frozen!");
        }
    }
}
