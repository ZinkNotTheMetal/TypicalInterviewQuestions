using System.Collections.Generic;

namespace TypicalInterviewQuestions
{
    //#6 in Amazon / Google Questions
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

        public static bool HasPairsThatEqualSum(this int[] input, int sum)
        {
            return FindPairsThatEqualSum(input, sum).Count > 0;
        }
    }
}
