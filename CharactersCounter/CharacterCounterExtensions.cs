using System.Text;

namespace CharactersCounters;
public static class CharacterCounterExtensions
{
    private const int _countOfExtraEndingInTheString = 2;

    public static string ToInfoString(this IDictionary<char, int> keyValuePairs)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var keyValuePair in keyValuePairs)
        {
            sb.Append($"{keyValuePair.Key}:{keyValuePair.Value}, ");
        }
        string strResult = sb.ToString();
        return strResult.Remove(strResult.Length - _countOfExtraEndingInTheString);
    }
}
