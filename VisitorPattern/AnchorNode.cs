using System;
namespace VisitorPattern;

public class AnchorNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}

