using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Cat : Animal
    {
        public Cat(string name, int age, bool isDomestic) : base(name, age, isDomestic)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("eating Jerry!");
        }

        public override void Move()
        {
            Console.WriteLine("running on my 4 legs!");
        }

        public override void Sleep()
        {
            Console.WriteLine("eu torc");
        }
        public void Talk()
        {
            Console.WriteLine("Miaauuu!");
        }
    }
}
