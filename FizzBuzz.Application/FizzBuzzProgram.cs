using System;

namespace FizzBuzz.Application
{
    /// <summary>
    ///     Classic FizzBuzz interview question
    /// </summary>
    public class FizzBuzzProgram
    {
        public static void Main(string[] args)
        {
            const int upperBound = 100;
            for (int i = 1; i <= upperBound; i++)
            {
                PrintFizzBuzz(i);
                //For formatting, do not print on last number
                if (i != upperBound) Console.Write(", ");
            }

            Console.ReadKey();
        }

        /// <summary>
        ///     Prints Fizz if % 3
        ///     Prints Buzz if % 5
        ///     Prints number if neither
        ///     Does not allow for negative or 0
        /// </summary>
        /// <param name="i" cref="int">Input to determine print</param>
        public static void PrintFizzBuzz(int i)
        {
            if (i <= 0) return;
            if (i % 3 == 0) Console.Write("Fizz");
            if (i % 5 == 0) Console.Write("Buzz");
            if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
        }
    }
}