using System;
using System.Text;
using Scoring.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNTagMapper
    {
        private static string _dateFormat = "yyyy.MM.dd";
        private static string _timeFormat = "HH:mm:ss";

        public static void AppendTag(StringBuilder pbn, string tagName,
                string tagContent)
        {
            if (!string.IsNullOrWhiteSpace(tagContent))
            {
                pbn.Append("[" + tagName + " \"" + tagContent + "\"]\n");
            }
        }

        public static void AppendTag(StringBuilder pbn, string tagName, DateTime date)
        {
            AppendTag(pbn, tagName, date.ToString(_dateFormat));
        }

        public static void AppendTag(StringBuilder pbn, string tagName, int i)
        {
            if (i > -1)
            {
                AppendTag(pbn, tagName, i.ToString());
            }
        }

        public static void AppendTag(StringBuilder pbn, string tagName,
                Direction direction)
        {
            AppendTag(pbn, tagName,
                    PBNDirectionMapper.GetstringFromDirection(direction));
        }

        public static void AppendTag(StringBuilder pbn, string tagName,
                Vulnerability vulnerability)
        {
            AppendTag(pbn, tagName,
                    PBNVulnerabilityMapper
                            .GetstringFromVulnerability(vulnerability));
        }

        public static void AppendTag(StringBuilder pbn, string tagName, Deal deal)
        {
            if (deal != null)
            {
                AppendTag(pbn, tagName, PBNDealMapper.GetstringFromDeal(deal));
            }
        }

        public static void AppendTag(StringBuilder pbn, string tagName,
                Contract contract)
        {
            if (contract != null)
            {
                AppendTag(pbn, tagName,
                        PBNContractMapper.GetstringFromContract(contract));
            }

        }

        public static void AppendTag(StringBuilder pbn, string tagName, bool boolValue)
        {
            AppendTag(pbn, tagName, boolValue ? "Yes" : "No");

        }

        public static void AppendTag(StringBuilder pbn, string tagName, DateTime date,
                bool timeOnly)
        {
            AppendTag(pbn, tagName, date.ToString(_timeFormat));
        }
    }
}