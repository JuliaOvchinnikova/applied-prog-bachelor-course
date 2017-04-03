using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Line(1, 1);
            var t = new Line(1, 2);
            Assert.AreEqual(null, Operations.Cross(c, t));
        }
       
        [TestMethod]
        public void TestMethod2()
        {
            var a = new Line(2, -3);
            var b = new Line(-3, 2);
            var c = new Point(1f,-1f);
            Assert.AreEqual(c.GetType(), Operations.Cross(a, b).GetType());

        }
        [TestMethod]
        public void TestMethod3()
        {
            var a = new Line(1, 1);
            var b = new Line(1, 1);
            var c = new Point(1, 1);
            Assert.AreEqual(c.GetType(), Operations.Cross(a, b).GetType());
        }
    }
}
