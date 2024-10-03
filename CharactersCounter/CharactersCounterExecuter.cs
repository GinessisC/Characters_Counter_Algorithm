using System.Collections.Generic;
using System.Linq;

namespace CharactersCounter;

public class CharactersCounterExecuter
{
    private readonly string _stringToEnter;

    private readonly string _separator = ", ";
    private readonly int _countOfExtraEndingInTheString = 2;


    public CharactersCounterExecuter(string stringToEnter)
    {
        _stringToEnter = stringToEnter;
    }

    private List<char> GetCharArrayOfLetters(List<char> charListToSort)
    {
        return charListToSort.Where(c => char.IsLetter(c)).ToList();
    }
    
        
    public string CountCharactersString()
    {
        var charsCountsKeyValuePairs = CountCharacters();
        string charsCountResultString = string.Empty;

        foreach (var item in charsCountsKeyValuePairs)
        {
            charsCountResultString += $"{item.Key}:{item.Value}, ";
        }
        return charsCountResultString.Remove(charsCountResultString.Length - _countOfExtraEndingInTheString);
    }

    public virtual IDictionary<char, int> CountCharacters()
    {
        Dictionary<char, int> charCountkeyValuePairs = new Dictionary<char, int>() { };

        var charsOfInputString = GetCharArrayOfLetters(_stringToEnter.ToList<char>()); //Casting to list for more func-s

        for (int i = 0; i < charsOfInputString.Count; i++)
        {
            int count = 0;
            char currentChar = charsOfInputString[i];

            for (int j = 0; j < charsOfInputString.Count; j++)
            {
                var lowerCharToHandle = char.ToLower(charsOfInputString[j]);
                var isCharInDictionary = charCountkeyValuePairs.ContainsKey(lowerCharToHandle);

                if (char.ToLower(currentChar) == lowerCharToHandle && !isCharInDictionary)
                {
                    count++;
                }
            }
            if (!charCountkeyValuePairs.ContainsKey(currentChar))
            {
                charCountkeyValuePairs.Add(char.ToLower(currentChar), count);
            }
        }
        return charCountkeyValuePairs;
    }
}
