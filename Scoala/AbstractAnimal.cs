using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public abstract class AbstractAnimal : IAnimal
    {
        #region fields
        public string Name;
        public int Age;
        public bool IsDomestic;
        public IMoveStrategy MoveStrategy;
        #endregion

        #region constructors
        public AbstractAnimal(string name, int age, bool isDomestic)
        {
            Name = name;
            Age = age;
            IsDomestic = isDomestic;
        }
        #endregion
        #region abstract methods
        public abstract void Eat();

       
        public abstract void Sleep();
        #endregion
        #region methods
        public virtual void Move()
        {
            MoveStrategy.Execute();
        }
        #endregion
    }
}
