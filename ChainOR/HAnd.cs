using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOR
{
    public class HAnd : AbstractHandle
    {
        char language = 'A';
        public override void Handle(Message message)
        {
            if (message.Language == language)
            {
                Console.WriteLine("Eu, HAnd can handle this message: " + message.Text);
            }
            else
            {
                Handlers.Instance.GetNextHandler().Handle(message);
            }
        }
    }

    public class UHand : AbstractHandle
    {
        //char language = 'A';
        char[] languages = new char[] { 'A', 'S', 'M' };
        public override void Handle(Message message)
        {
            if (CanHandle(message))
            {
                Console.WriteLine("Eu, Universal ASM  can handle this message: " + message.Text + ", language is " + message.Language);
            }
            else
            {
                Handlers.Instance.GetNextHandler().Handle(message);
            }
        }
        bool CanHandle(Message msg)
        {
            return languages.Contains(msg.Language);
        }
    }
}
