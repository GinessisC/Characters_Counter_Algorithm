using CharactersCounters;

Console.WriteLine("Enter your string: ");

string? userInput = Console.ReadLine();
CharactersCounter counter = new(userInput);

try
{
    var charCountInfo = counter.CountCharacters().ToInfoString();
    Console.WriteLine(charCountInfo);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


