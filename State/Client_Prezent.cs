using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Client_Prezent
    {
        void goNext(ATM aparat1)
        {
            aparat1.SetState(new Thank_You());
        }
    }
}
