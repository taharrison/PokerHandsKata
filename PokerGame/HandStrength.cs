﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public enum HandStrength
    {
        Nothing = 0,
        Pair = 1,
        TwoPair = 2,
        ThreeOfAKind
    }

    public enum Suit
    {
        Heart,
        Club,
        Spade,
        Diamond
    }
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
