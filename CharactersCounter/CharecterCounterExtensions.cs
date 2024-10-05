using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounters;


public static class CharecterCounterExtensions
{
    private static int _countOfExtraEndingInTheString = 2;

    public static string ToInfoString<T, T1>(this IDictionary<T, T1> keyValuePairs)
    {
        string result = string.Empty;
        
        foreach (var keyValuePair in keyValuePairs)
        {
            result += $"{keyValuePair.Key}:{keyValuePair.Value}, ";
        }

        return result.Remove(result.Length - _countOfExtraEndingInTheString);
    }
}
