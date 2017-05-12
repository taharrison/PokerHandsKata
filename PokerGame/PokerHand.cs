using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class PokerHand
    {
        List<Card> cards = new List<Card>();

        public HandStrength GetHandStrength()
        {
            

            if (cards
                .GroupBy(c => c.Value)
                .Any(g => g.Count() > 1))
                return HandStrength.Pair;

            return HandStrength.Nothing;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
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
