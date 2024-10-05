namespace CharactersCounters;

public class CharactersCounter
{
    private readonly string _stringToEnter;
    
    private const int _newCharCount = 1;
    private const int _amountOfNullString = 0;

    public CharactersCounter(string stringToEnter)
    {
        _stringToEnter = stringToEnter;
    }
    
    public virtual IDictionary<char, int> CountCharacters()
    {
        Dictionary<char, int> charsToCountInString = new Dictionary<char, int>();

        ArgumentException.ThrowIfNullOrEmpty("String can't be empty!"); 

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
                charsToCountInString.Add(currentChar, _newCharCount);
            }
        }
        return charsToCountInString;
    }
}
