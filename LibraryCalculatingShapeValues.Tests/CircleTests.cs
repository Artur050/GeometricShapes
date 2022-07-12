using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryCalculatingShapeValues.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            var radius = 10;

            Circle circle = new Circle(radius);

            var correctValue = Math.PI * Math.Pow(radius, 2);

            var result = circle.GetArea();

            Assert.AreEqual(result, correctValue);
        }
    }
}
