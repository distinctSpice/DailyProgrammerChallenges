using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulLibraries.Collections;

namespace TriangularNumbers.Implementation
{
    public static class GaussSummation
    {
        public static int GaussSum(this int ceiling)
        {
            return ceiling
                .TriangleNumbers()
                .RepeatingCombinations(3)
                .Count(rc => rc.Sum() == ceiling);
        }

        public static List<int> TriangleNumbers(this int ceiling)
        {
            return Enumerable.Range(0, ceiling - 1).Where(n =>
            {
                // Check if n is triangular
                var perfectSquareAttempt = Math.Sqrt((8 * n) + 1);
                return Math.Floor(perfectSquareAttempt) == perfectSquareAttempt;
            }).ToList();
        }
    }
}
