using GoldbachsWeakConjecture.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldbachsWeakConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(string.Join(" ", number.GoldbachsWeakNumbers() ?? new List<int>()));
            }
            //Console.ReadLine();
        }
    }
}
