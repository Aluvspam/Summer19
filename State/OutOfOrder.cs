using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Out_of_Order: IState
    {

        public void GoNext(ATM aparat)
        {
            aparat.SetState(new Idle());
        }
    }
}
