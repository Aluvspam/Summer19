using System;
using Scoala;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var v = new Point();
            var p = new Point(7, 2);
            Console.WriteLine(p);
            Console.WriteLine(v);
            Console.WriteLine(v.X + ", " + v.Y);
            v.X = 4;
            p.Y++;
            Engine e = new Gas_Engine();
            Scoala.ExampleFolder.TestE teste = new Scoala.ExampleFolder.TestE();
            teste.ExampleMethod();
            Console.ReadLine();
            //TO DO: TEMA: Sa se creeze clasa student si un obiect student cu numele, culoarea parului si culoarea ochilor vostri
            // sa se scrie acestea intr-un fisier text dupa ce veti citi prezentarea primita in PDF
        }
    }
}
