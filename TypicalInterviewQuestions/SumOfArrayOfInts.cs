using System.Linq;

namespace TypicalInterviewQuestions
{
    //Write an algorithm that sums up all integers in a given array.
    //Account for long to avoid integer overflow exception.
    public class SumOfArrayOfInts
    {
        public long SumOfEvenNumbersWithLinq(int[] input)
        {
            return input.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }
}