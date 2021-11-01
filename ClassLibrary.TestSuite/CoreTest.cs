using NUnit.Framework;

namespace ClassLibrary.TestSuite
{
    public class CoreTest
    {
        Core TestObject { get; set; }

        [SetUp]
        public void Setup()
        {
            TestObject = new Core();
        }

        [Test]
        public void TestPass()
        {
            Assert.Pass();
        }

        [Test]
        public void TestFail()
        {
            Assert.Fail();
        }
    }
}