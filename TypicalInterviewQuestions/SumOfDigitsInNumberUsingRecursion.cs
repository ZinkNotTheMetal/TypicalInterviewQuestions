namespace TypicalInterviewQuestions
{
    //#19 in Amazon / Google Questions
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
