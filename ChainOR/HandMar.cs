using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOR
{
    public class HandMar : AbstractHandle
    {
        char language = 'M';
        public override void Handle(Message message)
        {
            if (message.Language == language)
            {
                Console.WriteLine("I will handle this message when reached to M " + message.Text);
            }
            else
            {
                Handlers.Instance.GetNextHandler().Handle(message);
            }
        }
    }
}
