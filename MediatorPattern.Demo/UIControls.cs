using System;
namespace MediatorPattern.Demo;

public class UIControl
{
    protected DialogBox _owner;

    public UIControl(DialogBox owner)
    {
        _owner = owner;
    }
}

public class ListBox : UIControl
{
    private string _selection;

    public ListBox(DialogBox owner) : base(owner)
    {
    }

    public string Selection
    {
        get => _selection;
        set
        {
            _selection = value;
            _owner.Changed(this);
        }
    }
}

public class TextBox : UIControl
{
    private string _content;

    public TextBox(DialogBox owner) : base(owner)
    {
    }

    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            _owner.Changed(this);
        } 
    }
}

public class Button : UIControl
{
    private bool isEnabled;

    public Button(DialogBox owner) : base(owner)
    {
    }

    public bool IsEnabled
    {
        get => isEnabled;
        set 
        {
            isEnabled = value;
            _owner.Changed(this);
        } 
    }
}