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

        public void MakeItFly(AbstractAnimal animal)
        {
            animal.MoveStrategy = new Fly();
        }
        public void Freeze(AbstractAnimal animal)
        {
            animal.MoveStrategy = new FrozenMove();
        }
        public void WalkOnTwoLegs(AbstractAnimal animal)
        {
            animal.MoveStrategy = new MakeItWalkOnTwoLegs();
        }
    }
}
