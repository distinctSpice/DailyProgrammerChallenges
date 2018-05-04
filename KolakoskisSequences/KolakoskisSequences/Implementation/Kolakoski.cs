using System.Collections.Generic;

namespace KolakoskisSequences.Implementation
{
    public static class Kolakoski
    {
        public static List<int> GenerateSequence(int index)
        {
            var sequence = new List<int>() { 1, 2, 2 };
            var counter = 3;

            while (sequence.Count < index)
            {
                var i = sequence[counter - 1];

                if (counter % 2 == 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sequence.Add(2);
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        sequence.Add(1);
                    }
                }
                counter++;
            }
            return sequence;
        }
    }
}
