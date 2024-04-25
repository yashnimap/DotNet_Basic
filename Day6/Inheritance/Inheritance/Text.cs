using System;

namespace Inheritance
{
    public class Text : PresentationObject { 
        public int fontsize {  get; set; }
        public string fontname { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("we add a link to "+ url);
        }
    }
}
