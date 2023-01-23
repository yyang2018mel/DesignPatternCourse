using System;
namespace ChainOfResponsibility;

public class HttpRequest
{
    private string _username;
    private string _password;

    public HttpRequest(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public string UserName => _username;
    public string Password => _password;
}

