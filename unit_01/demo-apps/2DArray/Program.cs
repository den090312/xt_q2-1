using UtilsLibrary;
using System;

namespace _2DArray
{
    internal class Application
    {
        private const int Width = 4;
        private const int Height = 4;

        private readonly int[,] _values = new int[Width, Height];

        public void Run()
        {
            PopulateArray();
            PrintIntro();
            Solve();
        }

        private void PopulateArray()
        {
            var random = new Random();
            for (var i = 0; i < _values.GetLength(0); ++i)
            {
                for (var j = 0; j < _values.GetLength(1); ++j)
                {
                    _values[i, j] = random.Next(0, 10);
                }
            }
        }

        private void PrintIntro()
        {
            Console.WriteLine("This is the demo application for 2D Array sum utility");
            Console.WriteLine("Here is an array:");
            for (var i = 0; i < _values.GetLength(0); ++i)
            {
                for (var j = 0; j < _values.GetLength(1); ++j)
                {
                    Console.Write("{0} ", _values[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void Solve()
        {
            Console.WriteLine("Sum of even-positioned elements of this array is: {0}", ArrayUtils.SumEventPositionValues(_values));
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
