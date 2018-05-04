using Microsoft.SolverFoundation.Services;
using System;

namespace PieCreation.Implementation
{
    public static class Pie
    {
        //Constraints
        //
        //Pumpkin pies >= 0, apple pies >= 0
        //Pumpkin pie = 1 synthetic pumpkin flavouring
        //Pumpkin pie = 3 eggs
        //Apple pie = 4 eggs
        //Apple pie = 1 apple
        //Pumpkin pie = 4 cups of milk
        //Apple pie = 3 cups of milk
        //Pumpkin pie = 3 cups of sugar
        //Apple pie = 2 cups of sugar

        public static Report SolveUsingMicrosoftSolver(Ingredients ingredients)
        {
            var solverContext = SolverContext.GetContext();
            var model = solverContext.CreateModel();

            var pumpkinPiesCount = new Decision(Domain.Integer, "pumpkin_pies");
            var applePiesCount = new Decision(Domain.Integer, "apple_pies");

            model.AddDecisions(pumpkinPiesCount, applePiesCount);

            model.AddConstraints("constraints",
                pumpkinPiesCount >= 0,
                applePiesCount >= 0,
                (1 * pumpkinPiesCount) + (0 * applePiesCount) <= ingredients.ScoopsOfSyntheticPumpkinFlavouring,
                (0 * pumpkinPiesCount) + (1 * applePiesCount) <= ingredients.Apples,
                (3 * pumpkinPiesCount) + (4 * applePiesCount) <= ingredients.Eggs,
                (4 * pumpkinPiesCount) + (3 * applePiesCount) <= ingredients.CupsOfMilk,
                (3 * pumpkinPiesCount) + (2 * applePiesCount) <= ingredients.CupsOfSugar);

            model.AddGoal("amount", GoalKind.Maximize, pumpkinPiesCount + applePiesCount);
            
            return solverContext
                .Solve(new SimplexDirective())
                .GetReport();
        }
        
        public class Ingredients
        {
            public int ScoopsOfSyntheticPumpkinFlavouring { get; set; }
            public int Apples { get; set; }
            public int Eggs { get; set; }
            public int CupsOfMilk { get; set; }
            public int CupsOfSugar { get; set; }
        }
    }
}
