using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_lesson;
using System.Drawing;

namespace ShapeTest
{
    [TestClass]
    public class RectTest
    {
        [TestMethod]
        public void TestRect1()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(-1, 1);
            double dist = rect.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestRect2()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(8, 1);
            double dist = rect.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestRect3()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(3, 8);
            double dist = rect.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestRect4()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(3, -1);
            double dist = rect.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestRect5()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(-1,-1);
            double dist = rect.Distance(F);
            Assert.AreEqual(Math.Sqrt(2), dist, 1e-6);
        }
        [TestMethod]
        public void TestRect6()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(-1, 8);
            double dist = rect.Distance(F);
            Assert.AreEqual(Math.Sqrt(2), dist, 1e-6);
        }
        [TestMethod]
        public void TestRect7()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(8, 8);
            double dist = rect.Distance(F);
            Assert.AreEqual(Math.Sqrt(2), dist, 1e-6);
        }
        [TestMethod]
        public void TestRect8()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(8, -1);
            double dist = rect.Distance(F);
            Assert.AreEqual(Math.Sqrt(2), dist, 1e-6);
        }
        [TestMethod]
        public void TestRectInside()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            PointF F = new PointF(1, 1);
            double dist = rect.Distance(F);
            Assert.AreEqual(-1, dist, 1e-6);
        }
    }
}
