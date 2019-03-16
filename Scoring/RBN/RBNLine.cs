namespace Scoring.RBN
{
    public abstract class RBNLine
    {
        public abstract RBNLineType GetRBNLineType();

        public abstract string GetRBNstring();

        public abstract void ParseRBNstring(string rbn);
    }
}