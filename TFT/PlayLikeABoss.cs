﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class PlayLikeABoss : AbstractTFTPlayer
    {
        int changes;
        public PlayLikeABoss()
        {
            strategy = new TitForTat();
        }

        public override Moves FirstMove()
        {
            changes = 0;
            strategy = new TitForTat();
            Subscribe(Ids.id2, Event2Handler);
            Invoke(Ids.id1);
            moves = 1;
            flag = false;
            return strategy.FirstMove();
        }

        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (moves == 1)
            {
                Unsubscribe(Ids.id2);
            }
            else if (this.hisLastMove != othersLastMove)
            {
                changes++;
                if (changes == 3)
                {
                    Console.WriteLine("I think the other plays random");
                }
                else if (changes > 3)
                {
                    Console.WriteLine("The other plays random" + new string('!', changes - 3));
                }
            }
            StoreMoves(myLastMove, othersLastMove);
            if (othersLastMove == Moves.D)
            {
                strategy = new Atac();
            }
            return strategy.MoveLikeABoss(this);
        }
        protected override void Event2Handler()
        {
            if (!flag)
            {
                strategy = new Atac();//aleg strategia
                flag = true;
                base.Event2Handler();
            }
        }
    }
}
