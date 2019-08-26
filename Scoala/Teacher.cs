using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Teacher : Person
    {
        public int Experience;
        public List<Curs> Cursuri;

        public Teacher(string nume, int age, Address adresa, Sex sex, int experienta, List<Curs> cursuri) : base(nume, age, adresa, sex)
        {
            Experience = experienta;
            Cursuri = cursuri;
        }
    }
}
