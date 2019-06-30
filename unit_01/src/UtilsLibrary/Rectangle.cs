using System.Numerics;

namespace UtilsLibrary
{
    public class Rectangle
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public BigInteger Area => Width * Height;
    }
}
