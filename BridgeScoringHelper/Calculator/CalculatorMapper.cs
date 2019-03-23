using System;
using System.Collections.Generic;
using Scoring.Game;

namespace BridgeScoringHelper.Calculator
{
    public class CalculatorMapper
    {
        internal static string GetContractAndResultString(Contract contract, bool isVulnerable, int score)
        {
            if (contract.Level == 0)
            {
                return "Pass = 0";
            }
            var vulnerableString = isVulnerable ? " Vuln." : "";
            return $"{GetContractString(contract)} {GetTrickResult(contract.Level, contract.Tricks)}{vulnerableString} = {score}";
        }

        private static object GetContractString(Contract contract)
        {
            var doubleString = contract.ReDoubled ? "XX" : contract.Doubled ? "X" : "";

            return $"{contract.Level}{SuitStrings[contract.Suit]}{doubleString}";
        }

        private static string GetTrickResult(int level, int tricks)
        {
            if (level > 0)
            {
                int diff = tricks - 6 - level;
                if (diff > 0)
                {
                    return $" (+{diff})";
                }
                else if (diff < 0)
                {
                    return $" ({diff})";
                }
            }
            return "";
        }

        private static readonly Dictionary<Suit, string> SuitStrings = new Dictionary<Suit, string>
        {
            {Suit.Notrump, "NT"},
            {Suit.Clubs, Constants.Suit.ClubUnicodeCharacter.ToString()},
            {Suit.Diamonds, Constants.Suit.DiamondUnicodeCharacter.ToString()},
            {Suit.Hearts, Constants.Suit.HeartUnicodeCharacter.ToString()},
            {Suit.Spades, Constants.Suit.SpadeUnicodeCharacter.ToString()},
        };
    }
}
