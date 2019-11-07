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
}
