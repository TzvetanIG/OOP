using System;

public static class HTMLDispecher
{
    public static string CreateImage(string src, string alt, string title)
    {
        ElementBuilder img = new ElementBuilder("img");
        img.AddAtribute("src", src);
        img.AddAtribute("alt", alt);
        img.AddAtribute("title", title);
        img.CloseSelf(true);
        return img.ToString();
    }

    public static string CreateURL(string url, string title, string text)
    {
        ElementBuilder a = new ElementBuilder("a");
        a.AddAtribute("href", url);
        a.AddAtribute("title", title);
        a.AddContent(text);
        return a.ToString();
    }

    public static string CreateInput(string type, string name, string value)
    {
        ElementBuilder a = new ElementBuilder("a");
        a.AddAtribute("type", type);
        a.AddAtribute("name", name);
        a.AddAtribute("value", value);
        return a.ToString();
    }
}

