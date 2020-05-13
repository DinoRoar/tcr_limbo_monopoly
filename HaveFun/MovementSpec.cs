using Xunit;

namespace HaveFun
{
    public class MovementSpec
    {
        [Fact]
        public void CreatedBoardWillHavePlayersAtStart()
        {
            var board = new Board();
            var player1Position = board.Player1Position;
            Assert.Equal(0, player1Position);
        }

        [Fact]
        public void AfterRolling5PlayerPositionisAt5()
        {
            var board = new Board();
            board.MovePlayer(5);
            var player1Position = board.Player1Position;
            Assert.Equal(5,player1Position);
        }
    }
    
    public class Board
    {
        public int Player1Position { get; private set; } = 0;

        public void MovePlayer(int spaces)
        {
            Player1Position = spaces;
        }
    }
}

