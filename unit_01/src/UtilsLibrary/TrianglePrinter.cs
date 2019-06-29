using System;
using System.Text;

namespace UtilsLibrary
{
    public class TrianglePrinter
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void PrintIsoscelesTriangle(int height, int offset = 0)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }

            if (offset < 0 || offset >= 72)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }

            _stringBuilder.Clear();
            _stringBuilder.Append(' ', height * 2 + offset - 1);
            int right;
            int left = right = height + offset - 1;
            for (var i = 0; i < height; ++i)
            {
                _stringBuilder[left] = '*';
                _stringBuilder[right] = '*';
                --left;
                ++right;
                Console.WriteLine(_stringBuilder);
            }
        }

        public void PrintRightTriangle(int height)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }

            _stringBuilder.Clear();
            _stringBuilder.Append(' ', height);
            int right = 0;
            for (var i = 0; i < height; ++i)
            {
                _stringBuilder[right] = '*';
                ++right;
                Console.WriteLine(_stringBuilder);
            }
        }
    }
}
