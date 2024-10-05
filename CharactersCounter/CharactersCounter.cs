namespace CharactersCounters;

public class CharactersCounter
{
    private readonly string? _stringToEnter;
    
    private const int NewCharCount = 1;

    public CharactersCounter(string? stringToEnter)
    {
        ArgumentException.ThrowIfNullOrEmpty(_stringToEnter);
        _stringToEnter = stringToEnter;
    }
    
    public virtual IDictionary<char, int> CountCharacters()
    {
        Dictionary<char, int> charsToCountInString = new Dictionary<char, int>();

        for (int i = 0; i < _stringToEnter.Length; i++)
        {
            char currentChar = char.ToLower(_stringToEnter[i]);
            if (char.IsLetter(currentChar) is false)
            {
                continue;
            }

            if (charsToCountInString.ContainsKey(currentChar))
            {
                charsToCountInString[currentChar]++;
            }
            else
            {
                charsToCountInString.Add(currentChar, NewCharCount);
            }
        }
        return charsToCountInString;
    }
}