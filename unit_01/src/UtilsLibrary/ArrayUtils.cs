using System;
using System.Linq;

namespace UtilsLibrary
{
    public class ArrayUtils
    {
        public static void Sort<T>(T[] values) where T : IComparable
        {
            Sort(values, 0, values.Length - 1);
        }

        private static void Sort<T>(T[] array, int lo, int hi) where T : IComparable
        {
            if (lo < hi)
            {
                int p = Partition(array, lo, hi);
                Sort(array, lo, p - 1);
                Sort(array, p + 1, hi);
            }
        }

        private static int Partition<T>(T[] values, int lo, int hi) where T : IComparable
        {
            T pivot = values[hi];
            int i = (lo - 1);

            for (int j = lo; j <= hi - 1; j++)
            {
                if (values[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(ref values[i], ref values[j]);
                }
            }
            Swap(ref values[i + 1], ref values[hi]);
            return (i + 1);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var c = a;
            a = b;
            b = c;
        }

        public static T FindMax<T>(T[] values) where T : IComparable
        {
            IsArrayValid(values);

            var max = values[0];
            foreach (var t in values.Skip(1))
            {
                if (max.CompareTo(t) < 0)
                {
                    max = t;
                }
            }

            return max;
        }

        public static T FindMin<T>(T[] values) where T : IComparable
        {
            IsArrayValid(values);

            var min = values[0];
            foreach (var t in values.Skip(1))
            {
                if (t.CompareTo(min) < 0)
                {
                    min = t;
                }
            }

            return min;
        }

        private static void IsArrayValid<T>(T[] values) where T : IComparable
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }
        }

        // TODO: Think of possible generic implementation of math operations.
        public static int SumNonNegativeValues(int[] values)
        {
            IsArrayValid(values);

            return values.Where(t => t >= 0).Sum();
        }

        public static void ReplacePositive3D(int[,,] values)
        {
            for (var x = 0; x < values.GetLength(0); ++x)
            {
                for (var y = 0; y < values.GetLength(1); ++y)
                {
                    for (var z = 0; z < values.GetLength(2); ++z)
                    {
                        if (values[x, y, z] > 0)
                        {
                            values[x, y, z] = 0;
                        }
                    }
                }
            }
        }

        public static int SumEventPositionValues(int[,] values)
        {
            var sum = 0;
            for (var x = 0; x < values.GetLength(0); ++x)
            {
                for (var y = 0; y < values.GetLength(1); ++y)
                {
                    if ((x + y) % 2 == 0)
                    {
                        sum += values[x, y];
                    }
                }
            }
            return sum;
        }
    }
}
