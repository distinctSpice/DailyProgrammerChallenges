using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolakoskisSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var sequence = Implementation.Kolakoski.GenerateSequence(number);

            //Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine("{0}:{1}", sequence.Count(d => d == 1), sequence.Count(d => d == 2));
            Console.ReadKey();
        }
    }
}
