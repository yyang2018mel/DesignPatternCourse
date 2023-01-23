using System;
namespace ChainOfResponsibility;

public class Compressor : Handler
{

    public Compressor(Handler next)
        : base(next)
    { }

    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Compress");
        return false;
    }
}

