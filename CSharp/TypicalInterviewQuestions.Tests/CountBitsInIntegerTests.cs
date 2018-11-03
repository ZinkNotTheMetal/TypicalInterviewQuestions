using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class CountBitsInIntegerTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 256)]
        [TestCase(31, int.MaxValue)]
        public void ShouldReturnCorrectNumberOfBitsForInteger(int expected, int input)
        {
            Assert.AreEqual(expected, input.CountBits());
        }
    }
}
