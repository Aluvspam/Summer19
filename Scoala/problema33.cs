using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class problema33
    {
        void OMetoda()
        {
            decimal produs = 1;
            //TO DO: fix this for!
            //for (int i = 0; i < length; i++)
            //{

            //}
            for (int i = 12; i < 16; i++)
            {
                produs = i * produs;
            }
            Console.WriteLine("produsul este " + produs);
        }
    }
}
