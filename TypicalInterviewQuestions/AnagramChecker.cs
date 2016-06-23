using System;
using System.Collections.Generic;
using System.Linq;

namespace TypicalInterviewQuestions
{
    //#4 in Amazon / Google Questions
    public class AnagramChecker
    {
        public bool CorrectValidation(string input, string comparitor)
        {
            var inputCharArray = input.ToLower().ToCharArray();
            var comparitorCharArray = input.ToLower().ToCharArray();

            Array.Sort(inputCharArray);
            Array.Sort(comparitorCharArray);

            return inputCharArray.ToString() == comparitorCharArray.ToString();
        }

        public bool Validate(string input, string comparitor)
        {
            var enumerator = input.Replace(" ", string.Empty).ToLower().ToCharArray().ToList();
            List<char> characterList = input.Replace(" ", string.Empty).ToLower().ToCharArray().ToList();
            List<char> comparitorCharacterList = comparitor.Replace(" ", string.Empty).ToLower().ToCharArray().ToList();

            if (characterList.Count != comparitorCharacterList.Count) return false;

            foreach (var character in enumerator)
            {
                if(!comparitorCharacterList.Contains(character)) return false;
                characterList.Remove(character);
                comparitorCharacterList.Remove(character);
            }

            return characterList.Count == 0 && comparitorCharacterList.Count == 0;
        }
    }
}
