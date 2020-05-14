using Xunit;

namespace HaveFun
{
    public class BankPropertySpec
    {
        [Fact]
        public void PLayerstartsWith500()
        {
            var bank = new Bank();
            var playerMoney = bank.Player1Money;
            Assert.Equal(500, playerMoney);
        }
    }

    public class Bank
    {
        public int Player1Money { get; } = 500;
    }
}