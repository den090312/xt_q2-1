using System;
using ApplicationBase;
using UtilsLibrary;

namespace XmasTree
{
    /// <summary>
    /// Implements printer for X-Mas Tree.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void PrintIntro()
            => Console.WriteLine("Welcome to unit 01 - \"Xmas Tree\" application. User input represents number of triangles in tree.");

        protected override void Solve()
        {
            if (Value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (var i = 1; i < Value + 1; ++i)
            {
                new TrianglePrinter().PrintIsoscelesTriangle(i, Value - i);
            }
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
