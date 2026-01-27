using NUnit.Framework;
using ExceptionHandlingApp;
using System;

namespace ExceptionHandlingApp.Tests
{
    [TestFixture]
    public class MathUtilsTests
    {
        private MathUtils _math;

        [SetUp]
        public void Setup()
        {
            _math = new MathUtils();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => _math.Divide(10, 0));
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            int result = _math.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}
