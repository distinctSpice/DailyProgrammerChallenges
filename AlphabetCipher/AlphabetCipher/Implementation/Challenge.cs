using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCipher.Implementation
{
    public static class Challenge
    {
        private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string EncodeString(string rawKey, string rawString)
        {
            rawKey = rawKey.ToLower();
            rawString = rawString.ToLower();

            var key = CreateKey(rawKey, rawString.Length);
            var encodedString = string.Empty;

            for (var i = 0; i < rawString.Length; i++)
            {
                encodedString += EncodeChar(key[i], rawString[i]);
            }
            return encodedString;
        }

        public static string DecodeString(string rawKey, string encodedString)
        {
            rawKey = rawKey.ToLower();
            encodedString = encodedString.ToLower();

            var key = CreateKey(rawKey, encodedString.Length);
            var decodedString = string.Empty;

            for (var i = 0; i < encodedString.Length; i++)
            {
                decodedString += DecodeChar(key[i], encodedString[i]);
            }
            return decodedString;
        }

        private static string CreateKey(string value, int rawStringLength)
        {
            var key = string.Empty;

            while (key.Length < rawStringLength)
            {
                key += value;
            }
            return key.Substring(0, rawStringLength);
        }

        private static string EncodeChar(char charColumn, char charRow)
        {
            var colIndex = _alphabet.IndexOf(charColumn);
            var rowIndex = _alphabet.IndexOf(charRow);
            return RearrangeLetters(colIndex)[rowIndex].ToString();
        }

        private static string DecodeChar(char charColumn, char charRow)
        {
            var colIndex = _alphabet.IndexOf(charColumn);
            var rowIndex = RearrangeLetters(colIndex).IndexOf(charRow);
            return _alphabet[rowIndex].ToString();
        }

        private static string RearrangeLetters(int colIndex)
        {
            var initialList = _alphabet.Substring(0, colIndex);
            return _alphabet.Substring(colIndex, _alphabet.Length - colIndex) + initialList;
        }
    }
}
