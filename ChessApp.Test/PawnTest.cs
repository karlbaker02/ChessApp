using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChessApp.Test
{
    [TestClass]
    public class PawnTest
    {
        private Pawn Target { get; set; }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Pawn();
        }

        [TestClass]
        public class GetsMoveFrom : PawnTest
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Result_When_Passed_2_2()
            {
                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsTrue(possibleMoves.Any(c => c.X == 2 && c.Y == 3));
            }

            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_4_As_One_Result_When_Passed_2_2()
            {
                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsTrue(possibleMoves.Any(c => c.X == 2 && c.Y == 4));
            }

            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_2_4_When_Passed_2_2_If_Piece_Has_Already_Moved()
            {
                Target.HasMoved = true;

                var possibleMoves = Target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsFalse(possibleMoves.Any(c => c.X == 2 && c.Y == 4));
            }
        }
    }
}