using ApplicationBase;
using Simple;
using System;

namespace SimpleApp
{
    /// <summary>
    /// Implements detection of the fact that a number is a prime number in form of application.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void Solve()
        {
            if (Value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = PrimeNumbersDetector.IsPrime(Value) ? "is prime number." : "is not prime number.";
            Console.WriteLine("Value {0} {1}", Value, result);
        }
    }

    /// <summary>
    /// Defines an entry point for the .NET Core CLI app.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the Application that detects prime numbers.
        /// </summary>
        public static void Main()
        {
            new Application().Run();
        }
    }
}
