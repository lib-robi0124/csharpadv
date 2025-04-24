using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Dokument : ISearchable
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Dokument(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public void Search(string word)
        {
            if (Content.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found in document '{Title}'.");
            }
            else
            {
                Console.WriteLine($"Word '{word}' not found in document '{Title}'.");
            }
        }
    }
}
