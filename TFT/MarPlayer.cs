﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class MarPlayer : IPlayer
    {
        private List<IPlayer> juc = new List<IPlayer>();
        readonly MarPlayer2 mm = new MarPlayer2();
        

        public Moves FirstMove()
        {
            return Moves.D;
        }
        public Moves MyMove(Moves MyLastMove, Moves OthersLastMove)
        {
            return MarMove();
        }

        private Moves MarMove()
        {
            if (juc.Contains(mm))
                {
                    return Moves.B;
                }
                else
                {
                    return Moves.D;
                }
        }

    }
}
