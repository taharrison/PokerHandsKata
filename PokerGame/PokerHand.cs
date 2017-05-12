using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class PokerHand
    {

        public HandStrength GetHandStrength()
        {
            
            return HandStrength.Nothing;
        }

        public void AddCard(Card card)
        {
        }
    }

    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
