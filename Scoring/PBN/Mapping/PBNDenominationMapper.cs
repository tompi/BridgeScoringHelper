public class PBNDenominationMapper
{

    public static Denomination GetDenominationFromChar(char denomination)
    {
        if (denomination == '2')
        {
            return Denomination.Two;
        }
        else if (denomination == '3')
        {
            return Denomination.Three;
        }
        else if (denomination == '4')
        {
            return Denomination.Four;
        }
        else if (denomination == '5')
        {
            return Denomination.Five;
        }
        else if (denomination == '6')
        {
            return Denomination.Six;
        }
        else if (denomination == '7')
        {
            return Denomination.Seven;
        }
        else if (denomination == '8')
        {
            return Denomination.Eight;
        }
        else if (denomination == '9')
        {
            return Denomination.Nine;
        }
        else if (denomination == 'T')
        {
            return Denomination.Ten;
        }
        else if (denomination == 'J')
        {
            return Denomination.Jack;
        }
        else if (denomination == 'Q')
        {
            return Denomination.Queen;
        }
        else if (denomination == 'K')
        {
            return Denomination.King;
        }
        else if (denomination == 'A')
        {
            return Denomination.Ace;
        }
        else if (denomination == 'x' || denomination == 'X')
        {
            return Denomination.Small;
        }
        else
        {
            return Denomination.Unknown;
        }
    }

    public static char GetCharFromDenomination(Denomination denomination)
    {
        switch (denomination)
        {
            case Denomination.Two:
                return '2';
            case Denomination.Three:
                return '3';
            case Denomination.Four:
                return '4';
            case Denomination.Five:
                return '5';
            case Denomination.Six:
                return '6';
            case Denomination.Seven:
                return '7';
            case Denomination.Eight:
                return '8';
            case Denomination.Nine:
                return '9';
            case Denomination.Ten:
                return 'T';
            case Denomination.Jack:
                return 'J';
            case Denomination.Queen:
                return 'Q';
            case Denomination.King:
                return 'K';
            case Denomination.Ace:
                return 'A';
            case Denomination.Small:
                return 'x';
            default:
                return '?';
        }
    }
}
