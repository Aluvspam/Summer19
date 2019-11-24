using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Afisare6M:AbstractObserver
    {
        public Afisare6M()
        {
            Update = AfisareM2;
            Abonare();
        }
        public void AfisareM2(int x)
        {
            if (x > 25)
            {
                Console.WriteLine("Suntem imbracati de vara la temperatura de {0}", x);
            }
            else if (x>10)
            {
                Console.WriteLine("La temperatura de {0} suntem imbracati de toamna si primavara",x);
            }
            else
            {
                Console.WriteLine("deja vine iarna de la {0} grade si ne imbracam corespunzator",x);
            }
        }
    }
}
