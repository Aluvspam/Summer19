using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class MarPlayer: IPlayer , IScore
    { 
        public int ScoreMar
        {
            //Score scoreMAr;Score score2;
            get { return 0; }
        }
        Random mar;
        public MarPlayer()
        {
            mar = new Random();
        }
        public Moves MarMove1(Moves MarFirstMove, Moves MarLastMove)
        {
            return 'D';
        }
        public Moves MarMove()
        {
            if(mar.Next(2)==0)
            {
                if (scoreMar < score2)
                {
                    return 'C';
                }
                else
                {
                    return 'D';
                }
            }
        }
        
    }
}
