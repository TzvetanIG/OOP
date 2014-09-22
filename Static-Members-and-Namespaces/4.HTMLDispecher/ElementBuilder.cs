using System;
using System.Collections.Generic;

public class ElementBuilder
{
    private string name;
    private string content = "";
    private Dictionary<string, string> attributes = new Dictionary<string, string>();
    private bool isCloseSelf = false;

    public ElementBuilder(string name)
    {
        this.name = name;
    }


    public void AddAtribute(string nameAttribute, string valueAttribute)
    {
        this.attributes.Add(nameAttribute, valueAttribute);
    }


    public void AddContent(string content)
    {
        this.content = content;
    }


    public void CloseSelf(bool isCloseSelf)
    {
        this.isCloseSelf = isCloseSelf;
    }


    public override string ToString()
    {
        string attributesAsString = "";

        foreach (var attribute in this.attributes)
        {
            attributesAsString += " " + attribute.Key + "=\"" + attribute.Value + "\"";
        }

        string result;

        if (this.isCloseSelf)
        {
            result = String.Format("<{0}{1}/>", this.name, attributesAsString, this.content);
        }
        else
        {
            result = String.Format("<{0}{1}>{2}</{0}>", this.name, attributesAsString, this.content);
        }

        return result;
    }


    public static string operator *(ElementBuilder element, int n)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += element.ToString();
        }

        return result;
    }
}

