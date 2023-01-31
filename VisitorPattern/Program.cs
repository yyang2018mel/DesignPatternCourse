
using VisitorPattern;

var document = new HtmlDocument();
document.Add(new HeadingNode());
document.Add(new AnchorNode());

document.Execute(new HighlightOperation());

