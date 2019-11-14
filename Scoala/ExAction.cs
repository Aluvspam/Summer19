using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class ExAction
    {
        public void RunExample()
        {
            Action a1 = AsteaptaEnter;
            a1.Invoke();
            Action a2 = Test;
            a2.Invoke();
            Action[] actions = new Action[] { a2, a1 };
            foreach (var actiune in actions)
            {
                actiune.Invoke();
            }
        }
        void AsteaptaEnter()
        {
            Console.ReadLine();
        }
        void Test()
        {
            int i1 = 1;
            Console.WriteLine("test " + i1);
        }
    }

    class ActionPlus
    {

    }
}
