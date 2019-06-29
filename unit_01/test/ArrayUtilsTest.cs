using UtilsLibrary;
using Xunit;

namespace test
{
    public class ArrayUtilsSortShould
    {
        private readonly int[] _sortedArray = { 1, 2, 3, 4, 5 };

        [Fact]
        public void Pass_withReverseSortedArray()
        {
            int[] reverseSortedArray = { 5, 4, 3, 2, 1 };

            ArrayUtils.Sort(reverseSortedArray);

            Assert.Equal(_sortedArray, reverseSortedArray);
        }

        [Fact]
        public void PassWithUnsortedArray()
        {
            int[] unsortedArray = { 5, 3, 1, 2, 4 };

            ArrayUtils.Sort(unsortedArray);

            Assert.Equal(_sortedArray, unsortedArray);
        }

        [Fact]
        public void PassWithOddNumberOfElementsArray()
        {
            int[] unsortedArray = { 3, 1, 2, 4 };
            int[] sortedArray = { 1, 2, 3, 4 };

            ArrayUtils.Sort(unsortedArray);

            Assert.Equal(sortedArray, unsortedArray);
        }

        [Fact]
        public void PassWithDuplicates()
        {
            int[] expectedArray = { 2, 2, 4, 4 };
            int[] array = { 2, 4, 4, 2 };

            ArrayUtils.Sort(array);

            Assert.Equal(expectedArray, array);
        }
    }

    public class ArrayUtilsFindMaxShould
    {
        [Theory]
        [InlineData(new [] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new [] { 3, 2, 5, 4, 1 }, 5)]
        [InlineData(new [] { 5, 5, 5, 1, 1 }, 5)]
        public void PassGivenArray(int[] values, int expected)
        {
            Assert.Equal(expected, ArrayUtils.FindMax(values));
        }
    }

    public class ArrayUtilsFindMinShould
    {
        [Theory]
        [InlineData(new [] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new [] { 3, 2, 5, 4, 1 }, 1)]
        [InlineData(new [] { 1, 1, 1, 5, 5 }, 1)]
        public void PassGivenArray(int[] values, int expected)
        {
            Assert.Equal(expected, ArrayUtils.FindMax(values));
        }
    }

    public class ArrayUtilsSumNonNegativeValuesShould
    {
        [Theory]
        [InlineData(new [] {-1, 2, -3, 4, -5}, 6)]
        [InlineData(new [] {-3, -2, -5, -4, -1}, 0)]
        [InlineData(new [] {1, 1, 1, 5, 5}, 13)]
        public void PassGivenArray(int[] values, int expected)
        {
            Assert.Equal(expected, ArrayUtils.SumNonNegativeValues(values));
        }
    }

    public class ArrayUtilsSumEvenPositionValuesShould
    { 
        [Fact]
        public void PassGivenTestArray()
        {
            int[,] values = new int[,] { { 1, 1, 1 }, { 2, 2, 2 } };
            Assert.Equal(4, ArrayUtils.SumEventPositionValues(values));
        }
    }

    public class ArrayUtilsReplaceNonPositive3DShould
    {
        [Fact]
        public void PassGivenTestArray()
        {
            const int size = 3;
            int[,,] values = new int[size, size, size];
            int[,,] expected = new int[size, size, size];
            PopulateArray(values, size, -1);
            PopulateArray(values, size, 0);
            ArrayUtils.ReplaceNonPositive3D(values);
            Assert.Equal(expected, values);
        }

        private static void PopulateArray(int[,,] values, int size, int value)
        {
            for (var x = 0; x < size; ++x)
            {
                for (var y = 0; y < size; ++y)
                {
                    for (var z = 0; z < size; ++z)
                    {
                        values[x, y, z] = value;
                    }
                }
            }
        }
    }
}