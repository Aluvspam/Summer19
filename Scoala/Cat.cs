using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Cat : AbstractAnimal
    {
        public Cat(string name, int age, bool isDomestic) : base(name, age, isDomestic)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("I am {0} the cat! I am eating Jerry!", Name);
        }

        public override void Move()
        {
            Console.WriteLine("I am {0} the cat! I am running on my 4 legs!", Name);
        }

        public override void Sleep()
        {
            Console.WriteLine("I am {0} the cat! eu torc in 2 limbi!", Name);
        }
        public void Talk()
        {
            Console.WriteLine("Miaauuu!");
        }

        public void Hunt()
        {
            Console.WriteLine("I am {0} the cat! I am hunting a fish if I see one", Name);
            //TO DO: write code here
        }
    }
}
