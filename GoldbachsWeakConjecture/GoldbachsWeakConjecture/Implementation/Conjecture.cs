using System;
using System.Collections.Generic;
using System.Linq;
using UsefulLibraries.Collections;

namespace GoldbachsWeakConjecture.Implementation
{
    public static class Conjecture
    {
        public static IEnumerable<int> GoldbachsWeakNumbers(this int input)
        {
            if (input % 2 == 0) return null;

            return input
                .Primes()
                .RepeatingCombinations(3)
                .First(c => c.Sum() == input)
                .ToList();
        }

        private static List<int> Primes(this int ceiling)
        {
            return Enumerable
                .Range(2, ceiling - 2)
                .AsParallel()
                .Where(k => Enumerable
                    .Range(2, (int)Math.Sqrt(k))
                    .All(j => k % j != 0))
                .ToList();
        }
    }
}
