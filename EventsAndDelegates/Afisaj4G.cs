using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsAndDelegates
{
    public class Afisaj4G : AbstractObserver
    {
        public Afisaj4G()
        {
            Update = AfisareG;
            Abonare();
        }
        public void AfisareG(int x)
        {
            if ( x <= -20 )
            {
                Console.WriteLine($"La {x} grade uleiul de in ingheata");
            }
            else if (x <= -7 )
            {
                Console.WriteLine($"La {x} grade bromul ingheata");
            }
            else if ( x < 17 )
            {
                Console.WriteLine($"La {x} grade acidul acetic ingheata");
            }
        }
    }
}
