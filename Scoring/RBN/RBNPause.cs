// NB: Custom extension to RBN
public class RBNPause : RBNLine
{

    override public string GetRBNstring()
    {
        return "";
    }

    override public void ParseRBNstring(string rbn)
    {
    }

    override public RBNLineType GetRBNLineType()
    {
        return RBNLineType.Pause;
    }

}
