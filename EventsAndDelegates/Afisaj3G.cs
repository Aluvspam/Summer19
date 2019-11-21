using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Afisaj3G : AbstractObserver
    {
        public Afisaj3G()
        {
            Update = AfisareG;
            Abonare();
        }
        public void AfisareG(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"La {x} grade apa este inca in stare lichida");
            }
            else
            {
                Console.WriteLine($"Apa a inghetat la {x} grade");
            }        
        }

    }
}
