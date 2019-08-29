using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Beggar : Person
    {
        public Beggar(string nume, int age, Address adresa, Sex sex) : base(nume, age, adresa, sex)
        {
        }
        public override string ToString()
        {
            return "Mesieur, Si'l vour plaix";
        }
        public override void SpecialAction()
        {
            Console.WriteLine(this);
        }
    }
}
