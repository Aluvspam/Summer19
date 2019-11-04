using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class George : IPlayer, IScore
{
    string geo = "George";
    
	public int Score (score1 , score2)
	{
        
        get
        {
            if (geo == player1)
            {
                return score1;
            } 
            else if(geo == player2)
            {
                return score2;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            if (value == score1)
            {
                score1 = value;
            }
            else if (value == score2)
            {
                score2 = value;
            }
            else
            {
                Score = 0;
            }
        }



        
	}
}
