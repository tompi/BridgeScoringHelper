public static class HTMLTricksMapper
{
    public static string GetstringFromContract(Contract contract)
    {
        int diff = contract.Tricks - (contract.Level + 6);
        if (diff == 0)
        {
            return "=";
        }
        else if (diff > 0)
        {
            return "+" + diff;
        }
        else
        {
            return diff.ToString();
        }
    }
}
