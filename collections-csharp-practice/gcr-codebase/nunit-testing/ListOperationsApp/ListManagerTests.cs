using NUnit.Framework;
using System.Collections.Generic;
using ListOperationsApp;

namespace ListOperationsApp.Tests
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _manager;
        private List<int> _list;

        [SetUp]
        public void Setup()
        {
            _manager = new ListManager();
            _list = new List<int>();
        }

        [Test]
        public void AddElement_AddsElementToList()
        {
            _manager.AddElement(_list, 10);

            Assert.Contains(10, _list);
        }

        [Test]
        public void RemoveElement_RemovesElementFromList()
        {
            _list.Add(5);
            _list.Add(10);

            _manager.RemoveElement(_list, 5);

            Assert.IsFalse(_list.Contains(5));
        }

        [Test]
        public void GetSize_ReturnsCorrectSize()
        {
            _manager.AddElement(_list, 1);
            _manager.AddElement(_list, 2);
            _manager.AddElement(_list, 3);

            int size = _manager.GetSize(_list);

            Assert.AreEqual(3, size);
        }
    }
}
