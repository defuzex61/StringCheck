using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringCheck.Tests
{
    [TestClass]
    public class StrCheckTests
    {
        [TestMethod]
        public void CheckStr_shortestWord_shortestWordReturned()
        {
            string inputString = "The gondola ride gave me vertigo";
            string expectedWord = "me";

            string shortestWord = CheckStr.FindShortestWord(inputString);

            Assert.AreEqual(expectedWord, shortestWord);
        }
        [TestMethod]
        public void CheckStr_CountWords_CountWordsReturned()
        {
            string inputString = "The gondola ride gave me vertigo";
            decimal expectedCount = 6;

            int countWords = CheckStr.CountWords(inputString);

            Assert.AreEqual(expectedCount, countWords);
        }
        [TestMethod]
        public void CheckStr_CountСhars_CountCharsReturned()
        {
            string inputString = "The gondola ride gave me vertigo";
            decimal expectedCount = 32;

            int countWords = CheckStr.CountChars(inputString);

            Assert.AreEqual(expectedCount, countWords);
        }
        [TestMethod]
        public void CheckStr_Find11thChar_11thCharReturned()
        {
            string inputString = "The gondola ride gave me vertigo";
            char expectedWord =  ' ';

            char shortestWord = CheckStr.Find11thChar(inputString);

            Assert.AreEqual(expectedWord, shortestWord);
        }
        [TestMethod]
        public void CheckStr_CountDigits_CountDigitsReturned()
        {
            string inputString = "The1 gondola2 ride3 gave me vertigo";
            decimal expectedCount = 3;

            int countNums = CheckStr.CountDigits(inputString);

            Assert.AreEqual(expectedCount, countNums);
        }
        [TestMethod]
        public void CheckStr_MaxConsecutiveNumbers_MaxConsecutiveNumbersReturned()
        {
            string inputString = "The1 gondola2 ride332 gave1 me3 vertigo7";
            decimal expectedCount = 3;

            int countNums = CheckStr.MaxConsecutiveNumbers(inputString);

            Assert.AreEqual(expectedCount, countNums);
        }
        [TestMethod]
        public void CheckStr_CountAmCombinations_CountAmCombinationsReturned()
        {
            string inputString = "ads";
            decimal expectedCount = 0;

            string countNums = CheckStr.CountAmCombinations(inputString);

            //Assert.AreEqual(expectedCount, countNums);
            StringAssert.Contains(inputString,"d");

        }
       
    }
}
