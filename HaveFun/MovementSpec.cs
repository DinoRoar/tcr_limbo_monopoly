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
    }
    
    public class Board
    {
        public Board()
        {
            
        }

        public int Player1Position { get; } = 0;
    }
}

