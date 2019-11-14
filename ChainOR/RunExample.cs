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
            Handlers.Instance.AddHandle(new HandMar());
            Handlers.Instance.AddHandle(new UHand());
            var msg = new Message() { Text = "dublu vizor", Language = 'A' };
            Handle(msg);
            msg.Language = 'M';
            Handle(msg);
            msg.Language = 'S';
            Handle(msg);
            Handle(new Message() { Text = "Silvius language msg", Language = 'S' });
            Console.ReadLine();
        }
        static void Handle(Message msg)
        {
            Handlers.Instance.ResetHandlersIndex();
            Handlers.Instance.GetNextHandler().Handle(msg);
        }
    }
}
