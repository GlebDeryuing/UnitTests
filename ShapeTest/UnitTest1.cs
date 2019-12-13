using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_lesson;
using System.Drawing;

namespace ShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLineBefore()
        {
            Line line = new Line(0, 0, 0, 4);
            PointF F = new PointF(0, -1);
            double dist = line.Distance(F);
            Assert.AreEqual(1, dist,1e-6);
        }
        [TestMethod]
        public void TestLineAfter()
        {
            Line line = new Line(0, 0, 0, 4);
            PointF F = new PointF(0, 5);
            double dist = line.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestLineMidle()
        {
            Line line = new Line(0, 0, 0, 4);
            PointF F = new PointF(1, 1);
            double dist = line.Distance(F);
            Assert.AreEqual(1, dist, 1e-6);
        }
        [TestMethod]
        public void TestLineOnLine()
        {
            Line line = new Line(0, 0, 0, 4);
            PointF F = new PointF(0, 1);
            double dist = line.Distance(F);
            Assert.AreEqual(0, dist, 1e-6);
        }
    }
}
