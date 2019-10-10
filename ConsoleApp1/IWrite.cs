using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IWrite
    {
        void Write(string txt);
    }

    class Screen : IWrite
    {
        public void Write(string text)
        {
            Console.WriteLine("textul copiat este: " + text); ;
        }
    }
}
