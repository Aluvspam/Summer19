﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class GeoPlayer2 : IPlayer
    {
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {

            if (othersLastMove == Moves.B && myLastMove == Moves.D)
            {
                return Moves.C;
            }
            else
            {
                return Moves.D;
            }
        }
        public Moves FirstMove()
        {
            return Moves.D;
        }
    }
}

