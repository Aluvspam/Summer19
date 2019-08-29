using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Teacher : Person
    {
        #region fields
        public int Experience;
        public List<Curs> Cursuri;
        #endregion

        #region constructors
        public Teacher(string nume, int age, Address adresa, Sex sex, int experienta, List<Curs> cursuri) : base(nume, age, adresa, sex)
        {
            Experience = experienta;
            Cursuri = cursuri;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return base.ToString() + "has experience x years";
        }
        public void Teach()
        {
            Console.WriteLine("Teaching");
        }
        public override void SpecialAction()
        {
            Teach();
        }
        #endregion
    }
}
