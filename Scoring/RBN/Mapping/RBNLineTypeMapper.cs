namespace Scoring.RBN.Mapping
{
    public static class RBNLineTypeMapper
    {
        public static char GetChar(RBNLineType type)
        {
            switch (type)
            {
                case RBNLineType.TitleAndAuthor:
                    return 'T';
                case RBNLineType.DateAndTime:
                    return 'D';
                case RBNLineType.Location:
                    return 'L';
                case RBNLineType.EventOrMainHeading:
                    return 'E';
                case RBNLineType.SessionStageOrSubheading:
                    return 'S';
                case RBNLineType.FormOfScoring:
                    return 'F';
                case RBNLineType.TeamNamesAndCarryovers:
                    return 'K';
                case RBNLineType.NamesOfPlayersAndRoomOrTable:
                    return 'N';
                case RBNLineType.BoardNumber:
                    return 'B';
                case RBNLineType.Hands:
                    return 'H';
                case RBNLineType.Auction:
                    return 'A';
                case RBNLineType.ContractAndDeclarer:
                    return 'C';
                case RBNLineType.PlaySequence:
                    return 'P';
                case RBNLineType.ResultTricksWonAndScore:
                    return 'R';
                case RBNLineType.InstantAwards:
                    return 'I';
                case RBNLineType.MakesAtDoubleDummy:
                    return 'M';
                case RBNLineType.Pause:
                    return 'Q';
                case RBNLineType.BidExplanation:
                    return '*';
                default:
                    return ' ';
            }
        }

        public static RBNLineType GetRBNLineType(char type)
        {
            switch (type)
            {
                case 'T':
                    return RBNLineType.TitleAndAuthor;
                case 'D':
                    return RBNLineType.DateAndTime;
                case 'L':
                    return RBNLineType.Location;
                case 'E':
                    return RBNLineType.EventOrMainHeading;
                case 'S':
                    return RBNLineType.SessionStageOrSubheading;
                case 'F':
                    return RBNLineType.FormOfScoring;
                case 'K':
                    return RBNLineType.TeamNamesAndCarryovers;
                case 'N':
                    return RBNLineType.NamesOfPlayersAndRoomOrTable;
                case 'B':
                    return RBNLineType.BoardNumber;
                case 'H':
                    return RBNLineType.Hands;
                case 'A':
                    return RBNLineType.Auction;
                case 'C':
                    return RBNLineType.ContractAndDeclarer;
                case 'P':
                    return RBNLineType.PlaySequence;
                case 'R':
                    return RBNLineType.ResultTricksWonAndScore;
                case 'I':
                    return RBNLineType.InstantAwards;
                case 'M':
                    return RBNLineType.MakesAtDoubleDummy;
                case 'Q':
                    return RBNLineType.Pause;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return RBNLineType.BidExplanation;
            }
            return RBNLineType.Text;
        }
    }
}