using System.Collections.Generic;

namespace ChessApp
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate moveCoordinate);
    }
}