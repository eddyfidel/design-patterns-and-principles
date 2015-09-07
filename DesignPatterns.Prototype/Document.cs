using System;

namespace DesignPatterns.Prototype
{
    public class Document : ICloneable
    {
        private string Tittle { get; set; }

        private string Content { get; set; }

        public Document(string tittle, string content)
        {
            Tittle = tittle;

            Content = content;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}, Content: {1}", Tittle, Content);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
