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

        [Fact]
        public void BeforeAMovePLayer1IsToMove()
        {
            var board = new Board();
            Assert.Equal(1, board.PlayerToMove);
        }

        [Fact]
        public void AFterPlayerOneMovesOPlayerToMoveIs2()
        {
            var board = new Board();
            board.MovePlayer(2);
            Assert.Equal(2, board.PlayerToMove);
        }

        [Fact]
        public void CanCreateAGameWith3Players()
        {
            var board = new Board(3);
            Assert.Equal(3, board.NumberOfPlayers);
        }

        [Fact]
        public void In2PLayerGameAfter2MovesItIsPlayer1Move()
        {
            var board = new Board();
            board.MovePlayer(2);
            board.MovePlayer(2);
            Assert.Equal(1, board.PlayerToMove);
            
        }
    }
}

