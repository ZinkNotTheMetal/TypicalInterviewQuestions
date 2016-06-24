using System;

namespace TypicalInterviewQuestions
{
    //Write an algorithm to check if a number is Palindrome?
    //A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward.
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