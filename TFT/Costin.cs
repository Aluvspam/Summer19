using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{

    public class Costin : IPlayer, IScore
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


        public Moves MyMove(Moves m1, Moves m2)
        {
            var rnd = new Random();
            return (Moves)rnd.Next(Enum.GetNames(typeof(Moves)).Length);
        }


    }


}