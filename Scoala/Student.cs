using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Student : Person
    {
        public Curs Group;
        public int Semester;

        public Student(string nume, int age, Address adresa, Sex sex, Curs group, int semester) : base(nume, age, adresa, sex)
        {
            Group = group;
            Semester = semester;
        }

        public void Study()
        {
            Console.WriteLine("Learning");
        }
        public override string ToString()
        {
            return base.ToString() + ". " + ((Sex == Sex.Female) ? "Ea" : "El") + " este " + ((Sex == Sex.Female) ? "inscrisa" : "inscris") + " in grupa " + Group.ToString() + ".";
        }
        public override void SpecialAction()
        {
            Study();
        }
    }
}
