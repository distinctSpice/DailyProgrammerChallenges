using PieCreation.Implementation;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console
                .ReadLine()
                .Split(',')
                .Select(c => Convert.ToInt32(c))
                .ToList();

            var report = Pie.SolveUsingMicrosoftSolver(
                new Pie.Ingredients() {
                    ScoopsOfSyntheticPumpkinFlavouring = ingredients[0],
                    Apples = ingredients[1],
                    Eggs = ingredients[2],
                    CupsOfMilk = ingredients[3],
                    CupsOfSugar = ingredients[4]
                });

            Console.Write("{0}", report);
            Console.ReadKey();
        }
    }
}
