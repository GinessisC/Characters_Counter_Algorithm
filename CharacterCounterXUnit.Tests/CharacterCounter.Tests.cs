using CharacterCounterXUnit.Tests;
using CharactersCounter;

namespace CharacterCounter.Tests;

public class CharacterCounterTests
{
    

    private string GetActualResult(string stringToTest)
    {
        CharactersCounter.CharactersCounter charactersCounter = new(stringToTest);
        var charCount = charactersCounter.CountCharacters();
        return charCount.ToInfoString<char, int>();
    }
    [Fact]
    public void Theory()
    {
        void CountCharacters_DublicateCharCounting_DublicateChar() //for string with dublicate chars 
        {
            string actualWithDublicates = GetActualResult(InlineTestData.StrToTestWithDublicates);
            Assert.Equal(InlineTestData.ExpectedWithDublicates, actualWithDublicates);
        }
        void CountCharacters_NoDublicateCharCounting_NoDublicateChar() //for string without dublicate chars
        {
            var actualWithoutDublicates = GetActualResult(InlineTestData.StrToTestWithoutDublicates);
            Assert.Equal(InlineTestData.ExpectedWithoutDublicates, actualWithoutDublicates);

        }
        void CountCharacters_StrWithOtherCharsCharCounting_NoNumbers() //for string with numbers
        {
            string actualStrWithOtherChars = GetActualResult(InlineTestData.StrToTestWithOtherChars);
            Assert.Equal(InlineTestData.ExpectedWithOtherChars, actualStrWithOtherChars);
        }

        CountCharacters_DublicateCharCounting_DublicateChar();
        CountCharacters_NoDublicateCharCounting_NoDublicateChar();
        CountCharacters_StrWithOtherCharsCharCounting_NoNumbers();
    }
    
    
}