using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class WebPage : ISearchable
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Content { get; set; }
        public WebPage(string title, string url, string content)
        {
            Title = title;
            URL = url;
            Content = content;
        }
        public void Search(string word)
        {
            if (Content.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found in webpage '{Title}' at URL '{URL}'.");
            }
            else
            {
                Console.WriteLine($"Word '{word}' not found in webpage '{Title}'.");
            }
        }
    }
}
