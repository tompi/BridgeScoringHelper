public class Board
{
    public int Number { get; }
    public Vulnerability Vulnerability { get; }
    public Direction Dealer { get; }
    public Deal Deal { get; set; }

    public static Vulnerability GetVulnerability(int boardNumber)
    {
        int vulnMod = boardNumber % 16;
        switch (vulnMod)
        {
            case 1:
            case 8:
            case 11:
            case 14:
                return Vulnerability.None;
            case 4:
            case 7:
            case 10:
            case 13:
                return Vulnerability.Both;
            case 3:
            case 6:
            case 9:
            case 0:
                return Vulnerability.EastWest;
            default:
                return Vulnerability.NorthSouth;
        }
    }

    public static Direction GetDealer(int boardNumber)
    {
        int dealerMod = boardNumber % 4;
        switch (dealerMod)
        {
            case 1:
                return Direction.North;
            case 2:
                return Direction.East;
            case 3:
                return Direction.South;
            default:
                return Direction.West;
        }
    }

    public Board(int boardNumber)
    {
        Number = boardNumber;
        Dealer = GetDealer(boardNumber);
        Vulnerability = GetVulnerability(boardNumber);
    }
}
