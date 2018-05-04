using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ContinuedFractions.Implementation
{
    public static class ContinuedFraction
    {
        public static List<int> GaussNotation(this string input)
        {
            var numerator = GetFraction(input).First();
            var denominator = GetFraction(input).Last();
            var finishDecomposing = false;
            var gaussNotation = new List<int>();

            while (!finishDecomposing && denominator > 0)
            {
                var quotientFloor = Math.Floor(numerator / denominator);
                var newDenominator = numerator % denominator;

                numerator = denominator;
                denominator = newDenominator;

                gaussNotation.Add((int)quotientFloor);

                if (denominator == 1)
                {
                    gaussNotation.Add((int)numerator);
                    finishDecomposing = true;
                }
            }
            return gaussNotation;
        }

        public static List<int> Fraction(this string input)
        {
            var digits = GetGaussNotations(input);
            decimal denominator = 0, numerator = 0;
            var fraction = new List<int>();

            for (int i = 1; i < digits.Count; i++)
            {
                if (i == 1)
                {
                    numerator = (digits[i - 1] * digits[i]) + 1;
                    denominator = digits[i - 1];
                }
                else
                {
                    var oldNumerator = numerator;
                    numerator = (numerator * digits[i]) + denominator;
                    denominator = oldNumerator;
                }
            }

            return new List<int>() { (int)numerator, (int)denominator };
        }

        private static List<decimal> GetFraction(string input)
        {
            return input
                .Split('/')
                .Select(Convert.ToDecimal)
                .ToList();
        }

        private static List<decimal> GetGaussNotations(string input)
        {
            return input
                .Substring(1, input.Length - 2)
                .Split(new char[] { ';', ',' })
                .Select(Convert.ToDecimal)
                .Reverse()
                .ToList();
        }

        public static bool CheckIfFraction(string input)
        {
            return new Regex(@"[1-9][0-9]*\/[1-9][0-9]*")
                .Match(input)
                .Success;
        }
    }
}
