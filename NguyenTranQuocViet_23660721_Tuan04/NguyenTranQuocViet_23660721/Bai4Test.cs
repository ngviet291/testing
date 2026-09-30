using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai4Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.IsLeapYear(2000);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.IsLeapYear(2024);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.IsLeapYear(2023);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.IsLeapYear(1582);
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<ArgumentException>(() => methodLibrary.IsLeapYear(-2000));
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.IsLeapYear(int.Parse("abc")));
        }


        [TestMethod]
        public void TestInvalidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<ArgumentException>(() => methodLibrary.IsLeapYear(1581));
        }
    }
}