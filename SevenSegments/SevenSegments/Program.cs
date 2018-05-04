using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenSegments.Implementation;

namespace SevenSegments
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleInput = new string[3, 27] {
                { " ", " ", " ", " ", "_", " ", " ", "_", " ", " ", " ", " ", " ", "_", " ", " ", "_", " ", " ", "_", " ", " ", "_", " ", " ", "_", " "},
                { " ", " ", "|", " ", "_", "|", " ", "_", "|", "|", "_", "|", "|", "_", " ", "|", "_", " ", " ", " ", "|", "|", "_", "|", "|", "_", "|"},
                { " ", " ", "|", "|", "_", " ", " ", "_", "|", " ", " ", "|", " ", "_", "|", "|", "_", "|", " ", " ", "|", "|", "_", "|", " ", " ", "|"}
            };
            
            var result = Implementation.SevenSegments.Solve(sampleInput);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();
        }
    }
}
