﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleGitHubActions.Main;
using System.Collections.Generic;

namespace SampleGitHubActions.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.MyNumber, 999);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(Program.MyList, list);
        }
    }
}
