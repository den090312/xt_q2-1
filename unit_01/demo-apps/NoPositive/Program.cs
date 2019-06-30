using System;
using UtilsLibrary;

namespace NoPositive
{
    internal class Application
    {
        private const int Width = 2;
        private const int Height = 2;
        private const int Depth = 2;
        private const int TopValue = 10;

        private readonly int[,,] _values = new int[Width, Height, Depth];

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
                    for (var k = 0; k < _values.GetLength(2); ++k)
                    {
                        _values[i, j, k] = random.Next(0, TopValue) - TopValue / 2;
                    }
                }
            }
        }

        private void PrintIntro()
        {
            Console.WriteLine("This is the demo application for 3D Array non positive replacer");
            Console.WriteLine("Here is an array:");
            Print3DArray();
        }

        private void Print3DArray()
        {
            for (var i = 0; i<_values.GetLength(0); ++i)
            {
                for (var j = 0; j<_values.GetLength(1); ++j)
                {
                    for (var k = 0; k<_values.GetLength(2); ++k)
                    {
                        Console.Write("{0} ", _values[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------");
            }
        }

        private void Solve()
        {
            ArrayUtils.ReplacePositive3D(_values);
            Console.WriteLine("Array with all positive values been replaced presented below:");
            Print3DArray();
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
