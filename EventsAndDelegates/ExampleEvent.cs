﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void AndreisDelegate(int x);
    public delegate int Sum2(int a, int b);
    public class ExampleEvent
    {
        private ExampleEvent()
        {

        }
        private static ExampleEvent instance;
        public static ExampleEvent Instance
        {
            get
            {
                if (instance != null)
                {
                    instance = new ExampleEvent();
                }
                return instance;
            }
        }
        public static event AndreisDelegate Xevent;
        public static event EventHandler Xevent2;
        public event EventHandler Xevent3;
        public static void Main(string[] args)
        {
            // exemplu metoda anonima
            Sum2 SumaMea = (int a, int b) => { return a + b; };
            Console.WriteLine(SumaMea(3, 7));

            ExamplesEventsAndDelegates.AltaMetoda();
            Console.ReadLine();
            var r = new Random();
            int i = 0;
            while (true)
            {
                if ((i % 500) == r.Next(500))
                {
                    if (Xevent != null)
                    {
                        Xevent.Invoke(r.Next(10) + 1);
                    }
                }
                else if (i / 2 == r.Next(1000))
                {
                    if (Xevent2 != null)
                    {
                        Xevent2.Invoke(new ExampleEvent(), new EventArgs());
                    }
                }
                //else
                //{
                //    Xevent2.Invoke(new ExampleEvent(), new AndreisArgs(4.67));
                //}
                i++;
            }
        }
        public void MoreEvents()
        {
            Xevent3.Invoke(this, new AndreisArgs(3.3));
        }
    }
}
