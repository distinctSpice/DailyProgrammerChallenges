using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace HeighwayDragonCurveTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetSequence_8thIteration()
        {
            try
            {
                var impl = HeighwayDragonCurve.Implementation.HeighwayDragonCurve.GetSequenceByCycle(8);
                const string expectedResult = "110110011100100111011000110010011101100111001000110110001100100111011001110010"
                                            + "011101100011001000110110011100100011011000110010011101100111001001110110001100"
                                            + "100111011001110010001101100011001000110110011100100111011000110010001101100111"
                                            + "001000110110001100100111011001110010011101100011001001110110011100100011011000"
                                            + "110010011101100111001001110110001100100011011001110010001101100011001000110110"
                                            + "011100100111011000110010011101100111001000110110001100100011011001110010011101"
                                            + "1000110010001101100111001000110110001100100";

                Assert.AreEqual(impl, expectedResult);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
