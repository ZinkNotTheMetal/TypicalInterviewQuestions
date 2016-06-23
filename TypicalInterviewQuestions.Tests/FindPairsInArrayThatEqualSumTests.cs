using System.Collections.Generic;
using ExpectedObjects;
using NUnit.Framework;

namespace TypicalInterviewQuestions.Tests
{
    public class FindPairsInArrayThatEqualSumTests
    {
        [TestCase(1, new[] { 1 })]
        [TestCase(0, new int[] {})]
        public void ShouldReturnNullIfInvalidInput(int expectedSum, int[] testCase)
        {
            Assert.IsNull(testCase.FindPairsThatEqualSum(32));
        }

        [TestCase(4, new[] { 1, 3 })]
        public void ShouldReturnProperDictionary_WhenSumEqualsPairsOfElementsInsideArray(int expectedSum, int[] testcase)
        {
            var expected = new List<KeyValuePair<int, int>>();
            expected.Add(new KeyValuePair<int, int>(1, 3));
            expected.Add(new KeyValuePair<int, int>(3, 1));

            expected.ToExpectedObject().ShouldEqual(testcase.FindPairsThatEqualSum(expectedSum));
        }

        [TestCase(7, new[] { 1, 3, 4, 9, 2, 1, 5, 3, 1 })]
        public void ShouldReturnProperDictionary_WhenSumEqualsPairsOfElementsInsideArray_LotOfElements(int expectedSum, int[] testcase)
        {
            var expectedResult = new List<KeyValuePair<int, int>>();
            expectedResult.Add(new KeyValuePair<int, int>(3, 4));
            expectedResult.Add(new KeyValuePair<int, int>(4, 3));
            expectedResult.Add(new KeyValuePair<int, int>(4, 3));
            expectedResult.Add(new KeyValuePair<int, int>(2, 5));
            expectedResult.Add(new KeyValuePair<int, int>(5, 2));
            expectedResult.Add(new KeyValuePair<int, int>(3, 4));

            expectedResult.ToExpectedObject().ShouldEqual(testcase.FindPairsThatEqualSum(expectedSum));
        }
    }
}
