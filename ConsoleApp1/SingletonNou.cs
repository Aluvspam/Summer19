using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SingletonNou
    {
        private static readonly SingletonNou ObiectSingur= new SingletonNou();
        private SingletonNou()
        {
            //facem constructorul privat pentru ca clasa sa nu poata fi instantiata
        }
        public static SingletonNou getSingleton()
        {
            return ObiectSingur;
        }
    }
}
