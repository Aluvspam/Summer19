using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class Bird : AbstractAnimal
    {
        public Bird(string name, int age, bool isDomestic) : base(name, age, isDomestic)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("orz");
        }
        public override void Move()
        {
            Console.WriteLine("fly");
        }
        public override void Sleep()
        {
            Console.WriteLine("never sleep");
        }
        public void Talk()
        {
            Console.WriteLine("cip cirip");
        }
    }
}
