using System;
using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class Spade : SuitBase
    {
        public Spade()
        {
            Text = '\u2660'.ToString();
            TextColor = Colors.Suits.Spade;
        }
    }
}
