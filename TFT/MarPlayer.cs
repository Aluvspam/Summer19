using System;
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
            return Moves.C;
        }
        public Moves MyMove(Moves MyLastMove, Moves OthersLastMove)
        {
            
            if ((MyLastMove==Moves.C)&(OthersLastMove==Moves.B))
            {
                return Moves.C;
            }
            else{ return Moves.D;}
            
        }
    
}
    }