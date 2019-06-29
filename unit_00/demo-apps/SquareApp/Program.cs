using ApplicationBase;
using Square;

namespace SquareApp
{
    /// <summary>
    /// Implements the plotter of squares.
    /// </summary>
    internal class Application : IntReader
    {
        protected override void Solve()
        {
            new Plotter().PlotSquare(Value);
        }
    }

    /// <summary>
    /// Defines an entry point for the .NET Core CLI app.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the Application that plots a square.
        /// Square with a size of 1 is a whitespace.
        /// </summary>
        public static void Main()
        {
            new Application().Run();
        }
    }
}
