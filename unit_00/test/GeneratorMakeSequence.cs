using System;
using Xunit;
using Sequence;

namespace test
{
    public class GeneratorMakeSequence
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "1, 2")]
        [InlineData(7, "1, 2, 3, 4, 5, 6, 7")]
        public void Generator_With_Valid_Values_ShouldPass(int top, string expected)
        {
            var actual = Generator.MakeSequence(top);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Generator_With_Less_Or_Equal_Than_Zero_Values_Throws_ArgumentOutOfRangeException(int top)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Generator.MakeSequence(top));
        }

        [Fact]
        public void Generator_With_Max_Value_Throws_OutOfMemoryException()
        {
            Assert.Throws<OutOfMemoryException>(() => Generator.MakeSequence(int.MaxValue));
        }
    }
}
