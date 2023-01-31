using System;
namespace VisitorPattern;

public class HeadingNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}

