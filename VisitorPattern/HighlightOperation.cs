using System;
namespace VisitorPattern;

public class HighlightOperation : IOperation
{
    public void Apply(HeadingNode headingNode)
    {
        Console.WriteLine($"Highlighting {nameof(HeadingNode)}");
    }

    public void Apply(AnchorNode anchorNode)
    {
        Console.WriteLine($"Highlighting {nameof(AnchorNode)}");
    }
}

