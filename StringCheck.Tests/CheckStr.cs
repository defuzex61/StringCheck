using System;
using System.Linq;

namespace StringCheck
{
    internal class CheckStr
    {
        public static string FindShortestWord(string inputWord)
        {
            string[] inputWords = inputWord.Split(' ');
            return inputWords.OrderBy(word => word.Length).FirstOrDefault();
        }

        public static int CountWords(string inputString)
        {
            string[] strings = inputString.Split(' ');
            return strings.Length;
        }

        public static int CountChars(string inputString)
        {
            return inputString.Length;
        }

        public static char Find11thChar(string inputString)
        {
            return Convert.ToChar(inputString[11]);
        }

        public static int CountDigits(string inputString)
        {
            return inputString.Count(char.IsDigit);
        }

        public static int MaxConsecutiveNumbers(string inputString)
        {
            int maxConsecutiveCount = 0;
            int currentConsecutiveCount = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                {
                    currentConsecutiveCount++;
                    if (currentConsecutiveCount > maxConsecutiveCount)
                    {
                        maxConsecutiveCount = currentConsecutiveCount;
                    }
                }
                else
                {
                    currentConsecutiveCount = 0;
                }
            }

            return maxConsecutiveCount;
        }

        public static string CountAmCombinations(string inputString)
        {
            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a' && inputString[i+1]=='m')
                {
                    count++;
                }
            }
            
            return "0";
        }
    }
}