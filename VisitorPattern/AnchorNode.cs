using System;
namespace VisitorPattern;

public class AnchorNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine($"Highlight {nameof(AnchorNode)}");
    }
}

