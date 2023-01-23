using System;
namespace ChainOfResponsibility;

public abstract class Handler
{
    private Handler _next;

    public Handler(Handler next)
    {
        _next = next;
    }

    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
            return;

        if (_next is null)
            return;

        _next.Handle(request);
    }

    public abstract bool DoHandle(HttpRequest request);
}

