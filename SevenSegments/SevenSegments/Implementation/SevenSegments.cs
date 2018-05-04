using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegments.Implementation
{
    public static class SevenSegments
    {
        public static List<int> Solve(string[,] input)
        {
            var digits = new List<int>();
            foreach (var data in AssembleData(input))
            {
                var reorderedData = ReorderSegmentData(data);
                var digit = DetermineDigit(reorderedData);

                digits.Add(digit);
            }
            return digits;
        }

        public static List<string> AssembleData(string[,] unorderedInput)
        {
            var rowCount = unorderedInput.GetLength(0);
            var columnCount = unorderedInput.GetLength(1);
            var digitCount = columnCount / 3;
            var assembledData = new List<string>();

            for (var i = 1; i <= digitCount; i++)
            {
                var assembledDataSegment = new List<string>();
                var cursor = (i - 1) * 3;

                for (int j = cursor; j < cursor + 3; j++)
                {
                    for (int k = 0; k < rowCount; k++)
                    {
                        assembledDataSegment.Add(unorderedInput[k, j]);
                    }
                }
                assembledData.Add(string.Concat(assembledDataSegment));
            }
            return assembledData;
        }

        public static string[] ReorderSegmentData(string segmentData)
        {
            return new List<string>() {
                segmentData[3].ToString(),
                segmentData[7].ToString(),
                segmentData[8].ToString(),
                segmentData[5].ToString(),
                segmentData[2].ToString(),
                segmentData[1].ToString(),
                segmentData[4].ToString()
            }.ToArray();
        }

        public static int DetermineDigit(string[] segmentData)
        {
            //if (segmentData.Length != 27) throw new ArgumentException("Invalid digit data");

            var allSegmentData = GetAllDigitSegmentData();

            var virtualSegmentData = segmentData.Select(c => !string.IsNullOrWhiteSpace(c) ? (byte)1 : (byte)0).ToArray();
            var actualSegmentData = Array.Find(allSegmentData, array => array.SequenceEqual(virtualSegmentData));

            if (actualSegmentData != null)
            {
                return Array.FindIndex(allSegmentData, array => array.SequenceEqual(virtualSegmentData));
            }
            throw new ArgumentException("Input is not a valid digit");
        }

        /// <summary>
        /// Get segment data for all digits
        /// </summary>
        /// <returns></returns>
        private static byte[][] GetAllDigitSegmentData()
        {
            return new byte[][] {
                new byte[] { 1, 1, 1, 1, 1, 1, 0 }, // 0
                new byte[] { 0, 1, 1, 0, 0, 0, 0 }, // 1
                new byte[] { 1, 1, 0, 1, 1, 0, 1 }, // 2
                new byte[] { 1, 1, 1, 1, 0, 0, 1 }, // 3
                new byte[] { 0, 1, 1, 0, 0, 1, 1 }, // 4
                new byte[] { 1, 0, 1, 1, 0, 1, 1 }, // 5
                new byte[] { 1, 0, 1, 1, 1, 1, 1 }, // 6
                new byte[] { 1, 1, 1, 0, 0, 0, 0 }, // 7
                new byte[] { 1, 1, 1, 1, 1, 1, 1 }, // 8
                new byte[] { 1, 1, 1, 0, 0, 1, 1 }, // 9
            };
        }
    }
}
