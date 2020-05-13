namespace HaveFun
{
    public class Board
    {
        public Board():this(2)
        {
           
        }

        public Board(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
        }
        public int Player1Position { get; private set; } = 0;
        public int PlayerToMove { get; private set; } = 1;
        public int NumberOfPlayers { get; }

        public void MovePlayer(int spaces)
        {
            Player1Position = spaces;
            PlayerToMove++;

            if (PlayerToMove > NumberOfPlayers)
            {
                PlayerToMove = 1;
            }
        }
    }
}