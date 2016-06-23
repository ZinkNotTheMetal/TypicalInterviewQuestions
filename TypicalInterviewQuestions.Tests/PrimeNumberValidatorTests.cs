using System;
using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class PrimeNumberValidatorTests
    {
        private PrimeNumberValidator _primeValidator;

        [SetUp]
        public void Setup()
        {
            _primeValidator = new PrimeNumberValidator();
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(17)]
        [TestCase(19)]
        [TestCase(23)]
        [TestCase(29)]
        [TestCase(31)]
        [TestCase(37)]
        [TestCase(1609)]
        [TestCase(3079)]
        public void ShouldReturnTrueIfPrimeNumber(int testCase)
        {
            Assert.IsTrue(_primeValidator.Validate(testCase));
        }

        
        [TestCase(-1)]
        [TestCase(-549)]
        public void ShouldOnlyAllowPositiveNumbers_ShouldReturnExceptionIfNegative(int testCase)
        {
            Assert.Throws<ArgumentException>(() => _primeValidator.Validate(testCase));
        }

        [TestCase(0)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(46)]
        [TestCase(55)]
        [TestCase(63)]
        [TestCase(2112)]
        [TestCase(2500)]
        [TestCase(2560)]
        public void ShouldReturnFalseIfNotPrimeNumber(int testCase)
        {
            Assert.IsFalse(_primeValidator.Validate(testCase));
        }
    }
}
