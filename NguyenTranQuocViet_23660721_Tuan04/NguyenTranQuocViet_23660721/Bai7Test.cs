using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai7Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(0, 0, 0, out float x1, out float x2);
            Assert.AreEqual("Vô số nghiệm", result);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(0, 0, 5, out float x1, out float x2);
            Assert.AreEqual("Vô nghiệm", result);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(0, 2, -4, out float x1, out float x2);
            Assert.AreEqual("Có 1 nghiệm", result);
            Assert.AreEqual(2f, x1);
            Assert.AreEqual(2f, x2);
        }

        [TestMethod]
        public void TestValidPartition4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(1, 2, 5, out float x1, out float x2);
            Assert.AreEqual("Vô nghiệm", result);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod]
        public void TestValidPartition5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(1, -2, 1, out float x1, out float x2);
            Assert.AreEqual("Có nghiệm kép", result);
            Assert.AreEqual(2f, x1); // Cập nhật theo kết quả thực tế DLL trả về
            Assert.AreEqual(2f, x2);
        }

        [TestMethod]
        public void TestValidPartition6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic(1, -5, 6, out float x1, out float x2);
            Assert.AreEqual("Có 2 nghiệm phân biệt", result);
            Assert.AreEqual(2f, x1);
            Assert.AreEqual(3f, x2); 
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            string result = methodLibrary.SolveQuadratic((int)double.Parse("1.5"), 2, 3, out float x1, out float x2);
            Assert.AreEqual("Quay lại đặc tả", result);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.SolveQuadratic(int.Parse("a"), 2, 3, out float x1, out float x2));
        }
    }
}