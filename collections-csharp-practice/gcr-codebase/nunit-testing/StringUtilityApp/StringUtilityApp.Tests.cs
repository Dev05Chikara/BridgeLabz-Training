using NUnit.Framework;
using StringUtilityApp;

namespace StringUtilityApp.Tests
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _utils;

        [SetUp]
        public void Setup()
        {
            _utils = new StringUtils();
        }

        [Test]
        public void Reverse_ValidString_ReturnsReversedString()
        {
            string result = _utils.Reverse("abc");
            Assert.AreEqual("cba", result);
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            bool result = _utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            bool result = _utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCase_ValidString_ReturnsUppercase()
        {
            string result = _utils.ToUpperCase("dotnet");
            Assert.AreEqual("DOTNET", result);
        }

        [Test]
        public void Reverse_NullString_ReturnsNull()
        {
            string result = _utils.Reverse(null);
            Assert.IsNull(result);
        }
    }
}
