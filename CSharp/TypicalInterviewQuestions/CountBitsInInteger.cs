using System.Collections;
using System.Linq;

namespace TypicalInterviewQuestions
{
    //Write a function to count a total number of set bits in a 32 bit Integer?
    public static class CountBitsInInteger
    {
        public static int CountBits(this int input)
        {
            BitArray bitArray = new BitArray(new[] { input });

            bool[] bits = new bool[bitArray.Count];
            bitArray.CopyTo(bits, 0);

            byte[] bitValues = bits.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            return bitValues.Aggregate(0, (current, bit) => current + bit);
        }
    }
}