using System;
namespace VisitorPattern;

public class HeadingNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine($"Highlight {nameof(HeadingNode)}");
    }
}

