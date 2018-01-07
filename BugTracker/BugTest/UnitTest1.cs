using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker;


namespace BugTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests to see if the check inputs method will fail.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            frmBlackTester frmB = new frmBlackTester();

            frmB.checkInputs();

            Assert.IsFalse(frmBlackTester.rtnvalue);
        }
    }
}
