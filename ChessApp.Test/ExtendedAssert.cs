using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChessApp.Test
{
    public class ExtendedAssert
    {
        public static void Throws<TException>(Action executable) where TException : Exception
        {
            try
            {
                executable();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(TException), String.Format("Expected exception of type {0} but got {1}", typeof(TException), ex.GetType()));
                return;
            }

            Assert.Fail("Expected exception of type {0} but no exception was thrown", typeof(TException));
        }
    }
}