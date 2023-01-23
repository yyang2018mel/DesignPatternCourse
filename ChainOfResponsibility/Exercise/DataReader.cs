using System;
namespace ChainOfResponsibility.Exercise;

public abstract class DataReader
{
    private readonly DataReader _nextReader;

    public DataReader(DataReader nextReader)
    {
        _nextReader = nextReader;
    }

    public void Read(string fileName)
    {
        if (CanRead(fileName))
            DoRead(fileName);
        else if (_nextReader is not null)
            _nextReader.Read(fileName);
        else
            throw new NotSupportedException("File format not supported.");
    }

    protected abstract bool CanRead(string fileName);

    protected abstract void DoRead(string fileName);
}

