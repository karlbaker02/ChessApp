using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChessApp.Test
{
    [TestClass]
    public class RookTest
    {
        [TestClass]
        public class Constructor
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_Empty_Collection()
            {
                var rook = new Rook();

                Assert.AreEqual(0, rook.GetMovesFrom(new BoardCoordinate(1, 1)).Count());
            }
        }
    }
}