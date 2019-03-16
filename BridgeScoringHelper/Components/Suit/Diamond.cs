using System;
using BridgeScoringHelper.Style;

namespace BridgeScoringHelper.Components.Suit
{
    public class Diamond : SuitBase
    {
        public Diamond()
        {
            Text = '\u2666'.ToString();
            TextColor = Colors.Suits.Diamond;
        }
    }
}
