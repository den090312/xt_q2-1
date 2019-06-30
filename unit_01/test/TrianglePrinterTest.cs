using System;
using System.IO;
using UtilsLibrary;
using Xunit;

namespace test
{
    public class TrianglePrinterPrintIsoscelesTriangleShould
    {
        private readonly StringWriter _stringWriter = new StringWriter();
        private readonly TrianglePrinter _trianglePrinter = new TrianglePrinter();

        [Theory]
        [InlineData(1, "*\r\n")]
        [InlineData(3, "  *  \r\n *** \r\n*****\r\n")]
        public void PrintStringsGivenValueOf1Or3(int height, string expected)
        {
            Console.SetOut(_stringWriter);

            _trianglePrinter.PrintIsoscelesTriangle(height);

            Assert.Equal(expected, _stringWriter.ToString());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Throw_ArgumentOutOfRangeException_GivenNonPositiveValues(int height)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _trianglePrinter.PrintIsoscelesTriangle(height));
        }
    }

    public class TrianglePrinterPrintRightTriangleShould
    {
        private readonly StringWriter _stringWriter = new StringWriter();
        private readonly TrianglePrinter _trianglePrinter = new TrianglePrinter();

        [Theory]
        [InlineData(1, "*\r\n")]
        [InlineData(3, "*  \r\n** \r\n***\r\n")]
        public void PrintStringsGivenValueOf1Or3(int height, string expected)
        {
            Console.SetOut(_stringWriter);

            _trianglePrinter.PrintRightTriangle(height);

            Assert.Equal(expected, _stringWriter.ToString());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Throw_ArgumentOutOfRangeException_GivenNonPositiveValues(int height)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _trianglePrinter.PrintRightTriangle(height));
        }
    }
}
