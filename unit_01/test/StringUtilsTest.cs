using UtilsLibrary;
using Xunit;

namespace test
{
    public class StringUtilsCalculateAverageLengthShould
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1 12 123", 2)]
        [InlineData("a vv ccc", 2)]
        public void GiveFollowingValuesInCaseOfThisStrings(string data, int expected)
        {
            var actual = StringUtils.CalculateAverageLength(data);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(".............", 0)]
        [InlineData("1[12]123,,.,.", 2)]
        public void FilterNonDigitOrLetterCharacters(string data, int expected)
        {
            var actual = StringUtils.CalculateAverageLength(data);

            Assert.Equal(expected, actual);
        }
    }

    public class StringUtilsIncreaseCharactersMatchingSecondStringShould
    {
        [Theory]
        [InlineData("abcd", "bd", "abbcdd")]
        [InlineData("", "abc", "")]
        [InlineData("abc", "", "abc")]
        [InlineData("a", "aaa", "aa")]
        public void DoubleAmountOfCharactersThatSecondStringContains(string first, string second, string expected)
        {
            var actual = StringUtils.IncreaseCharactersMatchingSecondString(first, second);

            Assert.Equal(expected, actual);
        }
    }
}