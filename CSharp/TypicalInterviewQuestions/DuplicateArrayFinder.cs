using System.Linq;

namespace TypicalInterviewQuestions
{
    //Write an algorithm to find if an Array contains duplicates?
    public class DuplicateArrayFinder
    {
        public bool ContainsDuplicates(int[] input)
        {
            return input.ToList().GroupBy(x => x).Any(g => g.Count() > 1);
        }
    }
}