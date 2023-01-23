using System;
namespace ChainOfResponsibility;

public class Authenticator : Handler
{
    public Authenticator(Handler next)
        : base(next)
    { }

    public override bool DoHandle(HttpRequest request)
    {
        var isValid =
            request.UserName == "admin" &&
            request.Password == "1234";

        Console.WriteLine("Authentication");
        return !isValid;
    }
}

