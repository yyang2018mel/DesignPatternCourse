using System;
namespace ChainOfResponsibility.Exercise
{
    public class DataReadService
    {
        private readonly DataReader _headReader;

        public DataReadService(DataReader headReader)
        {
            _headReader = headReader;
        }

        public void Read(string fileName)
            => _headReader.Read(fileName);
    }
}

