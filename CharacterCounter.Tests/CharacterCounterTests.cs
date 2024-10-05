using CharactersCounters;

namespace CharacterCounter.Tests;

public class CharacterCounterTests
{
    [Theory]
    [InlineData("abcd efgh", "a:1, b:1, c:1, d:1, e:1, f:1, g:1, h:1")]
    [InlineData("Test", "t:2, e:1, s:1")]
    [InlineData("a1bcd efgth", "a:1, b:1, c:1, d:1, e:1, f:1, g:1, t:1, h:1")]
    public void CountChars_StringInput_ReturnStringAboutCountedChars(string inputString, string expected)
    {
        string actualStringValue = GetActualResult(inputString);
        Assert.Equal(expected, actualStringValue);
    }

    private string GetActualResult(string stringToTest)
    {
        CharactersCounter charactersCounter = new(stringToTest);
        var charCount = charactersCounter.CountCharacters();
        return charCount.ToInfoString<char, int>();
    }
}