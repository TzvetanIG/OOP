using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Extensions
{
    public static string Substring(this StringBuilder str, int startIndex, int length)
    {
        string strAsString = str.ToString();
        string substring = strAsString.Substring(startIndex, length);
        return substring;
    }

    public static StringBuilder RemoveText(this StringBuilder str, string text)
    {
        var lenght = text.Length;
        var strAsString = str.ToString();

        while (true)
        {
            var textPosition = strAsString.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);

            if (textPosition < 0)
            {
                break;
            }

            strAsString = strAsString.Remove(textPosition, lenght);
        }

        return str =  new StringBuilder(strAsString);
    }

    public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
    {
        var resultString = items.Aggregate("", (current, item) => current + item.ToString());
        return str.Append(resultString);
    }
}

