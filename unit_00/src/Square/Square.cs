using System;
using System.Text;

namespace Square
{
    /// <summary>Provides functionality to create square with a space in center via StringBuilder.</summary>
    public class Plotter
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder("", 255);

        /// <summary>Creates string that holds a square with a space in center.</summary>
        /// <param name="sideSize">Size of the square's side.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="sideSize">sideSize</paramref> is less than or equal to zero or even.</exception>
        public string MakeSquare(int sideSize)
        {
            if (sideSize <= 0 || sideSize % 2 == 0)
            {
                throw new ArgumentException($"Invalid value of sideSize = {sideSize}.", nameof(sideSize));
            }

            if (sideSize == 1)
            {
                return " ";
            }

            _stringBuilder.Clear();

            AppendLines(sideSize);

            _stringBuilder[GetCenterIndex(sideSize)] = ' ';

            return _stringBuilder.ToString();
        }

        private static int GetCenterIndex(int sideSize)
        {
            var half = sideSize / 2;
            return sideSize * (half + 1) + (half - 1);
        }

        private void AppendLines(int count)
        {
            for (var i = 0; i < count; ++i)
            {
                _stringBuilder.Append('*', count);
                _stringBuilder.AppendLine();
            }
        }

        /// <summary>Outputs square with size<paramref name="sideSize">sideSize</paramref> and space in center to console.</summary>
        /// <param name="sideSize">Size of the square's side.</param>
        public void PlotSquare(int sideSize)
        {
            try
            {
                Console.Write(MakeSquare(sideSize));
            }
            catch (Exception ex)
            {
                Console.Write($"Unable to create square due to: {ex.Message}");
            }
        }
    }
}
