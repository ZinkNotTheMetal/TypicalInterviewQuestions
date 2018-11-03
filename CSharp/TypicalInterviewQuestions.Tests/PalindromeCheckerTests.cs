using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        private PalindromeChecker _palindromeChecker;

        [SetUp]
        public void Setup()
        {
            _palindromeChecker = new PalindromeChecker();
        }

        [Test]
        public void ShouldReturnTrue_PositiveFirstExample()
        {
            Assert.IsTrue(_palindromeChecker.Validate("A man, a plan, a canal, Panama"));
        }

        [Test]
        public void ShouldReturnTrue_PositiveSecondExample()
        {
            Assert.IsTrue(_palindromeChecker.Validate("noon"));
        }

        [Test]
        public void ShouldReturnTrue_PositiveThirdExample()
        {
            Assert.IsTrue(_palindromeChecker.Validate("taco cat"));
        }

        [Test]
        public void ShouldReturnTrue_WhenPositiveForthExample()
        {
            Assert.IsTrue(_palindromeChecker.Validate("race car"));
        }

        [Test]
        public void ShouldReturnFalse_WhenNotAPalindrome()
        {
            Assert.IsFalse(_palindromeChecker.Validate("high noon"));
        }
    }
}
