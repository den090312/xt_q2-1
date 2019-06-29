using System;
using UtilsLibrary;

namespace CharDoubler
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Char Doubler application.");
            Console.WriteLine("Please input first string below:");
            var first = Console.ReadLine();
            Console.WriteLine("Please input second string below:");
            var second = Console.ReadLine();
            var result = StringUtils.IncreaseCharactersMatchingSecondString(first, second);
            Console.WriteLine("The result is:");
            Console.WriteLine(result);
        }
    }
}
