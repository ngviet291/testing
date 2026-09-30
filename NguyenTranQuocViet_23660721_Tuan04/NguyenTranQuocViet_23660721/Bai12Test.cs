using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai12Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 3, 8, 2, 5 };
            int result = methodLibrary.Largest(a);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { -5, -2, -10 };
            int result = methodLibrary.Largest(a);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 7, 7, 7 };
            int result = methodLibrary.Largest(a);
            Assert.AreEqual(7, result);
        }


        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { };
            int result = methodLibrary.Largest(a);
            Assert.AreEqual(int.MaxValue, result); // 2147483647
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 5 };
            int result = methodLibrary.Largest(a);
            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int result = methodLibrary.Largest(null);
            Assert.AreEqual("Quay lại đặc tả", result.ToString());
        }
    }
}