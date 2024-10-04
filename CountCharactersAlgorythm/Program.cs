//CharactersCounter counter = new("Hello world!");
//Console.WriteLine(counter.CountCharactersString());
using CharactersCounter;

Console.WriteLine("Enter your string: ");
string? userInput = Console.ReadLine();
CharactersCounter.CharactersCounter counter = new(userInput);

Console.WriteLine(counter.CountCharacters().ToInfoString());
