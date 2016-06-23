using System;
using System.Collections;
using System.Linq;

namespace TypicalInterviewQuestions
{
    //#8 in Amazon / Google Questions
    public static class CountBitsInInteger
    {
        public static int CountBits(this int input)
        {
            BitArray bitArray = new BitArray(new int[] { input });

            bool[] bits = new bool[bitArray.Count];
            bitArray.CopyTo(bits, 0);

            byte[] bitValues = bits.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            return bitValues.Aggregate(0, (current, bit) => current + bit);
        }
    }
}
