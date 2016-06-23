using System.Linq;

namespace TypicalInterviewQuestions
{
    public class SumOfArrayOfInts
    {
        public long SumOfEvenNumbersWithLinq(int[] input)
        {
            return input.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }
}