using System;
namespace VisitorPattern.Exercise;

public interface ISegment
{
    void ApplyFilter(IFilter filter);
}

public class FactSegment : ISegment
{
    public void ApplyFilter(IFilter filter)
    {
        filter.ApplyOn(this);
    }
}

public class FormatSegment : ISegment
{
    public void ApplyFilter(IFilter filter)
    {
        filter.ApplyOn(this);
    }
}