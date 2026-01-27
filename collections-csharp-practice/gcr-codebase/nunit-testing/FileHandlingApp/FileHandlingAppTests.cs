using NUnit.Framework;
using FileHandlingApp;
using System.IO;

namespace FileHandlingApp.Tests
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _processor;
        private string _testFile;

        [SetUp]
        public void Setup()
        {
            _processor = new FileProcessor();
            _testFile = "testfile.txt";
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(_testFile))
                File.Delete(_testFile);
        }

        [Test]
        public void WriteAndRead_File_ContentMatches()
        {
            string content = "NUnit File Test";

            _processor.WriteToFile(_testFile, content);
            string result = _processor.ReadFromFile(_testFile);

            Assert.AreEqual(content, result);
        }

        [Test]
        public void WriteToFile_FileExistsAfterWrite()
        {
            _processor.WriteToFile(_testFile, "Test");

            Assert.IsTrue(File.Exists(_testFile));
        }

        [Test]
        public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
        {
            Assert.Throws<FileNotFoundException>(() =>
                _processor.ReadFromFile("nonexistent.txt"));
        }
    }
}
