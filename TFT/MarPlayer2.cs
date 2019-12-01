using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class MarPlayer2 : IPlayer
    {

        Random a =new Random();
        public Moves FirstMove()
        {
            return Moves.D;
        }
        public Moves MyMove(Moves MyLastMove, Moves OthersLastMove)
        {
            return MarMove2();
        }
        private Moves MarMove2()
        {
            
                if (a.Next()%3!=0)
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
