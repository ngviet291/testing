using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai5Test
    {
        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int result = (int)methodLibrary.BinToDec("1010");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.BinToDec("10201"));
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.BinToDec("abc"));
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.BinToDec(null));
        }
    }
}