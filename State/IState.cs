using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IState
    {
        public void Idle();
        public void ClientPresent();
        public void ThankYou();
        public void OutOfOrder();

    }
}
