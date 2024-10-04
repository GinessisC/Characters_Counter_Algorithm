using System.Collections.Generic;
using System.Linq;

namespace CharactersCounter;

public class CharactersCounter
{
    private readonly string _stringToEnter;

    private readonly short _newCharCount = 1;
    private readonly string _separator = ", ";
    private readonly int _amountOfNullString = 0;

    public CharactersCounter(string stringToEnter)
    {
        _stringToEnter = stringToEnter;
    }

    
    public virtual IDictionary<char, int> CountCharacters()
    {
        Dictionary<char, int> charCountkeyValuePairs = new Dictionary<char, int>() { };

        if (!string.IsNullOrEmpty(_stringToEnter))
        {
            var charsInInputString = _stringToEnter.ToList();
            var lettersOnlyInInputString = charsInInputString.GetCharArrayOfLetters<char>();

            for (int i = 0; i < lettersOnlyInInputString.Count; i++)
            {
                char currentChar = char.ToLower(lettersOnlyInInputString[i]);

                if (charCountkeyValuePairs.ContainsKey(currentChar))
                {
                    charCountkeyValuePairs[currentChar] += 1;
                }
                else
                {
                    charCountkeyValuePairs.Add(currentChar, _newCharCount);
                }
            }

        }
        else
        {
            charCountkeyValuePairs.Add('0', _amountOfNullString);
        }
        return charCountkeyValuePairs;

    }
}
