using System.Text;

public static class RBNContractMapper
{

    public static Contract GetContractFromstring(string contract)
    {
        if (string.IsNullOrEmpty(contract))
        {
            return null;
        }
        if (contract == "Pass")
        {
            return new Contract();
        }
        var level = int.Parse(contract.Substring(0, 1));

        var suit = PBNSuitMapper.GetSuitFromstring(contract.Substring(1, 2));

        var reDoubled = contract.Contains("R");
        var doubled = reDoubled || contract.Contains("X");

        var player = Direction.South;
        int ix = contract.LastIndexOf(':');
        if (ix > 0)
        {
            player = PBNDirectionMapper.GetDirectionFromstring(contract[ix + 1]);
        }

        return new Contract(level, suit, doubled, reDoubled, player, 0);
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
            ret.Append("R");
        }
        else if (contract.Doubled)
        {
            ret.Append("X");
        }
        ret.Append(PBNDirectionMapper.GetstringFromDirection(contract.Player));
        return ret.ToString();
    }

}
