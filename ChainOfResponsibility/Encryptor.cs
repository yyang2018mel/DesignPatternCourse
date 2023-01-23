using System;
namespace ChainOfResponsibility;

public class Encryptor : Handler
{
    public Encryptor(Handler next)
        : base(next)
    { }

    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Encryption");
        return false;
    }
}

