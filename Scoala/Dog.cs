using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class Dog
    {
        public Dog(string name, int age, bool isDomestic) : base(name, age, isDomestic)
        {
            public override void Eat()
        {
            Console.WriteLine("Running after cat !");
        }
            public override void Move()
        {
        }
        public override void Slepp()
        {
            Console.WriteLine("Bone dream");
        }
        public override void Talk()
        {
            Console.WriteLine("I'm barking");
        }


        }
    }
}
