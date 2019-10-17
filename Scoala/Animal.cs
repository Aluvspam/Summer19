using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public abstract class Animal : IAnimal
    {
        #region fields
        public string Name;
        public int Age;
        public bool IsDomestic;
        #endregion

        #region constructors
        public Animal(string name, int age, bool isDomestic)
        {
            Name = name;
            Age = age;
            IsDomestic = isDomestic;
        }

        public abstract void Eat();

        public abstract void Move();

        public abstract void Sleep();
        #endregion
    }
}
