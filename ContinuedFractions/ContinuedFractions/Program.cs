using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContinuedFractions.Implementation;

namespace ContinuedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();

                    if (input.Contains("/"))
                    {
                        Console.WriteLine("[{0};{1}]",
                            input.GaussNotation().First(),
                            string.Join(",", input.GaussNotation().Skip(1)));
                    }
                    else
                    {
                        Console.WriteLine("{0}/{1}",
                            input.Fraction().First(),
                            input.Fraction().Last());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.ReadKey();
                }
            }
        }
    }
}
