using System;

namespace TypicalInterviewQuestions
{
    //#13 in Amazon / Google Questions
    public class PrimeNumberValidator
    {
        public bool Validate(int input)
        {
            if(input < 0) throw new ArgumentException("Validator expects positive number above 0.");
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
