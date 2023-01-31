using System;
namespace VisitorPattern.Exercise;

public interface IFilter
{
    void ApplyOn(FactSegment factSegment);
    void ApplyOn(FormatSegment formatSegment);
}

public class NoiseReduction : IFilter
{
    public void ApplyOn(FactSegment factSegment)
    {
        Console.WriteLine($"Applying {nameof(NoiseReduction)} on {nameof(FactSegment)}");
    }

    public void ApplyOn(FormatSegment formatSegment)
    {
        Console.WriteLine($"Applying {nameof(NoiseReduction)} on {nameof(FormatSegment)}");
    }
}

public class ReverbAdd : IFilter
{
    public void ApplyOn(FactSegment factSegment)
    {
        Console.WriteLine($"Applying {nameof(ReverbAdd)} on {nameof(FactSegment)}");
    }

    public void ApplyOn(FormatSegment formatSegment)
    {
        Console.WriteLine($"Applying {nameof(ReverbAdd)} on {nameof(FormatSegment)}");
    }
}

public class Normalization : IFilter
{
    public void ApplyOn(FactSegment factSegment)
    {
        Console.WriteLine($"Applying {nameof(Normalization)} on {nameof(FactSegment)}");
    }

    public void ApplyOn(FormatSegment formatSegment)
    {
        Console.WriteLine($"Applying {nameof(Normalization)} on {nameof(FormatSegment)}");
    }
}
