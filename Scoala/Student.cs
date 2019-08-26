using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Student : Person
    {
        public string Group;
        public int Semester;

        public Student(string nume, int age, Address adresa, Sex sex, string group, int semester) : base(nume, age, adresa, sex)
        {
            Group = group;
            Semester = semester;
        }
    }
}
