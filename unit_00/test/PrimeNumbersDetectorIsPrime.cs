using Xunit;
using Simple;

namespace test
{
    public class PrimeNumbersDetectorIsPrime
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(100803277, true)]
        [InlineData(100803276, false)]
        [InlineData(int.MaxValue - 1, false)]
        [InlineData(int.MaxValue, true)]
        public void PrimeNumberDetector_With_Valid_Table_Values_ShouldPass(int n, bool expected)
        {
            var actual = PrimeNumbersDetector.IsPrime(n);
            Assert.Equal(expected, actual);
        }
    }
}