
# Problem

The current implementation involves modifying each implementation of ```IHtmlNode```, whenever we want to add a new operation (method) to this interface.
We will also need to add a method in ```HtmlDocument``` too that iterativelys call each ```IHtmlNode``` with the new method accordingly.
This violates the **Open-Close Principle**, as adding new functionality requires modifying the existing classes.