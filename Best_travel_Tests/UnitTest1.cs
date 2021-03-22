using Best_travel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Best_travel_Tests
{
    [TestClass]
    public class SumOfKTests
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = SumOfK.chooseBestSum(163, 3, ts);
            Assert.AreEqual(163, n);

            ts = new List<int> { 50 };
            n = SumOfK.chooseBestSum(163, 3, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(230, 3, ts);
            Assert.AreEqual(228, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(331, 2, ts);
            Assert.AreEqual(178, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(331, 4, ts);
            Assert.AreEqual(331, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(331, 5, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(331, 1, ts);
            Assert.AreEqual(91, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.chooseBestSum(331, 8, ts);
            Assert.AreEqual(null, n);
        }
        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("****** Basic Tests bigger numbers");
            List<int> ts = new List<int> { 100, 76, 56, 44, 89, 73, 68, 56, 64, 123, 2333, 144, 50, 132, 123, 34, 89 };
            int? n = SumOfK.chooseBestSum(2430, 15, ts);
            Assert.AreEqual(1287, n);

            ts = new List<int> { 1000, 640, 1230, 2333, 1440, 500, 1320, 1230, 340, 890, 732, 1346 };
            n = SumOfK.chooseBestSum(23331, 8, ts);
            Assert.AreEqual(10789, n);

            ts = new List<int> { 1000, 640, 1230, 2333, 1440, 500, 1320, 1230, 340, 890, 732, 1346 };
            n = SumOfK.chooseBestSum(331, 2, ts);
            Assert.AreEqual(null, n);
        }
        [TestMethod]
        public void CustomTest()
        {
            Console.WriteLine("****** Custom Tests");
            List<int> ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            int? n = SumOfK.chooseBestSum(331, 4, ts);
            Assert.AreEqual(331, n);

            ts = new List<int> { 100, 76, 56, 44, 89, 73, 68, 56, 64, 123, 2333, 144, 50, 132, 123, 34, 89 };
            n = SumOfK.chooseBestSum(880, 8, ts);
            Assert.AreEqual(876, n);

            ts = new List<int> { 29, 98, 142, 146, 155, 179, 188, 193, 196, 212, 231, 281, 350, 367, 422, 426, 449, 475, 476, 486 };
            n = SumOfK.chooseBestSum(1821, 4, ts);
            Assert.AreEqual(1810, n);
        }
    }
}
