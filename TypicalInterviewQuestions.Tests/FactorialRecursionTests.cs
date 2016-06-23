using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class FactorialRecursionTests
    {
        private FactorialRecursion _factorialCalculator;

        [SetUp]
        public void Setup()
        {
            _factorialCalculator = new FactorialRecursion();
        }

        [Test]
        public void SendingInZero_ShouldReturnZero()
        {
            Assert.AreEqual(0, _factorialCalculator.Calculate(0));
        }

        [Test]
        public void SendingInNegative_ShouldReturnZero()
        {
            Assert.AreEqual(0, _factorialCalculator.Calculate(-10));
        }

        [Test]
        public void SendingInOne_ShouldReturnOne()
        {
            Assert.AreEqual(1, _factorialCalculator.Calculate(1));
        }

        [Test]
        public void SendingInTwo_ShouldReturnTwo()
        {
            Assert.AreEqual(2, _factorialCalculator.Calculate(2));
        }

        [Test]
        public void SendingInThree_ShouldReturnSix()
        {
            Assert.AreEqual(6, _factorialCalculator.Calculate(3));
        }

        [Test]
        public void SendingInFive_ShouldReturnOneHundredTwenty()
        {
            Assert.AreEqual(120, _factorialCalculator.Calculate(5));
        }
    }
}
