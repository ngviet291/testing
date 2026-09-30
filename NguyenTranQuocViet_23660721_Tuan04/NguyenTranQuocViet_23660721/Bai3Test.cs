using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai3Test
    {
        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(7);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(0);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(1000);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<Exception>(() => methodLibrary.primeCheck(-50));
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<Exception>(() => methodLibrary.primeCheck(5000));
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.primeCheck(int.Parse("ssa5000")));
        }

        [TestMethod]
        public void TestInvalidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<Exception>(() => methodLibrary.primeCheck(-1));
        }

        [TestMethod]
        public void TestInvalidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<Exception>(() => methodLibrary.primeCheck(1001));
        }
    }
}