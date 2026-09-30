using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai11Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("", "", "");
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh cong nghiep", "abc", "xyz");
            Assert.AreEqual("Truong dh cong nghiep", result);
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh cong nghiep", "dh", "dai hoc");
            Assert.AreEqual("Truong dai hoc cong nghiep", result);
        }

        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("dh cong nghiep", "dh", "dai hoc");
            Assert.AreEqual("dai hoc cong nghiep", result);
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh", "dh", "dai hoc");
            Assert.AreEqual("Truong dai hoc", result);
        }

        [TestMethod]
        public void TestValidBoundary3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh cong nghiep", "dh", "dai hoc");
            Assert.AreEqual("Truong dai hoc cong nghiep", result);
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe(null, "dh", "dai hoc");
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh cong nghiep", null, "dai hoc");
            Assert.AreEqual("Quay lại đặc tả", result);
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.ThayThe("Truong dh cong nghiep", "dh", null);
            Assert.AreEqual("Quay lại đặc tả", result);
        }
    }
}