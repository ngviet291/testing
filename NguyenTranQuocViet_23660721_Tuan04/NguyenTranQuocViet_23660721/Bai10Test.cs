using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai10Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 2, 1);
            Assert.AreEqual("ADEF", result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 2, 10);
            Assert.AreEqual("ABCDEF", result);
        }


        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 1, 1);
            Assert.AreEqual("ACDEF", result);
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 5, 1);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestValidBoundary3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 2, 0);
            Assert.AreEqual("CDEF", result);
        }

        [TestMethod]
        public void TestValidBoundary4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 1, 5);
            Assert.AreEqual("ABCDE", result);
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi(null, 2, 1);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", -2, 1);
            Assert.AreEqual("ABCDEF", result);
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.HuyChuoi("ABCDEF", int.Parse("2.5"), 1));
        }

        [TestMethod]
        public void TestInvalidPartition4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.HuyChuoi("ABCDEF", 2, -2);
            Assert.AreEqual("ABCDEF", result);
        }
    }
}