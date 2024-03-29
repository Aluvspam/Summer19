﻿using System;
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
            int[] data = new int[12] { 12, -1, 4, 100, 9, 7, 160, 16, 8, 9, 36, 25 };
            var sortari = new Sorting();
            sortari.Sort(data);
            Console.WriteLine("/////////////");
            data = new int[12] { 12, -1, 4, 100, 9, 7, 160, 16, 8, 9, 36, 25 };
            sortari.SetStrategy(new QuickSortStrategy());
            sortari.Sort(data);
            Console.WriteLine("/////////////");
            //QuickSortRecursion.IntArrayQuickSort(data);
            //Console.WriteLine(data);
            ExampleThreads.Run();
            Console.ReadLine();
            ChainOR.RunExample.Run();
            AwesomeSingleton s10 = AwesomeSingleton.Instance;

            AwesomeSingleton s20 = AwesomeSingleton.Instance;

            Console.WriteLine((Object.ReferenceEquals(s10, s20)) ? "Same object" : "Different Object");

            var add = new ConcreteStrategyAdd();
            var mult = new ConcreteStrategyMultiplication();

            add.AlgorithmInterface();
            mult.AlgorithmInterface();

            Singleton s = Singleton.Instance;
            s.SomeMethod();
            var s2 = Singleton.Instance;
            s2.SomeMethod();
            var c = new CopyMy(new AltReader(), new Screen());
            c.Copy();
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
