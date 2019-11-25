using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class MarPlayer : IPlayer, IScore
    {
        public int Score
        {

            get { return 0; }
        }
        Random mar;
        public MarPlayer()
        {
            mar = new Random();
        }
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
            int i = 0;
            if (i % 3 != 0)
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
