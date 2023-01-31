using System;
namespace VisitorPattern.Exercise;

public class WavFile
{
    private List<ISegment> segments = new();

    public static WavFile Read(string fileName)
    {
        // Simulate reading a wav file and building the segments
        var wavFile = new WavFile();
        wavFile.segments.Add(new FormatSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());
        return wavFile;
    }

    public void ApplyFilter(IFilter filter)
    {
        foreach (var segment in segments)
            segment.ApplyFilter(filter);
    }
}