﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class NormalMove: Move
    {
        public override MoveType Type => MoveType.NormalMove;
        public override Position FromPos { get; }
        public override Position ToPos { get; }

      public NormalMove(Position from,Position to)
        {
            FromPos = from;
            ToPos = to;

        }

    }
}
