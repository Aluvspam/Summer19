using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IState
    {
        void GoNext(ATM aparat);
    }
}
