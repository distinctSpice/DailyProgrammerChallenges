using AlphabetCipher.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCipher
{
    class Program
    {
        // Challenge
        // https://www.reddit.com/r/dailyprogrammer/comments/879u8b/20180326_challenge_355_easy_alphabet_cipher/?st=jg1s6pwa&sh=4160f12b

        private const string _expectedResult = "lumicjcnoxjhkomxpkwyqogywq";
        private const string _key = "snitch";
        private const string _rawString = "thepackagehasbeendelivered";

        static void Main(string[] args)
        {
            var result = Challenge.EncodeString(_key, _rawString);
            Console.WriteLine("{0} {1}", _key, _rawString);
            Console.WriteLine("--------------");
            Console.WriteLine(result);
            Console.WriteLine(result == _expectedResult);
            Console.ReadLine();
        }
    }
}
