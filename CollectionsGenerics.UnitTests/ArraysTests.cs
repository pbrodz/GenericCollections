using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsGenerics.UnitTests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void SimpleArraysTest()
        {
            var arr = new Arrays();
            var firstElementExpected = "Red";
            var simpArr = arr.SimpleArrays();
            Assert.AreEqual(firstElementExpected, simpArr[0]);
        }
        [TestMethod]
        public void OutOfBoundsTest()
        {
            var arr = new Arrays();
            var simpArr = arr.SimpleArrays();
            Assert.AreEqual(simpArr.Length, 10);
        }
        [TestMethod]
        public void BrownIndexTest()
        {
            var arr = new Arrays();
            var simpArr = arr.SimpleArrays();
            //This uses a static method to access the element within the array
            Assert.AreEqual(Array.IndexOf(simpArr, "Espresso"), 1);
        }
    }
}
