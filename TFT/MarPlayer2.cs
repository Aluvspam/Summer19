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
            return Moves.B;
        }
        public Moves MyMove(Moves MyLastMove, Moves OthersLastMove)
        {
           
            if ((MyLastMove==Moves.B)&(OthersLastMove==Moves.C))
            {
                return Moves.B;
                }
            else{ return Moves.D;}
            
        }}
    }


