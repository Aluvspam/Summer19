using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Singleton
    {
        static Singleton instance;
        static Object lacat;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lacat)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                            Console.WriteLine("just created new instance");
                        }
                    }
                }
                Console.WriteLine("returning instance");
                return instance;
            }
        }
        private Singleton()
        {

        }
        public void SomeMethod()
        {
            Console.WriteLine("someMethod");
        }
    }
}
