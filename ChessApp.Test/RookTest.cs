using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChessApp.Test
{
    [TestClass]
    public class RookTest
    {
        private Rook Target { get; set; }

        private static readonly BoardCoordinate DefaultCoordinate = new BoardCoordinate(1, 1);
        private const int DefaultBoardSize = 8;

        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Rook();
        }

        [TestClass]
        public class GetMovesFrom : RookTest
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Vertical_Moves_With_Board_Size_8()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(7, moves.Count(c => c.X == 1));
            }

            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Horizontal_Moves_With_Board_Size_8()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(7, moves.Count(c => c.Y == 1));
            }

            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_No_Moves_That_Contain_A_Zero()
            {
                var moves = Target.GetMovesFrom(DefaultCoordinate, DefaultBoardSize);

                Assert.AreEqual(0, moves.Count(c => c.X == 0 || c.Y == 0));
            }
        }
    }
}