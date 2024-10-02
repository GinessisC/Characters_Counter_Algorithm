using System.Collections.Generic;
using System.Linq;

namespace CharactersCounter
{
    public class CharactersCounter
    {
        private readonly string _stringToEnter;

        private readonly string _separator = ", ";
        private readonly int _zeroCountOfCharsInStr = 0;
        private readonly int _countOfExtraEndingInTheString = 2;


        public CharactersCounter(string stringToEnter)
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

        public virtual IEnumerable<KeyValuePair<char, int>> CountCharacters()
        {
            Dictionary<char, int> charCountkeyValuePairs = new Dictionary<char, int>() { };

            var charsOfInputString = GetCharArrayOfLetters(_stringToEnter.ToList<char>()); //Casting to list for more func-s

            for (int i = 0; i < charsOfInputString.Count; i++)
            {
                int count = 0;
                char currentChar = charsOfInputString[i];

                for (int j = 0; j < charsOfInputString.Count; j++)
                {
                    var readyCharToHandle = char.ToLower(charsOfInputString[j]);

                    if (char.ToLower(currentChar) == readyCharToHandle && !charCountkeyValuePairs
                        .ContainsKey(char.ToLower(readyCharToHandle)))
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
}
