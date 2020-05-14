using Xunit;

namespace HaveFun
{
    public class BankPropertySpec
    {
        [Fact]
        public void PLayerStartsWith500()
        {
            var bank = new Bank(1);
            var playerMoney = bank.Player1Money;
            Assert.Equal(500, playerMoney);
        }

        [Fact]
        public void Player2StartsWith500()
        {
            var bank = new Bank(2);
            var money = bank.Player2Money;
            Assert.Equal(500,money);
        }
    }

    public class Bank
    {
        public Bank(int numberOfPlayers)
        {
        }

        public int Player1Money { get; } = 500;
        public int Player2Money { get; } = 500;
    }
}