using System;
using UtilsLibrary;

namespace AverageStringLength
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("This is utility for getting average sub-string length in given string.");
            Console.WriteLine("Only sub-strings consisting of digits and characters are allowed \r\n" +
                              "no punctuation or special characters will be processed.");
            Console.WriteLine("Please input string.");
            string input = Console.ReadLine();
            Console.Write("Average length is {0}", StringUtils.CalculateAverageLength(input));
        }
    }
}
