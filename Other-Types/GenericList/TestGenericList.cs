using System;

class TestGenericList
{
    static void Main()
    {
        var list = new GenericList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(3);
        Console.WriteLine(list);

        list[4] = 5;
        Console.WriteLine(list);

        list.Add(-5);
        Console.WriteLine(list);

        Console.WriteLine("list[2] = " + list[2]);
        Console.WriteLine();

        list.RemoveByIndex(list.Count - 1);
        Console.WriteLine(list);
        Console.WriteLine();

        list.Insert(list.Count, 0);
        Console.WriteLine(list);
        Console.WriteLine();

        Console.WriteLine(list.GetIndexByValue(5));
        Console.WriteLine(list.IsContain(5));

        Console.WriteLine("Max = " + list.Max());
        Console.WriteLine("Min = " + list.Min());
        Console.WriteLine();

        list.RemoveAll();
        Console.WriteLine("Empty list" + list);

        Type type = typeof(GenericList<>);
        object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
        Console.WriteLine("GenericsList's version is {0}", ((VersionAttribute)allAttributes[0]).Version);



    }
}

