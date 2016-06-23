using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class SumOfArrayOfIntsTests
    {
        [Test]
        public void SumOfEvenNumbersWithLinq_WhenNoEvens_ShouldReturnSumOfEvens()
        {
            var sumCalculator = new SumOfArrayOfInts();

            int[] validArray = { 1, 3, 9, 5, 7 };

            var result = sumCalculator.SumOfEvenNumbersWithLinq(validArray);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SumOfEvenNumbersWithLinq_WhenValidNumbers_ShouldReturnSumOfEvens()
        {
            var sumCalculator = new SumOfArrayOfInts();

            int[] validArray = { 1, 3, 4, 5, 6 };

            var result = sumCalculator.SumOfEvenNumbersWithLinq(validArray);

            Assert.That(result, Is.EqualTo(10));
        }
    }
}