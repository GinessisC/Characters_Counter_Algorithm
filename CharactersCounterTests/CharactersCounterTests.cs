using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter.Tests
{
    [TestClass()]
    public class CharactersCounterTests
    {
        private const string strToTestWithoutDublicates = "abcd efgh";
        private const string expectedWithoutDublicates = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, h:1";

        private const string strToTestWithDublicates = "Test";
        private const string expectedWithDublicates = "t:2, e:1, s:1";

        private const string strToTestWithOtherChars = "a1bcd efgth";
        private const string expectedWithOtherChars = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, t:1, h:1";

        private string GetActualResult(string stringToTest)
        {
            CharactersCounter CharactersCounter = new(stringToTest);
            return CharactersCounter.CountCharacters();
        }

        [TestMethod()]
        public void CountCharacters_NoDublicateCharCounting_NoDublicateChar() //for string without dublicate chars
        {
            string actualWithoutDublicates = GetActualResult(strToTestWithoutDublicates);
            //CharactersCounter withoutDublicatesCharactersCounter = new(stringToTestWithoutDublicates);
            //var actualWithoutDublicates = withoutDublicatesCharactersCounter
            //    .CountCharacters();
            Assert.AreEqual(expectedWithoutDublicates, actualWithoutDublicates); 
        }
        [TestMethod()]
        public void CountCharacters_DublicateCharCounting_DublicateChar() //for string with dublicate chars 
        {
            
            string actualWithDublicates = GetActualResult(strToTestWithDublicates);
            Assert.AreEqual(expectedWithDublicates, actualWithDublicates); 
 
        }

        [TestMethod()]
        public void CountCharacters_StrWithOtherCharsCharCounting_NoNumbers() //for string with numbers
        {
            string actualStrWithOtherChars = GetActualResult(strToTestWithOtherChars);
            Assert.AreEqual(expectedWithOtherChars, actualStrWithOtherChars);  
        }
    }
}