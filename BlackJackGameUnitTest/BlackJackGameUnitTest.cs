using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackGameUnitTest
{
    [TestClass]
    public class BlackJackGameUnitTest
    {
        
        [TestMethod]
        void testReturnPlayerCard()
        {
            //arrange and act
            string playerCard = BlackJackConsoleGame.BlackJackGame.returnPlayerCard();
            int playerCardInt = Int32.Parse(playerCard);
            bool isPlayerCardLessThanOrEqualToTen = playerCardInt <= 10 && playerCardInt > 0;

            //assert
            Assert.AreEqual(isPlayerCardLessThanOrEqualToTen, true);

            //assert
            Assert.AreNotEqual(isPlayerCardLessThanOrEqualToTen, false);
        }

        [TestMethod]
        void returnComputerCard()
        {
            //arrange and act
            string computerCard = BlackJackConsoleGame.BlackJackGame.returnComputerCard();
            int computerCardInt = Int32.Parse(computerCard);
            bool isComputerCardLessThanOrEqualToTen = computerCardInt <= 10 && computerCardInt > 0;

            //assert
            Assert.AreEqual(isComputerCardLessThanOrEqualToTen, true);

            //assert
            Assert.AreNotEqual(isComputerCardLessThanOrEqualToTen, false);
        }
    }
}
