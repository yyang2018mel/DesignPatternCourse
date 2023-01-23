using System;
namespace ChainOfResponsibility.Exercise;

public class ExcelReader : DataReader
{
    public ExcelReader(DataReader nextReader)
        : base(nextReader)
    { }

    protected override bool CanRead(string fileName)
        => fileName.EndsWith(".xls");

    protected override void DoRead(string fileName)
        => Console.WriteLine("Reading data from an Excel spreadsheet.");
}

public class NumbersSheetReader : DataReader
{
    public NumbersSheetReader(DataReader nextReader)
        : base(nextReader)
    { }

    protected override bool CanRead(string fileName)
        => fileName.EndsWith(".numbers");

    protected override void DoRead(string fileName)
        => Console.WriteLine("Reading data from a Numbers spreadsheet.");
}

public class QuickBookReader : DataReader
{
    public QuickBookReader(DataReader nextReader)
        : base(nextReader)
    { }

    protected override bool CanRead(string fileName)
        => fileName.EndsWith(".qbw");

    protected override void DoRead(string fileName)
        => Console.WriteLine("Reading data from a QuickBooks file.");
}