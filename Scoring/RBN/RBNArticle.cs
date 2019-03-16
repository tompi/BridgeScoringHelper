using System.Collections.Generic;

namespace Scoring.RBN
{
    public class RBNArticle
    {
        public RBNArticle()
        {
            Lines = new List<RBNLine>();
        }

        public List<RBNLine> Lines;

        public string Author;
        public string Title;

        public void Add(RBNLine line)
        {
            if (line == null)
                return;

            RBNLineType type = line.GetRBNLineType();
            switch (type)
            {
                case RBNLineType.TitleAndAuthor:
                    RBNTitleAndAuthor ta = (RBNTitleAndAuthor)line;
                    Author = ta.Author;
                    Title = ta.Title;
                    return;
                default:
                    Lines.Add(line);
                    break;
            }
        }
    }
}