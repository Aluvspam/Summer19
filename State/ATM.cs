﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ATM
    {


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

