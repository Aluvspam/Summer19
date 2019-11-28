using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExampleThreads
    {
        static int numar;
        static object lacat = new object();
        public static void Run()
        {
            Thread thread1 = new Thread(Test1);
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();
            Thread thread2 = new Thread(Test2);
            thread2.Start();
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine("m" + i);
            }
        }

        static void Increment(int pas = 1)
        {
            lock (lacat)
            {
                numar += pas;
                Console.WriteLine(numar);
            }
        }
        static void Decrement(int pas = 1)
        {
            lock (lacat)
            {
                numar -= pas;
                Console.WriteLine(numar);
            }
        }
        static void Test1()
        {
            for (int i = 0; i < 160; i++)
            {
                Increment();
                Console.WriteLine("T1-" + i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 140; i++)
            {
                Increment(-1);
                Console.WriteLine("T2-" + i);

            }
        }
        static void Afisare()
        {
            lock (lacat)
            {
            }
        }
    }
}
