namespace TypicalInterviewQuestions
{
    //How to find sum of digits of a number using Recursion?
    public class SumOfDigitsInNumberUsingRecursion
    {
        public int Sum(int input)
        {
            if (input < 0) return -1;
            if (input == 0) return 0;

            return input % 10 + Sum(input / 10);
        }
    }
}