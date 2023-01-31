using System;
namespace VisitorPattern;

public interface IOperation
{
    void Apply(HeadingNode headingNode);
    void Apply(AnchorNode anchorNode);
}

