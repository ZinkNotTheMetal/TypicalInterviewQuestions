using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class FindNumberUnsortedArrayMajorityTests
    {
        private FindNumberUnsortedArrayMajority _arrayMajority;

        [SetUp]
        public void Setup()
        {
            _arrayMajority = new FindNumberUnsortedArrayMajority();
        }


        [Test]
        public void ShouldReturnNumberIfMajorityFound_FirstExample()
        {
            var input = new[] { 1, 1, 1, 4 };
            Assert.AreEqual(1, _arrayMajority.FindNumberWithinArray(input));
        }

        [Test]
        public void ShouldReturnNumberIfMajorityFound_SecondExample()
        {
            var input = new[] { 1, 3, 9, 2, 2, 4, 5, 2, 2, 2, 19, 2, 2 };
            Assert.AreEqual(2, _arrayMajority.FindNumberWithinArray(input));
        }

        [Test]
        public void ShouldReturnNumberIfMajorityFound_ThirdExample()
        {
            var input = new[] { 3, 49, 29, 19, 19, 10, 13, 13, 19, 11, 10, 19, 19, 19, 19, 19, 19, 1, 19 };
            Assert.AreEqual(19, _arrayMajority.FindNumberWithinArray(input));
        }

        [Test]
        public void ShouldReturnNegative1IfNoMajorityFound()
        {
            var input = new[] { 1, 1, 3, 4 };
            Assert.AreEqual(-1, _arrayMajority.FindNumberWithinArray(input));
        }

        [Test]
        public void ShouldReturnNegativeIfNothingFound()
        {
            var input = new int[] { 1, 3, 5 };
            Assert.AreEqual(-1, _arrayMajority.FindNumberWithinArray(input));
        }
    }
}
