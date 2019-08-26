using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Person
    {
        #region fields
        public string Name;
        public int Age;
        public Address Address;
        public Sex Sex;
        public static long Pupulation;
        #endregion

        #region constructor
        public Person(string nume, int age, Address adresa, Sex sex)
        {
            Name = nume;
            Age = age;
            Address = adresa;
            Sex = sex;
            Pupulation++;
        }
        public override string ToString()
        {
            return Name + ", " + Age + " ani, sta la " + Address + ", si este " + ((Sex == Sex.Female) ? "femeie" : "barbat");
        }
        #endregion

        public class Animal
        {
            bool IsDomestic;
            public List<Animal> Pet;
            private readonly string Name;
            private readonly int Age;

            public Animal(string name, int age, bool isDomestic, List<Animal> pet)
            {
                Name = name;
                Age = age;
                IsDomestic = isDomestic;
                Pet = pet;
            }
        }

    }
}
