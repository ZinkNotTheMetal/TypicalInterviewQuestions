using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class SumOfDigitsInNumberUsingRecursionTests
    {
        private SumOfDigitsInNumberUsingRecursion _digitCalculator;

        [SetUp]
        public void SetUp()
        {
            _digitCalculator = new SumOfDigitsInNumberUsingRecursion();
        }

        [TestCase(-29)]
        [TestCase(-292)]
        public void ShouldReturnNegativeValue_WithIncorrectInput(int input)
        {
            Assert.AreEqual(-1, _digitCalculator.Sum(input));
        }

        [TestCase(6, 123)]
        [TestCase(12, 156)]
        [TestCase(9, 2133)]
        [TestCase(27, 999)]
        public void ShouldReturnExpected_WithCorrectInput(int expected, int input)
        {
            Assert.AreEqual(expected, _digitCalculator.Sum(input));
        }
    }
}
