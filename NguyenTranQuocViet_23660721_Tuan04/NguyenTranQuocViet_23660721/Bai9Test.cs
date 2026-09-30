using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai9Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long k = methodLibrary.Sum(10, out long s);
            Assert.AreEqual(5L, k); 
            Assert.AreEqual(15L, s); 
        }


        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long k = methodLibrary.Sum(0, out long s);
            Assert.AreEqual(2L, k);  
            Assert.AreEqual(2L, s);  
        }

        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long k = methodLibrary.Sum(-50, out long s);
            Assert.AreEqual("Quay lại đặc tả", k.ToString());
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.Sum(long.Parse("abc"), out long s));
        }


        [TestMethod]
        public void TestInvalidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long k = methodLibrary.Sum(-1, out long s);
            Assert.AreEqual("Quay lại đặc tả", k.ToString());
        }
    }
}