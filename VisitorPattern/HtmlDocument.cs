using System;
namespace VisitorPattern;

public class HtmlDocument
{
    private List<IHtmlNode> nodes = new List<IHtmlNode>();

    public void Add(IHtmlNode node)
    {
        nodes.Add(node);
    }

    public void Highlight()
    {
        foreach (var node in nodes)
            node.Highlight();
    }
}

