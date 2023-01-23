using System;
namespace ChainOfResponsibility.Exercise;

public abstract class DataReader
{
    private readonly string _name;
    private readonly DataReader _nextReader;

    public DataReader(string name, DataReader nextReader)
    {
        _name = name;
        _nextReader = nextReader;
    }

    public void Read(string fileName)
    {
        if (TryRead(fileName))
            Console.WriteLine($"Reading data from a {_name}");
        else if (_nextReader is not null)
            _nextReader.Read(fileName);
        else
            throw new NotSupportedException("File format not supported.");
    }

    protected abstract bool TryRead(string fileName);
}

