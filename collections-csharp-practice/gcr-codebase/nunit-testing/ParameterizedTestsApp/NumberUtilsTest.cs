using NUnit.Framework;
using ParameterizedTestsApp;

namespace ParameterizedTestsApp.Tests
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _utils;

        [SetUp]
        public void Setup()
        {
            _utils = new NumberUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_MultipleNumbers_ReturnsExpectedResult(int number, bool expected)
        {
            bool result = _utils.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
