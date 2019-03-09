
using System.Collections.Generic;
using System.Text;

/*
 * Format used by "BigDeal" program
 */
public class Parser {
    private static char separator = ',';

    public static StringBuilder WriteCSV(List<PBNGame> games) {
        StringBuilder csv = new StringBuilder();
        foreach (PBNGame g in games) {
            AppendGame(g, csv);
        }
        return csv;
    }

    private static void AppendGame(PBNGame g, StringBuilder csv) {
        Deal deal = g.Identification.Deal;
        if (deal == null) deal = new Deal();
        csv.Append(GetHand(deal.North));
        csv.Append(GetHand(deal.East));
        csv.Append(GetHand(deal.South));
        csv.Append(GetHand(deal.West));
        csv.Append("\"" + g.Identification.Board + "\"" + separator);
        csv.Append("\"" + PBNDirectionMapper.GetstringFromDirection(g.Identification.Dealer));
        csv.Append("/" + GetVulnerability(g.Identification.Vulnerable) + "\"");
        csv.Append(separator + "\n");
    }

    private static string GetVulnerability(Vulnerability vulnerability) {
        switch (vulnerability) {
            case Vulnerability.None:
                return "-";
            default:
                return PBNVulnerabilityMapper
                        .GetstringFromVulnerability(vulnerability);
        }
    }

    private static string GetHand(Hand hand) {
		string pbn = PBNHandMapper.GetstringFromHand(hand);
		return '"' + pbn.Replace(".", "" + '"' + separator + '"') + '"'
				+ separator;
	}
}
