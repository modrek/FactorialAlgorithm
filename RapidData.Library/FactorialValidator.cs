using System;

namespace RapidData.MathLib
{
    public static class FactorialValidator 
    {
        public static void Validate(int param)
        {
            if (param < 0)
                throw new ArgumentException(null, nameof(param));            
        }
    }
}
