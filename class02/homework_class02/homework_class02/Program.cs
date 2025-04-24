using homework_class02.Entities;
using homework_class02.Interfaces;

#region Task 1


Dokument doc1 = new Dokument("Document 1", "search document 1.");

doc1.Search("document");

#endregion
#region Task 2

WebPage page1 = new WebPage("WebPage 1", "http://example.com", "search webpage 1.");
page1.Search("webpage");

#endregion
