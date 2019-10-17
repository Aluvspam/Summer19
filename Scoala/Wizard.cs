using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Wizard : Person
    {
        public Wizard(string nume, int age, Address adresa, Sex sex) : base(nume, age, adresa, sex)
        {
        }
    }
}
