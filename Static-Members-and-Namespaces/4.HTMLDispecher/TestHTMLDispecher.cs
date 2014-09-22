using System;

class TestHTMLDispecher
{
    static void Main()
    {
        ElementBuilder a = new ElementBuilder("a");
        a.AddAtribute("href", "#");
        a.AddAtribute("class", "link");
        a.AddContent("abv.bg");
        //a.CloseSelf(true);
        Console.WriteLine(a);
        Console.WriteLine(a*2);
        Console.WriteLine();

        Console.WriteLine(HTMLDispecher.CreateImage("image1.jpg", "test image", "test image"));
        Console.WriteLine(HTMLDispecher.CreateInput("submit", "submit", "Submit"));
        Console.WriteLine(HTMLDispecher.CreateURL("http://www.w3schools.com", "www.w3schools.com", "w3schools.com"));
    }


}

