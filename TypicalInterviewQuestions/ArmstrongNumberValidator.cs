using System;

namespace TypicalInterviewQuestions
{
    //#12 in Amazon / Google Questions
    public class ArmstrongNumberValidator
    {
        public bool Validate(int input)
        {
            if(input < 0) throw new ArgumentException("Can only validate positive numbers 0 or above.");
            if (input == 0) return true;

            int digits = Convert.ToInt32(Math.Floor(Math.Log10(input) + 1));
            long sum = 0;
            //For each digit power of digit add them together - if it's equal to sum then it's an armstrong
            for (int i = 1; i <= digits; i++)
            {
                sum += Convert.ToInt64(Math.Pow(GetDigit(input, i), digits));
            }

            return sum == input;
        }

        private int GetDigit(int input, int digitWanted)
        {
            //if (digitWanted == 1) return input % 10;
            return Convert.ToInt32(Math.Floor(input / Math.Pow(10, digitWanted - 1))) % 10;
        }
    }
}
