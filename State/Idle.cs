using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Idle : IState

    {

        void goNext(ATM aparat1)
        {
            aparat1.SetState(new Client_Prezent());
        }
    }
}
