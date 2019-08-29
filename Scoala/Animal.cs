using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class Animal
    {
        #region fields
        public string Name;
        public int Age;
        bool IsDomestic;
        #endregion

        #region constructors
        public Animal(string name, int age, bool isDomestic)
        {
            Name = name;
            Age = age;
            IsDomestic = isDomestic;
        }
        #endregion
    }
}
