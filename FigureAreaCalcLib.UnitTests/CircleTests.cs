using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalcLib.UnitTests
{
    [TestFixture]
    public class CircleTests
    {

        [Test]
        public void CircleArea_IfRadiusEqualsFive_ThrowArgumentException()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * Math.Pow(5, 2);

            var result = circle.Area;

            Assert.That(result, Is.EqualTo(expectedArea));
        }


        [Test]
        public void CircleArea_RadiusEqualsZero_ThrowArgumentException()
        {
            var circle = new Circle(0);

            Assert.That(() => circle.Area, Throws.ArgumentException);
        }


        [Test]
        public void CircleArea_RadiusLowerThanZero_ThrowArgumentException()
        {
            var circle = new Circle(-8);

            Assert.That(() => circle.Area, Throws.ArgumentException);
        }

    }
}
