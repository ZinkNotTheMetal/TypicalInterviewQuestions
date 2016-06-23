using System;
using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class ArmstrongNumberValidatorTests
    {
        private ArmstrongNumberValidator _armstrongValidator;

        [SetUp]
        public void Setup()
        {
            _armstrongValidator = new ArmstrongNumberValidator();
        }

        [TestCase(-1)]
        [TestCase(-549)]
        public void ShouldOnlyAllowPositiveNumbers_ShouldReturnExceptionIfNegative(int testCase)
        {
            Assert.Throws<ArgumentException>(() => _armstrongValidator.Validate(testCase));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(153)]
        [TestCase(370)]
        [TestCase(371)]
        [TestCase(407)]
        [TestCase(1634)]
        [TestCase(8208)]
        [TestCase(9474)]
        [TestCase(54748)]
        [TestCase(1741725)]
        public void ShouldReturnTrue_WhenValidArmstrongNumber(int testCase)
        {
            Assert.IsTrue(_armstrongValidator.Validate(testCase));
        }

        [TestCase(100)]
        [TestCase(297)]
        [TestCase(389)]
        [TestCase(581)]
        public void ShouldReturnFalse_WhenInputIsNotValidArmstrongNumber(int testCase)
        {
            Assert.IsFalse(_armstrongValidator.Validate(testCase));
        }
    }
}
