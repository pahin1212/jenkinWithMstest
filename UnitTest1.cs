using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testJenkinMsTestGit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.Fail("Test 1  failed");
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsTrue(true, "test passed");
        }

        [TestMethod]
        public void TestMethod3()
        {

            Assert.Fail("Test 3  failed");
        }

        [TestMethod]
        public void TestMethod4()
        {

            Assert.IsTrue(true, "test passed");
        }

    }
}
