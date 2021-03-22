using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaginationHelper;
using System.Collections.Generic;

namespace PaginationHelper_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //TODO: add more tests

        [TestMethod]
        public void Test1()
        {
            var helper = new PagnationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
            Assert.AreEqual(2, helper.PageCount);
            Assert.AreEqual(6, helper.ItemCount);
            Assert.AreEqual(4, helper.PageItemCount(0));
            Assert.AreEqual(2, helper.PageItemCount(1));
            Assert.AreEqual(-1, helper.PageItemCount(2));
        }
    }
}
