using System;
using Xunit;
using Square;

namespace test
{
    public class PlotterMakeSquare
    {
        private readonly Plotter _plotter = new Plotter();

        [Theory]
        [InlineData(1, " ")]
        [InlineData(3, "***\r\n* *\r\n***\r\n")]
        public void Plotter_With_Valid_Values_ShouldPass(int sideSize, string expected)
        {
            var actual = _plotter.MakeSquare(sideSize);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(2)]
        public void Plotter_With_Invalid_Values_Throws_ArgumentException(int sideSize)
        {
            Assert.Throws<ArgumentException>(() => _plotter.MakeSquare(sideSize));
        }
    }
}