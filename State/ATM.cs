using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ATM
    {


        IState current;
        public void GoNext()
        {
            current.GoNext(this);
        }

        public void SetState(IState atmState)
        {
        }
        
    }
}

