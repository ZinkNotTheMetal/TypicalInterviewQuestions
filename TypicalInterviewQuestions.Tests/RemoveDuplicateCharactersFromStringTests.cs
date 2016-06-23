using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    [TestFixture]
    public class RemoveDuplicateCharactersFromStringTests
    {
        [TestCase("Mad", "Mad")]
        [TestCase("One", "One")]
        [TestCase("Watch", "Watch")]
        [TestCase("", "")]
        public void RemoveDuplicates_WhenInputContainsNoDuplicates_ShouldReturnSameString(string expected, string input)
        {
            Assert.AreEqual(expected, input.LeaveFirstLetterRemoveDuplicates());
        }

        [TestCase("Expctd", "Expected")]
        [TestCase("Nie", "Nine")]
        [TestCase("Tweny-i", "Twenty-Nine")]
        [TestCase("Begin", "Beginning")]
        [TestCase("my artin ove", "my martian movie")]
        [TestCase("many os g", "many moons ago")]
        [TestCase("Try Being  h WODS a ", "Try Being In The WOODS at noon")]
        public void RemoveDuplicates_WhenInputContainsDuplicates_ShouldReturnExpectedString(string expected, string input)
        {
            Assert.AreEqual(expected, input.LeaveFirstLetterRemoveDuplicates());
        }
    }
}
