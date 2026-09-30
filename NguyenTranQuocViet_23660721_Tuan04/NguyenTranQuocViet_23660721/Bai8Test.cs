using System;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NguyenTranQuocViet_23660721
{
    [TestClass]
    public class Bai8Test
    {

        [TestMethod]
        public void TestValidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 130);
            Assert.AreEqual(48972, result, 1);
        }

        [TestMethod]
        public void TestValidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 180);
            Assert.AreEqual(132209, result, 1);
        }

        [TestMethod]
        public void TestValidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 250);
            Assert.AreEqual(264165, result, 1);
        }

        [TestMethod]
        public void TestValidPartition4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 350);
            Assert.AreEqual(492041, result, 1);
        }

        [TestMethod]
        public void TestValidPartition5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 450);
            Assert.AreEqual(751201, result, 1);
        }

        [TestMethod]
        public void TestValidPartition6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 600);
            Assert.AreEqual(1163459, result, 1);
        }


        [TestMethod]
        public void TestValidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 100);
            Assert.AreEqual(0, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 150);
            Assert.AreEqual(81620, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 151);
            Assert.AreEqual(83306, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 200);
            Assert.AreEqual(165935, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 201);
            Assert.AreEqual(167900, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 300);
            Assert.AreEqual(362395, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary7()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 301);
            Assert.AreEqual(364861, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary8()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 400);
            Assert.AreEqual(609015, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary9()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 401);
            Assert.AreEqual(611768, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary10()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 500);
            Assert.AreEqual(884345, result, 1);
        }

        [TestMethod]
        public void TestValidBoundary11()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, 501);
            Assert.AreEqual(887191, result, 1);
        }


        [TestMethod]
        public void TestInvalidPartition1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(200, 150);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestInvalidPartition2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Assert.ThrowsException<FormatException>(() => methodLibrary.TinhTienDien(int.Parse("abc"), 100));
        }

        [TestMethod]
        public void TestInvalidPartition3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, (int)double.Parse("150.5"));
            Assert.AreEqual(-1, result);
        }


        [TestMethod]
        public void TestInvalidBoundary1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(-1, 100);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestInvalidBoundary2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            double result = methodLibrary.TinhTienDien(100, -1);
            Assert.AreEqual(-1, result);
        }
    }
}