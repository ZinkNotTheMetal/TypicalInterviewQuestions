using System;

namespace TypicalInterviewQuestions
{
    //#7 in Amazon / Google Questions
    public class FibonacciPrint
    {
        public int PrintNthElementInSequence(int nthElement)
        {
            if (nthElement < 0) throw new ArgumentException("Fibonacci Element must be a positive number");
            if (nthElement == 0) return 0;
            if (nthElement == 1) return 0;
            if (nthElement == 2) return 1;

            int result = 0;
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 2; i < nthElement; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }
    }
}
