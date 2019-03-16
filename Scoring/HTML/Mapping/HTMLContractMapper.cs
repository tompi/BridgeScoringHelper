using System.Text;
using Scoring.Game;

namespace Scoring.HTML.Mapping
{
    public static class HTMLContractMapper
    {

        public static string GetstringFromContract(Contract contract)
        {
            if (contract == null)
            {
                return "";
            }
            if (contract.Level == 0)
            {
                return "Pass";
            }
            var ret = new StringBuilder();
            ret.Append(contract.Level);
            ret.Append(HTMLSuitMapper.GetstringFromSuit(contract.Suit));
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
}