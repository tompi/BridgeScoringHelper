using System.Collections.Generic;
using System.Text;
using Scoring.Game;
using Scoring.PBN.Game;
using Scoring.PBN.Mapping;

namespace Scoring.HTML.Mapping
{
    public static class HTMLParser
    {
        private static char separator = ',';

        // Custom CSV format for Mark Smits
        public static StringBuilder WriteCSV(List<PBNGame> games)
        {
            StringBuilder csv = new StringBuilder();
            foreach (PBNGame g in games)
            {
                AppendGame(g, csv);
            }
            return csv;
        }

        private static void AppendGame(PBNGame g, StringBuilder csv)
        {
            string line = GetHand(g.Identification.Deal.North)
                    + GetHand(g.Identification.Deal.East)
                    + GetHand(g.Identification.Deal.South)
                    + GetHand(g.Identification.Deal.West)
                    + '"'
                    + HTMLVulnerabilityMapper
                            .GetstringFromVulnerability(g.Identification.Vulnerable)
                    + '"' + separator + '"' + g.Identification.Board + '"'
                    + separator + '\n';
            csv.Append(line);
        }

        private static string GetHand(Hand hand)
        {
            string pbn = PBNHandMapper.GetstringFromHand(hand);
            return '"' + pbn.Replace(".", "" + '"' + separator + '"') + '"'
                    + separator;
        }
    }
}