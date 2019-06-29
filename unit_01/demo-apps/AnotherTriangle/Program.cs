using System;
using ApplicationBase;
using UtilsLibrary;

namespace AnotherTriangle
{
    /// <summary>
    /// Implements printer for isosceles triangle.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void PrintIntro()
            => Console.WriteLine("Welcome to unit 01 - \"Another Triangle\" application. User input represents the height of triangle.");

        protected override void Solve()
        {
            if (Value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            new TrianglePrinter().PrintIsoscelesTriangle(Value);
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
