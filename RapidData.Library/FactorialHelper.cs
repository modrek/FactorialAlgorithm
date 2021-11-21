using System.Linq;
using System.Numerics;

namespace RapidData.MathLib
{
    public static class FactorialHelper
    {       
        public static BigInteger Factorial1A(int number)
        {
            FactorialValidator.Validate(number);
            BigInteger fact = 1;
            for (var i = number; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }

        public static BigInteger Factorial1B(int number)
        {
            FactorialValidator.Validate(number);
            if (number == 0)
                return 1;
            var ints = Enumerable.Range(1, number);
            return ints.Aggregate((f, s) => f * s);
        }
        
        public static uint UnevenFactorial(uint number)
        {            
            if (number <= 2)
                return 1;
            if (number % 2 == 0)
                number--;

            return number * UnevenFactorial(number - 2);
        }

        public static BigInteger SquareFactorial (int number)
        {
            FactorialValidator.Validate(number);
            BigInteger fact = 1;
            for (var i = number; i>= 1; i--)
            {
                fact *= i*i;
            }
            return fact;
        }
    }
}
