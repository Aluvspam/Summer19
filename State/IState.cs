﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IState
    {
        void GoNext(ATM aparat);
    }
}
