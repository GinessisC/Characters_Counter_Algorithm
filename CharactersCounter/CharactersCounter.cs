using System.Collections.Generic;
using System.Linq;

namespace CharactersCounters;

public class CharactersCounter
{
    private readonly string _stringToEnter;
    
    private readonly short _newCharCount = 1;
    private readonly int _amountOfNullString = 0;

    public CharactersCounter(string stringToEnter)
    {
        _stringToEnter = stringToEnter;
    }
    
    public virtual IDictionary<char, int> CountCharacters()
    {
        Dictionary<char, int> charsToCountInString = new Dictionary<char, int>() { };

        if (string.IsNullOrEmpty(_stringToEnter) is false)
        {
            for (int i = 0; i < _stringToEnter.Length; i++)
            {
                char currentChar = char.ToLower(_stringToEnter[i]);

                if (char.IsLetter(currentChar))
                {
                    if (charsToCountInString.ContainsKey(currentChar))
                    {
                        charsToCountInString[currentChar]++;
                    }
                    else
                    {
                        charsToCountInString.Add(currentChar, _newCharCount);
                    }
                }
            }
        }
        else
        {
            throw new NullReferenceException("String can't be empty!");
        }
        return charsToCountInString;

    }
}
