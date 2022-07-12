using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryCalculatingShapeValues.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetPerimeterTest()
        {
            double a = 6;
            double b = 8;
            double c = 10;

            var triangle = new Triangle(a, b, c);

            var correctValue = a + b + c;

            var result = triangle.GetPerimeter();

            Assert.AreEqual(result, correctValue);
        }
    }
}
