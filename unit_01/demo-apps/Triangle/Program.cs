using ApplicationBase;
using System;
using UtilsLibrary;

namespace Triangle
{
    /// <summary>
    /// Implements printer for left aligned right triangles.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void PrintIntro()
            => Console.WriteLine("Welcome to unit 01 - Triangle. User input represents the height of triangle.");

        protected override void Solve()
        {
            if (Value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            new TrianglePrinter().PrintRightTriangle(Value);
        }
    }

    /// <summary>
    /// Defines an entry point for the .NET Core CLI app.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            new Application().Run();
        }
    }
}
