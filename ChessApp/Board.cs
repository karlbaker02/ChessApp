using System;

namespace ChessApp
{
    public class Board
    {
        private const int Boardsize = 8;

        private readonly Piece[,] _pieces = new Piece[Boardsize, Boardsize];

        public void AddPiece(Piece piece, BoardCoordinate moveCoordinate)
        {
            if (!moveCoordinate.IsCoordinateValidForBoardSize(Boardsize))
                throw new ArgumentException("moveTarget");

            _pieces[moveCoordinate.X, moveCoordinate.Y] = piece;
        }

        public Piece GetPiece(BoardCoordinate coordinates)
        {
            return _pieces[coordinates.X, coordinates.Y];
        }
    }
}