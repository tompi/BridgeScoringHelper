public class RBNContractAndDeclarer : RBNLine
{
    public Contract Contract;

    override public string GetRBNstring()
    {
        return RBNContractMapper.GetstringFromContract(Contract);
    }

    override public void ParseRBNstring(string rbn)
    {
        if (!string.IsNullOrEmpty(rbn))
        {
            Contract = RBNContractMapper.GetContractFromstring(rbn);
        }
    }

    override public RBNLineType GetRBNLineType()
    {
        return RBNLineType.ContractAndDeclarer;
    }

}
