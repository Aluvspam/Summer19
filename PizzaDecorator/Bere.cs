using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Bere : AbstractDrink
    { 
        public Bere()
            {
            DrinkBeer();
            }
        public void DrinkBeer()
        {
            volume = 500;
            price = 1;
        }

    }
}
