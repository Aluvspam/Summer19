using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Fish : AbstractAnimal
    {
        public Fish(string name, int Age, bool IsDomestic) : base (name, Age, IsDomestic)
        {

        }
        public override void Eat()
        {
            Console.WriteLine( "mananc pureci");
        }
        public void Inot()
        {
            Console.WriteLine("fac baie toata ziua");
        }
        public void Canta()
        {
            Console.WriteLine("sonata marii");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
    
    
    }

