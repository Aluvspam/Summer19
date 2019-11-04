using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ATM
    {
        public ATM()
        {
            current = new Idle();
        }

        IState current;
        public void GoNext()
        {

        }
        public void SetState(IState atmState)
        {
           current.GoNext(this);
            
        }
    }
}

