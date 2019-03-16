using System.Text;
using Scoring.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNDealMapper
    {

        public static Deal GetDealFromstring(string deal)
        {
            string[] firstAndHands = deal.Split(':');
            char first = firstAndHands[0][0];
            string[] hands = firstAndHands[1].Split(' ');
            Hand hand1 = null, hand2 = null, hand3 = null, hand4 = null;
            if (hands.Length > 0)
            {
                hand1 = PBNHandMapper.GetHandFromstring(hands[0]);
                if (hands.Length > 1)
                {
                    hand2 = PBNHandMapper.GetHandFromstring(hands[1]);
                    if (hands.Length > 2)
                    {
                        hand3 = PBNHandMapper.GetHandFromstring(hands[2]);

                        hand4 = null;
                        if (hands.Length > 3 && hands[3] != null
                                && hands[3].Length > 0)
                        {
                            hand4 = PBNHandMapper.GetHandFromstring(hands[3]);
                        }
                        else
                        {
                            hand4 = HandMissing.GetHandMissing(hand1, hand2, hand3);
                        }
                    }
                }
            }

            Deal ret = new Deal();

            if (first == 'W')
            {
                ret.West = hand1;
                ret.North = hand2;
                ret.East = hand3;
                ret.South = hand4;
            }
            else if (first == 'N')
            {
                ret.West = hand4;
                ret.North = hand1;
                ret.East = hand2;
                ret.South = hand3;
            }
            else if (first == 'E')
            {
                ret.West = hand3;
                ret.North = hand4;
                ret.East = hand1;
                ret.South = hand2;
            }
            else
            {
                ret.West = hand2;
                ret.North = hand3;
                ret.East = hand4;
                ret.South = hand1;
            }

            return ret;
        }

        public static string GetstringFromDeal(Deal deal)
        {
            var ret = new StringBuilder("W:");
            ret.Append(PBNHandMapper.GetstringFromHand(deal.West));
            ret.Append(" ");
            ret.Append(PBNHandMapper.GetstringFromHand(deal.North));
            ret.Append(" ");
            ret.Append(PBNHandMapper.GetstringFromHand(deal.East));
            ret.Append(" ");
            ret.Append(PBNHandMapper.GetstringFromHand(deal.South));
            return ret.ToString();
        }
    }
}