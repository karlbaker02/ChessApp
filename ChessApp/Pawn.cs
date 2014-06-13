using System.Collections.Generic;

namespace ChessApp
{
    public class Pawn
    {
        public IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate moveCoordinate)
        {
            yield return new BoardCoordinate(moveCoordinate.X, moveCoordinate.Y + 1);
        }
    }
}