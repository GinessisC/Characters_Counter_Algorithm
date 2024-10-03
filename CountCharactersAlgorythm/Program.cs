using CharactersCounter;

public class YourClass
{

    public static void Main(string[] args)
    {
        CharactersCounterExecuter counter = new("Hello world!");
        Console.WriteLine(counter.CountCharactersString());
    }

}