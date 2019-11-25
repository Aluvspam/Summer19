using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class GeoPlayer : IPlayer
    {             
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
                       	        
	         if (othersLastMove == Moves.B)	
             {
                return Moves.D;
             }
             else if (othersLastMove == Moves.C)
	         {
                return Moves.D;
	         }
             else
	         {
                return Moves.D;
	         } 	                               
        }
        public Moves FirstMove()
        {
            return Moves.C;
        }
	}
}
