using FigureAreaCalcLib;
using System;
using NUnit.Framework;

namespace FigureAreaCalcLib.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {       
        [Test]
        public void TriangleArea_IfValidParametersAreEntered_AreaEqualsSix()
        {
            double expectedArea = 6;
            var triangle = new Triangle(5, 4, 3);

            var result = triangle.Area;

            Assert.That(result, Is.EqualTo(expectedArea));
        }

        [Test]
        public void TriangleArea_RectangularTriangle_IsTrue()
        {
            var triangle = new Triangle(5, 4, 3);

            var result = triangle.isRectangularTriangle;

            Assert.That(result, Is.True);
        }

        [Test]
        public void TriangleArea_RectangularTriangle_IsFalse()
        {
            var triangle = new Triangle(3, 3, 3);

            var result = triangle.isRectangularTriangle;

            Assert.That(result, Is.False);
        }

        [Test]
        public void TriangleArea_TriangleSideEqualsZero_ThrowArgumentException()
        {
            var triangle = new Triangle(0, 4, 3);

            Assert.That(() => triangle.Area, Throws.ArgumentException);
        }

        [Test]
        public void TriangleArea_TriangleSideLowerThanZero_ThrowArgumentException()
        {
            var triangle = new Triangle(5, -2, 3);

            Assert.That(() => triangle.Area, Throws.ArgumentException);
        }
    }
}
