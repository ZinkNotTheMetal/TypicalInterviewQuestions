using System.Linq;

namespace TypicalInterviewQuestions
{
    //#15 in Amazon / Google Questions
    public class DuplicateArrayFinder
    {
        public bool ContainsDuplicates(int[] input)
        {
            return input.ToList().GroupBy(x => x).Any(g => g.Count() > 1);
        }

//        public bool ContainsDuplicates(int[] input)
//        {
//            List<int> numbers = new List<int>();
//
//            foreach (var number in input)
//            {
//                if (numbers.Contains(number)) return true;
//                numbers.Add(number);
//            }
//
//            return false;
//        }
    }
}
