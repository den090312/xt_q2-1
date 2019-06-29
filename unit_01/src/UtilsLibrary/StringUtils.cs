using System.Linq;

namespace UtilsLibrary
{
    public class StringUtils
    {
        public static double CalculateAverageLength(string input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            string[] words = input
                .Aggregate("", (current, c) => current + (char.IsLetterOrDigit(c) ? c : ' '))
                .Split(new []{' '}, System.StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return 0;
            }

            return words.Select(x => x.Length).Average();
        }

        public static string IncreaseCharactersMatchingSecondString(string input, string pattern)
        {
            return input.Aggregate("", (current, c) => current + (pattern.Contains(c) ? $"{c}{c}" : c.ToString()));
        }
    }
}
