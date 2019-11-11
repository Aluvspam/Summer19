using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOR
{
    public class HandS : AbstractHandle
    {
        char language = 'S';
        public override void Handle(Message message)
        {
            if (message.Language==language)

            {
                Console.WriteLine( "Ich versuch das zu verstehen" + message.Text);
            }
            else
            {
                Handlers.Instance.GetNextHandler().Handle(message);
            }

            throw new NotImplementedException();
        }

    }
    
    }

