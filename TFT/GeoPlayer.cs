using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class GeoPlayer : IPlayer, IScore
    {       
         public int[] Scores
         {
            get
            {
                return new int[] { score1, score2 };
            }
         }
        
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            
            while (GeoPlayer == player1)
	        {
	         if (othersLastMove == Moves.B)	
             {
                return Moves.B;
             }
             else if (othersLastMove == Moves.C)
	         {
                return Moves.D;
	         }
             else if (othersLastMove == Moves.D)
	         {
                return Moves.D;
	         } 
	        }

            while (GeoPlayer == player2)
	        {
             if (othersLastMove == Moves.B)	
             {
                return Moves.B;
             }
             else if (othersLastMove == Moves.C)
	         {
                return Moves.C;
	         }
             else if (othersLastMove == Moves.D)
	         {
                return Moves.C;
	         } 	                    
            }
            
        }
        public Moves FirstMove()
        {
            if (GeoPlayer == player1)
	        {
            return Moves.C;
	        }
            if (GeoPlayer == player2)
	        {
            return Moves.B;
	        }
        }
	}
}
