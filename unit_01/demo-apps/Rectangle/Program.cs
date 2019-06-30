using System;
using System.Numerics;
using System.Text;
using ApplicationBase;

namespace Rectangle
{
    internal class Application: GenericConsoleApplication
    {
        public override void Run()
        {
            PrintIntro();
            var result = false;
            while (!result)
            {
                result = AttemptToSolve();
            }
        }

        private static void PrintIntro()
        {
            Console.WriteLine("Welcome to the program for calculating the area of a rectangle.");
            Console.WriteLine("Below you will be prompted to enter the sides of the rectangle," +
                              " be advised however that all non-numeric characters will be ignored");
        }

        /// <summary>
        /// This method was specially constructed to conquer ambiguity in task's description:
        /// that states application should ignore all non numeric symbols.
        /// Method demonstrates PoC character-filter method.
        /// </summary>
        public int ReadIntFiltered()
        {
            ConsoleKeyInfo cki;
            var accumulator = new StringBuilder();
            do
            {
                cki = Console.ReadKey();
                var symbol = cki.KeyChar;

                if (!char.IsDigit(symbol) && symbol != '-' && cki.Key != ConsoleKey.Enter)
                {
                    Console.Write("\b \b");
                    continue;
                }

                if (cki.Key != ConsoleKey.Enter)
                {
                    accumulator.Append(symbol);
                }
            } while (cki.Key != ConsoleKey.Enter || accumulator.Length == 0);
            Console.WriteLine();

            if (!int.TryParse(accumulator.ToString(), out var result))
            {
                throw new FormatException($"String {nameof(accumulator)} has invalid format: {accumulator}");
            }

            return result;
        }

        private static void ValidateUserInput(int value, string valueName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(valueName);
            }
        }

        protected override void Solve()
        {
            Console.WriteLine("Please input width of the rectangle: ");
            int width = ReadIntFiltered();
            ValidateUserInput(width, nameof(width));
            Console.WriteLine("Please input height of the rectangle: ");
            int height = ReadIntFiltered();
            ValidateUserInput(width, nameof(height));
            BigInteger area = new UtilsLibrary.Rectangle(width, height).Area;
            Console.WriteLine("Area of the rectangle is: {0}", area);
        }
    }

    internal class Program
    {
        private static void Main()
        {
            new Application().Run();
        }
    }
}
