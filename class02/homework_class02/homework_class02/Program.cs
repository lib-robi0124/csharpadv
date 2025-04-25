using homework_class02.Entities;
using homework_class02.Interfaces;

#region Task 1


Dokument doc1 = new Dokument("Document 1", "search document 1.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("search document");
doc1.Search("document");
Console.ResetColor();

WebPage page1 = new WebPage("WebPage 1", "http://example.com", "search webpage 1.");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("searc web");
page1.Search("webpage");
Console.ResetColor();

#endregion
#region Task 2

Rectangle rectangle = new Rectangle(5, 10);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("area of rectangle");
rectangle.GetArea();
Console.ResetColor();

Circle circle = new Circle(7);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("area of circle");
circle.GetArea();
circle.CalculateArea();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("perimeter od circle");
circle.CalculatePerimeter();
Console.ResetColor();

Triangle triangle = new Triangle(5, 10);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("area of triangle");
triangle.GetArea();
Console.ResetColor();

#endregion

#region Task 3



#endregion

