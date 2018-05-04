using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangularNumbers.Implementation;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Convert.ToInt32(Console.ReadLine()).GaussSum());
            }
        }
    }
}
