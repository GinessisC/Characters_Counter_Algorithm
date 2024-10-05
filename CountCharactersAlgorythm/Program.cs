using CharactersCounters;

Console.WriteLine("Enter your string: ");

string? userInput = Console.ReadLine();

try
{
    CharactersCounter counter = new(userInput);
    var charCountInfo = counter.CountCharacters().ToInfoString();
    Console.WriteLine(charCountInfo);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


