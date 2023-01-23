using System;
namespace ChainOfResponsibility.Exercise;

public class ExcelReader : DataReader
{
    public ExcelReader(DataReader nextReader)
        : base("an Excel spreadsheet", nextReader)
    { }

    protected override bool TryRead(string fileName)
        => fileName.EndsWith(".xls");
}

public class NumbersSheetReader : DataReader
{
    public NumbersSheetReader(DataReader nextReader)
        : base("a Numbers spreadsheet", nextReader)
    { }

    protected override bool TryRead(string fileName)
        => fileName.EndsWith(".numbers");
}

public class QuickBookReader : DataReader
{
    public QuickBookReader(DataReader nextReader)
        : base("a QuickBooks file", nextReader)
    { }

    protected override bool TryRead(string fileName)
        => fileName.EndsWith(".qbw");
}