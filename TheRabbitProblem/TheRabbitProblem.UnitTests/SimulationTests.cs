using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRabbitProblem.Implementation;

namespace TheRabbitProblem.UnitTests
{
    [TestClass]
    public class SimulationTests
    {
        [TestMethod]
        public void SimulationTest_Success()
        {
            var simulation = new RabbitSimulation(2, 4, 200);
            var result = simulation.Begin();

            var aliveCount = result.Item1;
            var deadCount = result.Item2;
            var months = result.Item3;


            //Assert.IsTrue(result > 0);
        }

    }
}
