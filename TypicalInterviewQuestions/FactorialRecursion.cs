namespace TypicalInterviewQuestions
{
    //#11 in Amazon / Google Questions
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
