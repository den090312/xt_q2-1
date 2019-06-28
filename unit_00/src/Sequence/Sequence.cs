using System;
using System.Linq;

namespace Sequence
{
    /// <summary>Represents a generator that creates sequences of integers separated by commas.</summary>
    public class Generator
    {
        /// <summary>Creates string with a sequence of numbers separated by commas that starts with 1 and ends with <paramref name="top">top</paramref>.</summary>
        /// <param name="top">Last term of the sequence.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="top">top</paramref> is less or equals zero.</exception>
        /// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
        public static string MakeSequence(int top)
        {
            if (top <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(top), "Top value must be greater than zero.");
            }

            return string.Join(", ", Enumerable.Range(1, top));
        }
    }
}
