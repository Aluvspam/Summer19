using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public delegate string IntoarcereString();
    public delegate int IntMath(int i1, int i2);
    class ExAction
    {
        List<Action> Pasi;
        Queue<Action> actions1;
        Stack<int> stiva;
        public ExAction(List<Action> pasi)
        {
            Pasi = pasi;
            stiva = new Stack<int>();
        }
        public void RunExample()
        {
            Action a1 = AsteaptaEnter;
            a1.Invoke();
            Action a2 = Test;
            a2.Invoke();
            Action[] actions = new Action[] { a2, AfiseazaLungimea, a1 };
            actions1 = new Queue<Action>();
            foreach (var actiune in actions)
            {
                actiune.Invoke();
            }
            foreach (var pas in Pasi)
            {
                actions1.Enqueue(pas);
            }
            while (actions1.Count > 0)
            {
                var v = actions1.Dequeue();
                v.Invoke();
                actions[1].Invoke();
            }
            IntoarcereString a3 = Console.ReadLine;
            a3.Invoke();
            a3();
            IntMath d4 = Suma;
            Console.WriteLine(d4.Invoke(3, 5));
            Console.WriteLine(d4(13, 21));
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
        void AfiseazaLungimea()
        {
            stiva.Push(actions1.Count);
            Console.WriteLine("coada are lungimea " + actions1.Count);
        }
        int Suma(int a, int b)
        {
            return a + b;
        }
    }

    class ActionPlus
    {

    }
}
