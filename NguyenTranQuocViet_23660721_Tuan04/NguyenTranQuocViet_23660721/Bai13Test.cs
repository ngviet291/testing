using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai13Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 4, 3, 7, 8, 2, 8, 7, 3, 4 };
            bool result = methodLibrary.IsSymmetry(a, 9);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3, 4 };
            bool result = methodLibrary.IsSymmetry(a, 4);
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1 };
            bool result = methodLibrary.IsSymmetry(a, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3 };
            bool result = methodLibrary.IsSymmetry(a, 3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.IsSymmetry(null, 5);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3 };
            bool result = methodLibrary.IsSymmetry(a, -2);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3 };
            bool result = methodLibrary.IsSymmetry(a, 5);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }

        [TestMethod]
        public void TestInvalidPartition4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3 };
            Assert.ThrowsException<FormatException>(() => methodLibrary.IsSymmetry(a, int.Parse("null")));
        }

        [TestMethod]
        public void TestInvalidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 3 };
            bool result = methodLibrary.IsSymmetry(a, 0);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }

        [TestMethod]
        public void TestInvalidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 1, 2, 3 };
            bool result = methodLibrary.IsSymmetry(a, 4);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }
    }
}