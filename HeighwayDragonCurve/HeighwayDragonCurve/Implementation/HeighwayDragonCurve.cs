using System;
using System.Linq;

namespace HeighwayDragonCurve.Implementation
{
    public static class HeighwayDragonCurve
    {
        public static string GetSequenceByCycle(int cycles)
        {
            var currentSequence = "1";
            for (int i = 0; i < cycles; i++)
            {
                currentSequence += "1" + Flip(currentSequence);
            }
            return currentSequence;
        }

        private static string Flip(string sequence)
        {
            var flippedSequence = string.Empty;
            foreach (var bit in sequence.Reverse())
            {
                var flippedBit = 1 - Convert.ToInt32(bit.ToString());
                flippedSequence += flippedBit.ToString();
            }
            return flippedSequence;
        }
    }
}
