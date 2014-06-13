namespace ChessApp
{
    public class Board
    {
        private const int Boardsize = 8;

        private readonly Pawn[,] _pieces = new Pawn[Boardsize, Boardsize];

        public void AddPiece(Pawn piece, BoardCoordinate moveCoordinate)
        {
            _pieces[moveCoordinate.X, moveCoordinate.Y] = piece;
        }

        public Pawn GetPiece(BoardCoordinate coordinates)
        {
            return _pieces[coordinates.X, coordinates.Y];
        }
    }
}