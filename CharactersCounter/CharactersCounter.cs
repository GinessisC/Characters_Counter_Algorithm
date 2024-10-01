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

        //TODO: 
        //0. Create all the requirements.
        //
        //1. Remove all chars that are not letters from string
        //2. Casting all the characters to lowercase
        //3. Once we got row str to handle, we 
        //4. Start the algorithm: ...
        //  take str and do .ToCharArray() 
        //  look through entire char array using for-cycle
        //  create a counter and store one char in varuable
        //  start inner for-cycle to look for the same chars
        //  add the results: letter:count,(backspace)
        //  remove all chars in case if they are equal. if u don`t have same chars - remove that one char from char array
        //  repeat the cycle
        
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
                //var charsForInnerChecking = charsOfInputString;
                int count = 0;
                char currentChar = charsOfInputString[i];

                for (int j = 0; j < charsOfInputString.Count; j++)
                {
                    var readyCharToHandle = char.ToLower(charsOfInputString[j]);

                    if (char.ToLower(currentChar) == readyCharToHandle && !charactersCountResultString.Contains(char.ToLower(readyCharToHandle)))
                    {
                        count++;
                        //charsOfInputString.Remove(readyCharToHandle);

                    }
                }

                charactersCountResultString += $"{char.ToLower(currentChar)}:{count}, ";
            }
            var sortedString = RemoveDublicates(charactersCountResultString);
            return sortedString;
        }
    }
}
