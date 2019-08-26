using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class Animal
    {
        public string Name;
        public int Age;
        bool IsDomestic;       
        public List<Animal> Pet;

        public Animal(string name, int age, bool isDomestic, List<Animal> pet)
        {
            Name = name;
            Age = age;
            IsDomestic = isDomestic;
            Pet = pet;
        }
    }
}
