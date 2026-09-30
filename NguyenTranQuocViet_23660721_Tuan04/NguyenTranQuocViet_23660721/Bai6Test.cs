using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai6Test
    {
        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(5, 5, 5);
            Assert.AreEqual("Equilateral", result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(8, 5, 5);
            Assert.AreEqual("Isosceles", result);
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(3, 4, 5);
            Assert.AreEqual("Scalene", result);
        }

        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(1, 2, 4);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(1, 5, 2);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(6, 2, 3);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(0, 4, 5);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle(-3, 4, 5);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.Triangle((int)double.Parse("3.5"), 4, 5);
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition7()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.Triangle(int.Parse("a"), 4, 5));
        }
    }
}