using System.Collections.Generic;

namespace ChessApp
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate moveCoordinate, int boardSize)
        {
            for (var i = 1; i <= boardSize; i++)
            {
                if (i != moveCoordinate.X)
                    yield return new BoardCoordinate(i, moveCoordinate.Y);

                if (i != moveCoordinate.Y)
                    yield return new BoardCoordinate(moveCoordinate.X, i);
            }
        }
    }
}