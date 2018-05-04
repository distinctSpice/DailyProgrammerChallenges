using AlphabetCipher.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCipher.Tests
{
    [TestClass]
    public class AlphabetCipherTests
    {
        [TestMethod]
        public void ChallengeInputOne_Success()
        {
            const string key = "bond";
            const string rawString = "theredfoxtrotsquietlyatmidnight";
            const string expectedResult = "uvrufrsryherugdxjsgozogpjralhvg";

            var result = Challenge.EncodeString(key, rawString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ChallengeInputTwo_Success()
        {
            const string key = "train";
            const string rawString = "murderontheorientexpress";
            const string expectedResult = "flrlrkfnbuxfrqrgkefckvsa";

            var result = Challenge.EncodeString(key, rawString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ChallengeInputThree_Success()
        {
            const string key = "garden";
            const string rawString = "themolessnuckintothegardenlastnight";
            const string expectedResult = "zhvpsyksjqypqiewsgnexdvqkncdwgtixkx";

            var result = Challenge.EncodeString(key, rawString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BonusInputOne_Success()
        {
            const string key = "cloak";
            const string encodedString = "klatrgafedvtssdwywcyty";
            const string expectedResult = "iamtheprettiestunicorn";

            var result = Challenge.DecodeString(key, encodedString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BonusInputTwo_Success()
        {
            const string key = "python";
            const string encodedString = "pjphmfamhrcaifxifvvfmzwqtmyswst";
            const string expectedResult = "alwayslookonthebrightsideoflife";

            var result = Challenge.DecodeString(key, encodedString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BonusInputThree_Success()
        {
            const string key = "moore";
            const string encodedString = "rcfpsgfspiecbcc";
            const string expectedResult = "foryoureyesonly";

            var result = Challenge.DecodeString(key, encodedString);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
