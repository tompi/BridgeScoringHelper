namespace Scoring.RBN
{
    public class RBNTitleAndAuthor : RBNLine
    {
        public string Author;
        public string Title;

        override public string GetRBNstring()
        {
            return Title + ":" + Author;
        }

        override public void ParseRBNstring(string rbn)
        {
            if (!string.IsNullOrEmpty(rbn))
            {
                string[] strings = rbn.Split(':');
                Title = strings[0];
                if (strings.Length > 1)
                {
                    Author = strings[1];
                }
                else
                {
                    Author = null;
                }
            }
        }

        override public RBNLineType GetRBNLineType()
        {
            return RBNLineType.TitleAndAuthor;
        }

    }
}