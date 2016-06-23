using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class DuplicateArrayFinderTests
    {
        private DuplicateArrayFinder _duplicateArrayFinder;

        [SetUp]
        public void Setup()
        {
            _duplicateArrayFinder = new DuplicateArrayFinder();
        }

        [TestCase(10, 1, 3, 10, 19)]
        [TestCase(3, 4, 1, 30, 12, 2, 4)]
        [TestCase(2, 3, 4, 1, 2, 9, 3, 9)]
        public void ShouldReturnTrue_WhenDuplicatesPresent(params int[] testCase)
        {
            Assert.IsTrue(_duplicateArrayFinder.ContainsDuplicates(testCase));
        }

        [TestCase(10, 1, 3, 4, 19)]
        [TestCase(3, 4, 1, 30, 12, 2)]
        public void ShouldReturnFalse_WhenNoDuplicates(params int[] testCase)
        {
            Assert.IsFalse(_duplicateArrayFinder.ContainsDuplicates(testCase));
        }
    }
}
