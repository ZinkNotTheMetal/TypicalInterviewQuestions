using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class FibonacciPrintTests
    {
        private FibonacciPrint _fibonacciPrint;

        [SetUp]
        public void Setup()
        {
            _fibonacciPrint = new FibonacciPrint();
        }

        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(5, 6)]
        [TestCase(8, 7)]
        [TestCase(13, 8)]
        [TestCase(21, 9)]
        [TestCase(34, 10)]
        public void ShouldReturnProperNumberInSequence_WhenPositiveNumber(int expected, int element)
        {
            Assert.AreEqual(expected, _fibonacciPrint.PrintNthElementInSequence(element));
        }
    }
}
