namespace Scoring.RBN
{
    public class RBNText : RBNLine
    {
        public string Text;

        override public string GetRBNstring()
        {
            return "{" + Text + "}";
        }

        override public void ParseRBNstring(string rbn)
        {
            if (rbn != null && rbn.Length > 2)
            {
                Text = rbn.Substring(1, rbn.Length - 1);
            }
        }

        override public RBNLineType GetRBNLineType()
        {
            return RBNLineType.Text;
        }

    }
}