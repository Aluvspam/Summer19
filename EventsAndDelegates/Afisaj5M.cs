using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Afisaj5M : AbstractObserver
    {
        public Afisaj5M()
        {
            Update = AfisareM;
            Abonare();
        }
        public void AfisareM(int x)
        {
            if (x>25&&x<50)
            {
                Console.WriteLine("La {0} grade merge on inghetata",x);
            }
            else if (x <50)
            {
                Console.WriteLine("La temeratura asta de {0} grade, stai la umbra si rocoare !",x);
            }
            else if (x>10&&x<26)
            {
                Console.WriteLine("Merge un gratar la temperatura de {0} grade",x);
            }
            else
            {
                Console.WriteLine("Sub {0} grade merge o haina calduroasa si un ceai cald !",x);
            }
        }
    }
}
