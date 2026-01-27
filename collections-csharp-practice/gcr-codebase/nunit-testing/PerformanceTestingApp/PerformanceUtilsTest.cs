using NUnit.Framework;
using PerformanceTestingApp;

namespace PerformanceTestingApp.Tests
{
    [TestFixture]
    public class PerformanceUtilsTests
    {
        private PerformanceUtils _utils;

        [SetUp]
        public void Setup()
        {
            _utils = new PerformanceUtils();
        }

        [Test]
        [Timeout(2000)] // 2 seconds
        public void LongRunningTask_ShouldCompleteWithin2Seconds()
        {
            _utils.LongRunningTask();
        }
    }
}
