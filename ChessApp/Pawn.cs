using System.Collections.Generic;

namespace ChessApp
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }

        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate moveCoordinate, int boardSize)
        {
            yield return new BoardCoordinate(moveCoordinate.X, moveCoordinate.Y + 1);

            if (!HasMoved)
                yield return new BoardCoordinate(moveCoordinate.X, moveCoordinate.Y + 2);
        }
    }
}