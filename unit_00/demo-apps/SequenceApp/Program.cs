using ApplicationBase;
using Sequence;
using System;

namespace SequenceApp
{
    /// <summary>
    /// Implements an application to generate sequence of numbers based upon user input.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void Solve()
        {
            Console.WriteLine(Generator.MakeSequence(Value));
        }
    }

    /// <summary>
    /// Defines an entry point for the .NET Core CLI app.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the Application to solve Sequence generation problem.
        /// </summary>
        public static void Main()
        {
            new Application().Run();
        }
    }
}
