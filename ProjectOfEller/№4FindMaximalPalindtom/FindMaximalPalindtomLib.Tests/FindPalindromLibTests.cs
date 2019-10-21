using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximalPalindtomLib.Tests
{
    [TestClass]
    public class FindPalindromLibTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] expectedResult = new int[3] { 9009,91, 99 };
            FindMaximalPalindtomLib.FindPalindromLib find =
                new FindPalindromLib();
            int[] testResult = find.FindMaxPalindrom(10, 100);
            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], testResult[i]);
            }
            
        }
    }
}
