using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;

namespace PokerGame.Tests
{
    [TestFixture]
    class PokerHandTests
    {
        [Test]
        public void AHandOf0CardsIsWorthNothing()
        {
            var sut = new PokerHand();
            
            var handStrength = sut.GetHandStrength();

            Assert.AreEqual(HandStrength.Nothing, handStrength);
        }

        [Test]
        public void AHandOf5UnrelatedCardsIsWorthNothing()
        {
            var sut = new PokerHand();
            sut.AddCard(new Card(Suit.Heart, Value.Two));
            sut.AddCard(new Card(Suit.Club, Value.Three));
            sut.AddCard(new Card(Suit.Spade, Value.Seven));
            sut.AddCard(new Card(Suit.Diamond, Value.Eight));
            sut.AddCard(new Card(Suit.Heart, Value.Ten));
       
            var handStrength = sut.GetHandStrength();
        
            Assert.AreEqual(HandStrength.Nothing, handStrength);
        }

        [Test]
        public void CanIdentifyAPair()
        {
            var sut = new PokerHand();
            sut.AddCard(new Card(Suit.Heart, Value.Two));
            sut.AddCard(new Card(Suit.Club, Value.Two));
            sut.AddCard(new Card(Suit.Spade, Value.Seven));
            sut.AddCard(new Card(Suit.Diamond, Value.Eight));
            sut.AddCard(new Card(Suit.Heart, Value.Ten));

            var handStrength = sut.GetHandStrength();

            Assert.AreEqual(HandStrength.Pair, handStrength);
        }

        
    }

}
