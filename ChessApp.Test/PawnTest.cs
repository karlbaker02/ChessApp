using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChessApp.Test
{
    [TestClass]
    public class PawnTest
    {
        [TestClass]
        public class GetsMoveFrom
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_When_Passed_2_2()
            {
                var pawn = new Pawn();

                Tuple<int, int> possibleMoves = pawn.GetMovesFrom(2, 2);

                Assert.AreEqual(2, possibleMoves.Item1);
                Assert.AreEqual(3, possibleMoves.Item2);
            }
        }
    }
}