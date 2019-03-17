using System;
using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class Club : SuitBase
    {
        public Club()
        {
            Text = Constants.Suit.ClubUnicodeCharacter.ToString();
            TextColor = Colors.Suits.Club;
        }
    }
}
