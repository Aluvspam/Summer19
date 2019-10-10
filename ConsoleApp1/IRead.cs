using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IRead
    {
        string Read();
    }

    class KeyboardRead : IRead
    {
        public string Read()
        {
            Console.WriteLine("introduceti textul");
            return Console.ReadLine();
        }
    }

    class ReadFromFile : IRead
    {
        public string Read()
        {
            return "hardcoded text \"from file\"";
        }
    }

    class AltReader : IRead
    {
        public string Read()
        {
            return "hardcoded text \"alt reader\"";
        }
    }
}
