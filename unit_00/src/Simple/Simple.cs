using System;

namespace Simple
{
    /// <summary>
    /// Provides implementation of <see href="https://en.wikipedia.org/wiki/Trial_division">Trial division</see> method.
    /// Please refer to <see href="https://en.wikipedia.org/wiki/Primality_test">primality test</see> page for additional information.
    /// </summary>
    public class PrimeNumbersDetector
    {
        /// <summary>Detects <paramref name="n">n</paramref> is a prime number.</summary>
        /// <param name="n">Number to test.</param>
        public static bool IsPrime(int n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            var i = 5;
            var t = Math.Sqrt(n);
            while (i <= t)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }

                i += 6;
            }
            return true;
        }
    }
}
