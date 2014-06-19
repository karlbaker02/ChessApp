using System.Collections.Generic;
using System.Linq;

namespace ChessApp
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate moveCoordinate)
        {
            return Enumerable.Empty<BoardCoordinate>();
        }
    }
}