using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail();
        }

        [Test]
        public void FailingTestWithMessage()
        {
            Assert.Fail("Tell me master Wayne, why do we fail?");
        }
    }

    public class MoreTestsInTheSameFile
    {
        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }
    }
}