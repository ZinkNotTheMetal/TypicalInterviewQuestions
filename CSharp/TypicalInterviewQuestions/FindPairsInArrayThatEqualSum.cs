using System.Collections.Generic;

namespace TypicalInterviewQuestions
{
    //How to find all pairs of elements in an integer array, whose sum is equal to a given number?
    public static class FindPairsInArrayThatEqualSum
    {
        public static List<KeyValuePair<int, int>> FindPairsThatEqualSum(this int[] input, int sum)
        {
            if (input.Length < 2) return null;

            var result = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] + input[j] == sum) result.Add(new KeyValuePair<int, int>(input[i], input[j]));
                }
            }

            return result.Count == 0 ? null : result;
        }

        /// <summary>
        ///     Returns bool if the array has any elements equal to the pair.
        /// </summary>
        /// <param name="input">Array of elements</param>
        /// <param name="sum">Desired sum</param>
        /// <returns cref="bool">True if it has a pair that equals the sum, False if it does not.</returns>
        public static bool HasPairsThatEqualSum(this int[] input, int sum)
        {
            return FindPairsThatEqualSum(input, sum).Count > 0;
        }
    }
}