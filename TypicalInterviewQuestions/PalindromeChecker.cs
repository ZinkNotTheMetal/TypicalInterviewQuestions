using System;

namespace TypicalInterviewQuestions
{
    //#14 in Amazon / Google Questions
    public class PalindromeChecker
    {
        public bool Validate(string input)
        {
            var cleanInput = input.Replace(" ", string.Empty).Replace(",", string.Empty).Replace("!", string.Empty).ToLower();
            var backwardsString = cleanInput.ToCharArray();
            Array.Reverse(backwardsString);
            var backwards = new string(backwardsString);
            return backwards == cleanInput;
        }
    }
}
