namespace TypicalInterviewQuestions
{
    //Write a function to calculate factorial using recursion?
    public class FactorialRecursion
    {
        public int Calculate(int factorial)
        {
            if (factorial <= 0) return 0;
            if (factorial == 1) return factorial;
            return Calculate(factorial - 1) * factorial;
        }
    }
}