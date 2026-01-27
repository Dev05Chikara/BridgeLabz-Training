using NUnit.Framework;
using DatabaseConnectionApp;

namespace DatabaseConnectionApp.Tests
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _db;

        [SetUp]
        public void Setup()
        {
            _db = new DatabaseConnection();
            _db.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            _db.Disconnect();
        }

        [Test]
        public void Connect_SetUp_EstablishesConnection()
        {
            Assert.IsTrue(_db.IsConnected);
        }

        [Test]
        public void Disconnect_TearDown_ClosesConnection()
        {
            _db.Disconnect();
            Assert.IsFalse(_db.IsConnected);
        }
    }
}
