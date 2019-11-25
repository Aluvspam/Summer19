using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class Playersilviu : IPlayer
    {
        Random mutareintamplare = new Random();
        public Moves FirstMove()
        {
            if (mutareintamplare.Next(2) == 0)
            {
                return Moves.D;
            }
            else
            {
                return Moves.C;
            }
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (mutareintamplare.Next(2) == 0)
            {
                return Moves.D;
            }
            else
            {
                return Moves.C;
            }
        }
    }
}
