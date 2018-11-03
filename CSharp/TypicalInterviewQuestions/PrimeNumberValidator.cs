using System;

namespace TypicalInterviewQuestions
{
    //Write an algorithm to check if a number is Prime or not?
    //A prime number (or a prime) is a natural number greater than 1 that has no positive divisors 
    //  other than 1 and itself.
    public class PrimeNumberValidator
    {
        public bool Validate(int input)
        {
            if (input < 0) throw new ArgumentException("Validator expects positive number above 0.");
            //Zero and one are not considered prime numbers
            if (input == 0 || input == 1) return false;

            for (var i = 2; i < input; i++)
            {
                if (input % i == 0) return false;
            }
            return true;
        }
    }
}