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
            var cardGroups = cards
                .GroupBy(c => c.Value);

            var pairGroups = cardGroups
                .Where(g => g.Count() == 2);



            if (pairGroups
                .Count() == 2)
                return HandStrength.TwoPair;

            if (pairGroups
                .Count() == 1)
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
