using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class AnagramCheckerTests
    {
        private AnagramChecker _anagramChecker;

        [SetUp]
        public void SetUp()
        {
            _anagramChecker = new AnagramChecker();
        }

        [Test]
        public void CorrectWayToSolveTheProblem_FirstExample()
        {
            Assert.IsTrue(_anagramChecker.CorrectValidation("William Shakespeare", "I am a weakish speller"));
        }

        [Test]
        public void ShouldReturnTrue_FirstExampleFromWiki()
        {
            Assert.IsTrue(_anagramChecker.Validate("William Shakespeare", "I am a weakish speller"));
        }

        [Test]
        public void ShouldReturnTrue_SecondExampleFromWiki()
        {
            Assert.IsTrue(_anagramChecker.Validate("Madam Curie", "Radium came"));
        }

        [Test]
        public void ShouldReturnTrue_ThirdExampleFromWiki()
        {
            Assert.IsTrue(_anagramChecker.Validate("listen", "silent"));
        }

        [Test]
        public void ShouldReturnTrue_ForthExampleFromWiki()
        {
            Assert.IsTrue(_anagramChecker.Validate("incest", "insect"));
        }

        [Test]
        public void ShouldReturnFalse_WhenNotAnagram()
        {
            Assert.IsFalse(_anagramChecker.Validate("William Shakespear", "I like jelly doughnuts"));
        }
    }
}
