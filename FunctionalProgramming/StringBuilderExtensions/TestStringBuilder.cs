using System;
using System.Text;

class TestStringBuilder
{
    static void Main()
    {
        var str = new StringBuilder("Functional Programming");
        Console.WriteLine(str.Substring(0, 11));

        str = new StringBuilder("Functional funcTional Programming");
        Console.WriteLine(str.RemoveText("Functional"));
        Console.WriteLine(str.AppendAll(new string[]{" ", "one", " ", "two"}));
    }
}

