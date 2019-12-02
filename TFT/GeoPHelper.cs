using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class GeoPHelper : IPlayer
    {
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {           
                return Moves.B;          
        }
        public Moves FirstMove()
        {
            return Moves.D;
        }
    }
}
