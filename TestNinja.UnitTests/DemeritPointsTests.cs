using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsTests
    {
        private DemeritPointsCalculator _demeritpoints;

        [SetUp]
        public void SetUp()
        {
            _demeritpoints = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-5)]
        public void CalculateDemeritPoints_IfSpeedLessThanZero_ReturnArgumentOutOfRangeException(int speed)
        {
            Assert.That(()=> _demeritpoints.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>()) ;
        }

        [Test]
        [TestCase(310)]
        public void CalculateDemeritPoints_IfSpeedGreaterThanMaxSpeed_ReturnArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _demeritpoints.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(50)]
        public void CalculateDemeritPoints_IfSpeedLessThanSpeedLimit_ReturnZero(int speed)
        {
            var result = _demeritpoints.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64, 0)]
        [TestCase(70,1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var result = _demeritpoints.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
