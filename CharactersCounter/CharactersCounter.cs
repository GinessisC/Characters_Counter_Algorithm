using System.Collections.Generic;

namespace CharactersCounter
{
    public class CharactersCounter
    {
        private string _stringToEnter;
        public CharactersCounter(string stringToEnter)
        {
            _stringToEnter = stringToEnter;
        }

        
        private List<char> GetCharArrayOfLetters(List<char> charListToSort) =>
            charListToSort.Where(c => char.IsLetter(c)).ToList();

        private string RemoveDublicates(string stringToSort)
        {
            string NoDublicates = string.Empty;
            var noDublicatesList = stringToSort.Split(", ")
                .Where(letterAndSumPair => !letterAndSumPair.Contains("0")).ToList();

            foreach (var item in noDublicatesList)
            {
                NoDublicates += $"{item}, ";
            }
            return NoDublicates.Remove(NoDublicates.Length - 4);
        }
            

        public string CountCharacters()
        {
            string charactersCountResultString = string.Empty;
            var charsOfInputString = GetCharArrayOfLetters(_stringToEnter.ToList<char>()); //Casting to list for more func-s

            for (int i = 0; i < charsOfInputString.Count; i++)
            {
                int count = 0;
                char currentChar = charsOfInputString[i];

                for (int j = 0; j < charsOfInputString.Count; j++)
                {
                    var readyCharToHandle = char.ToLower(charsOfInputString[j]);

                    if (char.ToLower(currentChar) == readyCharToHandle && !charactersCountResultString.Contains(char.ToLower(readyCharToHandle)))
                    {
                        count++;
                    }
                }

                charactersCountResultString += $"{char.ToLower(currentChar)}:{count}, ";
            }
            var sortedString = RemoveDublicates(charactersCountResultString);
            return sortedString;
        }
    }
}
