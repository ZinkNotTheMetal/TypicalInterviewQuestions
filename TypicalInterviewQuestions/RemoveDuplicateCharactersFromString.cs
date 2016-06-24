using System.Linq;

namespace TypicalInterviewQuestions
{
    //Write a function to remove duplicate characters from String?
    //With a hint of fun - leave the first letter remove all other duplicates keep casing
    public static class RemoveDuplicateCharactersFromString
    {
        public static string LeaveFirstLetterRemoveDuplicates(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            var inputToLowerAsCharArray = input.ToLower().ToCharArray();
            var result = input.ToCharArray();
            var duplicateChars = inputToLowerAsCharArray.GroupBy(x => x).Where(g => g.Count() > 1 && g.Key != ' ').ToList();

            for (int j = 0; j < inputToLowerAsCharArray.Length; j++)
            {
                if (duplicateChars.Any(x => x.Key == inputToLowerAsCharArray[j]))
                {
                    var firstOccurance = input.ToLower().IndexOf(inputToLowerAsCharArray[j]);

                    if (j == firstOccurance) continue;
                    result[j] = char.MaxValue;
                }
            }

            return new string(result).Replace(char.MaxValue.ToString(), "");
        }
    }
}