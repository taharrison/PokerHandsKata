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

        
    }

}
