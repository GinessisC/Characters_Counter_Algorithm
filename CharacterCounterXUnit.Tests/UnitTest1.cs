using CharactersCounter;
using Xunit;
namespace CharacterCounterXUnit.Tests
{
    public class UnitTest1
    {
        private const string StrToTestWithoutDublicates = "abcd efgh";
        private const string ExpectedWithoutDublicates = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, h:1";

        private const string StrToTestWithDublicates = "Test";
        private const string ExpectedWithDublicates = "t:2, e:1, s:1";

        private const string StrToTestWithOtherChars = "a1bcd efgth";
        private const string ExpectedWithOtherChars = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, t:1, h:1";

        private string GetActualResult(string stringToTest)
        {
            CharactersCounterExecuter charactersCounter = new(stringToTest);
            return charactersCounter.CountCharactersString();
        }

        [Fact]
        public void CountCharacters_DublicateCharCounting_DublicateChar() //for string with dublicate chars 
        {

            string actualWithDublicates = GetActualResult(StrToTestWithDublicates);
            Assert.Equal(ExpectedWithDublicates, actualWithDublicates);
        }
        [Fact]
        public void CountCharacters_NoDublicateCharCounting_NoDublicateChar() //for string without dublicate chars
        {
            var actualWithoutDublicates = GetActualResult(StrToTestWithoutDublicates);
            Assert.Equal(ExpectedWithoutDublicates, actualWithoutDublicates);

        }
        [Fact]
        public void CountCharacters_StrWithOtherCharsCharCounting_NoNumbers() //for string with numbers
        {
            string actualStrWithOtherChars = GetActualResult(StrToTestWithOtherChars);
            Assert.Equal(ExpectedWithOtherChars, actualStrWithOtherChars);
        }
    }
}