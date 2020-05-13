namespace HaveFun
{
    public class Board
    {
        public int Player1Position { get; private set; } = 0;
        public int PlayerToMove { get; private set; } = 1;

        public void MovePlayer(int spaces)
        {
            Player1Position = spaces;
        }
    }
}