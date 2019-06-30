using System;

namespace SumOfNumbers
{
    internal class Program
    {
        private static void Main()
        {
            var sum = 0;
            for (var i = 0; i < 1000; ++i)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of all numbers that are divisible by 3 or 5 and less than a thousand is: {0}", sum);
        }
    }
}
