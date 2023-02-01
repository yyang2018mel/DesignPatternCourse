using System;
namespace MediatorPattern.Demo;

public abstract class DialogBox
{
    public abstract void Changed(UIControl changed);
}

public class ArticlesDialogBox : DialogBox
{
    private ListBox _articlesListBox;
    private TextBox _titleText;
    private Button _saveButton;


    public ArticlesDialogBox()
    {
        _articlesListBox = new(this);
        _titleText = new(this);
        _saveButton = new(this);
    }

    public void SimulateUserInteraction()
    {
        _articlesListBox.Selection = "Article 1";
        Console.WriteLine($"Selected an article: {_articlesListBox.Selection}");
        Console.WriteLine($"TextBox {_titleText.Content}");
        Console.WriteLine($"Button {nameof(_saveButton.IsEnabled)}: {_saveButton.IsEnabled}");
        Console.WriteLine();

        _titleText.Content = string.Empty;
        Console.WriteLine("Cleared the title text box");
        Console.WriteLine($"Button {nameof(_saveButton.IsEnabled)}: {_saveButton.IsEnabled}");
        Console.WriteLine();

        _titleText.Content = "Something";
        Console.WriteLine($"Changed the title text box to {_titleText.Content}");
        Console.WriteLine($"Button {nameof(_saveButton.IsEnabled)}: {_saveButton.IsEnabled}");
        Console.WriteLine();
    }

    public override void Changed(UIControl changed)
    {
        if (changed == _articlesListBox)
            ArticleSelected();
        else if (changed == _titleText)
            TitleChanged();
    }

    private void ArticleSelected()
    {
        _titleText.Content = _articlesListBox.Selection;
        _saveButton.IsEnabled = true;
    }

    private void TitleChanged()
    {
        var isEmpty = string.IsNullOrEmpty(_titleText.Content);
        _saveButton.IsEnabled = !isEmpty;
    }
}