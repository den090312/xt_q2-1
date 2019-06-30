using System;
using UtilsLibrary;

namespace ArrayProcessing
{
    internal class Application
    {
        private const int Size = 10;
        private const int TopBorder = 10;

        private readonly int[] _values = new int[Size];
        public void Run()
        {
            PopulateArray();
            PrintIntro();
            Solve();
        }

        private void PopulateArray()
        {
            var random = new Random();
            for (var i = 0; i < _values.Length; ++i)
            {
                _values[i] = random.Next(0, TopBorder) - TopBorder / 2;
            }
        }

        private void PrintIntro()
        {
            Console.WriteLine("This is the demo application for non-negative sum utility");
            Console.WriteLine("Here is an array:");
            PrintArray();
        }

        private void PrintArray()
        {
            foreach (var t in _values)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();
        }

        private void Solve()
        {
            Console.WriteLine("Maximum of an array is: {0}", ArrayUtils.FindMax(_values));
            Console.WriteLine("Minimum of an array is: {0}", ArrayUtils.FindMin(_values));
            Console.WriteLine("Below you can observe sorted array:");
            ArrayUtils.Sort(_values);
            PrintArray();
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
