using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{

    public class SmartCostin : IPlayer, IScore
    {
        int _Score = 0;

        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }

        public Moves FirstMove()
        {
            return Moves.D;
        }
        public void ScoreGame(Moves m1, Moves m2)
        {
            if (m1 == Moves.D & m2 == Moves.B)
            { Score += 3; }

            else if (m1 == Moves.D & m2 == Moves.C)
            {
                Score += 4;
            }

            else if (m1 == Moves.D & m2 == Moves.D)
            { Score += 2; }

            else if (m1 == Moves.B & m2 == Moves.B)
            { Score += 0; }

            else if (m1 == Moves.B & m2 == Moves.C)
            {
                Score += 0;
            }
            else if (m1 == Moves.B & m2 == Moves.D)
            { Score += 0; }

            else if (m1 == Moves.C & m2 == Moves.B)
            { Score += 0; }

            else if (m1 == Moves.C & m2 == Moves.C)
            {
                Score += 0;
            }
            else if (m1 == Moves.C & m2 == Moves.D)
            { Score += 0; }
        }

    public Moves MyMove(Moves m1, Moves m2)
    {
            return Moves.D;
    }

}


}