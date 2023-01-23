using System;
namespace ChainOfResponsibility;

public class WebServer
{
    private Handler _handlerHead;

    public WebServer(Handler handlerHead)
    {
        _handlerHead = handlerHead;
    }

    public void Handle(HttpRequest request)
    {
        _handlerHead.Handle(request);
    }
}

