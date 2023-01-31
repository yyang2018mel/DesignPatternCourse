using VisitorPattern.Exercise;

var wavFile = WavFile.Read("");

wavFile.ApplyFilter(new NoiseReduction());
wavFile.ApplyFilter(new ReverbAdd());