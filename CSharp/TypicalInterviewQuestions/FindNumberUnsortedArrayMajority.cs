using System;
using System.Collections.Generic;
using System.Linq;

namespace TypicalInterviewQuestions
{
    //Given an unsorted array which has a number in the majority 
    //  (a number appears more than 50% in the array), find that number?
    public class FindNumberUnsortedArrayMajority
    {
        /// <summary>
        ///     Takes an array of integers and finds if a number appears more than 50% in the array.
        /// </summary>
        /// <param name="input">Array of integers</param>
        /// <returns cref="int">-1 if not found. Or integer value if found.</returns>
        public int FindNumberWithinArray(int[] input)
        {
            //Trying to find out what count is, to determine what classifies as majority
            var majority = Math.Ceiling(input.Length / 2.0);
            if (input.Length % 2 == 0) majority = majority + 1;

            //Key = value of number
            //Value = count within the input
            var numberAndCount = new Dictionary<int, int>();

            foreach (var number in input)
            {
                if (numberAndCount.ContainsKey(number)) numberAndCount[number]++;
                else numberAndCount.Add(number, 1);
            }

            var maxCount = numberAndCount.Values.Max();
            var possibleMajority = numberAndCount.First(v => v.Value == maxCount).Key;

            if (majority <= maxCount) return possibleMajority;

            return -1;
        }
    }
}
