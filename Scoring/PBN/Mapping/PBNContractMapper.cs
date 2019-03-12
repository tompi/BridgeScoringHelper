using System.Text;

public static class PBNContractMapper
{

    public static Contract GetContractFromstring(string contract)
    {
        if (string.IsNullOrEmpty(contract))
        {
            return null;
        }
        Contract ret = new Contract();
        if (contract == "Pass")
        {
            return new Contract();
        }
        var level = int.Parse(contract.Substring(0, 1));
        var suit = PBNSuitMapper.GetSuitFromstring(contract[1].ToString());

        var reDoubled = contract.Contains("XX");
        var doubled = false;
        if (ret.ReDoubled || contract.Contains("X"))
        {
            doubled = true;
        }
        return new Contract(level, suit, doubled, reDoubled, Direction.South, 0);
    }

    public static string GetstringFromContract(Contract contract)
    {
        if (contract.Level == 0)
        {
            return "Pass";
        }
        var ret = new StringBuilder();
        ret.Append(contract.Level);
        ret.Append(PBNSuitMapper.GetstringFromSuit(contract.Suit));
        if (contract.ReDoubled)
        {
            ret.Append("XX");
        }
        else if (contract.Doubled)
        {
            ret.Append("X");
        }
        return ret.ToString();
    }

}
