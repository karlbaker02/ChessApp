using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChessApp.Test
{
    [TestClass]
    public class PawnTest
    {
        [TestClass]
        public class GetsMoveFrom
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Result_When_Passed_2_2()
            {
                var pawn = new Pawn();

                var possibleMoves = pawn.GetMovesFrom(new BoardCoordinate(2, 2));

                Assert.IsTrue(possibleMoves.Any(c => c.X == 2 && c.Y == 3));
            }
        }
    }
}