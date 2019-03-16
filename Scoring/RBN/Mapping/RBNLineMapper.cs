namespace Scoring.RBN.Mapping
{
    public static class RBNLineMapper
    {
        public static RBNLine GetRBNLine(string rbn)
        {
            if (rbn == null || rbn.Length < 2)
            {
                return null;
            }
            char firstChar = rbn[0];
            string value = rbn.Substring(2);
            RBNLineType type = RBNLineTypeMapper.GetRBNLineType(firstChar);
            RBNLine rbnLine = null;

            switch (type)
            {
                case RBNLineType.TitleAndAuthor:
                    rbnLine = new RBNTitleAndAuthor();
                    break;
                case RBNLineType.Hands:
                    rbnLine = new RBNHands();
                    break;
                case RBNLineType.Text:
                    value = rbn;
                    rbnLine = new RBNText();
                    break;
                case RBNLineType.Pause:
                    rbnLine = new RBNPause();
                    break;
                case RBNLineType.ContractAndDeclarer:
                    rbnLine = new RBNContractAndDeclarer();
                    break;
                case RBNLineType.Auction:
                    rbnLine = new RBNAuction();
                    break;
                case RBNLineType.BidExplanation:
                    rbnLine = new RBNBidExplanation();
                    break;
                default:
                    break;
                    /* TODO:
                case DateAndTime:
                case Location:
                case EventOrMainHeading:
                case SessionStageOrSubheading:
                case FormOfScoring:
                case TeamNamesAndCarryovers:
                case NamesOfPlayersAndRoomOrTable:
                case BoardNumber:
                case PlaySequence:
                case ResultTricksWonAndScore:
                case InstantAwards:
                case MakesAtDoubleDummy:
                    */
            }
            if (rbnLine != null)
            {
                rbnLine.ParseRBNstring(value);
            }
            return rbnLine;
        }

    }
}