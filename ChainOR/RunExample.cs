
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOR
{
    public class RunExample
    {
        public static void Run()
        {
            Handlers.Instance.AddHandle(new HAnd());
            Handlers.Instance.AddHandle(new HandS());
            Handlers.Instance.GetNextHandler().Handle(new Message() { Text = "dublu vizor", Language = 'A' });
            Handlers.Instance.ResetHandlersIndex();
            Handlers.Instance.GetNextHandler().Handle(new Message() { Text = "Silvius language msg", Language = 'S' });
            Console.ReadLine();
        }
    }
}
